using System;

namespace BlazorWeb.Services
{
    public class RandomGeneratorService : IRandomGeneratorService
    {
        private Random Random { get; } = new Random();

        public int GenerateRandomNumber(int min, int max)
        {
            return Random.Next(min, max);
        }
    }
}
