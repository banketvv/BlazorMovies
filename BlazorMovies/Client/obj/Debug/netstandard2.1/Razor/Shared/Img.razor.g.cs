#pragma checksum "C:\Users\banke\source\repos\BlazorMovies\BlazorMovies\BlazorMovies\Client\Shared\Img.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6498c901561479ea72569c8fdf177654fcfc813e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\banke\source\repos\BlazorMovies\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\banke\source\repos\BlazorMovies\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\banke\source\repos\BlazorMovies\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\banke\source\repos\BlazorMovies\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\banke\source\repos\BlazorMovies\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\banke\source\repos\BlazorMovies\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\banke\source\repos\BlazorMovies\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\banke\source\repos\BlazorMovies\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\banke\source\repos\BlazorMovies\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
    public partial class Img : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "flex-container");
            __builder.AddAttribute(2, "style", "width: 330px");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "flex-row");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "src", 
#nullable restore
#line 4 "C:\Users\banke\source\repos\BlazorMovies\BlazorMovies\BlazorMovies\Client\Shared\Img.razor"
                  OverridedUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "class", "img-thumbnail");
            __builder.AddAttribute(10, "style", "display: flex");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "form");
            __builder.AddAttribute(14, "style", "flex-direction: row; justify-content: space-between; float: left");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "style", "display: table-cell;");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "url");
            __builder.AddAttribute(21, "placeholder", "Enter image URL");
            __builder.AddAttribute(22, "class", "nav-link");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\banke\source\repos\BlazorMovies\BlazorMovies\BlazorMovies\Client\Shared\Img.razor"
                                                                                    Url

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Url = __value, Url));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.AddMarkupContent(27, "<div style=\"display: table-cell;\">\r\n            <button class=\"btn btn-info\" onclick>Show</button>\r\n        </div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\banke\source\repos\BlazorMovies\BlazorMovies\BlazorMovies\Client\Shared\Img.razor"
       

    [Parameter] public string Url { get; set; }
    [Parameter] public string OverridedUrl
    {
        get
        {
            return Url == "" ? "question.jpg" : Url;
        }
        set
        {
            Url = value;
        }
    }

    protected override void OnInitialized()
    {
        Url = "";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
