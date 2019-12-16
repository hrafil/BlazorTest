using Microsoft.AspNetCore.Components;

namespace BlazorWeb.Components.Experiments
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;

        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}
