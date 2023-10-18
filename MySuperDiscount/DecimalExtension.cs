namespace MySuperDiscount;

// public static class DecimalExtension
// { 
//     
//     /// <summary>
//     /// Checks if the value is not strictly within the specified range (exclusive of boundaries).
//     /// </summary>
//     /// <param name="value">The value to check.</param>
//     /// <param name="min">The lower boundary.</param>
//     /// <param name="max">The upper boundary.</param>
//     /// <returns>True if the value is within the range, excluding the boundaries; otherwise, false.</returns>
//     public static bool IsNotBetween(this decimal value, decimal min, decimal max)
//     {
//         return !value.IsBetween(min,max);
//     }
//     
//     /// <summary>
//     /// Checks if the value is strictly within the specified range (exclusive of boundaries).
//     /// </summary>
//     /// <param name="value">The value to check.</param>
//     /// <param name="min">The lower boundary.</param>
//     /// <param name="max">The upper boundary.</param>
//     /// <returns>True if the value is within the range, excluding the boundaries; otherwise, false.</returns>
//     public static bool IsBetween(this decimal value, decimal min, decimal max)
//     {
//         return value > min && value < max;
//     }
// }