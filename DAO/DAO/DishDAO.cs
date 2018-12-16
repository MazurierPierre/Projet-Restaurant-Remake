using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DishDAO : IDAO<Dish>
    {
        // Singleton pattern
        private static DishDAO instance = null;
        private static readonly object padlock = new object();

        private DishDAO()
        {
        }

        public static DishDAO Instance
        {
            get {
                lock (padlock) {
                    if (instance == null)
                        instance = new DishDAO();
                    return instance;
                }
            }
        }

        /*
         * CRUD Methods
         */

        // Create a new record un the Dish table of the database.
        public void create(Dish dish)
        {
            using (var db = new DataContext())
            {
                db.Dish.Add(dish);
                db.SaveChanges();
            }
        }

        // Delete a record in the "Dish" table of the database.
        public void delete(int id)
        {
            using (var db = new DataContext())
            {
                var dishToRemove = db.Dish.Where(a => a.ID == id).FirstOrDefault<Dish>();

                // Verify that the dish exists before removing it
                if (dishToRemove != null)
                {
                    db.Dish.Remove(dishToRemove);
                    db.SaveChanges();
                }
                
            }
        }

        // Returns a Dish object corresponding to a given ID (returns 'null' if none found)
        public Dish get(int id)
        {
            Dish query = null;

            using (var db = new DataContext())
            {
                query = db.Dish.Where(a => a.ID == id).FirstOrDefault<Dish>();
            }

            return query;
        }

        // Returns a Dish object corresponding to a given name (returns 'null' if none found)
        public Dish getByName(string name)
        {
            Dish query = null;

            using (var db = new DataContext())
            {
                query = db.Dish.Where(a => a.name == name).FirstOrDefault<Dish>();
            }

            return query;
        }

        // Return a list of instructions corresponding to a givent Dish ID
        public List<int> getInstructionsFromDish(int dishID)
        {
            var instructions = new List<int>();

            using (var db = new DataContext())
            {
                var query = db.InstructionInDish.Where(i => i.DishID == dishID);

                // Verify that a Dish record was found
                if(query == null)
                    return null;

                // Retrieves instructions from Dish object
                foreach (var instruction in query)
                {
                    instructions.Add(instruction.InstructionID);
                }
            }

            return instructions;
        }

        // Modifies dish record corresponding to give ID, returns trus if success, false if failure
        public bool update(int id, Dish newDish)
        {
            using (var db = new DataContext())
            {
                var dishToModify = db.Dish.Where(a => a.ID == id).FirstOrDefault<Dish>();

                // Verify that a dish exists with the given ID
                if (dishToModify == null)
                    return false;

                dishToModify = newDish;
                db.SaveChanges();
            }

            return true;
        }
    }
}
