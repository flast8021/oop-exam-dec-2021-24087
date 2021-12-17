using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_exam_dec_2021_24087.question4.models
{
    public abstract class Person
    {
        //default constructor
        public Person() 
        { 
        }
        public Person(string _name, string _Phone, string _pps)
        {
            Name = _name;
            Phone = _Phone;
            PPS = _pps;
        }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string PPS { get; set; }

        public string work()
        {
            return $"{Name}'s contact number is {Phone}";
        }
    }
    public class Employee : Person
    {
        public Employee(string _name, string _Phone, string _pps) 
        {
            Name = _name;
            Phone = _Phone;
            PPS = _pps;
        }
    }
}
