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
        
        public string Category { get; set; }
        public bool IsOnline { get; set; }
      public  int Limit { get; set; }
        

        public Group( string category, string no)
        {
            
            No = no;
            
           Category = category;
            
            
        }

        public Group()
        {
        }
    }
}
