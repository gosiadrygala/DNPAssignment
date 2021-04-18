// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\Pages\Children.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\Pages\Children.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\Pages\Children.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\Gosia\RiderProjects\AssignmentFamilies\Families\Pages\Children.razor"
       
    private IList<Child> children = new List<Child>();
    private IList<Child> childrenToShow = new List<Child>();
   

    protected override async Task OnInitializedAsync()
    {
        var children = await ChildrenData.GetAllChildren();
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
