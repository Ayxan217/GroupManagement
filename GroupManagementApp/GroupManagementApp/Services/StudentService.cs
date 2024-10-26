using GroupManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GroupManagementApp.Services
{
    internal class StudentService
    {

        public List<Student> Students = new List<Student>();
      
        public void CreateStudent()
        {
            
            Console.WriteLine("tehsil zemaneti:(var/yoxdur)");
            bool type = false;
           Type: string insurance = Console.ReadLine().Trim().ToLower();
            if(insurance !="var" && insurance != "yoxdur")
            {
                Console.WriteLine("duzgun daxil edin");
                goto Type;
            }
            else { 
                if(insurance == "var")
                {
                    type = true; 
                }
               
            }
            Console.WriteLine("adi daxil edin: ");
        name: string name = Console.ReadLine().ToLower();
            if (!Regex.IsMatch(name, @"^[a-z]{3,25}$"))
            {
                Console.WriteLine("duzgun ad daxil edin");
                goto name;
            }
            Console.WriteLine("soyadi daxil edin: ");
        surname: string surname = Console.ReadLine().ToLower();
            if (!Regex.IsMatch(surname, @"^[a-z]{3,25}$"))
            {
                Console.WriteLine("duzgun soyad daxil edin");
                goto surname;
            }
            

                Student student = new Student(name, surname,insurance);
               
                Students.Add(student);
            Console.WriteLine(Students.Count);
                Console.WriteLine($"{name} {surname} yaradıldı ");



        }

        public void ShowStudents()
        {
            
            Console.WriteLine("Telebeler:");
            Console.WriteLine(Students.Count);
            if (Students.Count == 0) 
            {
                Console.WriteLine("Telebe yoxdur.");
                return; 
            }

            foreach (var item in Students)
            {
                Console.WriteLine($"{item.Name} {item.Surname}");
            }
           
        }


    }
}
