#pragma checksum "/Users/Guest/Desktop/Tamagotchi/Tamagotchi/Views/Items/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7714fabdd100464cc569bc990b20c49de236eb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Index), @"mvc.1.0.view", @"/Views/Items/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Index.cshtml", typeof(AspNetCore.Views_Items_Index))]
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
#line 20 "/Users/Guest/Desktop/Tamagotchi/Tamagotchi/Views/Items/Index.cshtml"
using Tamagotchi;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7714fabdd100464cc569bc990b20c49de236eb6", @"/Views/Items/Index.cshtml")]
    public class Views_Items_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Styles/stlyes.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("all"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/scripts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!doctype html>\n<html lang=\"en\">\n  ");
            EndContext();
            BeginContext(35, 737, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7714fabdd100464cc569bc990b20c49de236eb64879", async() => {
                BeginContext(41, 399, true);
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- Bootstrap CSS -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    ");
                EndContext();
                BeginContext(440, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f7714fabdd100464cc569bc990b20c49de236eb65666", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(520, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(525, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7714fabdd100464cc569bc990b20c49de236eb67150", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(569, 196, true);
                WriteLiteral("\n    <script\n  src=\"https://code.jquery.com/jquery-3.4.0.js\"\n  integrity=\"sha256-DYZMCC8HTC+QDr5QNaIcfR7VSPtcISykd+6eSmBW5qo=\"\n  crossorigin=\"anonymous\"></script>\n\n    <title>Tamagotchi</title>\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(772, 3, true);
            WriteLiteral("\n  ");
            EndContext();
            BeginContext(775, 2815, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7714fabdd100464cc569bc990b20c49de236eb69374", async() => {
                BeginContext(781, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(805, 736, true);
                WriteLiteral(@"  <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
  <a class=""navbar-brand"" href=""/"">Tamagotchi</a>
  <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
    <span class=""navbar-toggler-icon""></span>
  </button>

  <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
    <ul class=""navbar-nav mr-auto"">
      <li class=""nav-item active"">
        <a class=""nav-link"" href=""/"">Home <span class=""sr-only"">(current)</span></a>
      </li>
      <li class=""nav-item"">
        <a class=""nav-link"" href=""/Index/new"">Go to Game</a>
      </li>
    </ul>
  </div>
</nav>
");
                EndContext();
#line 38 "/Users/Guest/Desktop/Tamagotchi/Tamagotchi/Views/Items/Index.cshtml"
 if(@Model.Count > 0)
{
  

#line default
#line hidden
#line 40 "/Users/Guest/Desktop/Tamagotchi/Tamagotchi/Views/Items/Index.cshtml"
   foreach(Pet pet in Model)
  {

#line default
#line hidden
                BeginContext(1598, 15, true);
                WriteLiteral("    <h1>Model: ");
                EndContext();
                BeginContext(1614, 14, false);
#line 42 "/Users/Guest/Desktop/Tamagotchi/Tamagotchi/Views/Items/Index.cshtml"
          Write(pet.getSleep());

#line default
#line hidden
                EndContext();
                BeginContext(1628, 21, true);
                WriteLiteral("</h1>\n    <h1>Model: ");
                EndContext();
                BeginContext(1650, 13, false);
#line 43 "/Users/Guest/Desktop/Tamagotchi/Tamagotchi/Views/Items/Index.cshtml"
          Write(pet.getFood());

#line default
#line hidden
                EndContext();
                BeginContext(1663, 21, true);
                WriteLiteral("</h1>\n    <h1>Model: ");
                EndContext();
                BeginContext(1685, 13, false);
#line 44 "/Users/Guest/Desktop/Tamagotchi/Tamagotchi/Views/Items/Index.cshtml"
          Write(pet.getPlay());

#line default
#line hidden
                EndContext();
                BeginContext(1698, 6, true);
                WriteLiteral("</h1>\n");
                EndContext();
#line 45 "/Users/Guest/Desktop/Tamagotchi/Tamagotchi/Views/Items/Index.cshtml"
  }

#line default
#line hidden
#line 45 "/Users/Guest/Desktop/Tamagotchi/Tamagotchi/Views/Items/Index.cshtml"
   

}

#line default
#line hidden
                BeginContext(1711, 59, true);
                WriteLiteral("\n<div class=\"container\">\n\n    <img id = \"petGif\" alt=\"Logo\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1770, "\"", 1815, 1);
#line 51 "/Users/Guest/Desktop/Tamagotchi/Tamagotchi/Views/Items/Index.cshtml"
WriteAttributeValue("", 1776, Url.Content("~/TamaImage/fishPet.gif"), 1776, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1816, 219, true);
                WriteLiteral(" />\n\n</div>\n\n  <div class=\"container text-center\">\n       <br>\n        <div class=\"row\">\n          <div class=\"col-sm-4\">\n            <ul style=\"list-style-type:none;\">\n              <li><img id = \"hungryGif\" alt=\"Logo\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2035, "\"", 2079, 1);
#line 60 "/Users/Guest/Desktop/Tamagotchi/Tamagotchi/Views/Items/Index.cshtml"
WriteAttributeValue("", 2041, Url.Content("~/TamaImage/hungry.gif"), 2041, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2080, 173, true);
                WriteLiteral(" /></li>\n            </ul>\n          </div>\n          <div class=\"col-sm-4\">\n            <ul style=\"list-style-type:none;\">\n              <li><img id = \"sleepGif\" alt=\"Logo\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2253, "\"", 2296, 1);
#line 65 "/Users/Guest/Desktop/Tamagotchi/Tamagotchi/Views/Items/Index.cshtml"
WriteAttributeValue("", 2259, Url.Content("~/TamaImage/sleep.gif"), 2259, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2297, 172, true);
                WriteLiteral(" /></li>\n            </ul>\n          </div>\n          <div class=\"col-sm-4\">\n            <ul style=\"list-style-type:none;\">\n              <li><img  id = \"funGif\" alt=\"Logo\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2469, "\"", 2510, 1);
#line 70 "/Users/Guest/Desktop/Tamagotchi/Tamagotchi/Views/Items/Index.cshtml"
WriteAttributeValue("", 2475, Url.Content("~/TamaImage/fun.gif"), 2475, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2511, 1025, true);
                WriteLiteral(@" /></li>
            </ul>
          </div>
        </div>
      </div>
      <form action=""/Index/new"" method=""post"">

      <div class=""container text-center"">
           <br>
            <div class=""row"">
              <div class=""col-sm-4"">
                <ul style=""list-style-type:none;"">
                  <li><button id = ""feed"" type=""submit"" value = 100 class = ""btn btn-info"" name=""food"">Feed</button></li>
                </ul>
              </div>
              <div class=""col-sm-4"">
                <ul style=""list-style-type:none;"">
                  <li><button id = ""sleep"" type=""submit"" value = 100 class = ""btn btn-info"" name=""sleep"">Sleep</button></li>
                </ul>
              </div>
              <div class=""col-sm-4"">
                <ul style=""list-style-type:none;"">
                  <li><button id = ""play"" value = 100 type=""submit"" class = ""btn btn-info"" name=""play"">Play</button></li>
                </ul>
              </div>
            </div>
          </div>
        </form>

 ");
                WriteLiteral(" ");
                EndContext();
                BeginContext(3536, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7714fabdd100464cc569bc990b20c49de236eb615854", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3580, 3, true);
                WriteLiteral("\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3590, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
