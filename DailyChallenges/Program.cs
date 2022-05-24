using DailyChallenges;

// string teamOne = "Indy Eleven";
// string teamTwo = "Chicago Fire";

// int scoreA = 4;
// int scoreB = 1;


// _blah.gameTime(teamOne, teamTwo, scoreA, scoreB);

// Console.WriteLine(_blah.gameTime(teamOne, teamTwo, scoreA, scoreB));



// string input = "I Know you are, but what am I?";
// string output = _blah.SpongeBobCaser(input);
// Console.WriteLine(output);

// //Array Challenge
//         //Write a method that takes in an array of ints and returns the sum of all of those ints.

//         //04
//         //Write a method that returns the average of an array of ints. The array of ints must be passed in as a parameter.

//         //05 Write another Average() method that takes parameters of (int[] intArr, int max, int min) - where max and min are thresholds for outliers - We don't want the outliers included in our average.

//         // int[] intArr = { 3, 6, 90, 5, 2, 8, 6, 120, 8, 12, 7, -56 }

//         // int min = 0;
//         // int max = 10;

//         // decimal averageWithOutOutliers = _key.Average(intArr, max, min);
// // arrayManipulation _huh = new arrayManipulation();

// int[] intArr = { 3, 5, 12, 18, 140, 0};
// // int sum = _huh.arraySum(numArray);
// int sum = numArray.Sum();
// Console.WriteLine(sum);

// int max = numArray.Max();
// Console.WriteLine(max);

// int min = numArray.Min();
// Console.WriteLine(min);







// Conversions _math = new Conversions();

// List<float> floatList = new List<float>(){ 0.12f, 13.6f, 26.2f, 13.1f, 36f };

// List<float> kmList = _math.distanceConversion(floatList);

// _math.PrintList(kmList);


// Console.WriteLine("Choose A, B, or C?");

// string input = Console.ReadLine();

// string output = _.favoriteAnimal(input);

// Console.WriteLine(output);


// HANGMAN CHALLENGE
// Write a method that takes a parameter of type string, and prints out _underscores_ and spaces for representing the string in a game of hangman.
// Example:
// "I love coding" would print "_   _ _ _ _   _ _ _ _ _ _"
// string input = "Do I love coding?";
// _blah.hangman(input);



// WORD - UNSCRAMBLE CHALLENGE
// Write a method that takes in a parameter of type string and returns the same word scrambled up.
// Example:
// "sharks" would return "rhssak", or something like that.

// string startWord = "shark";

// string scramble(string startWord)
// {
//         Random rando = new Random();
//         string endWord = startWord(rando);
//         return endWord;
// }


// string word = "shark";
// _blah.ScrambleWord(word);
ChallengeRepository _blah = new ChallengeRepository();
McDonaldsMenu _mcds = new McDonaldsMenu();



DateTime birthday = Convert.ToDateTime(Console.ReadLine());
int output = _mcds.CalculateAgeInDays(birthday);
Console.WriteLine(output);













