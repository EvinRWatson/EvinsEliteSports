#pragma checksum "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cff4fe169ba74d3fba10b95106db5c3e2dec37cf"
// <auto-generated/>
#pragma warning disable 1591
namespace EvinsEliteSports.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\_Imports.razor"
using EvinsEliteSports.Models;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"bg-info text-white p-2\"><span class=\"navbar-brand ml-2\">Evin\'s Elite Sports Administration</span></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row p-2");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-3");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(7);
            __builder.AddAttribute(8, "class", "btn btn-outline-primary btn-block");
            __builder.AddAttribute(9, "href", "/admin/products");
            __builder.AddAttribute(10, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(11, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\AdminLayout.razor"
                            NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n                Products\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(15);
            __builder.AddAttribute(16, "class", "btn btn-outline-primary btn-block");
            __builder.AddAttribute(17, "href", "/admin/orders");
            __builder.AddAttribute(18, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(19, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 17 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\AdminLayout.razor"
                            NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(21, "\r\n                Orders\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col");
            __builder.AddContent(25, 
#nullable restore
#line 22 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\AdminLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
