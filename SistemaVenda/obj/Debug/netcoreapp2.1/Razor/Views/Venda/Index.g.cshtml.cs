#pragma checksum "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Venda\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af3e449f6025289f8bbf2612836397847f08d133"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Venda_Index), @"mvc.1.0.view", @"/Views/Venda/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Venda/Index.cshtml", typeof(AspNetCore.Views_Venda_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af3e449f6025289f8bbf2612836397847f08d133", @"/Views/Venda/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9542d2a040dc74eba97c4a394c73aefd7909e77c", @"/Views/_ViewImports.cshtml")]
    public class Views_Venda_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SistemaVenda.Entidades.Venda>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Venda\Index.cshtml"
  
    ViewData["Title"] = "Venda";

#line default
#line hidden
            BeginContext(87, 284, true);
            WriteLiteral(@"
<h2>Vendas</h2>
<hr />

<table class=""table table-bordered"">
    <thead>
        <tr style=""background-color:#f6f6f6;"">
            <td>Código</td>
            <td>Data</td>
            <td>Cliente</td>
            <td>Total</td>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Venda\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(420, 34, true);
            WriteLiteral("        <tr style=\"cursor:pointer\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 454, "\"", 484, 3);
            WriteAttributeValue("", 464, "Editar(", 464, 7, true);
#line 22 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Venda\Index.cshtml"
WriteAttributeValue("", 471, item.Codigo, 471, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 483, ")", 483, 1, true);
            EndWriteAttribute();
            BeginContext(485, 20, true);
            WriteLiteral(">\r\n            <td> ");
            EndContext();
            BeginContext(506, 11, false);
#line 23 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Venda\Index.cshtml"
            Write(item.Codigo);

#line default
#line hidden
            EndContext();
            BeginContext(517, 24, true);
            WriteLiteral("</td>\r\n            <td> ");
            EndContext();
            BeginContext(542, 9, false);
#line 24 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Venda\Index.cshtml"
            Write(item.Data);

#line default
#line hidden
            EndContext();
            BeginContext(551, 24, true);
            WriteLiteral("</td>\r\n            <td> ");
            EndContext();
            BeginContext(576, 18, false);
#line 25 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Venda\Index.cshtml"
            Write(item.CodigoCliente);

#line default
#line hidden
            EndContext();
            BeginContext(594, 24, true);
            WriteLiteral("</td>\r\n            <td> ");
            EndContext();
            BeginContext(619, 10, false);
#line 26 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Venda\Index.cshtml"
            Write(item.Total);

#line default
#line hidden
            EndContext();
            BeginContext(629, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 28 "C:\Workspace\Udemy\NetCore_DDD\SistemaVenda\SistemaVenda\SistemaVenda\Views\Venda\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(662, 371, true);
            WriteLiteral(@"    </tbody>
</table>
<br />
<button type=""button"" class=""btn btn-block btn-primary"" onclick=""Cadastrar()"">Registrar Venda</button>

<script>
    function Editar(Codigo) {
        window.location = window.origin + ""\\Venda\\Cadastro\\"" + Codigo;
    }

    function Cadastrar() {
        window.location = window.origin + ""\\Venda\\Cadastro"";
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SistemaVenda.Entidades.Venda>> Html { get; private set; }
    }
}
#pragma warning restore 1591
