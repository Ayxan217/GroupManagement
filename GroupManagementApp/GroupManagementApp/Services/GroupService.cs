using GroupManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace GroupManagementApp.Services
{
    internal class GroupService
    {
        public static List<Group> Groups =new();

        public void CreateGroup()
        {
            

                Console.WriteLine("nomreni daxil edin: ");
                string no = Console.ReadLine();
                

                
                
                Group group = new(no);
                Groups.Add(group);
                Console.WriteLine($"{no} qrupu yaradıldı");
            

            
        }
        public void ShowGroups() {

            foreach (var item in Groups)
            {
                Console.WriteLine($"{item.Category}{item.No}");
            }

        }

     

    }
}
