#pragma checksum "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateHouse.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9e5c62b7ea2a835959e17827da9898a7a8415f7"
// <auto-generated/>
#pragma warning disable 1591
namespace RealEstate.Client.Pages.Create
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/createHouse")]
    public partial class CreateHouse : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Create House Form</h2>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateHouse.razor"
                 _house

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateHouse.razor"
                                   Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "class", "card card-body bg-light mt-5");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n\r\n\r\n\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group row");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<label for=\"description\" class=\"col-md-2 col-form-label\">Description:</label>\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-md-10");
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "id", "description");
                __builder2.AddAttribute(16, "class", "form-control");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 12 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateHouse.razor"
                                                                          _house.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _house.Description = __value, _house.Description))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _house.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group row");
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.AddMarkupContent(26, "<label for=\"imageurl\" class=\"col-md-2 col-form-label\">Image:</label>\r\n        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-md-10");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "id", "imageurl");
                __builder2.AddAttribute(32, "class", "form-control");
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateHouse.razor"
                                                                       _house.ImageURL

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _house.ImageURL = __value, _house.ImageURL))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _house.ImageURL));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n\r\n    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group row");
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.AddMarkupContent(42, "<label for=\"numofrooms\" class=\"col-md-2 col-form-label\">Number Of Rooms:</label>\r\n        ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col-md-10");
                __builder2.AddMarkupContent(45, "\r\n            ");
                __Blazor.RealEstate.Client.Pages.Create.CreateHouse.TypeInference.CreateInputNumber_0(__builder2, 46, 47, "numofrooms", 48, "form-control", 49, 
#nullable restore
#line 27 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateHouse.razor"
                                                                           _house.NumOfRooms

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _house.NumOfRooms = __value, _house.NumOfRooms)), 51, () => _house.NumOfRooms);
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group row");
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.AddMarkupContent(58, "<label for=\"price\" class=\"col-md-2 col-form-label\">Price:</label>\r\n        ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-md-10");
                __builder2.AddMarkupContent(61, "\r\n            ");
                __Blazor.RealEstate.Client.Pages.Create.CreateHouse.TypeInference.CreateInputNumber_1(__builder2, 62, 63, "price", 64, "form-control", 65, 
#nullable restore
#line 34 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateHouse.razor"
                                                                      _house.Price

#line default
#line hidden
#nullable disable
                , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _house.Price = __value, _house.Price)), 67, () => _house.Price);
                __builder2.AddMarkupContent(68, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n\r\n    ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-group row");
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.AddMarkupContent(74, "<label for=\"regionid\" class=\"col-md-2 col-form-label\">RegionId:</label>\r\n        ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "col-md-10");
                __builder2.AddMarkupContent(77, "\r\n            ");
                __Blazor.RealEstate.Client.Pages.Create.CreateHouse.TypeInference.CreateInputNumber_2(__builder2, 78, 79, "regionid", 80, "form-control", 81, 
#nullable restore
#line 41 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateHouse.razor"
                                                                         _house.RegionId

#line default
#line hidden
#nullable disable
                , 82, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _house.RegionId = __value, _house.RegionId)), 83, () => _house.RegionId);
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n\r\n\r\n\r\n    ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "form-group row");
                __builder2.AddMarkupContent(89, "\r\n        ");
                __builder2.AddMarkupContent(90, "<label for=\"square\" class=\"col-md-2 col-form-label\">Square(m²):</label>\r\n        ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "col-md-10");
                __builder2.AddMarkupContent(93, "\r\n            ");
                __Blazor.RealEstate.Client.Pages.Create.CreateHouse.TypeInference.CreateInputNumber_3(__builder2, 94, 95, "square", 96, "form-control", 97, 
#nullable restore
#line 50 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateHouse.razor"
                                                                       _house.Square

#line default
#line hidden
#nullable disable
                , 98, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _house.Square = __value, _house.Square)), 99, () => _house.Square);
                __builder2.AddMarkupContent(100, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n\r\n\r\n\r\n    ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "form-group row");
                __builder2.AddMarkupContent(105, "\r\n        ");
                __builder2.AddMarkupContent(106, "<label for=\"Status\" class=\"col-md-2 col-form-label\">Status:</label>\r\n        ");
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "col-md-10");
                __builder2.AddMarkupContent(109, "\r\n            ");
                __Blazor.RealEstate.Client.Pages.Create.CreateHouse.TypeInference.CreateInputSelect_4(__builder2, 110, 111, "form-control", 112, 
#nullable restore
#line 59 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateHouse.razor"
                                      _house.Status

#line default
#line hidden
#nullable disable
                , 113, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _house.Status = __value, _house.Status)), 114, () => _house.Status, 115, (__builder3) => {
                    __builder3.AddMarkupContent(116, "\r\n");
#nullable restore
#line 60 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateHouse.razor"
                 foreach (var status in Enum.GetValues(typeof(HouseStatus)))
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(117, "                    ");
                    __builder3.OpenElement(118, "option");
                    __builder3.AddAttribute(119, "value", 
#nullable restore
#line 62 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateHouse.razor"
                                    status

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(120, 
#nullable restore
#line 62 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateHouse.razor"
                                             status

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(121, "\r\n");
#nullable restore
#line 63 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateHouse.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(122, "            ");
                }
                );
                __builder2.AddMarkupContent(123, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n\r\n\r\n\r\n\r\n\r\n\r\n    ");
                __builder2.AddMarkupContent(126, "<div class=\"row\">\r\n        <div class=\"col-md-12 text-right\">\r\n            <button type=\"submit\" class=\"btn btn-success\">Create</button>\r\n        </div>\r\n    </div>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.RealEstate.Client.Pages.Create.CreateHouse
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591