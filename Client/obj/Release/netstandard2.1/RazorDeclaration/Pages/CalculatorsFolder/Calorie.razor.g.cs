#pragma checksum "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed23e50de009f29fe6573708874e95ddf3489de7"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazorapp.Client.Pages.CalculatorsFolder
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
#line 2 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
using Blazorapp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
using Blazorapp.Client.Pages.Enums;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DailyCalorieCalculator")]
    public partial class Calorie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\SÜMEYRA\Desktop\Blazorapp\Client\Pages\CalculatorsFolder\Calorie.razor"
       private const string green = "#1c7c00";
    private const string red = "#ff0000";
    private string palMessage = "";
    private string maintenanceMessage = "";

    private string maintenanceMessageColor = "";
    private string palMessageColor = "";

    private bool palButtonDisabled => caloricData.Maintenance == 0;
    private CaloricData caloricData = new CaloricData();





    private void OnCalculateMaintenanceClick()
    {
        if (caloricData.Weight > 0 && caloricData.Height > 0 && caloricData.Age > 0)
        {
            maintenanceMessageColor = green;
            maintenanceMessage = "";

            switch (caloricData.Gender)
            {
                case (int) Enums.Gender.Male:

                    var maleResult = Math.Round((9.99 * caloricData.Weight) + (6.25 * caloricData.Height) - (4.92 * caloricData.Age) + 5).ToString();
                    int.TryParse(maleResult, out int maleValue);
                    caloricData.Maintenance = maleValue;
                    break;

                case (int) Enums.Gender.Female:
                    var femaleResult = Math.Round((9.99 * caloricData.Weight) + (6.25 * caloricData.Height) - (4.92 * caloricData.Age) - 161).ToString();
                    int.TryParse(femaleResult, out int femaleValue);
                    caloricData.Maintenance = femaleValue;

                    break;

                default:
                    break;
            }
        }
        else
        {
            maintenanceMessageColor = red;
            maintenanceMessage = "Invalid Inputs detected";
            caloricData.Maintenance = 0;
        }
    }
    private void OnHeightChange(ChangeEventArgs e)
    {
        int.TryParse(e.Value.ToString(), out int value);
        caloricData.Height = value;
    }

    private void OnWeightChange(ChangeEventArgs e)
    {
        int.TryParse(e.Value.ToString(), out int value);
        caloricData.Weight = value;
    }

    private void OnAgeChange(ChangeEventArgs e)
    {
        int.TryParse(e.Value.ToString(), out int value);
        caloricData.Age = value;
    } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
