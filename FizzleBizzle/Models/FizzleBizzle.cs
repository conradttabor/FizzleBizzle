using System;

namespace FizzleBizzle.Models
{
    public class FizzleBizzle : IFizzleBizzle
    {
        public int Fizz { get; set; }
        public int Buzz { get; set; }

        public FizzleBizzle() { }

        public FizzleBizzle(int fizz, int buzz)
        {
            Fizz = fizz;
            Buzz = buzz;
        }

        public string[] FizzBuzz(int start, int end)
        {
            var arraySize = (start <= end) ? (end + 1) - start : (start + 1) - end;
            var array = new string[arraySize];
            if (start <= end)
            {
                var arrayCounter = 0;
                for (int i = start; i <= end; i++)
                {
                    var entry = "";

                    if (i % Fizz == 0)
                        entry += "Fizz";
                    if (i % Buzz == 0)
                        entry += "Buzz";
                    if (entry == "")
                        entry = i.ToString();

                    array[arrayCounter] = entry;
                    arrayCounter++;
                }
            }
            if (start > end)
            {
                var arrayCounter = 0;
                for (int i = start; i >= end; i--)
                {
                    var entry = "";

                    if (i % Fizz == 0)
                        entry += "Fizz";
                    if (i % Buzz == 0)
                        entry += "Buzz";
                    if (entry == "")
                        entry = i.ToString();

                    array[arrayCounter] = entry;
                    arrayCounter++;
                }
            }

            return array;
        }

        public string[] FizzBuzzBazz(int start, int end, Predicate<int> bazz)
        {
            var arraySize = (start <= end) ? (end + 1) - start : (start + 1) - end;
            var fizzBuzzBazzArray = new string[arraySize];          

            if (start <= end)
            {
                var arrayCounter = 0;

                for (int i = start; i <= end; i++)
                {
                    var entry = "";

                    if (i % Fizz == 0)
                        entry += "Fizz";
                    if (i % Buzz == 0)
                        entry += "Buzz";
                    if (entry == "FizzBuzz" && bazz(i))
                        entry += "Bazz";
                    if (entry == "")
                        entry += i;

                    fizzBuzzBazzArray[arrayCounter] = entry;

                    arrayCounter++;
                }
                
            }

            else if (start > end)
            {
                var arrayCounter = 0;

                for (int i = start; i >= end; i--)
                {
                    var entry = "";

                    if (i % Fizz == 0)
                        entry += "Fizz";
                    if (i % Buzz == 0)
                        entry += "Buzz";
                    if (entry == "FizzBuzz" && bazz(i))
                        entry += "Bazz";
                    if (entry == "")
                        entry += i;

                    fizzBuzzBazzArray[arrayCounter] = entry;

                    arrayCounter++;
                }
            }

            return fizzBuzzBazzArray;
        }
    }
}