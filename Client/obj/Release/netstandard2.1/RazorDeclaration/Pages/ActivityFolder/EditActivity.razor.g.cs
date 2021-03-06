#pragma checksum "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\Pages\ActivityFolder\EditActivity.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfac783334e0726891eda795a4a0975488b95b9c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazorapp.Client.Pages.ActivityFolder
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using Blazorapp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\_Imports.razor"
using Blazorapp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\Pages\ActivityFolder\EditActivity.razor"
using Blazorapp.Shared.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditActivity/{activitiesId}")]
    public partial class EditActivity : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\Pages\ActivityFolder\EditActivity.razor"
        [Parameter] public string activitiesId { get; set; }

            Activity act = new Activity();

            protected async override Task OnParametersSetAsync()
            {
                act = await http.GetFromJsonAsync<Activity>($"api/Activities/{activitiesId}");
            }

            async Task Edit()
            {
                act.TotalCalorie = CalculateCalorie(act.ActivityFeatureNavigation.Point, act.Minutes);
              
                await http.PutAsJsonAsync($"api/Activities/{activitiesId}", act);
                await js.InvokeVoidAsync("alert", $"Updated Successfully!");
                nm.NavigateTo("ActivityList");
            }

            double CalculateCalorie(double point, double minutes)
            {
                double level = point * minutes;
                if (minutes > 1440)
                {
                    Console.Write("time is more than 24 hours");
                }

                return (level + ((1440 - minutes) * 1.2)) / 1440;

            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nm { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
