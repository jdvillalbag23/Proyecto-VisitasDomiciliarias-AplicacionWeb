#pragma checksum "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5742f085fdb5fdbad0d0fd0ad38de8849666e355"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VisitasDomiciliarias.App.Frontend.Pages.Propietarios.Pages_Propietarios_PropList), @"mvc.1.0.razor-page", @"/Pages/Propietarios/PropList.cshtml")]
namespace VisitasDomiciliarias.App.Frontend.Pages.Propietarios
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5742f085fdb5fdbad0d0fd0ad38de8849666e355", @"/Pages/Propietarios/PropList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6f0820f72a853aa73172bc21b518405deb6820", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Propietarios_PropList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "filtroBusqueda", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DetailsProp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditProp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DeleteP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./PropList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
  
    ViewData["Title"] = "Propietario";

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr>\r\n\r\n<h1>");
#nullable restore
#line 8 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Registrate y conoce los beneficios que tenemos para ti y tu mascota</p>\r\n    \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5742f085fdb5fdbad0d0fd0ad38de8849666e3557633", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n        <p>\r\n          Buscar: ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5742f085fdb5fdbad0d0fd0ad38de8849666e3557962", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 15 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FiltroBusqueda);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Filtrar\" />\r\n        </p>\r\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("      \r\n<hr>\r\n<div class=\"container\">\r\n  <div class=\"row\">\r\n      <div class=\"col-9\">\r\n          <h2 class=\"text-info\">Lista de Propietarios</h2>\r\n      </div>      \r\n  </div>\r\n</div>\r\n\r\n</br>\r\n");
#nullable restore
#line 29 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
 if(Model.Propietarios.Count()>0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table id=\"tblPropietarios\" class=\"table table-striped table-bordered\" style=\"width: 100%;\">\r\n  <thead>\r\n    <tr>      \r\n      <th>");
#nullable restore
#line 34 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
     Write(Html.DisplayNameFor(p => p.Propietarios.FirstOrDefault().PropietarioId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 35 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
     Write(Html.DisplayNameFor(p => p.Propietarios.FirstOrDefault().Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 36 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
     Write(Html.DisplayNameFor(p => p.Propietarios.FirstOrDefault().Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 37 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
     Write(Html.DisplayNameFor(p => p.Propietarios.FirstOrDefault().Identificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 38 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
     Write(Html.DisplayNameFor(p => p.Propietarios.FirstOrDefault().Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 39 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
     Write(Html.DisplayNameFor(p => p.Propietarios.FirstOrDefault().Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    </tr>\r\n  </thead>\r\n\r\n   <tbody>\r\n");
#nullable restore
#line 44 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
     foreach (var propietarios in Model.Propietarios)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <tr>\r\n       <td>");
#nullable restore
#line 47 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
      Write(Html.DisplayFor(p => propietarios.PropietarioId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 48 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
      Write(Html.DisplayFor(p => propietarios.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 49 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
      Write(Html.DisplayFor(p => propietarios.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 50 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
      Write(Html.DisplayFor(p => propietarios.Identificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 51 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
      Write(Html.DisplayFor(p => propietarios.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 52 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
      Write(Html.DisplayFor(p => propietarios.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       \r\n       <td>\r\n         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5742f085fdb5fdbad0d0fd0ad38de8849666e35515893", async() => {
                WriteLiteral("\r\n         <i class=\"fas fa-info-circle fa-lg\"></i> ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-propietarioId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
                                                                                            WriteLiteral(propietarios.PropietarioId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["propietarioId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-propietarioId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["propietarioId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        \r\n      </td>\r\n       <td>\r\n         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5742f085fdb5fdbad0d0fd0ad38de8849666e35518370", async() => {
                WriteLiteral("\r\n         <i class=\"fas fa-user-edit\" aria-hidden=\"true\"> </i>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-propietarioId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
                                                                                         WriteLiteral(propietarios.PropietarioId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["propietarioId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-propietarioId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["propietarioId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n       </td>\r\n\r\n       <td>\r\n         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5742f085fdb5fdbad0d0fd0ad38de8849666e35520862", async() => {
                WriteLiteral("\r\n         <i class=\"fas fa-trash-alt\" aria-hidden=\"true\"></i>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-propietarioId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
                                                                                       WriteLiteral(propietarios.PropietarioId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["propietarioId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-propietarioId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["propietarioId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n       </td>\r\n\r\n     </tr> \r\n");
#nullable restore
#line 72 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
  }  

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n");
#nullable restore
#line 75 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
} 
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>No hay propietarios registrados</p>\r\n");
#nullable restore
#line 79 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\Propietarios\PropList.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"d-grid gap-2 d-md-flex justify-content-md-end\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5742f085fdb5fdbad0d0fd0ad38de8849666e35524168", async() => {
                WriteLiteral("Registrar Propietario");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5742f085fdb5fdbad0d0fd0ad38de8849666e35525430", async() => {
                WriteLiteral("Regresar a la lista de Propietarios ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<hr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VisitasDomiciliarias.App.Frontend.Pages.PropListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VisitasDomiciliarias.App.Frontend.Pages.PropListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VisitasDomiciliarias.App.Frontend.Pages.PropListModel>)PageContext?.ViewData;
        public VisitasDomiciliarias.App.Frontend.Pages.PropListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591