using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    // This interface implements a simple CRUD to interact with the database
    interface IDAO<T>
    {
        /*
         * All Data Access Objects implementing this interface SHOULD use a Singleton pattern !
         */

        // Create new object un database
        void create(T t);

        // Delete object in database
        void delete(int id);

        // Get object in database
        T get(int id);

        // Get all objects for database (NOT IMPLEMENTED YET)
        //List<T> getAll();

        // Modify object un database
        bool update(int id, T newT);
    }
}
