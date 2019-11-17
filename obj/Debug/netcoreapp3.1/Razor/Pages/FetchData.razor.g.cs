#pragma checksum "D:\Developer\2019\Web\jmw-blazor\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aaad5b75afa605a87046506ccb000313a56c30a"
// <auto-generated/>
#pragma warning disable 1591
namespace JMW.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Developer\2019\Web\jmw-blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Developer\2019\Web\jmw-blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Developer\2019\Web\jmw-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Developer\2019\Web\jmw-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Developer\2019\Web\jmw-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Developer\2019\Web\jmw-blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Developer\2019\Web\jmw-blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Developer\2019\Web\jmw-blazor\_Imports.razor"
using JMW;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Developer\2019\Web\jmw-blazor\_Imports.razor"
using JMW.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Developer\2019\Web\jmw-blazor\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Developer\2019\Web\jmw-blazor\Pages\FetchData.razor"
using JMW.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorAnimate.Animate>(0);
            __builder.AddAttribute(1, "Animation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAnimate.IAnimation>(
#nullable restore
#line 6 "D:\Developer\2019\Web\jmw-blazor\Pages\FetchData.razor"
                    Animations.FadeIn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Duration", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.TimeSpan?>(
#nullable restore
#line 6 "D:\Developer\2019\Web\jmw-blazor\Pages\FetchData.razor"
                                                 TimeSpan.FromSeconds(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n\r\n    ");
                __builder2.AddMarkupContent(5, "<h1>Weather forecast</h1>\r\n\r\n    ");
                __builder2.AddMarkupContent(6, "<p>This component demonstrates fetching data from a service.</p>\r\n\r\n");
#nullable restore
#line 12 "D:\Developer\2019\Web\jmw-blazor\Pages\FetchData.razor"
     if (forecasts == null)
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(7, "        ");
                __builder2.AddMarkupContent(8, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 15 "D:\Developer\2019\Web\jmw-blazor\Pages\FetchData.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(9, "        ");
                __builder2.OpenElement(10, "table");
                __builder2.AddAttribute(11, "class", "table");
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.AddMarkupContent(13, "<thead>\r\n                <tr>\r\n                    <th>Date</th>\r\n                    <th>Temp. (C)</th>\r\n                    <th>Temp. (F)</th>\r\n                    <th>Summary</th>\r\n                </tr>\r\n            </thead>\r\n            ");
                __builder2.OpenElement(14, "tbody");
                __builder2.AddMarkupContent(15, "\r\n");
#nullable restore
#line 28 "D:\Developer\2019\Web\jmw-blazor\Pages\FetchData.razor"
                 foreach (var forecast in forecasts)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(16, "                    ");
                __builder2.OpenElement(17, "tr");
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.OpenElement(19, "td");
                __builder2.AddContent(20, 
#nullable restore
#line 31 "D:\Developer\2019\Web\jmw-blazor\Pages\FetchData.razor"
                             forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 32 "D:\Developer\2019\Web\jmw-blazor\Pages\FetchData.razor"
                             forecast.TemperatureC

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                        ");
                __builder2.OpenElement(25, "td");
                __builder2.AddContent(26, 
#nullable restore
#line 33 "D:\Developer\2019\Web\jmw-blazor\Pages\FetchData.razor"
                             forecast.TemperatureF

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                        ");
                __builder2.OpenElement(28, "td");
                __builder2.AddContent(29, 
#nullable restore
#line 34 "D:\Developer\2019\Web\jmw-blazor\Pages\FetchData.razor"
                             forecast.Summary

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n");
#nullable restore
#line 36 "D:\Developer\2019\Web\jmw-blazor\Pages\FetchData.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(32, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n");
#nullable restore
#line 39 "D:\Developer\2019\Web\jmw-blazor\Pages\FetchData.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(35, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "D:\Developer\2019\Web\jmw-blazor\Pages\FetchData.razor"
           
        private WeatherForecast[] forecasts;

        protected override async Task OnInitializedAsync()
        {
            forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
