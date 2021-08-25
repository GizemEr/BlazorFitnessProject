#pragma checksum "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Shared\LoginDisplay.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b79150b98b0512cb852a3f1f96ed47d3946f62eb"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazorapp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Blazorapp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Blazorapp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Blazorapp.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Shared\LoginDisplay.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Shared\LoginDisplay.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Shared\LoginDisplay.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\n            ");
                __builder2.OpenElement(3, "a");
                __builder2.AddAttribute(4, "href", "authentication/profile");
                __builder2.AddContent(5, "Hello, ");
                __builder2.AddContent(6, 
#nullable restore
#line 17 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Shared\LoginDisplay.razor"
                                                     name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(7, "!");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(8, "\n            ");
                __builder2.OpenElement(9, "button");
                __builder2.AddAttribute(10, "class", "nav-link btn btn-link");
                __builder2.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Shared\LoginDisplay.razor"
                                                            BeginSignOut

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(12, "Log out");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\n        ");
            }
            ));
            __builder.AddAttribute(14, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "\n            ");
                __builder2.AddMarkupContent(16, "<a href=\"authentication/register\">Register</a>\n            ");
                __builder2.AddMarkupContent(17, "<a href=\"authentication/login\">Log in</a>\n        ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Shared\LoginDisplay.razor"
           private string _authMessage;
        private string _userId;
        private AspNetUsers _username;
        private string name;
        private IEnumerable<Claim> _claims = Enumerable.Empty<Claim>();

        protected override async Task OnParametersSetAsync()
        {
            await GetClaimsPrincipalData();
            await base.OnParametersSetAsync();
        }

        private async Task BeginSignOut(MouseEventArgs args)
        {
            await SignOutManager.SetSignOutState();
            Navigation.NavigateTo("authentication/logout");
        }

        private async Task GetClaimsPrincipalData()
        {
            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            var user = authState.User;

            if (user.Identity.IsAuthenticated)
            {
                _authMessage = $"{user.Identity.Name} is authenticated.";
                _claims = user.Claims;
                _userId = $"{user.FindFirst(c => c.Type == "sub")?.Value}";

                _username = await http.GetFromJsonAsync<AspNetUsers>($"api/AspNetUsers/{_userId}");

                name = _username.Name + ' ' + _username.Surname;
            }
            else
            {
                _authMessage = "The user is NOT authenticated.";
            }
        } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignOutSessionStateManager SignOutManager { get; set; }
    }
}
#pragma warning restore 1591
