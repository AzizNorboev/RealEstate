#pragma checksum "D:\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a06aa21765065606f363c2d7b5ee25a6664b9437"
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
#line 1 "D:\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using RealEstate.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using RealEstate.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\_Imports.razor"
using Entities.Models;

#line default
#line hidden
#nullable disable
    public partial class Search : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "style", "margin-bottom: 10px");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "placeholder", "Search by Description");
            __builder.AddAttribute(7, "onkeyup", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 4 "D:\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\Search.razor"
                                                                           SearchChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 4 "D:\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Components\Search.razor"
                         SearchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "oninput", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchTerm = __value, SearchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
