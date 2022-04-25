using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace CSharpConcept
{
    internal class dictionaryhashtable
    {
        public static void Main()
        {
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary.Add(1, "VSG");
            dictionary.Add(2, "DCV");
            dictionary.Add(3, "RHV");
            dictionary.Add(4, "SRA");

            foreach (var item in dictionary)
            {
                Console.WriteLine("Key: {0},Value: {1} ",item.Key,item.Value);
            }
            
            Console.WriteLine("Hashtable Entries");
            Hashtabledemo();

            

        }

        public static void Hashtabledemo()
        {
            Hashtable h1 = new Hashtable();
            h1.Add("VSG", 750);
            h1.Add("DSY", 700);
            h1.Add("SHA", 650);
            h1.Add("BSY", 500);

            foreach(DictionaryEntry item1 in h1)
            {
                Console.WriteLine("Key:{0},Value:{1}", item1.Key, item1.Value);
            }
        }
    }
}
