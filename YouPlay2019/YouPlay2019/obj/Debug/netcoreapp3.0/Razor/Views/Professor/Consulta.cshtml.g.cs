#pragma checksum "C:\Users\Usuário\Desktop\TrabalhoLPI\TrabalhoLPI-master\YouPlay2019\YouPlay2019\Views\Professor\Consulta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eda65d3881cd79ee17ceb73d1f63d71d889755d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Professor_Consulta), @"mvc.1.0.view", @"/Views/Professor/Consulta.cshtml")]
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
#line 1 "C:\Users\Usuário\Desktop\TrabalhoLPI\TrabalhoLPI-master\YouPlay2019\YouPlay2019\Views\_ViewImports.cshtml"
using YouPlay2019;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuário\Desktop\TrabalhoLPI\TrabalhoLPI-master\YouPlay2019\YouPlay2019\Views\_ViewImports.cshtml"
using YouPlay2019.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eda65d3881cd79ee17ceb73d1f63d71d889755d", @"/Views/Professor/Consulta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"634c936464a17cbf67c034bf83934b714757038e", @"/Views/_ViewImports.cshtml")]
    public class Views_Professor_Consulta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<YouPlay2019.Models.ProfessorViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuário\Desktop\TrabalhoLPI\TrabalhoLPI-master\YouPlay2019\YouPlay2019\Views\Professor\Consulta.cshtml"
  
    ViewData["Title"] = "Consulta";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<header>
    <h2 class=""text-center mb-2"">Consulta de Professores</h2>
</header>

<div class=""table-responsive-lg"">
    <table class=""table table-hover table-bordered"" id=""TabelaID"">
        <thead class=""thead-dark"">
            <tr>
                <th scope=""col"">Código</th>
                <th scope=""col"">Nome</th>
                <th scope=""col"">Status</th>
                <th scope=""col"">Disciplina</th>
                <th scope=""col"">Ação</th>
            </tr>
            <tr>
                <th scope=""col""></th>
                <th><input type=""text"" id=""txtColuna2"" /></th>
                <th scope=""col""></th>
                <th><input type=""text"" id=""txtColuna3"" /></th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 28 "C:\Users\Usuário\Desktop\TrabalhoLPI\TrabalhoLPI-master\YouPlay2019\YouPlay2019\Views\Professor\Consulta.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 31 "C:\Users\Usuário\Desktop\TrabalhoLPI\TrabalhoLPI-master\YouPlay2019\YouPlay2019\Views\Professor\Consulta.cshtml"
                               Write(item.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\Usuário\Desktop\TrabalhoLPI\TrabalhoLPI-master\YouPlay2019\YouPlay2019\Views\Professor\Consulta.cshtml"
                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\Usuário\Desktop\TrabalhoLPI\TrabalhoLPI-master\YouPlay2019\YouPlay2019\Views\Professor\Consulta.cshtml"
                   Write(item.CodigoStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\Usuário\Desktop\TrabalhoLPI\TrabalhoLPI-master\YouPlay2019\YouPlay2019\Views\Professor\Consulta.cshtml"
                   Write(item.DescricaoDisciplina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1232, "\"", 1279, 3);
            WriteAttributeValue("", 1239, "javascript:editarProfessor(", 1239, 27, true);
#nullable restore
#line 36 "C:\Users\Usuário\Desktop\TrabalhoLPI\TrabalhoLPI-master\YouPlay2019\YouPlay2019\Views\Professor\Consulta.cshtml"
WriteAttributeValue("", 1266, item.Codigo, 1266, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1278, ")", 1278, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Editar</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1343, "\"", 1390, 3);
            WriteAttributeValue("", 1350, "javascript:apagarProfessor(", 1350, 27, true);
#nullable restore
#line 37 "C:\Users\Usuário\Desktop\TrabalhoLPI\TrabalhoLPI-master\YouPlay2019\YouPlay2019\Views\Professor\Consulta.cshtml"
WriteAttributeValue("", 1377, item.Codigo, 1377, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1389, ")", 1389, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Apagar</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Usuário\Desktop\TrabalhoLPI\TrabalhoLPI-master\YouPlay2019\YouPlay2019\Views\Professor\Consulta.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>
<script>
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

        $");
            WriteLiteral("(\"#TabelaID input\").blur(function () {\r\n            $(this).val(\"\");\r\n        });\r\n    });\r\n\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<YouPlay2019.Models.ProfessorViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591