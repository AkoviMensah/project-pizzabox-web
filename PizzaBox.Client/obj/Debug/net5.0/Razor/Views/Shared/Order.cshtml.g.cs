#pragma checksum "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcfe7ec19c6fb8116b4f599dc2a8f47463d19562"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Order), @"mvc.1.0.view", @"/Views/Shared/Order.cshtml")]
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
#line 1 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcfe7ec19c6fb8116b4f599dc2a8f47463d19562", @"/Views/Shared/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Client.Models.OrderViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-check-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "radio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/customer/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div style=\"padding: 50px;\">\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dcfe7ec19c6fb8116b4f599dc2a8f47463d195624674", async() => {
                WriteLiteral("\n    ");
#nullable restore
#line 5 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    <fieldset>\n      <legend>Customers</legend>\n\n      ");
#nullable restore
#line 10 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
 Write(Html.ValidationMessageFor(m => m.SelectedCustomer));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n");
#nullable restore
#line 12 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
       foreach (var item in Model.Customers)
      {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"form-check\">\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dcfe7ec19c6fb8116b4f599dc2a8f47463d195625767", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 15 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedCustomer);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
                                                                             WriteLiteral(item);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n          <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 486, "\"", 497, 1);
#nullable restore
#line 16 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
WriteAttributeValue("", 492, item, 492, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 16 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
                                                 Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n        </div>\n");
#nullable restore
#line 18 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </fieldset>\n\n    <fieldset>\n      <legend>Stores</legend>\n\n      ");
#nullable restore
#line 24 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
 Write(Html.ValidationMessageFor(m => m.SelectedStore));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n");
#nullable restore
#line 26 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
       foreach (var item in Model.Stores)
      {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"form-check\">\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dcfe7ec19c6fb8116b4f599dc2a8f47463d195629750", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 29 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedStore);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
                                                                          WriteLiteral(item);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n          <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 873, "\"", 884, 1);
#nullable restore
#line 30 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
WriteAttributeValue("", 879, item, 879, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 30 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
                                                 Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n        </div>\n");
#nullable restore
#line 32 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </fieldset>\n\n    <fieldset>\n      <legend>Crusts</legend>\n\n      ");
#nullable restore
#line 38 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
 Write(Html.ValidationMessageFor(m => m.SelectedCrust));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n");
#nullable restore
#line 40 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
       foreach (var item in Model.Crusts)
      {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"form-check\">\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dcfe7ec19c6fb8116b4f599dc2a8f47463d1956213727", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 43 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedCrust);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
                                                                          WriteLiteral(item);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n          <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 1260, "\"", 1271, 1);
#nullable restore
#line 44 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
WriteAttributeValue("", 1266, item, 1266, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 44 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
                                                 Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n        </div>\n");
#nullable restore
#line 46 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </fieldset>\n\n    <fieldset>\n      <legend>Sizes</legend>\n\n      ");
#nullable restore
#line 52 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
 Write(Html.ValidationMessageFor(m => m.SelectedSize));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n");
#nullable restore
#line 54 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
       foreach (var item in Model.Sizes)
      {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"form-check\">\n          ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dcfe7ec19c6fb8116b4f599dc2a8f47463d1956217706", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 57 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SelectedSize);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
                                                                         WriteLiteral(item);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n          <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 1643, "\"", 1654, 1);
#nullable restore
#line 58 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
WriteAttributeValue("", 1649, item, 1649, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 58 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
                                                 Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n        </div>\n");
#nullable restore
#line 60 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </fieldset>\n\n    <fieldset>\n      <legend>Toppings</legend>\n\n      ");
#nullable restore
#line 66 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
 Write(Html.ValidationMessageFor(m => m.SelectedToppings));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n");
#nullable restore
#line 68 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
       foreach (var item in Model.Toppings)
      {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"form-check\">\n          <input class=\"form-check-input\" type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 1959, "\"", 1969, 1);
#nullable restore
#line 71 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
WriteAttributeValue("", 1964, item, 1964, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"selectedtoppings\"");
                BeginWriteAttribute("value", " value=\"", 1994, "\"", 2007, 1);
#nullable restore
#line 71 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
WriteAttributeValue("", 2002, item, 2002, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n          <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 2051, "\"", 2062, 1);
#nullable restore
#line 72 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
WriteAttributeValue("", 2057, item, 2057, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 72 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
                                                 Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n        </div>\n");
#nullable restore
#line 74 "/home/akovi/revature/project-pizzabox-web/PizzaBox.Client/Views/Shared/Order.cshtml"
      }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </fieldset>\n\n    <button type=\"submit\">make pizza</button>\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Client.Models.OrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
