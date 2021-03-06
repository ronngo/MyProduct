#pragma checksum "C:\Users\ronng\source\repos\MyProduct\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2630c4052f614488c0062e9762669b357db48db2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\ronng\source\repos\MyProduct\Views\_ViewImports.cshtml"
using MyProduct;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ronng\source\repos\MyProduct\Views\_ViewImports.cshtml"
using MyProduct.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2630c4052f614488c0062e9762669b357db48db2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"000fc6fe457f27e7eb71845c7f08320abf33284c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyProduct.ViewModels.HomeIndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"text-center\">\r\n        <button class=\"btn btn-dark filter-product-btn\" data-filter=\"all\">All</button>\r\n");
#nullable restore
#line 6 "C:\Users\ronng\source\repos\MyProduct\Views\Home\Index.cshtml"
         foreach (var item in Model.Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"btn btn-dark filter-product-btn\" data-filter=\"");
#nullable restore
#line 8 "C:\Users\ronng\source\repos\MyProduct\Views\Home\Index.cshtml"
                                                                    Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 8 "C:\Users\ronng\source\repos\MyProduct\Views\Home\Index.cshtml"
                                                                                        Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 9 "C:\Users\ronng\source\repos\MyProduct\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 13 "C:\Users\ronng\source\repos\MyProduct\Views\Home\Index.cshtml"
         foreach (var item in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 491, "\"", 547, 4);
            WriteAttributeValue("", 499, "col-md-6", 499, 8, true);
            WriteAttributeValue(" ", 507, "pb-4", 508, 5, true);
            WriteAttributeValue(" ", 512, "filter", 513, 7, true);
#nullable restore
#line 15 "C:\Users\ronng\source\repos\MyProduct\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 519, item.Category.CategoryName, 520, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"card bg-white rounded shadow-sm\">\r\n                    <div class=\"card-body row\">\r\n                        <div class=\"col-7\"><label>");
#nullable restore
#line 18 "C:\Users\ronng\source\repos\MyProduct\Views\Home\Index.cshtml"
                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n                        <div class=\"col-5\"><label>");
#nullable restore
#line 19 "C:\Users\ronng\source\repos\MyProduct\Views\Home\Index.cshtml"
                                             Write(string.Format("{0:c0}", item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n                    </div>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 893, "\"", 913, 1);
#nullable restore
#line 21 "C:\Users\ronng\source\repos\MyProduct\Views\Home\Index.cshtml"
WriteAttributeValue("", 899, item.ImageUrl, 899, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Alternate Text"" class=""card-img-top img-fluid d-block mx-auto mb-3"" />
                    <div class=""card-body row"">
                        <div class=""col-12"">
                            <span class=""badge w-100"" style=""background-color: lawngreen"">");
#nullable restore
#line 24 "C:\Users\ronng\source\repos\MyProduct\Views\Home\Index.cshtml"
                                                                                     Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 29 "C:\Users\ronng\source\repos\MyProduct\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            DefineSection("ScriptsValidate", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $("".filter-product-btn"").click(function () {
                let value = $(this).attr('data-filter');
                if (value == ""all"") {
                    $("".filter"").show('1000');
                }
                else {
                    $("".filter"").not('.' + value).hide('3000');
                    $("".filter"").filter('.' + value).show('3000');
                }
            })
        })
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyProduct.ViewModels.HomeIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
