#pragma checksum "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\Client\PropertyList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d8eaefe011fd357b11c4fb2d09cc37f01dd6393"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_PropertyList), @"mvc.1.0.view", @"/Views/Client/PropertyList.cshtml")]
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
#line 1 "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\_ViewImports.cshtml"
using Indecomm.FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\_ViewImports.cshtml"
using Indecomm.FrontEnd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d8eaefe011fd357b11c4fb2d09cc37f01dd6393", @"/Views/Client/PropertyList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b6d708c3419835cc500a7ac129ccde9a92f7ea3", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_PropertyList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Indecomm.BusinessLayer.Model.PropertyModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\Client\PropertyList.cshtml"
  
    ViewData["Title"] = "Property List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Property List</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d8eaefe011fd357b11c4fb2d09cc37f01dd63933866", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\Client\PropertyList.cshtml"
           Write(Html.DisplayNameFor(model => model.First().fullAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\Client\PropertyList.cshtml"
           Write(Html.DisplayNameFor(model => model.First().physical.YearBuilt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\Client\PropertyList.cshtml"
           Write(Html.DisplayNameFor(model => model.First().financial.ListPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\Client\PropertyList.cshtml"
           Write(Html.DisplayNameFor(model => model.First().financial.MonthlyRent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\Client\PropertyList.cshtml"
           Write(Html.DisplayNameFor(model => model.First().grossYield));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>Action</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\Client\PropertyList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\Client\PropertyList.cshtml"
               Write(Html.DisplayFor(modelItem => item.fullAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\Client\PropertyList.cshtml"
               Write(Html.DisplayFor(modelItem => item.physical.YearBuilt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\Client\PropertyList.cshtml"
               Write(Html.DisplayFor(modelItem => item.financial.ListPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\Client\PropertyList.cshtml"
               Write(Html.DisplayFor(modelItem => item.financial.MonthlyRent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 48 "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\Client\PropertyList.cshtml"
                     if (item.grossYield > 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\Client\PropertyList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.grossYield));

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\Client\PropertyList.cshtml"
                                                                      
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    <input type=\"button\" id=\"btnSave\" value=\"Save Data\" class=\"btn btn-sm btn-success\" />\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\admin\source\repos\IndecommService\Indecomm.FrontEnd\Views\Client\PropertyList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<script>
    $(document).on(""click"", ""#btnSave"", function () {
        var dataRow = $(this).closest('tr').find('td');
        var propertyData = {};
        propertyData.Address = dataRow[0].innerText;
        propertyData.YearBuilt = dataRow[1].innerText;
        propertyData.ListPrice = (dataRow[2].innerText).replace('$', '').replace(',', '');
        propertyData.MonthlyRent = (dataRow[3].innerText).replace('$', '').replace(',', '');
        $.ajax({
            type: ""post"",
            url: ""/Client/Create"",
            data: { ""address"": propertyData.Address, ""yearBuilt"": propertyData.YearBuilt, ""listPrice"": propertyData.ListPrice, ""monthlyRent"": propertyData.MonthlyRent },
            success: function (response) {
                alert(response.status);
            },
            failure: function (response) {
                alert(response.status);
            },
            error: function (response) {
                alert(response.status);
            }");
            WriteLiteral("\r\n        });\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Indecomm.BusinessLayer.Model.PropertyModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591