#pragma checksum "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5645a5a86aa141874e2ac93314f38342b05049a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services__TableServ), @"mvc.1.0.view", @"/Views/Services/_TableServ.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5645a5a86aa141874e2ac93314f38342b05049a", @"/Views/Services/_TableServ.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1784aa609900fbcd42eebc7b10b095438e452a13", @"/Views/_ViewImports.cshtml")]
    public class Views_Services__TableServ : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ContractModule1.Models.Service>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\" id=\"tableService\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 7 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
           Write(Html.DisplayNameFor(model => model.HashService));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 10 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
           Write(Html.DisplayNameFor(model => model.Hash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
           Write(Html.DisplayNameFor(model => model.ServiceType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
           Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
           Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
           Write(Html.DisplayNameFor(model => model.ResearchType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
           Write(Html.DisplayNameFor(model => model.IsComplex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
           Write(Html.DisplayNameFor(model => model.Cabinet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
           Write(Html.DisplayNameFor(model => model.IDMKB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
           Write(Html.DisplayNameFor(model => model.IsArchived));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody id=\"tableInf\">\r\n");
#nullable restore
#line 49 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.HashService));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.Hash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.ServiceType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.Code));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.ResearchType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsComplex));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 83 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cabinet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 86 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.IDMKB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 89 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsArchived));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a class=\'btn btn-info text-white\'");
            BeginWriteAttribute("onclick", " onclick=", 3080, "", 3118, 3);
            WriteAttributeValue("", 3089, "AddEditPersonalInfo(", 3089, 20, true);
#nullable restore
#line 92 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
WriteAttributeValue("", 3109, item.Id, 3109, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3117, ")", 3117, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\'fa fa-pencil\'></i> Изменить </a>\r\n                    <a class=\'btn btn-danger text-white\' style=\'margin-left:5px\'");
            BeginWriteAttribute("onclick", " onclick=", 3243, "", 3268, 3);
            WriteAttributeValue("", 3252, "Delete(", 3252, 7, true);
#nullable restore
#line 93 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
WriteAttributeValue("", 3259, item.Id, 3259, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3267, ")", 3267, 1, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\'fa fa-trash\'></i> Удалить</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 96 "C:\Users\yanak\Desktop\ContractModule1\ContractModule1\Views\Services\_TableServ.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ContractModule1.Models.Service>> Html { get; private set; }
    }
}
#pragma warning restore 1591