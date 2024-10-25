using GroupManagementApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupManagementApp.Models
{
    internal class Group
    {
        public string No;
        static int Count = 100;
        public string Category { get; set; }
        public string IsOnline { get; set; }
        public int Limit { get; set; }
        public List<string> Students { get; set; }
        

        public Group( string no )
        {
            
            
            No = no;
            
            
        }
        


    }
}
