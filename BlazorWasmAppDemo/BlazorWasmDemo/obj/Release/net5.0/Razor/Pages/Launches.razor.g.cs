#pragma checksum "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\Pages\Launches.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5891e98656b3ca0c784ebc228b9331086a98b948"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWasmDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\_Imports.razor"
using BlazorWasmDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\_Imports.razor"
using BlazorWasmDemo.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/launches")]
    public partial class Launches : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>SpaceX Launches</h1>\r\n");
            __builder.AddMarkupContent(1, "<p>This lists SpaceX launches from the GraphQL api at api.spacex.land</p>");
#nullable restore
#line 7 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\Pages\Launches.razor"
 if (launches == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 10 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\Pages\Launches.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table-striped table-bordered table-sm ");
            __builder.AddMarkupContent(5, "<thead><tr><th>Id</th>\r\n                <th>isTentative</th>\r\n                <th>Launch Date</th>\r\n                <th>Mission Name</th>\r\n                <th>isUpcoming</th>\r\n                <th>Details</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 25 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\Pages\Launches.razor"
             foreach (var launch in launches)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 28 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\Pages\Launches.razor"
                         launch.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 29 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\Pages\Launches.razor"
                         launch.IsTentative

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 30 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\Pages\Launches.razor"
                         launch.LaunchDateLocal.DateTime.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddAttribute(18, "style", "min-width:150px; max-width:300px");
            __builder.AddContent(19, 
#nullable restore
#line 31 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\Pages\Launches.razor"
                                                                  launch.MissionName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 32 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\Pages\Launches.razor"
                         launch.Upcoming

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddAttribute(25, "style", "max-width:800px");
            __builder.AddContent(26, 
#nullable restore
#line 33 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\Pages\Launches.razor"
                                                 launch.Details

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\Pages\Launches.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "tr");
            __builder.OpenElement(28, "td");
            __builder.AddAttribute(29, "colspan", "6");
            __builder.AddContent(30, "Records: ");
            __builder.AddContent(31, 
#nullable restore
#line 37 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\Pages\Launches.razor"
                                          launches.Count()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\shutslar\Documents\srcScratchPad\BlazorWasmAppDemo\BlazorWasmAppDemo\BlazorWasmDemo\Pages\Launches.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
