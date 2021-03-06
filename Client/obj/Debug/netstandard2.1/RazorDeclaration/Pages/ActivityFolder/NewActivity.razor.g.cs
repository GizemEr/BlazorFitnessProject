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
#line 1 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Blazorapp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Blazorapp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\Pages\ActivityFolder\NewActivity.razor"
using Blazorapp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\Pages\ActivityFolder\NewActivity.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/NewActivity")]
    public partial class NewActivity : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\STAJ ile ilgili her şey\Blazorapp (2)\Blazorapp\Client\Pages\ActivityFolder\NewActivity.razor"
      

    Activity act= new Activity();
    List<ActivityValue> values;

    async Task Add()
    {
        var navigation = values.Where(c => c.Id == act.ActivityFeature).FirstOrDefault();
        act.UserId = _userId;
        act.TotalCalorie = CalculateCalorie(navigation.Point, act.Hour);
        await http.PostAsJsonAsync<Activity>("api/Activities", act);
        nm.NavigateTo("ActivityList");
    }


    private string _userId;
    private AspNetUsers _username;
    private string name;
    private IEnumerable<Claim> _claims = Enumerable.Empty<Claim>();

    protected override async Task OnParametersSetAsync()
    {
        values = await http.GetFromJsonAsync<List<ActivityValue>>("api/ActivityValues");
        await GetClaimsPrincipalData();
        await base.OnParametersSetAsync();
    }

    private async Task GetClaimsPrincipalData()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity.IsAuthenticated)
        {
            _claims = user.Claims;
            _userId = $"{user.FindFirst(c => c.Type == "sub")?.Value}";
        }
    }


    double CalculateCalorie(double point, double hours)
    {
        double level = 0;
        level += (point * hours) ;

        if (hours> 24)
        {
            Console.Write("time is more than 24 hours");
        }
        level += (24 - hours) * 1.2;
        level /= 24;
        return (level - 1) * 1020;

    }


     

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nm { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
