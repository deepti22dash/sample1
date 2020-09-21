using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   interface Vehicle
    {
        void changeGear(int a);
        void SpeedUp(int a);
        void applyBrakes(int a);
    }
    class Bicycle: Vehicle
    {
        int speed ;
        int gear;
        public void changeGear(int newGear)
        {
            gear = newGear;
        }
        public void speedUp(int increment)
        {
            speed = speed + increment;
        }
        public void applyBrakes(int decrement)
        {
            speed = speed - decrement;
        }
        public void printStates()
        {
            Console.WriteLine(" speed:" + speed + "gear:" + gear);
        }

    }
    class Bike: Vehicle
    {
        int speed;
        int gear;
        
        public void changeGear(int newGear)
        {
            gear = newGear;
        }
        public void speedUp(int increment)
        {
            speed = speed + increment;
        }
        public void applyBrakes(int decrement)
        {
            speed = speed - decrement;
        }
        public void printStates()
        {
            Console.WriteLine(" speed:" + speed + "gear:" + gear);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle = new Bicycle();
            bicycle.changeGear(2);
            bicycle.speedUp(3);
            bicycle.applyBrakes(1);
            Console.WriteLine(" Bicycle pesent states:");
            bicycle.printStates();

            Bike bike = new Bike();
            bike.changeGear(1);
            bike.speedUp(5);
            bike.applyBrakes(3);
            Console.WriteLine(" Bike pesent states:");
            bicycle.printStates();


        }
    }
}
