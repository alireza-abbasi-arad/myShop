#pragma checksum "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\Shared\Components\GetMenuForMobil\GetMenuForMobil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e69b9d96baaf4c14f95e0fbd1d386d9c7312081a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GetMenuForMobil_GetMenuForMobil), @"mvc.1.0.view", @"/Views/Shared/Components/GetMenuForMobil/GetMenuForMobil.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\_ViewImports.cshtml"
using EndPoint.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\_ViewImports.cshtml"
using EndPoint.Site.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\Shared\Components\GetMenuForMobil\GetMenuForMobil.cshtml"
using asp_store_bugeto.Application.Services.Common.Queries.GetMenuItems;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e69b9d96baaf4c14f95e0fbd1d386d9c7312081a", @"/Views/Shared/Components/GetMenuForMobil/GetMenuForMobil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87685c89e84078b3e134b89a928accf3d0f04a39", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_GetMenuForMobil_GetMenuForMobil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MenuItemDto>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("category-level-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\Shared\Components\GetMenuForMobil\GetMenuForMobil.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\Shared\Components\GetMenuForMobil\GetMenuForMobil.cshtml"
 for (int i = 0; i < Model.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>\r\n        <a href=\"#\" class=\"collapsed\" type=\"button\" data-toggle=\"collapse\" data-target=\"#collapse_");
#nullable restore
#line 10 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\Shared\Components\GetMenuForMobil\GetMenuForMobil.cshtml"
                                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"false\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 307, "\"", 334, 2);
            WriteAttributeValue("", 323, "collapse_", 323, 9, true);
#nullable restore
#line 10 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\Shared\Components\GetMenuForMobil\GetMenuForMobil.cshtml"
WriteAttributeValue("", 332, i, 332, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"mdi mdi-chevron-down\"></i>");
#nullable restore
#line 10 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\Shared\Components\GetMenuForMobil\GetMenuForMobil.cshtml"
                                                                                                                                                                                       Write(Model[i].CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\Shared\Components\GetMenuForMobil\GetMenuForMobil.cshtml"
         if (Model[i].SubCategories.Count > 0)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("id", " id=\"", 479, "\"", 495, 2);
            WriteAttributeValue("", 484, "collapse_", 484, 9, true);
#nullable restore
#line 15 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\Shared\Components\GetMenuForMobil\GetMenuForMobil.cshtml"
WriteAttributeValue("", 493, i, 493, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 513, "\"", 541, 2);
            WriteAttributeValue("", 531, "heading_", 531, 8, true);
#nullable restore
#line 15 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\Shared\Components\GetMenuForMobil\GetMenuForMobil.cshtml"
WriteAttributeValue("", 539, i, 539, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#accordionExample\"");
            BeginWriteAttribute("style", " style=\"", 574, "\"", 582, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <ul>\r\n");
#nullable restore
#line 17 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\Shared\Components\GetMenuForMobil\GetMenuForMobil.cshtml"
                     for (int j = 0; j < Model[i].SubCategories.Count; j++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 735, "\"", 743, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e69b9d96baaf4c14f95e0fbd1d386d9c7312081a8074", async() => {
#nullable restore
#line 20 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\Shared\Components\GetMenuForMobil\GetMenuForMobil.cshtml"
                                                                                                                 Write(Model[i].SubCategories[j].CategoryName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 784, "~/products?catid=", 784, 17, true);
#nullable restore
#line 20 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\Shared\Components\GetMenuForMobil\GetMenuForMobil.cshtml"
AddHtmlAttributeValue("", 801, Model[i].SubCategories[j].CategoryID, 801, 37, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 22 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\Shared\Components\GetMenuForMobil\GetMenuForMobil.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n");
#nullable restore
#line 25 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\Shared\Components\GetMenuForMobil\GetMenuForMobil.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </li>\r\n");
#nullable restore
#line 27 "C:\Users\aradprogrammer\source\repos\asp_store_bugeto\EndPoint.Site\Views\Shared\Components\GetMenuForMobil\GetMenuForMobil.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MenuItemDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
