#pragma checksum "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\ChallengesFolder\TighSlimmingChallenge3.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea9bf6c16575e4ef0429a43a5c4400b7558b54d7"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazorapp.Client.Pages.ChallengesFolder
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
#line 3 "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/TighSlimmingChallenge")]
    public partial class TighSlimmingChallenge3 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<font face=\"Verdana\" size=\"8\" color=\"purple\"> 30 Day Tigh Slimming Challenge </font>\n\n");
            __builder.AddMarkupContent(1, "<html>\n<head>\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n    <style>\n        * {\n            box-sizing: border-box;\n        }\r\n\r\n        body {\r\n            font-family: \'Comic Sans MS\',Verdana;\r\n            background-image: url(\"https://image.freepik.com/free-photo/top-view-measuring-tape-with-weight-apple_23-2148523285.jpg\");\r\n            background-repeat: no-repeat;\r\n            background-size: 100% 100%;\r\n            background-position-x: right;\r\n        }\n\n        /* Float four columns side by side */\n        .column {\n            float: left;\n            width: 20%;\n            padding: 10px;\n        }\n\n        /* Remove extra left and right margins, due to padding */\n        .row {\n            margin: 0 -5px;\n        }\n\n            /* Clear floats after the columns */\n            .row:after {\n                content: \"\";\n                display: table;\n                clear: both;\n            }\n\n        /* Responsive columns */\n        @media screen and (max-width: 600px) {\n            .column {\n                width: 100%;\n                display: block;\n                margin-bottom: 20px;\n            }\n        }\n\n        /* Style the counter cards */\n        .card {\n            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);\n            padding: 25px;\n            text-align: center;\n            background-color: #f3f4f1;\n        }\n    </style>\n</head>\n<body>\n\n    <div class=\"row\">\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #DDA0DD;\">\n                <h3>DAY 1 </h3>\n                <p>10 LEG SWINGS</p>\n                <p>12 SIDE LUNGES</p>\n                <p>10 PLIE SQUATS</p>\n            </div>\n        </div>\n\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8BFD8;\">\n                <h3>DAY 2 </h3>\n                <p>10 SIDE LEG LIFTS</p>\n                <p>12 PLIE SQUATS</p>\n                <p>10 INNER THIGH PULSES</p>\n            </div>\n        </div>\n\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #DDA0DD;\">\n                <h3>DAY 3 </h3>\n                <p>12 LEG SWINGS</p>\n                <p>12 SIDE LEG LIFTS</p>\n                <p>15 SIDE LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8BFD8;\">\n                <h3>DAY 4 </h3>\n                <p>15 SIDE LUNGES</p>\n                <p>15 PLIE SQUATS</p>\n                <p>12 INNER THIGH PULSES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #DDA0DD;\">\n                <h3>DAY 5</h3>\n                <p>REST DAY</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8BFD8;\">\n                <h3>DAY 6</h3>\n                <p>15 SIDE LEG LIFTS</p>\n                <p>15 PLIE SQUATS</p>\n                <p>12 INNER THIGH PULSES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #DDA0DD;\">\n                <h3>DAY 7</h3>\n                <p>15 LEG SWINGS</p>\n                <p>15 SIDE LUNGES</p>\n                <p>20 PLIE SQUATS</p>\n            </div>\n        </div>\n\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8BFD8;\">\n                <h3>DAY 8</h3>\n                <p>20 SIDE LUNGES</p>\n                <p>20 PLIE SQUATS</p>\n                <p>15 INNER THIGH PULSES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #DDA0DD;\">\n                <h3>DAY 9</h3>\n                <p>15 LEG SWINGS</p>\n                <p>20 SIDE LEG LIFTS</p>\n                <p>20 SIDE LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8BFD8;\">\n                <h3>DAY 10</h3>\n                <p>REST DAY</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #DDA0DD;\">\n                <h3>DAY 11</h3>\n                <p>20 LEG SWINGS</p>\n                <p>25 SIDE LUNGES</p>\n                <p>25 PLIE SQUATS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8BFD8;\">\n                <h3>DAY 12</h3>\n                <p>20 SIDE LUNGES</p>\n                <p>25 PLIE SQUATS</p>\n                <p>20 INNER THIGH PULSES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #DDA0DD;\">\n                <h3>DAY 13</h3>\n                <p>25 LEG SWINGS</p>\n                <p>20 SIDE LEG LIFTS</p>\n                <p>25 SIDE LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8BFD8;\">\n                <h3>DAY 14</h3>\n                <p>25 SIDE LEG LIFTS</p>\n                <p>30 PLIE SQUATS</p>\n                <p>20 INNER THIGH PULSES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #DDA0DD;\">\n                <h3>DAY 15</h3>\n                <p>REST DAY</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8BFD8;\">\n                <h3>DAY 16</h3>\n                <p>25 SIDE LEG LIFTS</p>\n                <p>30 PLIE SQUATS</p>\n                <p>25 INNER THIGH PULSES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #DDA0DD;\">\n                <h3>DAY 17</h3>\n                <p>25 LEG SWINGS</p>\n                <p>30 SIDE LUNGES</p>\n                <p>35 PLIE SQUATS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8BFD8;\">\n                <h3>DAY 18</h3>\n                <p>30 SIDE LUNGES</p>\n                <p>35 PLIE SQUATS</p>\n                <p>25 INNER THIGH PULSES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #DDA0DD;\">\n                <h3>DAY 19</h3>\n                <p>30 LEG SWINGS</p>\n                <p>30 SIDE LEG LIFTS</p>\n                <p>35 SIDE LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8BFD8;\">\n                <h3>DAY 20</h3>\n                <p>REST DAY</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #DDA0DD;\">\n                <h3>DAY 21</h3>\n                <p>30 LEG SWINGS</p>\n                <p>35 SIDE LUNGES</p>\n                <p>40 PLIE SQUATS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8BFD8;\">\n                <h3>DAY 22</h3>\n                <p>40 SIDE LUNGES</p>\n                <p>40 PLIE SQUATS</p>\n                <p>30 INNER THIGH PULSES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #DDA0DD;\">\n                <h3>DAY 23</h3>\n                <p>35 LEG SWINGS</p>\n                <p>35 SIDE LEG LIFTS</p>\n                <p>40 SIDE LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8BFD8;\">\n                <h3>DAY 24</h3>\n                <p>35 SIDE LEG LIFTS</p>\n                <p>45 PLIE SQUATS</p>\n                <p>35 INNER THIGH PULSES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #DDA0DD;\">\n                <h3>DAY 25</h3>\n                <p>REST DAY</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8BFD8;\">\n                <h3>DAY 26</h3>\n                <p>40 SIDE LEG LIFTS</p>\n                <p>50 PLIE SQUATS</p>\n                <p>35 INNER THIGH PULSES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #DDA0DD;\">\n                <h3>DAY 27</h3>\n                <p>35 LEG SWINGS</p>\n                <p>40 SIDE LUNGES</p>\n                <p>50 PLIE SQUATS</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8BFD8;\">\n                <h3>DAY 28</h3>\n                <p>45 SIDE LUNGES</p>\n                <p>55 PLIE SQUATS</p>\n                <p>40 INNER THIGH PULSES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #DDA0DD;\">\n                <h3>DAY 29</h3>\n                <p>40 LEG SWINGS</p>\n                <p>45 SIDE LEG LIFTS</p>\n                <p>45 SIDE LUNGES</p>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\" style=\"background-color: #D8BFD8;\">\n                <h3>DAY 30</h3>\n                <p>50 SIDE LUNGES</p>\n                <p>55 PLIE SQUATS</p>\n                <p>45 INNER THIGH PULSES</p>\n            </div>\n        </div>\n    </div>\n</body>\n</html>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
