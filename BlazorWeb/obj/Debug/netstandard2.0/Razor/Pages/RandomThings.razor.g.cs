#pragma checksum "D:\DATA\OTHER_PROJECTS\MY_PROJ\BlazorTest\BlazorWeb\Pages\RandomThings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07b640f77524fd5447a0751e0b08ae86d46249b8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWeb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\DATA\OTHER_PROJECTS\MY_PROJ\BlazorTest\BlazorWeb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\DATA\OTHER_PROJECTS\MY_PROJ\BlazorTest\BlazorWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\DATA\OTHER_PROJECTS\MY_PROJ\BlazorTest\BlazorWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\DATA\OTHER_PROJECTS\MY_PROJ\BlazorTest\BlazorWeb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\DATA\OTHER_PROJECTS\MY_PROJ\BlazorTest\BlazorWeb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\DATA\OTHER_PROJECTS\MY_PROJ\BlazorTest\BlazorWeb\_Imports.razor"
using BlazorWeb;

#line default
#line hidden
#line 7 "D:\DATA\OTHER_PROJECTS\MY_PROJ\BlazorTest\BlazorWeb\_Imports.razor"
using BlazorWeb.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/randomthings")]
    public partial class RandomThings : RandomThingsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>RandomThings</h1>\r\n<hr>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>Random number generator</h3>\r\n\r\n");
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, "Number: ");
            __builder.AddContent(4, 
#line 9 "D:\DATA\OTHER_PROJECTS\MY_PROJ\BlazorTest\BlazorWeb\Pages\RandomThings.razor"
            GeneratedNumber

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 11 "D:\DATA\OTHER_PROJECTS\MY_PROJ\BlazorTest\BlazorWeb\Pages\RandomThings.razor"
                  RandomNumberRangeModel

#line default
#line hidden
            ));
            __builder.AddAttribute(8, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#line 11 "D:\DATA\OTHER_PROJECTS\MY_PROJ\BlazorTest\BlazorWeb\Pages\RandomThings.razor"
                                                          HandleRandomNumberSubmit

#line default
#line hidden
            )));
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n\r\n    ");
                __Blazor.BlazorWeb.Pages.RandomThings.TypeInference.CreateInputNumber_0(__builder2, 15, 16, "numberFrom", 17, 
#line 15 "D:\DATA\OTHER_PROJECTS\MY_PROJ\BlazorTest\BlazorWeb\Pages\RandomThings.razor"
                                              RandomNumberRangeModel.From

#line default
#line hidden
                , 18, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RandomNumberRangeModel.From = __value, RandomNumberRangeModel.From)), 19, () => RandomNumberRangeModel.From);
                __builder2.AddMarkupContent(20, "\r\n    ");
                __Blazor.BlazorWeb.Pages.RandomThings.TypeInference.CreateInputNumber_1(__builder2, 21, 22, "numberTo", 23, 
#line 16 "D:\DATA\OTHER_PROJECTS\MY_PROJ\BlazorTest\BlazorWeb\Pages\RandomThings.razor"
                                            RandomNumberRangeModel.To

#line default
#line hidden
                , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RandomNumberRangeModel.To = __value, RandomNumberRangeModel.To)), 25, () => RandomNumberRangeModel.To);
                __builder2.AddMarkupContent(26, "\r\n\r\n    ");
                __builder2.AddMarkupContent(27, "<button class=\"btn btn-primary\" type=\"submit\">Generate random number</button>\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BlazorWeb.Pages.RandomThings
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591