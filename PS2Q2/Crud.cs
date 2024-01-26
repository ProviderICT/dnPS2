using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2Q2
{
    class Crud : Icrud<Student>
    {
        private Dictionary<int, Student> datadict = new Dictionary<int, Student>();
        public void Create(Student data)
        {
            datadict.Add(data.Id, data);
            Console.WriteLine("Create Successfully..");
        }
        public Student Read(int id)
        {
            return datadict.ContainsKey(id) ? datadict[id] : null;
        }

        public void Update(int id, Student UData)
        {
            if (datadict.ContainsKey(id))
            {
                datadict[id] = UData;
                Console.WriteLine("Updated Successfully.");
            }
            else
            {
                Console.WriteLine("Id Not Found");
            }
        }
        public void Delete(int id)
        {
            if (datadict.ContainsKey(id))
            {
                datadict.Remove(id);
                Console.WriteLine("Deleted Successfully.");
            }
            else
            {
                Console.WriteLine("Id Not Found");
            }
        }

       
    }
}
