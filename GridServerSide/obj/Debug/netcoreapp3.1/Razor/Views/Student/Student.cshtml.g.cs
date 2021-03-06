#pragma checksum "C:\Users\alwan\source\repos\GridServerSide\GridServerSide\Views\Student\Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34d1701387e01f6347b07fe5ce386e8a08acbed9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Student), @"mvc.1.0.view", @"/Views/Student/Student.cshtml")]
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
#line 1 "C:\Users\alwan\source\repos\GridServerSide\GridServerSide\Views\_ViewImports.cshtml"
using GridServerSide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alwan\source\repos\GridServerSide\GridServerSide\Views\_ViewImports.cshtml"
using GridServerSide.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alwan\source\repos\GridServerSide\GridServerSide\Views\Student\Student.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alwan\source\repos\GridServerSide\GridServerSide\Views\Student\Student.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alwan\source\repos\GridServerSide\GridServerSide\Views\Student\Student.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34d1701387e01f6347b07fe5ce386e8a08acbed9", @"/Views/Student/Student.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d75d72fa8651380a5b9362561aaf672b18162773", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentPaging>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\alwan\source\repos\GridServerSide\GridServerSide\Views\Student\Student.cshtml"
  
    ViewData["Title"] = "Student";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"" />
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js""></script>

<h1>Student</h1>

<div class=""container"">
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>
                    Student ID
                </th>
                <th>
                    Name
                </th>
                <th>
                    GPA
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 33 "C:\Users\alwan\source\repos\GridServerSide\GridServerSide\Views\Student\Student.cshtml"
             foreach (var std in Model.Students)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "C:\Users\alwan\source\repos\GridServerSide\GridServerSide\Views\Student\Student.cshtml"
                   Write(std.StudentID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\alwan\source\repos\GridServerSide\GridServerSide\Views\Student\Student.cshtml"
                   Write(std.StudentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "C:\Users\alwan\source\repos\GridServerSide\GridServerSide\Views\Student\Student.cshtml"
                   Write(std.StudentGPA);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 46 "C:\Users\alwan\source\repos\GridServerSide\GridServerSide\Views\Student\Student.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td colspan=\"3\">\r\n                    ");
#nullable restore
#line 49 "C:\Users\alwan\source\repos\GridServerSide\GridServerSide\Views\Student\Student.cshtml"
               Write(Html.PagedListPager((IPagedList)Model.Students,
     page => Url.Action("Student", new { page = page }),
     PagedListRenderOptions.OnlyShowFivePagesAtATime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentPaging> Html { get; private set; }
    }
}
#pragma warning restore 1591
