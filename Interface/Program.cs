// - create interface IWalkable,IDriveable
// - create classes: Dog,Car,Kangaroo,Ship,Horse
// - IWalkable has method Walk()
// - IDriverable has method Drive() 
// - Each classes has to implement rhe corresponding interface/s
// - create list of IWalkable and add there 5 objects
// - create list of IDriveable and add there 5 objects

using System;
using System.Collections.Generic;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IDriveable> drive = new List<IDriveable>(5);
            drive.Add(new Car() { Name = "honda" });
            drive.Add(new Ship() { Name = "shipp" });
            drive.Add(new Car() { Name = "toyota" });
            drive.Add(new Ship() { Name = "ship2" });
            drive.Add(new Car() { Name = "bmw" });
            List<IWalkable> walk = new List<IWalkable>(5);
            walk.Add(new Dog() { Name = "pitbull" });
            walk.Add(new Horse() { Name = "mustang" });
            walk.Add(new Kangaroo() { Name = "kangoroo" });
            walk.Add(new Dog() { Name = "alabai" });
            walk.Add(new Dog() { Name = "chihuahua" });
            foreach (var d in drive)
            {
                Console.WriteLine(d.Name);
            }
            Console.WriteLine("***********");
            foreach (var w in walk)
            {
                Console.WriteLine(w.Name);
            }
        }
    }
}
