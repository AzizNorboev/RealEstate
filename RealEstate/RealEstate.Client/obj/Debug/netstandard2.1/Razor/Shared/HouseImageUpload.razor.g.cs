#pragma checksum "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\Shared\HouseImageUpload.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c584395bdd29d656525bb20c1d114652e60ecf3"
// <auto-generated/>
#pragma warning disable 1591
namespace RealEstate.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using RealEstate.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using RealEstate.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\_Imports.razor"
using Entities.Models;

#line default
#line hidden
#nullable disable
    public partial class HouseImageUpload : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "file");
            __builder.AddAttribute(2, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\Shared\HouseImageUpload.razor"
                                            HandleSelected

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "accept", ".jpg, .jpeg, png");
            __builder.AddElementReferenceCapture(4, (__value) => {
#nullable restore
#line 1 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\Shared\HouseImageUpload.razor"
                         _input = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 2 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\Shared\HouseImageUpload.razor"
 if (ImgUrl != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "div");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "src", 
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\Shared\HouseImageUpload.razor"
                   ImgUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "style", "width:300px");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 7 "C:\Users\Admin\Documents\GitHub\WADCW\RealEstate\RealEstate.Client\Shared\HouseImageUpload.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
