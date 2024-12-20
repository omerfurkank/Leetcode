using Leetcode.Arrays.Easy;
using Leetcode.Matrix.Easy;
using Leetcode.Strings;
using Leetcode.Strings.Easy;
using System.Globalization;

Console.WriteLine("Hello, World!");

#region Array

#region TwoSum
//int[] numbers = TwoSum.TwoSum3([3, 2, 4], 6);
//Console.WriteLine(string.Join(", ",numbers)); 
#endregion

#region RemoveDuplicatesFromSortedArray
//int num = RemoveDuplicatesFromSortedArray.RemoveDuplicates2([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]);
//Console.WriteLine(num);
#endregion

#region RemoveElement
//int num = RemoveElement.RemoveElement1([0, 1, 2, 2, 3, 0, 4, 2], 2);
//Console.WriteLine(num); 
#endregion

#region SearchInsertPosition
//int num = SearchInsertPosition.SearchInsert([1, 3, 5, 6], 7);
//Console.WriteLine(num); 
#endregion

#region PlusOne
//int[] numbers = PlusOne.PlusOne1([9, 8, 7, 6, 5, 4, 3, 2, 1, 0]);
//Console.WriteLine(string.Join(", ", numbers));
#endregion

#region MergeSortedArray
//MergeSortedArray.Merge([0], 0, [1], 1);
#endregion

#region MajorityElement
//int num = MajorityElement.MajorityElement1([2, 2, 1, 1, 1, 2, 2]);
//Console.WriteLine(num); 
#endregion

#region BestTimeToBuyAndSellStock
//int num = BestTimeToBuyAndSellStock.MaxProfit2([7, 6, 4, 3, 1]);
//Console.WriteLine(num);
#endregion

#region PascalsTriangle
//var result = PascalsTriangle.Generate(5);
//foreach (var triangle in result) Console.WriteLine(string.Join(", ", triangle));
#endregion

#region SingleNumber
//int num = SingleNumber.SingleNumber2([4, 1, 2, 1, 2]);
//Console.WriteLine(num);
#endregion

#region ContainsDuplicate
//bool result = ContainsDuplicate.ContainsDuplicate1([1, 2, 3, 4]);
//Console.WriteLine(result); 
#endregion

#region ContainsDuplicateII
//bool result = ContainsDuplicateII.ContainsNearbyDuplicate2([1, 0, 1, 1], 1);
//Console.WriteLine(result);
#endregion

#region MaxConsecutiveOnes
//int result = MaxConsecutiveOnes.FindMaxConsecutiveOnes([1, 1, 0, 1, 1, 1]);
//Console.WriteLine(result); 
#endregion

#region SummaryRanges
//IList<string> result = SummaryRanges.SummaryRanges1([0, 2, 3, 4, 6, 8, 9]);
//foreach (var range in result) Console.WriteLine(range); 
#endregion

#region MissingNumber
//int num = MissingNumber.MissingNumber3([0, 1]);
//Console.WriteLine(num); 
#endregion

#region MoveZeroes
//var result = MoveZeroes.MoveZeroes1([0, 1, 0, 3, 12]);
//Console.WriteLine(String.Join(',',result)); 
#endregion

#region IntersectionOfTwoArrays
//var result = IntersectionOfTwoArrays.Intersection([1, 2, 2, 1], [2, 2]);
//Console.WriteLine(string.Join(Environment.NewLine, result)); 
#endregion

#region IntersectionOfTwoArraysII
//var result = IntersectionOfTwoArraysII.Intersect1([1, 2, 2, 1], [2, 2]);
//Console.WriteLine(string.Join(Environment.NewLine, result)); 
#endregion

#region NumArray
//NumArray1 numArray1 = new([-2, 0, 3, -5, 2, -1]);
//numArray1.SumRange(0, 1);
#endregion

#region ThirdMaximumNumber
//int num = ThirdMaximumNumber.ThirdMax([2, 2, 3, 1,4]);
//Console.WriteLine(num);
#endregion

#region FindAllNumbersDisappearedInAnArray
//var result = FindAllNumbersDisappearedInAnArray.FindDisappearedNumbers2([4, 3, 2, 7, 8, 2, 3, 1]);
//Console.WriteLine(string.Join(", ", result));
#endregion

#region AssignCookies
//int result = AssignCookies.FindContentChildren([1, 2, 3], [1, 1]); 
#endregion

#region IslandPerimeter
//int result = IslandPerimeter.IslandPerimeter1([[0, 1, 0, 0], [1, 1, 1, 0], [0, 1, 0, 0], [1, 1, 0, 0]]);
//Console.WriteLine(result); 
#endregion

#region TeemoAttacking
//int result = TeemoAttacking.FindPoisonedDuration([1, 2, 3, 4, 5, 6, 7, 8, 9], 5); 
#endregion

#region ReshapeTheMatrix
//var result = ReshapeTheMatrix.MatrixReshape([[1, 2],[3, 4]], 1, 4); 
#endregion

#region DistributeCandies
//var result = DistributeCandies.DistributeCandies1([1, 1, 2, 2, 3, 3]); 
#endregion

#region LongestHarmoniousSubsequence
//var result = LongestHarmoniousSubsequence.FindLHS([1, 3, 2, 2, 5, 2, 3, 7]); 
#endregion

#region CanPlaceFlowers
//var result = CanPlaceFlowers.CanPlaceFlowers1([1, 0, 0, 0, 1], 1); 
#endregion

#region MaximumProductOfThreeNumbers
//var result = MaximumProductOfThreeNumbers.MaximumProduct([-100, -98, -1, 2, 3, 4]);

#endregion

#region MaximumAverageSubarrayI
//var result = MaximumAverageSubarrayI.FindMaxAverage([0, 4, 0, 3, 2], 1); 
#endregion

#region SetMismatch
//var result = SetMismatch.FindErrorNums([1, 2, 2, 4]); 
#endregion

#region LongestContinuousIncreasingSubsequence
//var result = LongestContinuousIncreasingSubsequence.FindLengthOfLCIS([1, 3, 5, 4, 7]);
//Console.WriteLine(result); 
#endregion
#endregion

#region Matrix

#region ImageSmoother
//var result = ImageSmoother.ImageSmoother1([[100, 200, 100], [200, 50, 200], [100, 200, 100]]);
//foreach (var item in result) Console.WriteLine(string.Join(",",item)); 
#endregion


#endregion

#region String

#region RomanToInteger
//int num = RomanToInteger.RomanToInt2("MCMXCIV");
//Console.WriteLine(num);
#endregion

#region IntegerToRoman
//string num = IntegerToRoman.IntToRoman(3749);
//Console.WriteLine(num);
#endregion

#region KeyboardRow
//var result = KeyboardRow.FindWords(["Hello", "Alaska", "Dad", "Peace"]); 
#endregion

#region RelativeRanks
//var result = RelativeRanks.FindRelativeRanks2([10, 3, 8, 9, 4]);
//Console.WriteLine(string.Join(',', result)); 
#endregion

#region MinimumIndexSumOfTwoLists
//MinimumIndexSumOfTwoLists.FindRestaurant(["Shogun", "Tapioca Express", "Burger King", "KFC"],
//["KFC", "Shogun", "Burger King"]); 
#endregion

#endregion

