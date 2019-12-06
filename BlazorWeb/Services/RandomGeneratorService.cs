using System;

namespace BlazorWeb.Services
{
    public class RandomGeneratorService : IRandomGeneratorService
    {
        public int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
