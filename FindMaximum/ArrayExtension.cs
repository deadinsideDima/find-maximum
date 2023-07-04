using System;

namespace FindMaximum
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Finds the element of the array with the maximum value.
        /// </summary>
        /// <param name="array"> Source array. </param>
        /// <returns>The element of the array with the maximum value.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public static int GetMax(int[]? array)
        {
            int max = 0;
            if (array != null)
            {
                if (array.Length == 0)
                {
                    throw new ArgumentException("Array is empty", nameof(array));
                }

                max = array[0];

                for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] > max)
                        {
                            max = array[i];
                        }
                    }
            }
            else
            {
                throw new ArgumentNullException(nameof(array));
            }

            return max;
        }
    }
}
