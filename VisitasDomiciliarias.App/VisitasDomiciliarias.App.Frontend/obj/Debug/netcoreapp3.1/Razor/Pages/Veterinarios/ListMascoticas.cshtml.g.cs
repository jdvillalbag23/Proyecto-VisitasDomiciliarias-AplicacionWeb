#pragma checksum "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3006dd99f6906b39a184d6ef2302924875815bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VisitasDomiciliarias.App.Frontend.Pages.Veterinarios.Pages_Veterinarios_ListMascoticas), @"mvc.1.0.razor-page", @"/Pages/Veterinarios/ListMascoticas.cshtml")]
namespace VisitasDomiciliarias.App.Frontend.Pages.Veterinarios
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
#line 1 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\_ViewImports.cshtml"
using VisitasDomiciliarias.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3006dd99f6906b39a184d6ef2302924875815bb", @"/Pages/Veterinarios/ListMascoticas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6f0820f72a853aa73172bc21b518405deb6820", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Veterinarios_ListMascoticas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditVets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
  
    int idVeterinario = Model.Veterinario.VeterinarioId;

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr>\r\n<div class=\"container\">\r\n  <div class=\"row\">\r\n      <div class=\"col-10\">\r\n          <h2 class=\"text-info\">Lista de Mascotas</h2>\r\n      </div>      \r\n  </div>\r\n</div>\r\n<div>\r\n    Mostrando ");
#nullable restore
#line 15 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
         Write(Model.MascotasVeterinarios.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" mascotas visitadas\r\n</div>\r\n\r\n<br>\r\n\r\n");
#nullable restore
#line 20 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
 if(Model.MascotasVeterinarios.Count()>0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table id=\"tblMascotaVeterinario\" class=\"table table-striped table-bordered\" style=\"width: 90%;\">\r\n  <thead>\r\n    <tr> \r\n      <th>");
#nullable restore
#line 25 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
     Write(Html.DisplayNameFor(m => m.MascotasVeterinarios.FirstOrDefault().MascotaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>     \r\n      <th>");
#nullable restore
#line 26 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
     Write(Html.DisplayNameFor(m => m.MascotasVeterinarios.FirstOrDefault().Mascota.PropietarioId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 27 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
     Write(Html.DisplayNameFor(m => m.MascotasVeterinarios.FirstOrDefault().Mascota.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 28 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
     Write(Html.DisplayNameFor(m => m.MascotasVeterinarios.FirstOrDefault().Mascota.Raza));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 29 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
     Write(Html.DisplayNameFor(m => m.MascotasVeterinarios.FirstOrDefault().Mascota.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 30 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
     Write(Html.DisplayNameFor(m => m.MascotasVeterinarios.FirstOrDefault().Mascota.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>            \r\n            \r\n    </tr>\r\n  </thead>\r\n\r\n<tbody>\r\n");
#nullable restore
#line 36 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
     foreach (var mascota in Model.MascotasVeterinarios)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <tr>        \r\n       <td>");
#nullable restore
#line 39 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
      Write(Html.DisplayFor(m => mascota.MascotaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 40 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
      Write(Html.DisplayFor(m => mascota.Mascota.PropietarioId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 41 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
      Write(Html.DisplayFor(m => mascota.Mascota.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 42 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
      Write(Html.DisplayFor(m => mascota.Mascota.Raza));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 43 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
      Write(Html.DisplayFor(m => mascota.Mascota.Tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 44 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
      Write(Html.DisplayFor(m => mascota.Mascota.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>          \r\n     </tr> \r\n");
#nullable restore
#line 46 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
  }  

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n");
#nullable restore
#line 49 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
} 
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>No hay mascotas visitadas</p>\r\n");
#nullable restore
#line 53 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<hr>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3006dd99f6906b39a184d6ef2302924875815bb10049", async() => {
                WriteLiteral("\r\n    <i aria-hidden=\"true\">Regresar</i>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-VeterinarioId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Veterinarios\ListMascoticas.cshtml"
                                                             WriteLiteral(idVeterinario);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["VeterinarioId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-VeterinarioId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["VeterinarioId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<hr>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VisitasDomiciliarias.App.Frontend.Pages.ListMascoticasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VisitasDomiciliarias.App.Frontend.Pages.ListMascoticasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VisitasDomiciliarias.App.Frontend.Pages.ListMascoticasModel>)PageContext?.ViewData;
        public VisitasDomiciliarias.App.Frontend.Pages.ListMascoticasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591