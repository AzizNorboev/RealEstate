#pragma checksum "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateApartment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9db20f8a238ca289b3c8c426dda2b497ff39c7c5"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/createApartment")]
    public partial class CreateApartment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Create Apartment Form</h2>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateApartment.razor"
                 _apartment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateApartment.razor"
                                       Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "class", "card card-body bg-light mt-5");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n\r\n   \r\n\r\n    ");
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
#line 12 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateApartment.razor"
                                                                          _apartment.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _apartment.Description = __value, _apartment.Description))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _apartment.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group row");
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.AddMarkupContent(26, "<label for=\"floorno\" class=\"col-md-2 col-form-label\">Floor Number:</label>\r\n        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-md-10");
                __builder2.AddMarkupContent(29, "\r\n            ");
                __Blazor.RealEstate.Client.Pages.Create.CreateApartment.TypeInference.CreateInputNumber_0(__builder2, 30, 31, "floorno", 32, "form-control", 33, 
#nullable restore
#line 19 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateApartment.razor"
                                                                        _apartment.FloorNo

#line default
#line hidden
#nullable disable
                , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _apartment.FloorNo = __value, _apartment.FloorNo)), 35, () => _apartment.FloorNo);
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n\r\n    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group row");
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.AddMarkupContent(42, "<label for=\"imageurl\" class=\"col-md-2 col-form-label\">Image:</label>\r\n        ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col-md-10");
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "id", "imageurl");
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateApartment.razor"
                                                                       _apartment.ImageURL

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _apartment.ImageURL = __value, _apartment.ImageURL))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _apartment.ImageURL));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group row");
                __builder2.AddMarkupContent(57, "\r\n        ");
                __builder2.AddMarkupContent(58, "<label for=\"numofrooms\" class=\"col-md-2 col-form-label\">Number Of Rooms:</label>\r\n        ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-md-10");
                __builder2.AddMarkupContent(61, "\r\n            ");
                __Blazor.RealEstate.Client.Pages.Create.CreateApartment.TypeInference.CreateInputNumber_1(__builder2, 62, 63, "numofrooms", 64, "form-control", 65, 
#nullable restore
#line 33 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateApartment.razor"
                                                                           _apartment.NumOfRooms

#line default
#line hidden
#nullable disable
                , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _apartment.NumOfRooms = __value, _apartment.NumOfRooms)), 67, () => _apartment.NumOfRooms);
                __builder2.AddMarkupContent(68, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n\r\n    ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-group row");
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.AddMarkupContent(74, "<label for=\"price\" class=\"col-md-2 col-form-label\">Price:</label>\r\n        ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "col-md-10");
                __builder2.AddMarkupContent(77, "\r\n            ");
                __Blazor.RealEstate.Client.Pages.Create.CreateApartment.TypeInference.CreateInputNumber_2(__builder2, 78, 79, "price", 80, "form-control", 81, 
#nullable restore
#line 40 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateApartment.razor"
                                                                      _apartment.Price

#line default
#line hidden
#nullable disable
                , 82, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _apartment.Price = __value, _apartment.Price)), 83, () => _apartment.Price);
                __builder2.AddMarkupContent(84, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n\r\n    ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "form-group row");
                __builder2.AddMarkupContent(89, "\r\n        ");
                __builder2.AddMarkupContent(90, "<label for=\"regionid\" class=\"col-md-2 col-form-label\">RegionId:</label>\r\n        ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "col-md-10");
                __builder2.AddMarkupContent(93, "\r\n            ");
                __Blazor.RealEstate.Client.Pages.Create.CreateApartment.TypeInference.CreateInputNumber_3(__builder2, 94, 95, "regionid", 96, "form-control", 97, 
#nullable restore
#line 47 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateApartment.razor"
                                                                         _apartment.RegionId

#line default
#line hidden
#nullable disable
                , 98, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _apartment.RegionId = __value, _apartment.RegionId)), 99, () => _apartment.RegionId);
                __builder2.AddMarkupContent(100, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n\r\n\r\n\r\n    ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "form-group row");
                __builder2.AddMarkupContent(105, "\r\n        ");
                __builder2.AddMarkupContent(106, "<label for=\"square\" class=\"col-md-2 col-form-label\">Square(m²):</label>\r\n        ");
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "col-md-10");
                __builder2.AddMarkupContent(109, "\r\n            ");
                __Blazor.RealEstate.Client.Pages.Create.CreateApartment.TypeInference.CreateInputNumber_4(__builder2, 110, 111, "square", 112, "form-control", 113, 
#nullable restore
#line 56 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateApartment.razor"
                                                                       _apartment.Square

#line default
#line hidden
#nullable disable
                , 114, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _apartment.Square = __value, _apartment.Square)), 115, () => _apartment.Square);
                __builder2.AddMarkupContent(116, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n\r\n\r\n\r\n    ");
                __builder2.OpenElement(119, "div");
                __builder2.AddAttribute(120, "class", "form-group row");
                __builder2.AddMarkupContent(121, "\r\n        ");
                __builder2.AddMarkupContent(122, "<label for=\"Status\" class=\"col-md-2 col-form-label\">Status</label>\r\n        ");
                __builder2.OpenElement(123, "div");
                __builder2.AddAttribute(124, "class", "col-md-10");
                __builder2.AddMarkupContent(125, "\r\n            ");
                __Blazor.RealEstate.Client.Pages.Create.CreateApartment.TypeInference.CreateInputSelect_5(__builder2, 126, 127, "form-control", 128, 
#nullable restore
#line 65 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateApartment.razor"
                                      _apartment.Status

#line default
#line hidden
#nullable disable
                , 129, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _apartment.Status = __value, _apartment.Status)), 130, () => _apartment.Status, 131, (__builder3) => {
                    __builder3.AddMarkupContent(132, "\r\n");
#nullable restore
#line 66 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateApartment.razor"
                 foreach (var status in Enum.GetValues(typeof(ApartmentStatus)))
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(133, "                    ");
                    __builder3.OpenElement(134, "option");
                    __builder3.AddAttribute(135, "value", 
#nullable restore
#line 68 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateApartment.razor"
                                    status

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(136, 
#nullable restore
#line 68 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateApartment.razor"
                                             status

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(137, "\r\n");
#nullable restore
#line 69 "C:\Users\Admin\Documents\GitHub\RealEstate\RealEstate\RealEstate.Client\Pages\Create\CreateApartment.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(138, "            ");
                }
                );
                __builder2.AddMarkupContent(139, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n\r\n\r\n\r\n\r\n\r\n\r\n    ");
                __builder2.AddMarkupContent(142, "<div class=\"row\">\r\n        <div class=\"col-md-12 text-right\">\r\n            <button type=\"submit\" class=\"btn btn-success\">Create</button>\r\n        </div>\r\n    </div>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.RealEstate.Client.Pages.Create.CreateApartment
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
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
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
