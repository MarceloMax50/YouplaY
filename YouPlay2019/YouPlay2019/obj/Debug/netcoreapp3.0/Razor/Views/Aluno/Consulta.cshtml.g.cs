#pragma checksum "C:\Users\Usuário\Desktop\YouplaY\YouPlay2019\YouPlay2019\Views\Aluno\Consulta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3209f995fa52003c004c9fb8e6ae57fa2fe73c11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aluno_Consulta), @"mvc.1.0.view", @"/Views/Aluno/Consulta.cshtml")]
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
#line 1 "C:\Users\Usuário\Desktop\YouplaY\YouPlay2019\YouPlay2019\Views\_ViewImports.cshtml"
using YouPlay2019;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuário\Desktop\YouplaY\YouPlay2019\YouPlay2019\Views\_ViewImports.cshtml"
using YouPlay2019.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3209f995fa52003c004c9fb8e6ae57fa2fe73c11", @"/Views/Aluno/Consulta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"634c936464a17cbf67c034bf83934b714757038e", @"/Views/_ViewImports.cshtml")]
    public class Views_Aluno_Consulta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<YouPlay2019.Models.AlunoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Pesquisar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuário\Desktop\YouplaY\YouPlay2019\YouPlay2019\Views\Aluno\Consulta.cshtml"
  
    ViewData["Title"] = "Consulta";

#line default
#line hidden
#nullable disable
            WriteLiteral("<header>\r\n    <h2 class=\"text-center\">Consulta de Alunos</h2>\r\n</header>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3209f995fa52003c004c9fb8e6ae57fa2fe73c114157", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        \r\n");
#nullable restore
#line 11 "C:\Users\Usuário\Desktop\YouplaY\YouPlay2019\YouPlay2019\Views\Aluno\Consulta.cshtml"
         if (ViewBag.Erro != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <span class=\"text-danger\">");
#nullable restore
#line 15 "C:\Users\Usuário\Desktop\YouplaY\YouPlay2019\YouPlay2019\Views\Aluno\Consulta.cshtml"
                                         Write(ViewBag.Erro);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 18 "C:\Users\Usuário\Desktop\YouplaY\YouPlay2019\YouPlay2019\Views\Aluno\Consulta.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\Usuário\Desktop\YouplaY\YouPlay2019\YouPlay2019\Views\Aluno\Consulta.cshtml"
 if (Model == null && ViewBag.Erro == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                <span class=\"text-danger\">\r\n                    Nenhum dado encontrado\r\n                </span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\Usuário\Desktop\YouplaY\YouPlay2019\YouPlay2019\Views\Aluno\Consulta.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card"">
        <div class=""card-body"">
            <div class=""table-responsive-lg"">
                <table class=""table table-hover table-bordered"" id=""TabelaID"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"">Código</th>
                            <th scope=""col"">Nome</th>
");
            WriteLiteral(@"                            <th scope=""col"">Status</th>
                            <th scope=""col"">Disciplina</th>
                            <th scope=""col"">Ações </th>
                        </tr>
                        <tr>
                            <th scope=""col""></th>
                            <th><input type=""text"" id=""txtColuna2"" /></th>
                            <th scope=""col"" ></th>
");
            WriteLiteral("                            <th ><input type=\"text\" id=\"txtColuna3\" /></th>\r\n                            <th scope=\"col\" ></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 58 "C:\Users\Usuário\Desktop\YouplaY\YouPlay2019\YouPlay2019\Views\Aluno\Consulta.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th scope=\"row\">");
#nullable restore
#line 61 "C:\Users\Usuário\Desktop\YouplaY\YouPlay2019\YouPlay2019\Views\Aluno\Consulta.cshtml"
                                           Write(item.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 62 "C:\Users\Usuário\Desktop\YouplaY\YouPlay2019\YouPlay2019\Views\Aluno\Consulta.cshtml"
                               Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                <td>");
#nullable restore
#line 64 "C:\Users\Usuário\Desktop\YouplaY\YouPlay2019\YouPlay2019\Views\Aluno\Consulta.cshtml"
                               Write(item.CodigoStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2475, "\"", 2518, 3);
            WriteAttributeValue("", 2482, "javascript:editarAluno(", 2482, 23, true);
#nullable restore
#line 67 "C:\Users\Usuário\Desktop\YouplaY\YouPlay2019\YouPlay2019\Views\Aluno\Consulta.cshtml"
WriteAttributeValue("", 2505, item.Codigo, 2505, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2517, ")", 2517, 1, true);
            EndWriteAttribute();
            WriteLiteral("  class=\"btn btn-primary\">Editar</a>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2595, "\"", 2638, 3);
            WriteAttributeValue("", 2602, "javascript:apagarAluno(", 2602, 23, true);
#nullable restore
#line 68 "C:\Users\Usuário\Desktop\YouplaY\YouPlay2019\YouPlay2019\Views\Aluno\Consulta.cshtml"
WriteAttributeValue("", 2625, item.Codigo, 2625, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2637, ")", 2637, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Apagar</a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 71 "C:\Users\Usuário\Desktop\YouplaY\YouPlay2019\YouPlay2019\Views\Aluno\Consulta.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 77 "C:\Users\Usuário\Desktop\YouplaY\YouPlay2019\YouPlay2019\Views\Aluno\Consulta.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    $(document).ready(function () {
        $('#TabelaID').DataTable({
            ""language"": {
                ""lengthMenu"": ""Mostrando _MENU_ registros por página"",
                ""zeroRecords"": ""Nada Encontado"",
                ""info"": ""Exibindo página _PAGE_ de _páginas_"",
                ""infoEmpty"": ""Nenhum registro disponível"",
                ""infoFiltered"": ""(Filtrado de _MAX_ registros totais)""
            }
        });
    });
    $(function () {
        $(""#TabelaID input"").keyup(function () {
            var index = $(this).parent().index();
            var nth = ""#TabelaID td:nth-child("" + (index + 1).toString() + "")"";
            var valor = $(this).val().toUpperCase();
            $(""#TabelaID tbody tr"").show();
            $(nth).each(function () {
                if ($(this).text().toUpperCase().indexOf(valor) < 0) {
                    $(this).parent().hide();
                }
            });
        });

        $(""#TabelaID input"").blur(function () {
");
            WriteLiteral("            $(this).val(\"\");\r\n        });\r\n    });\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<YouPlay2019.Models.AlunoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
