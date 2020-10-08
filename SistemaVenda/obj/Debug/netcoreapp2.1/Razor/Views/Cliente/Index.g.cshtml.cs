#pragma checksum "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf008b2510e257dac8d21a91991477e23c035884"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Index.cshtml", typeof(AspNetCore.Views_Cliente_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf008b2510e257dac8d21a91991477e23c035884", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9542d2a040dc74eba97c4a394c73aefd7909e77c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SistemaVenda.Entidades.Cliente>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Cliente";

#line default
#line hidden
            BeginContext(91, 317, true);
            WriteLiteral(@"
<h2>Clientes</h2>
<hr />

<table class=""table table-bordered"">
    <thead>
        <tr style=""background-color:#f6f6f6;"">
            <td>Código</td>
            <td>Nome</td>
            <td>Email</td>
            <td>CNPJ_CPF</td>
            <td>Celular</td>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 21 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Cliente\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(457, 34, true);
            WriteLiteral("        <tr style=\"cursor:pointer\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 491, "\"", 521, 3);
            WriteAttributeValue("", 501, "Editar(", 501, 7, true);
#line 23 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 508, item.Codigo, 508, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 520, ")", 520, 1, true);
            EndWriteAttribute();
            BeginContext(522, 20, true);
            WriteLiteral(">\r\n            <td> ");
            EndContext();
            BeginContext(543, 11, false);
#line 24 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Cliente\Index.cshtml"
            Write(item.Codigo);

#line default
#line hidden
            EndContext();
            BeginContext(554, 24, true);
            WriteLiteral("</td>\r\n            <td> ");
            EndContext();
            BeginContext(579, 9, false);
#line 25 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Cliente\Index.cshtml"
            Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(588, 24, true);
            WriteLiteral("</td>\r\n            <td> ");
            EndContext();
            BeginContext(613, 10, false);
#line 26 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Cliente\Index.cshtml"
            Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(623, 24, true);
            WriteLiteral("</td>\r\n            <td> ");
            EndContext();
            BeginContext(648, 13, false);
#line 27 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Cliente\Index.cshtml"
            Write(item.CNPJ_CPF);

#line default
#line hidden
            EndContext();
            BeginContext(661, 24, true);
            WriteLiteral("</td>\r\n            <td> ");
            EndContext();
            BeginContext(686, 12, false);
#line 28 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Cliente\Index.cshtml"
            Write(item.Celular);

#line default
#line hidden
            EndContext();
            BeginContext(698, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 30 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Cliente\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(731, 377, true);
            WriteLiteral(@"    </tbody>
</table>
<br />
<button type=""button"" class=""btn btn-block btn-primary"" onclick=""Cadastrar()"">Cadastrar Cliente</button>

<script>
    function Editar(Codigo) {
        window.location = window.origin + ""\\Cliente\\Cadastro\\"" + Codigo;
    }

    function Cadastrar() {
        window.location = window.origin + ""\\Cliente\\Cadastro"";
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SistemaVenda.Entidades.Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591
