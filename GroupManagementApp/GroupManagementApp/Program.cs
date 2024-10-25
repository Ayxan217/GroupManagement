using GroupManagementApp.Services;

namespace GroupManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("1.grup yarat\n2.Gruplarin siyahisini goster\n3.grup uzerinde duzelish etmek\n4.qrupdaki telebelerin siyahisini goster\n5.butun telebelerin siyahisini goster\n6. telebe yarat\n\n0.cixish");
                 answer = Console.ReadLine().Trim();
                GroupService service = new GroupService();
                switch (answer) {
                    case "1":

                        service.CreateGroup();
                        
                        break;
                    case "2":
                        service.ShowGroups();
                        break;
                
                }

            }
            while (answer!="0");
        }
    }
}
