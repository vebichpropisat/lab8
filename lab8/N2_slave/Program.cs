using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_slave
{
    class Slave
    {
        public string Name { get; set; }
        public int Old { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Slave> slaves = new List<Slave>();
            using (StreamReader s = new StreamReader("slaves.txt"))
            {
                string line;
                while ((line = s.ReadLine()) != null)
                {
                    string[] p = line.Split(',');
                    slaves.Add(new Slave { Name = p[0], Old = int.Parse(p[1]) });
                }
            }
            slaves = slaves.OrderBy(e => e.Old).ToList();
            Console.WriteLine("Список спiвробiтникiв, вiдсортований за досвiдом:");
            foreach (var slave in slaves)
            {
                Console.WriteLine(slave.Name + " - " + slave.Old);
            }
        }
    }
}
