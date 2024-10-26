using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GroupManagementApp.Models
{
    internal class Student:Group
    {
        

        public string Name { get; set; }
        public string Surname { get; set; }

        public string GroupNo { get; set; }
        public Group Group {  get; set; }
        public bool Type {  get; set; }
   

       
    }
}
