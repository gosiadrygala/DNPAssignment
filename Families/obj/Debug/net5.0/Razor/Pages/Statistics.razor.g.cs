#pragma checksum "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\Pages\Statistics.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7690c70b08dcdbb08dcfc0f6b0989c8adedcbc17"
// <auto-generated/>
#pragma warning disable 1591
namespace Families.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using Families;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\_Imports.razor"
using Families.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\Pages\Statistics.razor"
           [Authorize(Policy = "SecurityLevel3")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/statistics")]
    public partial class Statistics : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-bkuw6p1jt0>Hair Color distribution among families </h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn-generate");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\Pages\Statistics.razor"
                                       GeneratePieChartBlazor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "b-bkuw6p1jt0");
            __builder.AddContent(5, "Generate the pie chart");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<div id=\"chartdiv\" b-bkuw6p1jt0></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\Pages\Statistics.razor"
       
    public PieChartData pieChartData = new PieChartData();
    public List<PieChartData> pieChartDatas = new List<PieChartData>();

    private async Task GeneratePieChartBlazor()
    {
        pieChartDatas = await pieChartData.GetPieChartDatas();
        await JsRuntime.InvokeVoidAsync("GeneratePieChart", pieChartDatas);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
