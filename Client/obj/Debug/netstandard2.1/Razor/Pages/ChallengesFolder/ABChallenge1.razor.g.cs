#pragma checksum "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\ChallengesFolder\ABChallenge1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d33f1e22e0df91fdb7171b5731aa2c1d672e5a68"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Abchallengeforaflattummy")]
    public partial class ABChallenge1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<font face=\"Comic Sans MS\" size=\"6\" color=\"pink\"> 30 DAY AB CHALLENGE FOR FLAT TUMMY </font>\r\n\r\n");
            __builder.AddMarkupContent(1, "<html>\r\n<head>\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <style>\r\n        * {\r\n            box-sizing: border-box;\r\n        }\r\n\r\n    body { background-image: url(\"https://image.freepik.com/free-photo/dumbbells-flat-lay-pink-yellow_1220-3951.jpg\"); background-repeat: no-repeat; background-size: 85% 100%; background-position-x: right; font-family: \'Comic Sans MS\',Verdana; }\r\n\r\n        /* Float four columns side by side */\r\n        .column {\r\n            float: left;\r\n            width: 20%;\r\n            padding: 10px;\r\n        }\r\n\r\n        /* Remove extra left and right margins, due to padding */\r\n        .row {\r\n            margin: 0 -5px;\r\n        }\r\n\r\n            /* Clear floats after the columns */\r\n            .row:after {\r\n                content: \"\";\r\n                display: table;\r\n                clear: both;\r\n            }\r\n\r\n        /* Responsive columns */\r\n        @media screen and (max-width: 600px) {\r\n            .column {\r\n                width: 100%;\r\n                display: block;\r\n                margin-bottom: 20px;\r\n            }\r\n        }\r\n\r\n        /* Style the counter cards */\r\n        .card {\r\n            box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);\r\n            padding: 16px;\r\n            text-align: center;\r\n            background-color: #f3f4f1;\r\n        }\r\n    </style>\r\n</head>\r\n<body>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"column\">\r\n            <div class=\"card\" style=\"background-color:#faa;\">\r\n                <h3>DAY 1 </h3>\r\n                <p>10 CRUNCHES</p>\r\n                <p>10 RUSSIAN TWIST</p>\r\n                <p>10 LEFT LIFTS</p>\r\n                <p>15 sec PLANK</p>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"column\">\r\n            <div class=\"card\" style=\"background-color:#fba;\">\r\n                <h3>DAY 2 </h3>\r\n                <p>10 REVERSE CRUNCHES</p>\r\n                <p>10 TOE TOUCHES</p>\r\n                <p>10 FLUTTER KICKS</p>\r\n                <p>15 sec PLANK</p>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"column\">\r\n            <div class=\"card\" style=\"background-color:#faa;\">\r\n                <h3>DAY 3 </h3>\r\n                <p>10 CRUNCHES</p>\r\n                <p>10 HEEL TAPS</p>\r\n                <p>10 DIAMOND SIT UPS</p>\r\n                <p>15 sec PLANK</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"column\">\r\n            <div class=\"card\" style=\"background-color:#fba;\">\r\n                <h3>DAY 4 </h3>\r\n                <p>REST DAY</p>\r\n                <p></p>\r\n                <p></p>\r\n                <p></p>\r\n            </div>\r\n        </div>\r\n        <div class=\"column\">\r\n            <div class=\"card\" style=\"background-color:#faa;\">\r\n                <h3>DAY 5</h3>\r\n                <p>12 CRUNCHES</p>\r\n                <p>12 RUSSIAN TWISTS</p>\r\n                <p>12 LEG LIFTS</p>\r\n                <p>30 sec PLANK</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"column\">\r\n            <div class=\"card\" style=\"background-color:#fba;\">\r\n                <h3>DAY 6</h3>\r\n                <p>12 REVERSE CRUNCHES</p>\r\n                <p>12 TOE TOUCHES</p>\r\n                <p>12 FLUTTER KICKS</p>\r\n                <p>30 sec PLANK</p>\r\n            </div>\r\n        </div>\r\n   \r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#faa;\">\r\n            <h3>DAY 7</h3>\r\n            <p>12 CRUNCHES</p>\r\n            <p>12 HEEL TAPS</p>\r\n            <p>12 DIAMOND SIT UPS</p>\r\n            <p>30 sec PLANK</p>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#fba;\">\r\n            <h3>DAY 8</h3>\r\n            <p>REST DAY</p>\r\n            <p></p>\r\n            <p></p>\r\n            <p></p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#faa;\">\r\n            <h3>DAY 9</h3>\r\n            <p>15 CRUNCHES</p>\r\n            <p>15 RUSSIAN TWISTS</p>\r\n            <p>15 LEG LIFTS</p>\r\n            <p>45 sec PLANK</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#fba;\">\r\n            <h3>DAY 10</h3>\r\n            <p>15 REVERSE CRUNCHES</p>\r\n            <p>15 TOE TOUCHES</p>\r\n            <p>15 FLUTTER KICKS</p>\r\n            <p>45 sec PLANK</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#faa;\">\r\n            <h3>DAY 11</h3>\r\n            <p>15 CRUNCHES</p>\r\n            <p>15 HEEL TAPS</p>\r\n            <p>15 DIAMOND SIT UPS</p>\r\n            <p>45 sec PLANK</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#fba;\">\r\n            <h3>DAY 12</h3>\r\n            <p>REST DAY</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#faa;\">\r\n            <h3>DAY 13</h3>\r\n            <p>10 CRUNCHES x2</p>\r\n            <p>10 RUSSIAN TWISTS x2</p>\r\n            <p>10 LEG LIFTS x2</p>\r\n            <p>60 sec PLANK x2</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#fba;\">\r\n            <h3>DAY 14</h3>\r\n            <p>10 REVERSE CRUNCHES x2</p>\r\n            <p>10 TOE TAPS x2</p>\r\n            <p>10 FLUTTER KICKS x2</p>\r\n            <p>60 sec PLANK x2</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#faa;\">\r\n            <h3>DAY 15</h3>\r\n            <p>10 CRUNCHES x2</p>\r\n            <p>10 HEEL TAPS x2</p>\r\n            <p>10 DIAMOND SIT UPS x2</p>\r\n            <p>60 sec PLANK x2</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#fba;\">\r\n            <h3>DAY 16</h3>\r\n            <p>REST DAY</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#faa;\">\r\n            <h3>DAY 17</h3>\r\n            <p>12 CRUNCHES x2</p>\r\n            <p>12 RUSSIAN TWISTS x2</p>\r\n            <p>12 LEG LIFTS x2</p>\r\n            <p>60 sec PLANK x2</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#fba;\">\r\n            <h3>DAY 18</h3>\r\n            <p>12 REVERSE CRUNCHES x2</p>\r\n            <p>12 TOE TAPS x2</p>\r\n            <p>12 FLUTTER KICKS x2</p>\r\n            <p>60 sec PLANK x2</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#faa;\">\r\n            <h3>DAY 19</h3>\r\n            <p>12 CRUNCHES x2</p>\r\n            <p>12 HEEL TAPS x2</p>\r\n            <p>12 DIAMOND SIT UPS x2</p>\r\n            <p>60 sec PLANK x2</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#fba;\">\r\n            <h3>DAY 20</h3>\r\n            <p>REST DAY</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#faa;\">\r\n            <h3>DAY 21</h3>\r\n            <p>15 CRUNCHES x2</p>\r\n            <p>15 RUSSIAN TWISTS x2</p>\r\n            <p>15 LEG LIFTS x2</p>\r\n            <p>60 sec PLANK x2</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#fba;\">\r\n            <h3>DAY 22</h3>\r\n            <p>15 REVERSE CRUNCHES x2</p>\r\n            <p>15 TOE TAPS x2</p>\r\n            <p>15 FLUTTER KICKS x2</p>\r\n            <p>60 sec PLANK x2</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#faa;\">\r\n            <h3>DAY 23</h3>\r\n            <p>15 CRUNCHES x2</p>\r\n            <p>15 HEEL TAPS x2</p>\r\n            <p>15 DIAMOND SIT UPS x2</p>\r\n            <p>60 sec PLANK x2</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#fba;\">\r\n            <h3>DAY 24</h3>\r\n            <p>REST DAY</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#faa;\">\r\n            <h3>DAY 25</h3>\r\n            <p>10 CRUNCHES x3</p>\r\n            <p>10 RUSSIAN TWISTS x3</p>\r\n            <p>10 LEG LIFTS x3</p>\r\n            <p>60 sec PLANK x3</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#fba;\">\r\n            <h3>DAY 26</h3>\r\n            <p>10 REVERSE CRUNCHES x3</p>\r\n            <p>10 TOE TAPS x3</p>\r\n            <p>10 FLUTTER KICKS x3</p>\r\n            <p>60 sec PLANK x3</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#faa;\">\r\n            <h3>DAY 27</h3>\r\n            <p>10 CRUNCHES x3</p>\r\n            <p>10 HEEL TAPS x3</p>\r\n            <p>10 DIAMOND SIT UPS x3</p>\r\n            <p>60 sec PLANK x3</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#fba;\">\r\n            <h3>DAY 28</h3>\r\n            <p>REST DAY</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#faa;\">\r\n            <h3>DAY 29</h3>\r\n            <p>10 CRUNCHES x3</p>\r\n            <p>10 RUSSIAN TWISTS x3</p>\r\n            <p>10 LEG LIFTS x3</p>\r\n            <p>10 REVERSE CRUNCHES x3</p>\r\n            <p>60 sec PLANK x3</p>\r\n        </div>\r\n    </div>\r\n    <div class=\"column\">\r\n        <div class=\"card\" style=\"background-color:#fba;\">\r\n            <h3>DAY 30</h3>\r\n            <p>10 TOE TAPS x3</p>\r\n            <p>10 FLUTTER KICKS x3</p>\r\n            <p>10 HEEL TAPS x3</p>\r\n            <p>10 DIAMOND SIT UPS x3</p>\r\n            <p>60 sec PLANK x3</p>\r\n        </div>\r\n    </div>\r\n        </div>\r\n</body>\r\n</html>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
