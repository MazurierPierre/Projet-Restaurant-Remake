using Controller.Interfaces;
using Controller.Room;
using Model.Kitchen;
using Model.Kitchen.Cooking;
using Model.Room;
using Model.Room.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Common
{
    public class BringMealToCounter : IAct
    {

        public void act()
        {
            Counter c = InitKitchen.Instance.counter;
            Boolean hasAPlace = false;
            foreach (Tuple<Dish, int> tupleCommand in InitKitchen.Instance.dishReady)
            {
                hasAPlace = false; 
                foreach (KeyValuePair<int, Dish> counterPlace in c.mapCounter)  //vérification qu'il y a de la place sur le comptoir
                {
                    if (( counterPlace.Key == 0 ) && (counterPlace.Value == null) && (hasAPlace == false)) //Emplacement disponible
                    {
                        c.mapCounter.Remove(counterPlace.Key); // On supprime l'emplacement actuel de la key
                        c.mapCounter.Add(tupleCommand.Item2, tupleCommand.Item1); //On crée une entrée avec le numéro de table & on lui associe le plat
                        hasAPlace = true; //Le plat à maintenant une place, inutile de continuer de parcourir les autres emplacement
                    }
                }
                if (hasAPlace == false)
                {
                    // La map est full - Alerte quelqu'un !
                }
            }
        }

        public void act(Client client, Table table)
        {
            throw new NotImplementedException();
        }

        public void act(Table table, EnumRoom.BreadType type)
        {
            throw new NotImplementedException();
        }

        public void act(Table table, EnumRoom.JugType type)
        {
            throw new NotImplementedException();
        }

        public void act(Table table)
        {
            throw new NotImplementedException();
        }

        public void act(Table table, Waiter waiter)
        {
            throw new NotImplementedException();
        }

        public void act(Client client)
        {
            throw new NotImplementedException();
        }

        public void act(Card card)
        {
            throw new NotImplementedException();
        }

        public void act(Client client, List<Menu> orderList)
        {
            throw new NotImplementedException();
        }
    }
}
