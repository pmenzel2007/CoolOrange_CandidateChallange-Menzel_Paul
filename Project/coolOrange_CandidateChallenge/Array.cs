using System;

namespace coolOrange_CandidateChallenge
{
	public class Array
	{
        /// <summary>
        /// Returns the biggest integer in a given Array between position1 and position2 by iterating over every element of the Array
        /// between the two positions and comparing it to the currentt biggest integer found.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="position1"></param>
        /// <param name="position2"></param>
        /// <returns>the biggest integer found inside the given range in the given array</returns>
		public static int FindMaxValue(int[] array, int position1, int position2)
		{
			int ret = int.MinValue;

            for (int i = position1; i <= position2; i++)
            {
                if (array[i] > ret)
                {
                    ret = array[i];
                }
            }
            return ret;
		}

        /// <summary>
        /// Returns the index of the smallest integer in a given Array bebetween position1 and position2 by iterating over every element of the Array
        /// between the two positions and comparing it to the currentt smallest integer found. 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="position1"></param>
        /// <param name="position2"></param>
        /// <returns>the index of the smallest integer found inside the given range in the given array</returns>
		public static int FindMinPosition(int[] array, int position1, int position2)
		{
            int ret = 0;
			int min = int.MaxValue;

            for (int i = position1; i <= position2;i++)
            {
                if (array[i] < min)
                {
					min = array[i];
                    ret = i;
                }
            }

            return ret;
        }

        /// <summary>
        /// Swaps the Values of the two given indexes in the given array by using a tuple assignment
        /// </summary>
        /// <param name="array"></param>
        /// <param name="position1"></param>
        /// <param name="position2"></param>
		public static void Swap(int[] array, int position1, int position2)
		{
            (array[position2], array[position1]) = (array[position1], array[position2]);
        }

        /// <summary>
        /// shifts all the elements between the passed positions to the left by one position leaves position2 unchanged by saving the value at the index position1
        /// in a temporary variable and then iterating over the array and changing every value to the next one in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="position1"></param>
        /// <param name="position2"></param>
        public static void ShiftLeftByOne(int[] array, int position1, int position2)
		{
			int temp = array[position1];
			for (int i = position1; i < position2;i++)
			{
                if (i + 1 != position2)
                {
					array[i] = array[i + 1];
                } else
				{
					array[i] = temp;
				}
            }
		}

        /// <summary>
        /// returns an array with the given size filled with random integer between the minValue and maxValue
        /// </summary>
        /// <param name="size"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns>the random Array</returns>
		public static int[] CreateRandomArray(int size, int minValue, int maxValue)
		{
            int[] array = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
			{
				array[i] = random.Next(minValue, maxValue);
            }

			return array;
		}

        /// <summary>
        /// returns a 2D array with the given size filled with random integer between the minValue and maxValue
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns>the randomized 2D Array</returns>
		public static int[,] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
		{
            int[,] matrix = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(minValue, maxValue);
                }
            }
            return matrix;

        }

        /// <summary>
        /// copies the given array twice into a 2D array
        /// </summary>
        /// <param name="array"></param>
        /// <returns>the 2D array containing the given array and its copy</returns>
        public static int[,] CopyArray(int[] array)
        {
            int[,] ret = new int[2, array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                ret[0, i] = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                ret[1, i] = array[i];
            }

            return ret;
        }

        /// <summary>
        /// Returns the position of the given number inside the array. It does so by utilizing a binary search. 
        /// It cuts the array in half everytime the number its looking for is not at the center and then checking again by using only 
        /// the half of the array where the number should be
        /// </summary>
        /// <param name="array"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int FindInSortedArray(int[] array, int number)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == number)
                {
                    return mid;
                }
                else if (array[mid] > number)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }


    }
}
