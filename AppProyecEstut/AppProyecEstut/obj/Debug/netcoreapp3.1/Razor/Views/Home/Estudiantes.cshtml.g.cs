#pragma checksum "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "344c7a704f174732bc5535706c90516a569427b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Estudiantes), @"mvc.1.0.view", @"/Views/Home/Estudiantes.cshtml")]
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
#line 1 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\_ViewImports.cshtml"
using AppProyecEstut;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\_ViewImports.cshtml"
using AppProyecEstut.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"344c7a704f174732bc5535706c90516a569427b9", @"/Views/Home/Estudiantes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"188dfef2c70d9e4f434bf75199fdb9019a62d419", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Estudiantes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppProyecEstut.Models.Estudiantes>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-current", new global::Microsoft.AspNetCore.Html.HtmlString("page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Crear", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
  
    ViewData["Title"] = "Estudiantes";
    var valorRol = "";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h2 class=""text-center m-2"">  Lista de estudiantes </h2>

<div class=""col-12 d-flex flex-column align-items-center flex-md-row flex-lg-row justify-content-md-center justify-content-lg-center align-items-ad-start align-items-lg-start"">

    <div class=""col-12 col-md-6 col-lg-3 bg-white p-5 border rounded m-2 d-flex align-items-center justify-content-start"">

        <ul class=""nav nav-pills nav-fill"">

");
#nullable restore
#line 23 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
             if (User.IsInRole("admin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "344c7a704f174732bc5535706c90516a569427b95831", async() => {
                WriteLiteral("Agregar Estudiante");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 28 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </ul>

    </div>

    <div class=""col-12 col-md-6 col-lg-8 bg-white p-3 border rounded m-2"">

        <table class=""table"">

            <thead>
                <tr>
                    <th scope=""col"">Codigo</th>
                    <th scope=""col"">Nombre</th>
                    <th scope=""col"">Correo</th>
                    <th scope=""col"">Nota1</th>
                    <th scope=""col"">Nota2</th>
                    <th scope=""col"">Nota3</th>
                    <th scope=""col"">Rol</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 49 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
                 foreach (var myEstudiantes in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 52 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
                                   Write(myEstudiantes.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
                       Write(myEstudiantes.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 54 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
                       Write(myEstudiantes.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 55 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
                       Write(myEstudiantes.Nota1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
                       Write(myEstudiantes.Nota2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 57 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
                       Write(myEstudiantes.Nota3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 58 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
                       Write(myEstudiantes.Rol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 60 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
                             if (User.IsInRole("admin") || User.IsInRole("vendedor"))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
                           Write(Html.ActionLink("Detalle", "Detalle", new { id = @myEstudiantes.Codigo }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
                                                                                                          ;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
                             if (User.IsInRole("admin") || User.IsInRole("coordinador"))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
                           Write(Html.ActionLink("Editar", "Editar", new { id = @myEstudiantes.Codigo }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
                                                                                                        ;
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
                             if (User.IsInRole("admin"))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
                           Write(Html.ActionLink("Borrar", "Borrar", new { id = @myEstudiantes.Codigo }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
                                                                                                        ;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 75 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"


                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            </tbody>\r\n        </table>\r\n\r\n        <!--definamos los objetos de la navegacion-->\r\n        ");
#nullable restore
#line 85 "C:\Users\LINA\Desktop\SENA\trimestre2\AppProyecEstut\AppProyecEstut\Views\Home\Estudiantes.cshtml"
   Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("Index", new { page = page }),
       new X.PagedList.Mvc.Core.Common.PagedListRenderOptions
       {
           DisplayItemSliceAndTotal = false,
           ContainerDivClasses = new[] { "navigation" },
           LiElementClasses = new[] { "page-item" },
           PageClasses = new[] { "page-link" },
       }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n            <script>\r\n                $(document).ready(fuction();{\r\n                    $(\"ul.pagination > li.disabled > a\").addClass(\"page-link\")\r\n                })\r\n            </script>\r\n\r\n        ");
            }
            );
            WriteLiteral("\r\n        <!--Definimos los objetos de la navegacion-->\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppProyecEstut.Models.Estudiantes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
