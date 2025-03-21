using Leetcode.Arrays.Easy;
using Leetcode.DynamicProgramming.Easy;
using Leetcode.Matrix.Easy;
using Leetcode.SlidingWindow.Easy;
using Leetcode.Sorting.Algorithms;
using Leetcode.Sorting.Easy;
using Leetcode.Strings;
using Leetcode.Strings.Easy;
using Leetcode.Strings.Medium;
using Leetcode.TwoPointers.Easy;
using System.Globalization;

Console.WriteLine("Hello, World!");

#region Array

#region TwoSum
//int[] numbers = TwoSum.TwoSum3([3, 2, 4], 6);
//Console.WriteLine(string.Join(", ", numbers));
#endregion

#region PlusOne
//int[] numbers = PlusOne.PlusOne1([9, 8, 7, 6, 5, 4, 3, 2, 1, 0]);
//Console.WriteLine(string.Join(", ", numbers));
#endregion

#region SingleNumber
//int num = SingleNumber.SingleNumber2([4, 1, 2, 1, 2]);
//Console.WriteLine(num);
#endregion

#region SummaryRanges
//IList<string> result = SummaryRanges.SummaryRanges1([0, 2, 3, 4, 6, 8, 9]);
//foreach (var range in result) Console.WriteLine(range);
#endregion

#region NumArray
//NumArray1 numArray1 = new([-2, 0, 3, -5, 2, -1]);
//numArray1.SumRange(0, 1);
#endregion

#region FindAllNumbersDisappearedInAnArray
//var result = FindAllNumbersDisappearedInAnArray.FindDisappearedNumbers2([4, 3, 2, 7, 8, 2, 3, 1]);
//Console.WriteLine(string.Join(", ", result));
#endregion

#region TeemoAttacking
//int result = TeemoAttacking.FindPoisonedDuration([1, 2, 3, 4, 5, 6, 7, 8, 9], 5);
#endregion

#region ReshapeTheMatrix
//var result = ReshapeTheMatrix.MatrixReshape([[1, 2], [3, 4]], 1, 4);
#endregion

#region DistributeCandies
//var result = DistributeCandies.DistributeCandies1([1, 1, 2, 2, 3, 3]);
#endregion

#region CanPlaceFlowers
//var result = CanPlaceFlowers.CanPlaceFlowers1([1, 0, 0, 0, 1], 1);
#endregion

#region LongestContinuousIncreasingSubsequence
//var result = LongestContinuousIncreasingSubsequence.FindLengthOfLCIS([1, 3, 5, 4, 7]);
//Console.WriteLine(result);
#endregion

#region BaseballGame
//var result = BaseballGame.CalPoints(["5", "2", "C", "D", "+"]);
//Console.WriteLine(result);
#endregion

#region DegreeOfAnArray
//var result = DegreeOfAnArray.FindShortestSubArray([1, 2, 2, 3, 1, 4, 2]);
//Console.WriteLine(result);
#endregion

#region DesignHashSet
//var obj = new DesignHashSet();
//obj.Add(0);
#endregion

#region _1bitand2bitCharacters
//var result = _1bitand2bitCharacters.IsOneBitCharacter([0]);
//Console.WriteLine(result);
#endregion

#region FindPivotIndex
//var result = FindPivotIndex.PivotIndex([1, 7, 3, 6, 5, 6]);
//Console.WriteLine(result); 
#endregion

#region FindSmallestLetterGreaterThanTarget
//var result = FindSmallestLetterGreaterThanTarget.NextGreatestLetter(['c', 'f', 'j'], 'a');
//Console.WriteLine(result); 
#endregion

#region MinCostClimbingStairs
//var result = MinCostClimbingStairs.MinCostClimbingStairs1([1, 100, 1, 1, 1, 100, 1, 1, 100, 1]);
//Console.WriteLine(result); 
#endregion

var result = ValidMountainArray.ValidMountainArray2([0, 3, 2, 1]);
Console.WriteLine(result);

#endregion

#region DynamicProgramming

#region PascalsTriangle
//var result = PascalsTriangle.Generate(5);
//foreach (var triangle in result) Console.WriteLine(string.Join(", ", triangle));

#endregion

#endregion

#region Matrix

#region ImageSmoother
//var result = ImageSmoother.ImageSmoother1([[100, 200, 100], [200, 50, 200], [100, 200, 100]]);
//foreach (var item in result) Console.WriteLine(string.Join(",", item));
#endregion

#region IslandPerimeter
//int result = IslandPerimeter.IslandPerimeter1([[0, 1, 0, 0], [1, 1, 1, 0], [0, 1, 0, 0], [1, 1, 0, 0]]);
//Console.WriteLine(result);
#endregion

#region LargestTriangleArea
//var result = LargestTriangleArea.LargestTriangleArea1([[1, 0], [0, 0], [0, 1]]);
//Console.WriteLine(result.ToString()); 
#endregion

#endregion

#region SlidingWindow

#region ContainsDuplicateII
//bool result = ContainsDuplicateII.ContainsNearbyDuplicate2([1, 0, 1, 1], 1);
//Console.WriteLine(result);
#endregion

#region LongestHarmoniousSubsequence
//var result = LongestHarmoniousSubsequence.FindLHS([1, 3, 2, 2, 5, 2, 3, 7]);
#endregion

#region MaximumAverageSubarrayI
//var result = MaximumAverageSubarrayI.FindMaxAverage([0, 4, 0, 3, 2], 1);
#endregion

#endregion

#region String

#region RomanToInteger
//int num = RomanToInteger.RomanToInt2("MCMXCIV");
//Console.WriteLine(num);
#endregion

#region KeyboardRow
//var result = KeyboardRow.FindWords(["Hello", "Alaska", "Dad", "Peace"]);
#endregion

#region MinimumIndexSumOfTwoLists
//MinimumIndexSumOfTwoLists.FindRestaurant(["Shogun", "Tapioca Express", "Burger King", "KFC"],
//["KFC", "Shogun", "Burger King"]);
#endregion

#region IntegerToRoman
//string num = IntegerToRoman.IntToRoman(3749);
//Console.WriteLine(num);
#endregion

#region ShortestCompletingWord
//var result = ShortestCompletingWord.ShortestCompletingWord4("1s3 PSt", ["step", "steps", "stripe", "stepple"]);
//Console.WriteLine(result); 
#endregion

#region UniqueMorseCodeWords
//var result = UniqueMorseCodeWords.UniqueMorseRepresentations2(["gin", "zen", "gig", "msg"]);
//Console.WriteLine(result); 
#endregion

#endregion

#region TwoPointers

#region AssignCookies
//int result = AssignCookies.FindContentChildren([1, 2, 3], [1, 1]);
#endregion

#region ShortestDistanceToACharacter
//var result = ShortestDistanceToACharacter.ShortestToChar("loveleetcode", 'e');
//Console.WriteLine(string.Join(',',result)); 
#endregion

#endregion

#region Sorting

#region ArrayPartition
//var result = ArrayPartition.ArrayPairSum();
#endregion

#region MaximumProductOfThreeNumbers
//var result = MaximumProductOfThreeNumbers.MaximumProduct([-100, -98, -1, 2, 3, 4]);

#endregion

#region MissingNumber
//int num = MissingNumber.MissingNumber3([0, 1]);
//Console.WriteLine(num);
#endregion

#region RelativeRanks
//var result = RelativeRanks.FindRelativeRanks2([10, 3, 8, 9, 4]);
//Console.WriteLine(string.Join(',', result));
#endregion

#region SetMismatch
//var result = SetMismatch.FindErrorNums([1, 2, 2, 4]);
#endregion

#region ThirdMaximumNumber
//int num = ThirdMaximumNumber.ThirdMax([2, 2, 3, 1, 4]);
//Console.WriteLine(num);
#endregion

#region MajorityElement
//int num = MajorityElement.MajorityElement1([2, 2, 1, 1, 1, 2, 2]);
//Console.WriteLine(num);
#endregion

#region LargestNumberAtLeastTwiceOfOthers
//var result = LargestNumberAtLeastTwiceOfOthers.DominantIndex([3, 6, 1, 0]); 
#endregion

#region SortArrayByParity
//var result = SortArrayByParity.SortArrayByParity3([3, 1, 2, 4]);
//Console.WriteLine(string.Join('-',result)); 
#endregion

#endregion

#region SortingAlgorithms

#region BubbleSort
//int[] result = { 5, 2, 7, 9, 1, 0, 6, 3, 4,8 };
//BubbleSort.Sort(result);
//Console.WriteLine(string.Join('-',result)); 
#endregion

#endregion
