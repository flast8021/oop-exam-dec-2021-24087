using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_dec_2021_24087.question4.models
{
    class EmployeeList
    {
        public List<Person> list = new List<Person>() {
        new Employee("Usman Zia", "0123456", "1234567AB"),
        new Employee("John Murphy", "0223562", "2566982BC"),
        new Employee("Ali Nalim", "0256315", "2561288CD")
        };
        public void work()
        {
            foreach (Person p in list)
            {
                string msg = p.work();
            }
        }
    }

    
}
