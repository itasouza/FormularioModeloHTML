#pragma checksum "C:\Labs\JQueryDataTableCore\JQueryDataTableCore\Views\ServerProcessing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d64ffb6f7d2aefbd6425407940cf6574b7a5202b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ServerProcessing_Index), @"mvc.1.0.view", @"/Views/ServerProcessing/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ServerProcessing/Index.cshtml", typeof(AspNetCore.Views_ServerProcessing_Index))]
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
#line 1 "C:\Labs\JQueryDataTableCore\JQueryDataTableCore\Views\_ViewImports.cshtml"
using JQueryDataTableCore;

#line default
#line hidden
#line 2 "C:\Labs\JQueryDataTableCore\JQueryDataTableCore\Views\_ViewImports.cshtml"
using JQueryDataTableCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d64ffb6f7d2aefbd6425407940cf6574b7a5202b", @"/Views/ServerProcessing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f9e4266f3e387c8f9a24bc5e0669522221b7d9a", @"/Views/_ViewImports.cshtml")]
    public class Views_ServerProcessing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Labs\JQueryDataTableCore\JQueryDataTableCore\Views\ServerProcessing\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 84, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"container\">\r\n\r\n    <h2>Modelo de Processamento de Dados</h2>\r\n\r\n");
            EndContext();
            BeginContext(325, 447, true);
            WriteLiteral(@"
   
    <table id=""tblClientes"" class=""table table-striped table-bordered responsive nowrap"" style=""width:100%"">
        <thead>
            <tr>
                <th>Id</th>
                <th>Nome</th>
                <th>Sexo</th>
                <th>Estado</th>
                <th>Idade</th>
                <th>Ações</th>
            </tr>
        </thead>
        <tbody id=""bodyTable""></tbody>
    </table>


</div>


");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(789, 2241, true);
                WriteLiteral(@"



    <script type=""text/javascript"">
        $(document).ready(function () {

            var table = $(""#tblClientes"").DataTable({
                ""sAjaxSource"": '/ServerProcessing/Processar',
                ""bServerSide"": true,
                ""aLengthMenu"": [[10, 20, 50, 100], [""10 Registros"", ""20 Registros"", ""50 Registros"", ""100 Registros""]],
                ""aoColumns"": [
                    { ""mData"": ""id"" }, { ""mData"": ""nome"" }, { ""mData"": ""sexo"" }, { ""mData"": ""estado"" },
                    { ""mData"": ""idade"" }
                ],
                ""fnServerParams"": function (aoData) {
                    aoData.push({ ""name"": ""idadeInicial"", ""value"": $(""#txtIdadeInicial"").val() });
                    aoData.push({ ""name"": ""idadeFinal"", ""value"": $(""#txtIdadeFinal"").val() });
                },
                ""language"": {
                    ""sEmptyTable"": ""Nenhum registro encontrado"",
                    ""sInfo"": ""Mostrando de _START_ até _END_ de _TOTAL_ registros"",
        ");
                WriteLiteral(@"            ""sInfoEmpty"": ""Mostrando 0 até 0 de 0 registros"",
                    ""sInfoFiltered"": ""(Filtrados de _MAX_ registros)"",
                    ""sInfoPostFix"": """",
                    ""sInfoThousands"": ""."",
                    ""sLengthMenu"": ""_MENU_ "",
                    ""sLoadingRecords"": ""Carregando..."",
                    ""sProcessing"": ""Processando..."",
                    ""sZeroRecords"": ""Nenhum registro encontrado"",
                    ""sSearch"": ""Pesquisar"",
                },
                ""oPaginate"": {
                    ""sNext"": ""Próximo"",
                    ""sPrevious"": ""Anterior"",
                    ""sFirst"": ""Primeiro"",
                    ""sLast"": ""Último""
                },
                ""oAria"": {
                    ""sSortAscending"": "": Ordenar colunas de forma ascendente"",
                    ""sSortDescending"": "": Ordenar colunas de forma descendente""
                }


            });

            //$(""#txtIdadeInicial"").keyup(function () {
     ");
                WriteLiteral("       //    table.fnFilter();\r\n            //});\r\n            //$(\"#txtIdadeFinal\").keyup(function () {\r\n            //    table.fnFilter();\r\n            //});\r\n\r\n        })\r\n    </script>\r\n\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
