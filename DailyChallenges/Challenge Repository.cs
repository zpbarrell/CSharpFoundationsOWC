using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//01
        //Write a method that each complete the following tasks:

        //Take in FOUR parameters: 2 strings and 2 ints. The strings being the names of two different soccer teams, and the ints being the teams' scores.

        //Method should return a string of either "{teamOne} won." or "{teamTwo} won." or "{teamOne} and {teamTwo} tied".

        //Invoke each method in Program.cs and print the returned results to the console.
namespace DailyChallenges
{
    public class ChallengeRepository
    {
        

    }
    public class McDonaldsMenu
    {

        // public 
        // DateTime dob = Convert.ToDateTime("");
        // string text = CalculateYourAge(dob);

        // public int CalculateAgeInDays(DateTime birthday)
        // {
        //     DateTime age = DateTime.Today - birthday;
        // }

    //Write a method that takes in a list of ints and returns a dictionary
        public Dictionary<string, decimal> MeanMedianMode (List<int> intList)
        {
            //new dictionary to return.
            Dictionary<string, decimal> meanMedianModeDict = new Dictionary<string, decimal>();
            //sort intList
            intList.Sort();
            //variables of int mean/median/mode - values of my dict
            //calculate mean/median/mode
            decimal mean = Mean(intList);
            decimal median = Median(intList);
            decimal mode = Mode(intList);


            //add mean median, mode to my dictionary with keys(string mean, median, mode)
            meanMedianModeDict.Add("mean", mean);
            meanMedianModeDict.Add("median", median);
            meanMedianModeDict.Add("mode", mode);

        }
        private decimal Mean(List<int> intList)
        {
            decimal mean = intList.Count > 0 ? (decimal)(intList.Average()) : 0.0m;
            return mean;
        }
        private decimal Median(List<int> intList)
        {
            intList.Sort();

            decimal median;

            if(intList.Count % 2 != 0)
            {
                median = intList[((intList.Count / 2);

            }
            else{
                //even
                int x = intList[((intList.Count) / 2)];
                int y = intList[((intList.Count) / 2) - 1];
                
                median = (x + y) / 2;
            }


            return median;
        }
        private decimal Mode(List<int> intList)
        {
            decimal Mode;
            for(i == i)
            {
                Mode++;
            }
            
            int mode = x.GroupBy()
            return Mode;
        }
        private 
        //class object should have Class, object {get; set; } Full constructor, Empty constructor
    }
}

        // //Method to convert every other char in a string toupper
        // public string SpongeBobCaser(string input)
        // {
        //     string output = "";

        //     foreach (char x in input)
        //     {
        //         if(input.IndexOf(x) % 2 == 0)
        //         {
        //            output += char.ToUpper(x);

        //         }
        //         else 
        //         {
        //             output += char.ToLower(x);
        //         }
        //     }
        //     return output;
        // }
        //     public int Sum(int[] intArr)
        //     {
        //         int sum = 0;
        //         foreach (int x in intArr)
        //         {
        //             sum += x;
        //         }
        //         return sum;
        //     }

        // //Write a method that returns the average of an array of ints. The array of ints must be passed in as a parameter.
        //     public decimal Average(int[] intArr)
        //     {
        //         decimal sum = Sum(intArr); //invoking above method
        //         decimal arrayLength = intArr.Length;
        //         decimal average = (decimal)(sum / arrayLength); // casting
        //         return average;
        //     }
        // //05 Write another Average() method that takes parameters of (int[] intArr, int max, int min) - where max and min are thresholds for outliers - We don't want the outliers included in our average.

        //     public decimal Average(int[] intArr, int max, int min)
        //     {
        //         decimal sum = 0;
        //         decimal arrayLength = 0;

        //         foreach (int x in intArr)
        //         {
        //             if (x <= max && x >= min)
        //             {
        //                 sum += x;
        //                 arrayLength++;
        //             }
        //         }
        //         return sum / arrayLength;
        //     }


        // //  public class arrayManipulation
        // //  {
        // //      public int arraySum(int[] numArray)
        // //      {
        // //          int sum = numArray.Sum();
        // //      }
        // //  }



        //     public class Conversions
        //     {
        //         public List<float> distanceConversion(List<float> floatList)
        //         {
        //             // float kmDistance = {};
        //             List<float> newFloatList = new List<float>();

        //             foreach(float x in floatList)
        //             {
        //                 if (x >= 0.5f)
        //                 {
        //                     newFloatList.Add(x * 1.6f);
        //                 }

        //             }

        //             return newFloatList;
        //         }

        //         public void PrintList(List<float> floatList)
        //         {
        //             foreach ( float x in floatList)
        //             {
        //                 Console.WriteLine(x);
        //             }
        //         }
        //     }
        //     public string favoriteAnimal(string inputA)
        // {

        //     string x = inputA.ToUpper();

        //     if(x == "A")
        //     {
        //         return "Alligator";
        //     }
        //     else if(x == "B")
        //     {
        //         return "Biscuit";
        //     }
        //     else if(x == "C")
        //     {
        //         return "Chihuahua";
        //     }
        //     else
        //         return "Spaghetti";
        // }

    //     public string hangman(string input)
    //     {
    //         foreach (char x in input)
    //         {
    //             int i = input.Length;
    //             if(x == " ")
    //             {
    //             return " ";
    //             }
    //             else if (x != " ");
    //             {
    //                     return "_";
    //             } 
    //         }
    //     }
        



    //     public string ScrambleWord(string word)
    //     {
    //         char[] chars = new char[word.Length];
    //         Random rand = new Random(100);
    //         int index = 0;
    //         while (word.Length > 0)
    //         { 
    //               int next = rand.Next(0, word.Length - 1); 
    //             chars[index] = word[next];               
    //             word = word.Substring(0, next) + word.Substring(next + 1);
    //             ++index;
    //         }
    //         return new String(chars);
    //     }
    // }

