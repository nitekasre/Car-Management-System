using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_2
{
    //interface that includes all the methods for the CarRepository class
    interface CRUD
    {
        //method to get all the cars from the collection
        ICollection<Car> GetCars();
        
        //method to add cars
        void AddRecord(Car obj);

        //method to delete cars
        void DeleteCar(Car obj);

        //allows for a car to be found by the VIN
        Car FindCar(string vin);

        //method to update records
        void UpdateCar(string vin, Car carchanges);
    }

    class CarRepository : CRUD
    {
        //represents the entity of the database
        Assignment6_2Entities entities;

        //public constructor call for the database since the class is internal
        public CarRepository()
        {
            entities = new Assignment6_2Entities();
        }
        public void AddRecord(Car obj)
        {
            //updates the database and saves the changes
            entities.Cars.Add(obj);
            entities.SaveChanges();
        }

        public void DeleteCar(Car obj)
        {
            //deletes the record from the databse and saves the changes
            entities.Cars.Remove(obj);
            entities.SaveChanges();
        }

        public Car FindCar(string vin)
        {
            //identifies/finds the selected car by the VIN
            var selcar = entities.Cars.First(n => n.VIN == vin);
            if (selcar != null)
            {
                return selcar;
            }

            else
            {
                return null;
            }
        }

        public ICollection<Car> GetCars()
        {
            //returns the data from the database to the list view
            return entities.Cars.ToList();
        }

        public void UpdateCar(int vin, Car carchanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateCar(string vin, Car carchanges)
        {
            //will pass updated information to the record associated with the VIN
            var cartoupdate = entities.Cars.Find(vin);

            //paramters to update the record for a car
            cartoupdate.VIN = carchanges.VIN;
            cartoupdate.Make = carchanges.Make;
            cartoupdate.Model = carchanges.Model;
            cartoupdate.Year = carchanges.Year;
            cartoupdate.Price = carchanges.Price;
            cartoupdate.Ability = carchanges.Ability;
            //saves changes to the record
            entities.SaveChanges();
        }
    }
}
