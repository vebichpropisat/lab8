using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_shkila
{
    class Shkila
    {
        public string Name { get; set; }
        public int[] Bals { get; set; }
    }
    class Program
    {
        static void Main()
        {
            List<Shkila> shkila = new List<Shkila>();
            using (StreamReader s = new StreamReader("shkila.txt"))
            {
                string line;
                while ((line = s.ReadLine()) != null)
                {    
                    string[] p = line.Split(',');
                    string name = p[0];
                    int[] bals = p.Skip(1).Select(int.Parse).ToArray();
                    shkila.Add(new Shkila { Name = name, Bals = bals });
                }
            }
            List<Shkila> norm_skila = shkila.Where(s => s.Bals.Average() >= 6.0).ToList();
            Console.WriteLine("Студенти з середнiм балом 6 або бiльше:");
            foreach (Shkila shkil in norm_skila)
            {
                Console.WriteLine(shkil.Name + ": " + string.Join(", ", shkil.Bals));
            }
        }
    }
}
