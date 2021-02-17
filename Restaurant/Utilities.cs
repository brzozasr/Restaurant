using System;

namespace Restaurant
{
    public static class Utilities
    {
        public static Random Random => new Random();
        
        public static double DoubleGenerator(this Random random, double min, double max)
        {
            return Math.Round(Random.NextDouble() * (max - min) + min, 2,
                MidpointRounding.AwayFromZero);
        }
    }
}