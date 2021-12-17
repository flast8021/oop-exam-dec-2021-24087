using System;
using oop_exam_dec_2021_24087.question1.models;
namespace question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter correct information to add in List:");

            Building B = new Building();

            BuildingCodes Bc = new BuildingCodes();

            Console.WriteLine("Please Enter the Building-ID:");
            Bc.BuildingId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter the Building Location:");
            Bc.BuildingLocation = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please Enter the Building Code:");
            Bc.BuildingCode = Convert.ToString(Console.ReadLine());

            B.listOfBuildings.Add(Bc);

            Console.WriteLine("-------------------------------------------------------");
            B.display();
        }
    }
}
