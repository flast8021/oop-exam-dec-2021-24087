using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_dec_2021_24087.question1.models
{
    public class Building
    {
        public List<BuildingCodes> listOfBuildings = new List<BuildingCodes>()
        {
            new BuildingCodes(101,"Tallaght","1346"),
            new BuildingCodes(107,"Crumlin","2019"),
            new BuildingCodes(102,"Lucan","1379")
        };

        public void display(bool sort=true)
        {
            /*List<BuildingCodes> sortedList = listOfBuildings.OrderBy(x=> x.BuildingId).ToList();
            if (!sort)
            {
                sortedList = listOfBuildings.OrderByDescending(x => x.BuildingId).ToList();

            }*/
            foreach (BuildingCodes b in listOfBuildings)
            {
                
                string message = $"{b.BuildingId} is located in {b.BuildingLocation} and code is {b.BuildingCode}";
                    Console.WriteLine(message);

            }
         
        }
    }
}
