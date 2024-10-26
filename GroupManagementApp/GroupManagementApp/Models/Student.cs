using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GroupManagementApp.Models
{
    internal class Student
    {
        

        public string Name { get; set; }
        public string Surname { get; set; }

        public string GroupNo { get; set; }
        public Student Group {  get; set; }
        public string Type {  get; set; }
   

        public Student(string name,string surname,string type)
        {

            Name = name;
            Surname = surname;
            Type = type;
                    
        }
    }
}
