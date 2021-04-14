#pragma checksum "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\OrderTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f176f16d5ad7398a695d40d3f74ca2449a73302"
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
    public partial class OrderTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.OpenElement(2, "thead");
            __builder.OpenElement(3, "tr");
            __builder.OpenElement(4, "th");
            __builder.AddAttribute(5, "colspan", "5");
            __builder.AddAttribute(6, "class", "text-center");
            __builder.AddContent(7, 
#nullable restore
#line 3 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\OrderTable.razor"
                                                 TableTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 6 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\OrderTable.razor"
         if (Orders?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\OrderTable.razor"
             foreach (Order o in Orders)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 11 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\OrderTable.razor"
                         o.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 12 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\OrderTable.razor"
                         o.Zip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, "<th>Product</th>\r\n                    ");
            __builder.AddMarkupContent(18, "<th>Quantity</th>\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\OrderTable.razor"
                                            e => OrderSelected.InvokeAsync(o.OrderID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, 
#nullable restore
#line 18 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\OrderTable.razor"
                             ButtonLabel

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\OrderTable.razor"
                 foreach (CartLine line in o.Lines)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "<td colspan=\"2\"></td>\r\n                        ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 26 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\OrderTable.razor"
                             line.Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 27 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\OrderTable.razor"
                             line.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        <td></td>");
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\OrderTable.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\OrderTable.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\OrderTable.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<tr><td colspan=\"5\" class=\"text-center\">No Orders</td></tr>");
#nullable restore
#line 36 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\OrderTable.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\EvinW\Documents\MSSA\SportsStore\EvinsEliteSports\Pages\Admin\OrderTable.razor"
       
    [Parameter]
    public string TableTitle { get; set; } = "Orders";
    [Parameter]
    public IEnumerable<Order> Orders { get; set; }
    [Parameter]
    public string ButtonLabel { get; set; } = "Ship";
    [Parameter]
    public EventCallback<int> OrderSelected { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
