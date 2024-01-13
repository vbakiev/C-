using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods {
    internal class Program {
        static void Main (string[] args) {

            /*
               if ipAddress consists of 4 numbers
               and
               if each ipAddress number has no leading zeroes
               and
               if each ipAddress number is in range 0 - 255

               then ipAddress is valid

               else ipAddress is invalid
            */

            //IP Validation
            string ipv4Input = "255.23.32.153";
            bool validLength = false;
            bool validZeroes = true;
            bool validRange = true;

            ValidLength();
            ValidRange();
            ValidZeroes();

            if(validLength && validZeroes && validRange)
                Console.WriteLine($"The IP address {ipv4Input} is valid");
            else
                Console.WriteLine($"The IP address {ipv4Input} isn't valid\n");

            void ValidLength() {
                string[] numberArray = ipv4Input.Split('.');
                if(numberArray.Length == 4) {
                    validLength = true;
                }
                if(validLength)
                    Console.WriteLine("Valid length is true\n");
                else
                    Console.WriteLine("Valid length validation is not met\n");
            }

            void ValidZeroes () {
                string[] numberArray = ipv4Input.Split('.');
                for (int i = 0; i < numberArray.Length; i++) {
                    if (numberArray[i].StartsWith("0") && numberArray[i].Length > 1) {
                        validZeroes = false;
                        break;
                    }
                }
                if (validZeroes)
                    Console.WriteLine("Valid zeroes is true\n");
                else
                    Console.WriteLine("Valid zeroes validation is not met\n");
            }

            void ValidRange () {
                int cast;
                string[] numberArray = ipv4Input.Split('.');
                for(int i = 0; i < numberArray.Length; i++) {
                    cast = int.Parse(numberArray[i]);
                    if (cast < 0 || cast > 255) {
                        validRange = false;
                        break;
                    }

                }
                if (validRange)
                    Console.WriteLine("Valid range is true\n");
                else
                    Console.WriteLine("Valid range validation is not met\n");
            }
        }

    }
}
