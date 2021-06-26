#pragma checksum "C:\Users\User\Desktop\KEKChat\KEKChat\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f994a173b6878f7e0833d76715a8774618dde7dc"
// <auto-generated/>
#pragma warning disable 1591
namespace KEKChat.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\KEKChat\KEKChat\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\KEKChat\KEKChat\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\KEKChat\KEKChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\KEKChat\KEKChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\KEKChat\KEKChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\KEKChat\KEKChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\KEKChat\KEKChat\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\KEKChat\KEKChat\_Imports.razor"
using KEKChat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\KEKChat\KEKChat\_Imports.razor"
using KEKChat.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\KEKChat\KEKChat\Pages\Login.razor"
using Controllers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>\r\n    Username\r\n</h3>\r\n");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\User\Desktop\KEKChat\KEKChat\Pages\Login.razor"
                          _username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _username = __value, _username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<br>\r\n<br>\r\n");
            __builder.AddMarkupContent(7, "<h3>\r\n    Password\r\n</h3>\r\n");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\User\Desktop\KEKChat\KEKChat\Pages\Login.razor"
                          _password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _password = __value, _password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
#nullable restore
#line 19 "C:\Users\User\Desktop\KEKChat\KEKChat\Pages\Login.razor"
 if (DatabaseController.CheckInformation(_username, _password) == false && clicked == true)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "    <br>\r\n    ");
            __builder.AddMarkupContent(14, "<p>The username or password was incorrect. Please check them again</p>\r\n");
#nullable restore
#line 23 "C:\Users\User\Desktop\KEKChat\KEKChat\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-outline-success");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\User\Desktop\KEKChat\KEKChat\Pages\Login.razor"
                                                  () => CheckData()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Login");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\User\Desktop\KEKChat\KEKChat\Pages\Login.razor"
       

    string _username;
    string _password;
    bool clicked = false;

    /// <summary>
    /// Creating a method to use the controller
    /// </summary>
    ///

    private void CheckData()
    {

        if (DatabaseController.CheckInformation(_username, _password) == true)
        {
            clicked = false;
            NavManager.NavigateTo("/chatroom");
        }
        else
        {
            clicked = true;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
