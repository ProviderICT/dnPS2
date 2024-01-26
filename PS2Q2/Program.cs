using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Class:");
            Console.WriteLine("1. Student");
            Console.WriteLine("2. Facult");
            Console.WriteLine("3. Subject");
            Console.WriteLine("4. Exit");

            Console.WriteLine("Enter Class : ");
            int classch = Convert.ToInt32(Console.ReadLine());
           
                switch (classch)
                {
                    case 1:

                    Crud crud = new Crud();
                    while (true)
                    {
                        Console.WriteLine("\n Choose an Operation:");
                        Console.WriteLine("1. Create");
                        Console.WriteLine("2. Read");
                        Console.WriteLine("3. Update");
                        Console.WriteLine("4. Delete");
                        Console.WriteLine("5. Exit");

                        Console.WriteLine("Enter Your Choice: ");

                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.Write("Enter Id Of Student: ");
                                int createId = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter Name Of Student: ");
                                string cName = Console.ReadLine();

                                crud.Create(new Student { Id = createId, Name = cName });
                                break;

                            case 2:
                                Console.Write("Enter Id Of Student: ");
                                int rId = Convert.ToInt32(Console.ReadLine());
                                Student result = crud.Read(rId);
                                if (result != null)
                                {
                                    Console.WriteLine($"Id: {result.Id}, Name: {result.Name}");
                                }
                                else
                                {
                                    Console.WriteLine("Id Not Found");
                                }
                                break;
                            case 3:
                                Console.Write("Enter Id Of Student: ");
                                int UpId = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter Name Of Student: ");
                                string upName = Console.ReadLine();

                                crud.Update(UpId, new Student { Id = UpId, Name = upName });
                                break;
                            case 4:
                                Console.Write("Enter Id Of Student: ");
                                int dId = Convert.ToInt32(Console.ReadLine());

                                crud.Delete(dId);
                                break;
                            case 5:
                                Environment.Exit(0);
                                return;
                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                    }break;

                case 2:
                    FacultyCrud fcrud = new FacultyCrud();

                    while (true)
                    {

                        Console.WriteLine("\n Choose an Operation:");
                        Console.WriteLine("1. Create");
                        Console.WriteLine("2. Read");
                        Console.WriteLine("3. Update");
                        Console.WriteLine("4. Delete");
                        Console.WriteLine("5. Exit");

                        Console.WriteLine("Enter Your Choice: ");

                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.Write("Enter Id Of Faculty: ");
                                int createId = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter Name Of Faculty: ");
                                string cName = Console.ReadLine();

                                fcrud.Create(new Faculty { Id = createId, Name = cName });
                                break;

                            case 2:
                                Console.Write("Enter Id Of Faculty: ");
                                int rId = Convert.ToInt32(Console.ReadLine());
                                Faculty result = fcrud.Read(rId);
                                if (result != null)
                                {
                                    Console.WriteLine($"Id: {result.Id}, Name: {result.Name}");
                                }
                                else
                                {
                                    Console.WriteLine("Id Not Found");
                                }

                                break;
                            case 3:
                                Console.Write("Enter Id Of Faculty: ");
                                int UpId = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter Name Of Faculty: ");
                                string upName = Console.ReadLine();

                                fcrud.Update(UpId, new Faculty { Id = UpId, Name = upName });
                                break;
                            case 4:
                                Console.Write("Enter Id Of Faculty: ");
                                int dId = Convert.ToInt32(Console.ReadLine());

                                fcrud.Delete(dId);
                                break;
                            case 5:
                                Environment.Exit(0);
                                return;
                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                    }
                    break;
                    case 3:
                    SubjectCrud scrud = new SubjectCrud();

                    while (true)
                    {
                        Console.WriteLine("\n Choose an Operation:");
                        Console.WriteLine("1. Create");
                        Console.WriteLine("2. Read");
                        Console.WriteLine("3. Update");
                        Console.WriteLine("4. Delete");
                        Console.WriteLine("5. Exit");

                        Console.WriteLine("Enter Your Choice: ");

                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.Write("Enter Id Of Subject: ");
                                int createId = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter Name Of Subject: ");
                                string cName = Console.ReadLine();

                                scrud.Create(new Subject { Id = createId});
                                break;

                            case 2:
                                Console.Write("Enter Id Of Subject: ");
                                int rId = Convert.ToInt32(Console.ReadLine());
                                Subject result = scrud.Read(rId);
                                if (result != null)
                                {
                                    Console.WriteLine($"Id: {result.Id}");
                                }
                                else
                                {
                                    Console.WriteLine("Id Not Found");
                                }

                                break;
                            case 3:
                                Console.Write("Enter Id Of Subject: ");
                                int UpId = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter Name Of Subject: ");
                                string upName = Console.ReadLine();

                                scrud.Update(UpId, new Subject { Id = UpId});
                                break;
                            case 4:
                                Console.Write("Enter Id Of Subject: ");
                                int dId = Convert.ToInt32(Console.ReadLine());

                                scrud.Delete(dId);
                                break;
                            case 5:
                                Environment.Exit(0);
                                return;
                            default:
                                Console.WriteLine("Invalid Choice");
                                break;
                        }
                    }
                    break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter Valid Options:");
                        break;

                }        
        }
      
    }       
}
