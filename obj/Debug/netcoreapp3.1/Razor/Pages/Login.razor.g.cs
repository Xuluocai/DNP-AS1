#pragma checksum "C:\Users\admin\source\repos\Solution1\Assignment\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38691b9374c2f7e33f3bb9976efdd3a989affa63"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment.Pages
{
    #line hidden
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using Assignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\admin\source\repos\Solution1\Assignment\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddAttribute(2, "class", "text-center");
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\Users\admin\source\repos\Solution1\Assignment\Pages\Login.razor"
                         temICON

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ");
            __builder.AddContent(5, 
#nullable restore
#line 6 "C:\Users\admin\source\repos\Solution1\Assignment\Pages\Login.razor"
                                  regorlog

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n<hr>\r\n<br>\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddContent(8, 
#nullable restore
#line 9 "C:\Users\admin\source\repos\Solution1\Assignment\Pages\Login.razor"
       error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n<br>\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "=text-center");
            __builder.AddMarkupContent(12, "\r\n    <br>\r\n    ");
            __builder.OpenElement(13, "form");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.AddMarkupContent(15, "<span>UserName:</span>\r\n        ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "name", "UserName");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\admin\source\repos\Solution1\Assignment\Pages\Login.razor"
                                      UserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UserName = __value, UserName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    <br>\r\n    ");
            __builder.OpenElement(22, "form");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddMarkupContent(24, "<span>Password</span>\r\n        ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "password");
            __builder.AddAttribute(27, "name", "Password");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\admin\source\repos\Solution1\Assignment\Pages\Login.razor"
                                                      Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "<br>\r\n");
#nullable restore
#line 22 "C:\Users\admin\source\repos\Solution1\Assignment\Pages\Login.razor"
     if (regorlog == "Register")
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "        ");
            __builder.OpenElement(33, "form");
            __builder.AddMarkupContent(34, "<span>Confirm</span>");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "password");
            __builder.AddAttribute(37, "name", "CPassword");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\admin\source\repos\Solution1\Assignment\Pages\Login.razor"
                                                                                 CPassword

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CPassword = __value, CPassword));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "<br><hr>\r\n");
#nullable restore
#line 25 "C:\Users\admin\source\repos\Solution1\Assignment\Pages\Login.razor"

    }
    else {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, " <hr>");
#nullable restore
#line 27 "C:\Users\admin\source\repos\Solution1\Assignment\Pages\Login.razor"
               }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "    ");
            __builder.OpenElement(43, "div");
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\admin\source\repos\Solution1\Assignment\Pages\Login.razor"
                          ClickLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\admin\source\repos\Solution1\Assignment\Pages\Login.razor"
                          ClickReg

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "Register");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        \r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "<br>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\admin\source\repos\Solution1\Assignment\Pages\Login.razor"
       

    private String temICON = "Login";
    private String regorlog { get; set; }
    private String error { get; set; }
    private String UserName{ get; set; }
    private String Password { get; set; }
    private String CPassword { get; set; }
    private User User;
    private Boolean isreg;
    private UserArray UserArray;

    protected override async Task OnInitializedAsync()
    {
        UserArray = new UserArray(new List<User>());
    }

    public void CreateUser(String UserName,String Password)
    {
        Console.WriteLine("Creation init");
        this.UserName = UserName;
        this.Password = Password;
        User = new User(UserName, Password);
        Console.WriteLine("Creation" + UserName);
        Console.WriteLine("Userarray" + UserArray);
        UserArray.addUser(User);
        Console.WriteLine("Creation complete");
    }
    public void ClickReg()
    {
        error = "";
        if (isreg == false)
        {
            temICON = null;
            isreg = true;
            regorlog = "Register";
            StateHasChanged();
            Console.WriteLine("Change");
        }
        else
        {
            if (UserName == null || Password == null)
            {
                error = "Wrong!";
            }
            else { error = "";
                User usert = new User(UserName, Password);
                for(int i = 0; i < UserArray.getSize(); i++)
                {
                    if (usert.name.Equals(UserArray.getUser(i).name)) {
                        error = "Has existed";
                        break;
                    }
                }
                if (Password == CPassword)
                {
                    reg();
                    UserName = null;
                    Password = null;
                    CPassword = null;

                }
                else { error = "Password doesn't match"; }
            }
        }
    }
    private void reg()
    {
        Console.WriteLine("UserName:" + UserName + "Password" + Password + "CPassword" + CPassword);
        Console.WriteLine("reginit");
        CreateUser(UserName, Password);
        Console.WriteLine("123" + UserArray.getUserByUser(User));
        Console.WriteLine("Creat complete." + UserArray.getSize() + UserArray.getUserByUser(User).name + UserArray.getUserByUser(User).password);
    }
    public void ClickLogin()
    {
        Console.WriteLine("111");
        error = "";
        if (isreg == true)
        {
            temICON = null;
            isreg = false;
            regorlog = "Login";
            StateHasChanged();
        }
        else
        {
            if (UserName == null || Password == null)
            {
                error = "";
                error = "Your are in register page";
            }
            else
            {
                if (LoginVierfy())
                {
                    Console.WriteLine("123");
                    NavigationManager.NavigateTo("View");
                }
            }
        }
    }
    public Boolean LoginVierfy()
    {
        Boolean a = false;
        error = "";

        for (int i = 0; i < UserArray.getSize(); i++)
        {
            if (UserArray.getUser(i).name.Equals(UserName) && UserArray.getUser(i).password.Equals(Password))
            {
                a = true;
                Console.Write("Naving");
                NavigationManager.NavigateTo("View");
                break;
            }
            else
            {
                a = false;
                error = "Wrong";
            }
        }
        return a;
    }

    public bool SidebarToggle = false;
    public void Close()
    {
        SidebarToggle = false;
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
