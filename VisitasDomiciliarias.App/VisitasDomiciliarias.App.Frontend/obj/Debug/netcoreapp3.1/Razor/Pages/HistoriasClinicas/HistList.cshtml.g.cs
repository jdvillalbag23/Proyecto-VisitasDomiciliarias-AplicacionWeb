#pragma checksum "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3521be068cda2aac9cd2b4ca5d29a9094e9beccd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VisitasDomiciliarias.App.Frontend.Pages.HistoriasClinicas.Pages_HistoriasClinicas_HistList), @"mvc.1.0.razor-page", @"/Pages/HistoriasClinicas/HistList.cshtml")]
namespace VisitasDomiciliarias.App.Frontend.Pages.HistoriasClinicas
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3521be068cda2aac9cd2b4ca5d29a9094e9beccd", @"/Pages/HistoriasClinicas/HistList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6f0820f72a853aa73172bc21b518405deb6820", @"/Pages/_ViewImports.cshtml")]
    public class Pages_HistoriasClinicas_HistList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "filtroBusqueda", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DetailsHist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditHist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DeleteH", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./HistList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
  
    ViewData["Title"] = "Historia Clínica";

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr>\r\n\r\n<h1>");
#nullable restore
#line 8 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Revisa la historia clínica de tu mascota</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3521be068cda2aac9cd2b4ca5d29a9094e9beccd7648", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <p>\r\n            Buscar: ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3521be068cda2aac9cd2b4ca5d29a9094e9beccd7975", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 14 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
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
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Filtrar\" />\r\n        </p>\r\n");
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
            WriteLiteral("\r\n<hr>\r\n<div class=\"container\">\r\n  <div class=\"row\">\r\n      <div class=\"col-10\">\r\n          <h2 class=\"text-info\">Lista de Visitas</h2>\r\n      </div>      \r\n  </div>\r\n</div>\r\n\r\n</br>\r\n\r\n");
#nullable restore
#line 29 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
 if(Model.Historias.Count()>0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table id=\"tblHistorias\" class=\"table table-striped table-bordered\" style=\"width: 90%;\">\r\n  <thead>\r\n    <tr> \r\n      <th>");
#nullable restore
#line 34 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
     Write(Html.DisplayNameFor(h => h.Historias.FirstOrDefault().MascotaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>     \r\n      <th>");
#nullable restore
#line 35 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
     Write(Html.DisplayNameFor(h => h.Historias.FirstOrDefault().VeterinarioId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 36 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
     Write(Html.DisplayNameFor(h => h.Historias.FirstOrDefault().HistoriaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 37 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
     Write(Html.DisplayNameFor(h => h.Historias.FirstOrDefault().Temperatura));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 38 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
     Write(Html.DisplayNameFor(h => h.Historias.FirstOrDefault().Peso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 39 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
     Write(Html.DisplayNameFor(h => h.Historias.FirstOrDefault().FrecRespiratoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 40 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
     Write(Html.DisplayNameFor(h => h.Historias.FirstOrDefault().FrecCardiaca));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 41 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
     Write(Html.DisplayNameFor(h => h.Historias.FirstOrDefault().EstadoAnimo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 42 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
     Write(Html.DisplayNameFor(h => h.Historias.FirstOrDefault().FechaVisita));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th>");
#nullable restore
#line 43 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
     Write(Html.DisplayNameFor(h => h.Historias.FirstOrDefault().Recomendaciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            \r\n    </tr>\r\n  </thead>\r\n\r\n   <tbody>\r\n");
#nullable restore
#line 49 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
     foreach (var historia in Model.Historias)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <tr>        \r\n       <td>");
#nullable restore
#line 52 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
      Write(Html.DisplayFor(h => historia.MascotaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 53 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
      Write(Html.DisplayFor(h => historia.VeterinarioId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 54 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
      Write(Html.DisplayFor(h => historia.HistoriaId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 55 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
      Write(Html.DisplayFor(h => historia.Temperatura));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 56 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
      Write(Html.DisplayFor(h => historia.Peso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 57 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
      Write(Html.DisplayFor(h => historia.FrecRespiratoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 58 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
      Write(Html.DisplayFor(h => historia.FrecCardiaca));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 59 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
      Write(Html.DisplayFor(h => historia.EstadoAnimo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 60 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
      Write(Html.DisplayFor(h => historia.FechaVisita));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       <td>");
#nullable restore
#line 61 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
      Write(Html.DisplayFor(h => historia.Recomendaciones));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n       \r\n                     \r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3521be068cda2aac9cd2b4ca5d29a9094e9beccd18526", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-info-circle fa-lg\"></i>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idHistoria", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
                              WriteLiteral(historia.HistoriaId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idHistoria"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idHistoria", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idHistoria"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3521be068cda2aac9cd2b4ca5d29a9094e9beccd20987", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-user-edit\" aria-hidden=\"true\"> </i>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idHistoria", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
                                                                                                 WriteLiteral(historia.HistoriaId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idHistoria"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idHistoria", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idHistoria"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3521be068cda2aac9cd2b4ca5d29a9094e9beccd23529", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-trash-alt\" aria-hidden=\"true\"></i>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idHistoria", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
                                                                                               WriteLiteral(historia.HistoriaId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idHistoria"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idHistoria", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idHistoria"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n\r\n     </tr> \r\n");
#nullable restore
#line 84 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
  }  

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n");
#nullable restore
#line 87 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
} 
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>No hay Historias Clínicas registradas</p>\r\n");
#nullable restore
#line 91 "C:\Veterinaria\VisitasDomiciliarias.App\VisitasDomiciliarias.App.Frontend\Pages\HistoriasClinicas\HistList.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"d-grid gap-2 col-3 mx-auto\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3521be068cda2aac9cd2b4ca5d29a9094e9beccd26871", async() => {
                WriteLiteral("Adicionar Historia");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3521be068cda2aac9cd2b4ca5d29a9094e9beccd28130", async() => {
                WriteLiteral("Regresar a la lista de Historias Clínicas ");
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
            WriteLiteral("\r\n<hr>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VisitasDomiciliarias.App.Frontend.Pages.HistListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VisitasDomiciliarias.App.Frontend.Pages.HistListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VisitasDomiciliarias.App.Frontend.Pages.HistListModel>)PageContext?.ViewData;
        public VisitasDomiciliarias.App.Frontend.Pages.HistListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
