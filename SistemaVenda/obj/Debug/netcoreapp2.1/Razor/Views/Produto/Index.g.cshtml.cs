#pragma checksum "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "021ef3211c5b7bc6bd883ec9ae86a36e0269e406"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Index), @"mvc.1.0.view", @"/Views/Produto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Index.cshtml", typeof(AspNetCore.Views_Produto_Index))]
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
#line 1 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\_ViewImports.cshtml"
using SistemaVenda;

#line default
#line hidden
#line 2 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\_ViewImports.cshtml"
using SistemaVenda.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"021ef3211c5b7bc6bd883ec9ae86a36e0269e406", @"/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9542d2a040dc74eba97c4a394c73aefd7909e77c", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SistemaVenda.Entidades.Produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Produto\Index.cshtml"
  
    ViewData["Title"] = "Produto";

#line default
#line hidden
            BeginContext(91, 326, true);
            WriteLiteral(@"
<h2>Produtos</h2>
<hr />

<table class=""table table-bordered"">
    <thead>
        <tr style=""background-color:#f6f6f6;"">
            <td>Código</td>
            <td>Descrição</td>
            <td>Quantidade</td>
            <td>Valor</td>
            <td>Categoria</td>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 21 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Produto\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(466, 34, true);
            WriteLiteral("        <tr style=\"cursor:pointer\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 500, "\"", 530, 3);
            WriteAttributeValue("", 510, "Editar(", 510, 7, true);
#line 23 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Produto\Index.cshtml"
WriteAttributeValue("", 517, item.Codigo, 517, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 529, ")", 529, 1, true);
            EndWriteAttribute();
            BeginContext(531, 20, true);
            WriteLiteral(">\r\n            <td> ");
            EndContext();
            BeginContext(552, 11, false);
#line 24 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Produto\Index.cshtml"
            Write(item.Codigo);

#line default
#line hidden
            EndContext();
            BeginContext(563, 24, true);
            WriteLiteral("</td>\r\n            <td> ");
            EndContext();
            BeginContext(588, 14, false);
#line 25 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Produto\Index.cshtml"
            Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(602, 24, true);
            WriteLiteral("</td>\r\n            <td> ");
            EndContext();
            BeginContext(627, 15, false);
#line 26 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Produto\Index.cshtml"
            Write(item.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(642, 24, true);
            WriteLiteral("</td>\r\n            <td> ");
            EndContext();
            BeginContext(667, 10, false);
#line 27 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Produto\Index.cshtml"
            Write(item.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(677, 24, true);
            WriteLiteral("</td>\r\n            <td> ");
            EndContext();
            BeginContext(702, 24, false);
#line 28 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Produto\Index.cshtml"
            Write(item.Categoria.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(726, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 30 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Produto\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(759, 377, true);
            WriteLiteral(@"    </tbody>
</table>
<br />
<button type=""button"" class=""btn btn-block btn-primary"" onclick=""Cadastrar()"">Cadastrar Produto</button>

<script>
    function Editar(Codigo) {
        window.location = window.origin + ""\\Produto\\Cadastro\\"" + Codigo;
    }

    function Cadastrar() {
        window.location = window.origin + ""\\Produto\\Cadastro"";
    }
</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SistemaVenda.Entidades.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
