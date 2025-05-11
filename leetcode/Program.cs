// See https://aka.ms/new-console-template for more information

using leetcode;
using leetcode.Arrays;

/* STRINGS */
// 1
// var sln = new MergeStringsAlternately();
// Console.WriteLine(sln.MergeAlternately("abc", "pqrd"));

// 2
// var gcd = new GcdOfStrings();
// Console.WriteLine(gcd.Exec("AA", "A"));

/* ARRAYS */

// var candies = new KidsWithCandies();
// Console.WriteLine(string.Join(",", candies.Execute([12,1,12], 10)));

// quick sort
var quick = new QuickSort();
Console.WriteLine(string.Join(",", quick.Sort([5,0,0,10,5, -1, 100, 3, 50, 25])));
