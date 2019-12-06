using BlazorWeb.Models.RandomThings;
using BlazorWeb.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorWeb.Pages
{
    public class RandomThingsBase : ComponentBase
    {
        [Inject] IRandomGeneratorService RandomGeneratorService { get; set; }

        protected int GeneratedNumber { get; set; }

        protected RandomNumberRange RandomNumberRangeModel = new RandomNumberRange();

        protected void HandleRandomNumberSubmit()
        {
            GeneratedNumber = RandomGeneratorService.GenerateRandomNumber(RandomNumberRangeModel.From, RandomNumberRangeModel.To);
        }
    }
}
