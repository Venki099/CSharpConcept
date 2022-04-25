﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Debug7
    {
        public static void Main() {
            IDictionary<int, string> number = new Dictionary<int, string>();
            number.Add(1, "One"); //adding key/value using the Add() method
            number.Add(3, "Three");
            number.Add(2, "Two");
            foreach (KeyValuePair<int, string> kvp in number)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>(){
                {"Uk","London, Manchester, Birmingham"},
                {"USA","Chicago, New York, Washington"},
                {"IN","Mumbai, New Delhi, Pune"}
                            };
            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value:{1} ", kvp.Key,kvp.Value);

        }
}
}
