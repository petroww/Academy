#pragma checksum "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aba8d87ab37146c1a61bc5efb355bbedf5c98809"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_CoursesList), @"mvc.1.0.view", @"/Views/Courses/CoursesList.cshtml")]
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
#line 1 "C:\Users\Miros\Desktop\Academy\Academy\Views\_ViewImports.cshtml"
using Academy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Miros\Desktop\Academy\Academy\Views\_ViewImports.cshtml"
using Academy.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba8d87ab37146c1a61bc5efb355bbedf5c98809", @"/Views/Courses/CoursesList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c51d00096b207fcd7f4e4578759324063e6cf65", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_CoursesList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<Academy.Models.Courses.Cours>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Courses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    body {
        margin: 0;
        padding: 0;
        background-color: #6abadeba;
        font-family: 'Arial';
    }

    .form-content {
        border: 1px solid #ced4da;
        margin-bottom: 2%;
        background: #23463f;
        border-radius: 15px;
        color: #08ffd1;
    }
</style>
<div class=""form-content"">
");
#nullable restore
#line 22 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"
     if (Model == null || Model?.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"text-succes\" style=\"font-size: 20px; color:red\">");
#nullable restore
#line 24 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"
                                                             Write(ViewData["delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 25 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"
        if (User.IsInRole("Teacher"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"text-center\"> Нямате записани курсове </h1>\r\n");
#nullable restore
#line 28 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <h1 class=\"text-center\"> Няма налични курсове </h1>\r\n");
#nullable restore
#line 32 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"
        }
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"text-succes\" style=\"font-size: 20px; color:lawngreen\">");
#nullable restore
#line 36 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"
                                                                   Write(ViewData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"text-succes\" style=\"font-size: 20px; color:red\">");
#nullable restore
#line 37 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"
                                                             Write(ViewData["delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral(@"        <table class=""table form-content"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Област</th>
                    <th scope=""col"">Тема</th>
                    <th scope=""col"" #>Продължителност (минути)</th>
                    <th scope=""col"" #></th>
                </tr>
            </thead>
            <tbody>
                <h2 style=""text-align:center""> Курсове </h2>
");
#nullable restore
#line 52 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"
                 foreach (var course in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 55 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"
                                    Write(Model.IndexOf(course) + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</th>\r\n                        <td>");
#nullable restore
#line 56 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"
                       Write(course.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 57 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"
                       Write(course.Theme);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 58 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"
                       Write(course.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        <td>\r\n");
#nullable restore
#line 61 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"
                             if(User.IsInRole("Admin") || User.IsInRole("Teacher"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aba8d87ab37146c1a61bc5efb355bbedf5c988099099", async() => {
                WriteLiteral("Редактиране");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("\\", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-coursId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"
                                      WriteLiteral(course.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["coursId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-coursId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["coursId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aba8d87ab37146c1a61bc5efb355bbedf5c9880911919", async() => {
                WriteLiteral("Изтриване");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("\\", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-coursId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"
                                      WriteLiteral(course.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["coursId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-coursId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["coursId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 72 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <td>\r\n                    </tr>\r\n");
#nullable restore
#line 77 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 81 "C:\Users\Miros\Desktop\Academy\Academy\Views\Courses\CoursesList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<Academy.Models.Courses.Cours>> Html { get; private set; }
    }
}
#pragma warning restore 1591
