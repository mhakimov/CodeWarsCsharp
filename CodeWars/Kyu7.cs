﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class Kyu7
    {
        public static Dictionary<string, int> get_animals_count(int legs_number, int heads_number, int horns_number)
        {
            int rabbits_count=0, chickens_count=0, cows_count = 0;
            cows_count = horns_number / 2;
            heads_number -= cows_count;
            legs_number -= cows_count * 4;
            rabbits_count = heads_number;

            if (heads_number * 4 != legs_number)
            {
                rabbits_count--;
                chickens_count++;
                while (rabbits_count * 4 + chickens_count * 2 != legs_number)
                {
                    rabbits_count--;
                    chickens_count++;
                }
            }

            return new Dictionary<string, int>() { { "rabbits", rabbits_count }, { "chickens", chickens_count }, { "cows", cows_count } };
        }


        public static List<int> Solve(List<string> arr)
        {
            var toReturn = new List<int>();
            string str = "abcdefghijklmnopqrstuvwxyz";

            foreach(var element in arr)
            {
                int toAdd = 0;
                for (int i = 0; i < element.Length; i++)
                {
                    var index = str.IndexOf(str.Single(s => s.ToString() == element[i].ToString().ToLower()));
                    if (i == index) toAdd++;
                }
                toReturn.Add(toAdd);
            }

            return toReturn;
        }
    }
}
