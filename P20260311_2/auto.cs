using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace P20260311_2
{
    internal class auto
    {
        int Id;
        string marka;
        string tipus;
        int ar;
        int evjarat;
        string szin;
        Boolean torott;

        public auto(int id, string marka, string tipus, int ar, int evjarat, string szin, bool torott)
        {
            this.Id = id;
            this.Marka = marka;
            this.Tipus = tipus;
            this.Ar = ar;
            this.Evjarat = evjarat;
            this.Szin = szin;
            this.torott = torott;
        }

        public int Id1 { get => Id; set => Id = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Evjarat { get => evjarat; set => evjarat = value; }
        public string Szin { get => szin; set => szin = value; }
        public bool Torott { get => torott; set => torott = value; }

        /*public static List<auto> feltolt(string fnev)
        {
            List<auto> list = new List<auto>();

            string[] sorok = File.ReadAllLines(fnev);

            for (int i = 0; i < sorok.Length; i++)
            {
                string mezok[i] = sorok[i].Split();
            }
           
        }*/
    }
}
