#pragma checksum "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Children.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09b2234f1cf0edf260308c2d1d67d3e8c5bf4513"
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
#line 1 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Families;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Gosia\RiderProjects\Families\Families\_Imports.razor"
using Families.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Children.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Children.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Children.razor"
using Microsoft.AspNetCore.Authentication.OAuth.Claims;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/children")]
    public partial class Children : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddAttribute(1, "b-bjc2azyzru");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "class", "searchbar");
            __builder.AddAttribute(4, "placeholder", "Search by name or surname");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Children.razor"
                                                                                         (arg) => Search(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-bjc2azyzru");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "children-page");
            __builder.AddAttribute(11, "b-bjc2azyzru");
            __builder.AddMarkupContent(12, "<div class=\"children-pic\" b-bjc2azyzru><img src=\"Images/children.svg\" alt=\"Adults\" b-bjc2azyzru></div>");
#nullable restore
#line 15 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Children.razor"
     if (childrenToShow == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<p b-bjc2azyzru><em b-bjc2azyzru>Loading...</em></p>");
#nullable restore
#line 20 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Children.razor"
    }
    else if (!childrenToShow.Any())
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<p b-bjc2azyzru><em b-bjc2azyzru>No Children exist. Please add some.</em></p>");
#nullable restore
#line 26 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Children.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "children-table");
            __builder.AddAttribute(17, "b-bjc2azyzru");
            __builder.AddMarkupContent(18, "<thead b-bjc2azyzru><tr b-bjc2azyzru><th b-bjc2azyzru>Name</th>\r\n                <th b-bjc2azyzru>Surname</th>\r\n                <th b-bjc2azyzru>Age</th>\r\n                <th b-bjc2azyzru>Interests</th></tr></thead>\r\n            ");
            __builder.OpenElement(19, "tbody");
            __builder.AddAttribute(20, "b-bjc2azyzru");
#nullable restore
#line 39 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Children.razor"
             foreach (var item in childrenToShow){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "tr");
            __builder.AddAttribute(22, "b-bjc2azyzru");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "b-bjc2azyzru");
            __builder.AddContent(25, 
#nullable restore
#line 41 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Children.razor"
                         item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "b-bjc2azyzru");
            __builder.AddContent(29, 
#nullable restore
#line 42 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Children.razor"
                         item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddAttribute(32, "b-bjc2azyzru");
            __builder.AddContent(33, 
#nullable restore
#line 43 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Children.razor"
                         item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "b-bjc2azyzru");
            __builder.AddContent(37, 
#nullable restore
#line 44 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Children.razor"
                         GetAllPets(item)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Children.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Children.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\Gosia\RiderProjects\Families\Families\Pages\Children.razor"
       
    private IList<Child> children;
    private IList<Child> childrenToShow;
   

    protected override async Task OnInitializedAsync()
    {
        children = ChildrenData.GetAllChildren();
        childrenToShow = children;
    }

    private string GetAllPets(Child child)
    {
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < child.Interests.Count; i++)
        {
            if (i == 0)
            {
                stringBuilder.Append(child.Interests[i].Type);
            }
            else
            {
                stringBuilder.Append(", "+child.Interests[i].Type);
            }
            
        }

        return stringBuilder.ToString();
    }

    private void Search(ChangeEventArgs changeEventArgs)
    {
        string? searchByName = null;
        try
        {
            searchByName = changeEventArgs.Value.ToString();
        }catch(Exception e){}
        if (searchByName != null){
            childrenToShow = children.Where(child => child.FirstName.Contains(searchByName) || 
                                                     child.LastName.Contains(searchByName)).ToList();
        }
        else
        {
            childrenToShow = children;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private InterfaceChildrenData ChildrenData { get; set; }
    }
}
#pragma warning restore 1591
