#pragma checksum "C:\Users\Kemal\Desktop\Blazorapp (2)\Blazorapp\Client\Pages\DietFoodsFolder\VeganList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68aa79c331d10b502bf7c22991481597d4ee7beb"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazorapp.Client.Pages.DietFoodsFolder
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Veganlist")]
    public partial class VeganList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\n");
            __builder.AddMarkupContent(1, "<html lang=\"en\">\n<head>\n    <style>\n    * {\n    box-sizing: border-box;\n    }\r\n    body { font-family: \'Yanone Kaffeesatz\', sans-serif; background-image: url(\"https://images.unsplash.com/photo-1543362906-acfc16c67564?ixlib=rb-1.2.1&auto=format&fit=crop&w=1402&q=80\");\n           background-repeat: no-repeat; \n           background-size: 100% 100%; }\n    .header{\n    color: #161111;\n    text-align: center;\n    font-size: 35px;\n    text-decoration: underline rgb(49, 49, 49);\n    }\n    .column {\n    float: right;\n    width: 30%;\n    padding: 10px 10px;\n    }\n    .row {\n    margin: 10px 10px;\n    }\n    .row:after {\n    content: \"\";\n    display: table;\n    clear: both;\n    }\n    @media screen and (max-width: 600px) {\n    .column {\n    width: 100%;\n    display: block;\n    margin-bottom: 20px;\n    }\n    }\n    .card {\n    margin: 1rem;\n    width: 300px;\n    height: 500px;\n    padding: .5rem 1rem;\n    background-image: url(\"https://images.unsplash.com/photo-1532153259564-a5f24f261f51?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80\");\n    color:rgba(255, 225, 170, 0.788);\n    border-radius: 8px;\n    float:right;\n    display: flex;\n    flex-direction: column;\n    justify-content: center;\n    align-items: center;\n    }\n    .card:hover{\n    box-shadow: 3px 3px 3px 3px rgba(255, 225, 170, 0.788);\n    }\n    h1{\n    font-family: \'Allura\', cursive;\n    color: rgb(0, 0, 0);\n    }\n</style>\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <link rel=\"stylesheet\" href=\"style.css\">\n\n    <title>The Ultimate Vegan Shopping List</title>\n</head>\n<body>\n    <div class=\"header\">\n        <h2>The Ultimate Vegan Shopping List</h2>\n    </div>\n    <div class=\"row\">\n        <div class=\"column\">\n            <div class=\"card\">\n                <h1>VEGETABLES</h1>\n                <ul>\n                    <li>Broccoli</li>\n                    <li>Carrots</li>\n                    <li>Celery</li>\n                    <li>Cauliflower</li>\n                    <li>Cucumbers</li>\n                    <li>Snap peas</li>\n                    <li>Bell peppers</li>\n                    <li>Baby spinach</li>\n                    <li>Romaine</li>\n                    <li>Butter lettuce</li>\n                    <li>Leaf lettuce</li>\n                </ul>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\">\n                <h2 style=\"font-family: \'Allura\', cursive; color: rgb(0, 0, 0);\">COOKING & BAKING</h2>\n                <ul>\n                    <li>Whole grain flour</li>\n                    <li>Baking powder</li>\n                    <li>Baking soda</li>\n                    <li>Corn starch</li>\n                    <li>Apple cider vinegar</li>\n                    <li>Coconut oil</li>\n                    <li>Earth Balance Butter</li>\n                    <li>Ground flax seed</li>\n                    <li>Yeast</li>\n                </ul>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\">\n                <h1>SWEETENERS</h1>\n                <ul>\n                    <li>Organic cane sugar</li>\n                    <li>Agave syrup</li>\n                    <li>Maple syrup</li>\n                    <li>Molasses</li>\n                    <li>Coconut sugar</li>\n                    <li>Fruit preserves</li>\n                    <li>Dates</li>\n                    <li>Dried fruits</li>\n                    <li>Dark chocolate chips</li>\n                    <li>Stevia</li>\n                </ul>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\">\n                <h1>WHEAT</h1>\n                <ul>\n                    <li>Bread</li>\n                    <li>Tortillas</li>\n                    <li>English muffins</li>\n                    <li>Bagels</li>\n                    <li>Pitas</li>\n                    <li>Pasta</li>\n                </ul>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\">\n                <h1>MILK</h1>\n                <ul>\n                    <li>Soy milk</li>\n                    <li>Almond milk</li>\n                    <li>Cashew milk</li>\n                    <li>Oat milk</li>\n                    <li>Coconut milk</li>\n                    <li>Rice milk</li>\n                    <li>Hemp milk</li>\n                    <li>Flax milk</li>\n                </ul>\n            </div>\n        </div>\n        <div class=\"column\">\n            <div class=\"card\">\n                <h1>CONDIMENTS</h1>\n                <ul>\n                    <li>Salsa</li>\n                    <li>Hummus</li>\n                    <li>Soy sauce</li>\n                    <li>Sriracha</li>\n                    <li>Mustard</li>\n                    <li>Vegan mayo</li>\n                    <li>Vegetable bouillon</li>\n                    <li>Nutritional yeast</li>\n                    <li>Lemon/lime juice</li>\n                    <li>Vinegar (white, balsamic)</li>\n                </ul>\n            </div>\n        </div>\n    </div>\n</body>\n</html>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591