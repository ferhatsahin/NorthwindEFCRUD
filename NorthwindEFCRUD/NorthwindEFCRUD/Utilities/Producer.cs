using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEFCRUD
{
    public static class Producer
    {
        public static string CreateCustomerID(string companyName)
        {
            string id = string.Empty;
            Random rnd = new Random();
            companyName = ConvertToENG(companyName);

            if (companyName.Length > 5)
            {
                id = companyName[0].ToString();
                for (int i = 0; i < 3; i++)
                {
                    id += companyName[rnd.Next(companyName.Length)];
                }
                id += companyName[companyName.Length - 1].ToString();
            }
            else
            {
                id = companyName;
            }


            return id.ToUpper();
        }

        private static string ConvertToENG(string word)
        {
            int index;
            char character;
            string oldValue = "öüçiğş";
            string newValue = "oucıgs";

            for (int i = 0; i < 3; i++)
            {
                character = char.ToLower(word[i]);

                if (oldValue.Contains(character))
                {
                    index = oldValue.IndexOf(character);
                    word.Replace(oldValue[index], newValue[index]);
                }
            }

            return word;
        }
    }
}
