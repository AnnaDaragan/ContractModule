#pragma checksum "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\CompanyServices\_TableCompServ.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dfc70fef188769a094bbc7fe27d5a8f42b2059b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CompanyServices__TableCompServ), @"mvc.1.0.view", @"/Views/CompanyServices/_TableCompServ.cshtml")]
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
#line 1 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\_ViewImports.cshtml"
using ContractModule1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\_ViewImports.cshtml"
using ContractModule1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dfc70fef188769a094bbc7fe27d5a8f42b2059b", @"/Views/CompanyServices/_TableCompServ.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1784aa609900fbcd42eebc7b10b095438e452a13", @"/Views/_ViewImports.cshtml")]
    public class Views_CompanyServices__TableCompServ : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContractModule1.Models.CompanyServices>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <table class=\"table\" id=\"tableCompanyServices\">\r\n        <thead>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 7 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\CompanyServices\_TableCompServ.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 8 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\CompanyServices\_TableCompServ.cshtml"
               Write(Html.DisplayNameFor(model => model.Hash));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 9 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\CompanyServices\_TableCompServ.cshtml"
               Write(Html.DisplayNameFor(model => model.Contract));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 10 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\CompanyServices\_TableCompServ.cshtml"
               Write(Html.DisplayNameFor(model => model.Service));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 11 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\CompanyServices\_TableCompServ.cshtml"
               Write(Html.DisplayNameFor(model => model.IsArchived));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody id=\"tableInf\">\r\n");
#nullable restore
#line 16 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\CompanyServices\_TableCompServ.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 20 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\CompanyServices\_TableCompServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 23 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\CompanyServices\_TableCompServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.Hash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\CompanyServices\_TableCompServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.Contract.NumberContract));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\CompanyServices\_TableCompServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.Service.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\CompanyServices\_TableCompServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsArchived));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a class=\'btn btn-info text-white\'");
            BeginWriteAttribute("onclick", " onclick=", 1321, "", 1359, 3);
            WriteAttributeValue("", 1330, "AddEditPersonalInfo(", 1330, 20, true);
#nullable restore
#line 35 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\CompanyServices\_TableCompServ.cshtml"
WriteAttributeValue("", 1350, item.Id, 1350, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1358, ")", 1358, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\'fa fa-pencil\'></i> ???????????????? </a>\r\n                    <a class=\'btn btn-danger text-white\' style=\'margin-left:5px\'");
            BeginWriteAttribute("onclick", " onclick=", 1484, "", 1509, 3);
            WriteAttributeValue("", 1493, "Delete(", 1493, 7, true);
#nullable restore
#line 36 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\CompanyServices\_TableCompServ.cshtml"
WriteAttributeValue("", 1500, item.Id, 1500, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1508, ")", 1508, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\'fa fa-trash\'></i> ??????????????</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\CompanyServices\_TableCompServ.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContractModule1.Models.CompanyServices>> Html { get; private set; }
    }
}
#pragma warning restore 1591
