namespace BlazorWeb.Services
{
    public interface IRandomGeneratorService
    {
        int GenerateRandomNumber(int min, int max);
    }
}
