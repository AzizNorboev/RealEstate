#pragma checksum "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\Page.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8575b25df5964ae86beb27d4f20fa722f15160e6"
// <auto-generated/>
#pragma warning disable 1591
namespace RealEstate.Client.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using RealEstate.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using RealEstate.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Entities.Models;

#line default
#line hidden
#nullable disable
    public partial class Page : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "Page navigation example");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "pagination justify-content-center");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\Page.razor"
         foreach (var link in _links)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\Page.razor"
                          () => OnSelectedPage(link)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "style", "cursor: pointer;");
            __builder.AddAttribute(10, "class", "page-item" + " " + (
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\Page.razor"
                                                                                                  link.Enabled ? null : "disabled"

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\Page.razor"
                                                                                                                                      link.Active ? "active" : null

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "span");
            __builder.AddAttribute(13, "class", "page-link");
            __builder.AddAttribute(14, "href", "#");
            __builder.AddContent(15, 
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\Page.razor"
                                                  link.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\Page.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
