#pragma checksum "C:\Users\Gosia\RiderProjects\DNPAssignment3\Families\Pages\Logout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06e04d76a24165527509017dd50a160220417bfe"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Gosia\RiderProjects\DNPAssignment3\Families\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gosia\RiderProjects\DNPAssignment3\Families\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gosia\RiderProjects\DNPAssignment3\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Gosia\RiderProjects\DNPAssignment3\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Gosia\RiderProjects\DNPAssignment3\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Gosia\RiderProjects\DNPAssignment3\Families\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Gosia\RiderProjects\DNPAssignment3\Families\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Gosia\RiderProjects\DNPAssignment3\Families\_Imports.razor"
using Families;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Gosia\RiderProjects\DNPAssignment3\Families\_Imports.razor"
using Families.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gosia\RiderProjects\DNPAssignment3\Families\Pages\Logout.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Gosia\RiderProjects\DNPAssignment3\Families\Pages\Logout.razor"
using WebFamilies_Assignment.Authentication;

#line default
#line hidden
#nullable disable
    public partial class Logout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "a");
                __builder2.AddAttribute(3, "href", "");
                __builder2.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Gosia\RiderProjects\DNPAssignment3\Families\Pages\Logout.razor"
                             PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(5, "\r\n            Log out \r\n        ");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Gosia\RiderProjects\DNPAssignment3\Families\Pages\Logout.razor"
       
    private string username;
    private string password;
    
    public async Task PerformLogout()
    {
        ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();     
        username = "";
        password = "";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
