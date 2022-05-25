using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KomodoGreenPlan.CarRepository
{
    public class Cars
    {
        //Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public CarType? CarType { get; set; }
        //public bool ApplyRewards

        //Full Constructor
        public Cars(string make, string model, CarType? carType)
        {
            Make = make;
            Model = model;
            CarType = carType;
        }
        //Empty
        public Cars() { }
    }
    //Enum Car {Gas, Hybrid, Electric }
    public enum CarType { Gas, Hybrid, Electric }
}