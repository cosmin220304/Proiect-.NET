#pragma checksum "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc334b333dd6fb417013ca204971b52597117452"
// <auto-generated/>
#pragma warning disable 1591
namespace TweetMeFront.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\_Imports.razor"
using TweetMeFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\_Imports.razor"
using TweetMeFront.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "nav");
            __builder.AddAttribute(2, "b-o67f2dhjzi");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "class", "nav-item mr-2");
            __builder.AddAttribute(5, "aria-hidden", "true");
            __builder.AddAttribute(6, "href", 
#nullable restore
#line 2 "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\Shared\NavMenu.razor"
                                                       logoLink

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(7, "b-o67f2dhjzi");
            __builder.AddMarkupContent(8, "<p class=\"p=0 m-0\" b-o67f2dhjzi>TweetMe</p>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "b-o67f2dhjzi");
            __builder.AddMarkupContent(12, "<a class=\"nav-item mr-2\" aria-hidden=\"true\" href=\"search\" b-o67f2dhjzi><p class=\"p=0 m-0\" b-o67f2dhjzi>Search</p></a>\r\n        ");
            __builder.AddMarkupContent(13, "<a class=\"nav-item ml-2 mr-2\" aria-hidden=\"true\" href=\"popular\" b-o67f2dhjzi><p class=\"p=0 m-0\" b-o67f2dhjzi>Popular</p></a>\r\n        ");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "class", "nav-item" + "  " + (
#nullable restore
#line 12 "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\Shared\NavMenu.razor"
                             logged

#line default
#line hidden
#nullable disable
            ) + " ml-2" + " mr-2");
            __builder.AddAttribute(16, "aria-hidden", "true");
            __builder.AddAttribute(17, "href", "friends");
            __builder.AddAttribute(18, "b-o67f2dhjzi");
            __builder.AddMarkupContent(19, "<p class=\"p=0 m-0\" b-o67f2dhjzi>Friends</p>");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "class", "nav-item" + "  " + (
#nullable restore
#line 15 "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\Shared\NavMenu.razor"
                             logged

#line default
#line hidden
#nullable disable
            ) + " ml-1");
            __builder.AddAttribute(23, "aria-hidden", "true");
            __builder.AddAttribute(24, "href", "profile");
            __builder.AddAttribute(25, "b-o67f2dhjzi");
            __builder.AddMarkupContent(26, "<p class=\"p=0 m-0\" b-o67f2dhjzi>Profile</p>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
