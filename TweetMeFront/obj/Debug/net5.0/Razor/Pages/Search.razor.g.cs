#pragma checksum "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a456fe48d9c140609b9a364d68c710fb616edc8e"
// <auto-generated/>
#pragma warning disable 1591
namespace TweetMeFront.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "search-page");
            __builder.AddAttribute(2, "b-qqufjelhzy");
            __builder.AddMarkupContent(3, "<p class=\"search-text\" b-qqufjelhzy>How is the world today?</p>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "search");
            __builder.AddAttribute(6, "b-qqufjelhzy");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\Pages\Search.razor"
                         search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\Pages\Search.razor"
                                          startSearch

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "id", "search");
                __builder2.AddAttribute(15, "class", "search-box");
                __builder2.AddAttribute(16, "type", "text");
                __builder2.AddAttribute(17, "placeholder", "Search Tweeter..");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "D:\Documente\GitHub Projects\Proiect-.NET\TweetMeFront\Pages\Search.razor"
                                   search

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => search = __value, search))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => search));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n            <input type=\"submit\" class=\"submit-btn m-0\" value=\"Go\" b-qqufjelhzy>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
