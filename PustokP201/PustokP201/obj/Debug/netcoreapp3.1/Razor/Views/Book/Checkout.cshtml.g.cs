#pragma checksum "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\PustokP201\PustokP201\Views\Book\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "283ca52114acfaddd96f6688cc9f412a95759a62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Checkout), @"mvc.1.0.view", @"/Views/Book/Checkout.cshtml")]
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
#line 1 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\PustokP201\PustokP201\Views\_ViewImports.cshtml"
using PustokP201;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\PustokP201\PustokP201\Views\_ViewImports.cshtml"
using PustokP201.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\PustokP201\PustokP201\Views\_ViewImports.cshtml"
using PustokP201.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"283ca52114acfaddd96f6688cc9f412a95759a62", @"/Views/Book/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5884438bbf247ea6d9f39676e18e38800fdc98e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CheckoutItemViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://demo.hasthemes.com/pustok-preview/pustok/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\PustokP201\PustokP201\Views\Book\Checkout.cshtml"
   
    decimal total = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"      
        <section class=""breadcrumb-section"">
            <h2 class=""sr-only"">Site Breadcrumb</h2>
            <div class=""container"">
                <div class=""breadcrumb-contents"">
                    <nav aria-label=""breadcrumb"">
                        <ol class=""breadcrumb"">
                            <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                            <li class=""breadcrumb-item active"">Checkout</li>
                        </ol>
                    </nav>
                </div>
            </div>
        </section>
        <main id=""content"" class=""page-section inner-page-sec-padding-bottom space-db--20"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-12"">
                        <!-- Checkout Form s-->
                        <div class=""checkout-form"">
                            <div class=""row row-40"">
                                <div class=""col-12"">
                  ");
            WriteLiteral(@"                  <h1 class=""quick-title"">Checkout</h1>
                                    <!-- Slide Down Trigger  -->
                                    <div class=""checkout-quick-box"">
                                        <p>
                                            <i class=""far fa-sticky-note""></i>Returning customer? <a href=""javascript:""
                                                                                                     class=""slide-trigger"" data-target=""#quick-login"">
                                                Click
                                                here to login
                                            </a>
                                        </p>
                                    </div>
                                    <!-- Slide Down Blox ==> Login Box  -->
                                    <div class=""checkout-slidedown-box"" id=""quick-login"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283ca52114acfaddd96f6688cc9f412a95759a626398", async() => {
                WriteLiteral(@"
                                            <div class=""quick-login-form"">
                                                <p>
                                                    If you have shopped with us before, please enter your details in the
                                                    boxes below. If you are a new
                                                    customer
                                                    please
                                                    proceed to the Billing & Shipping section.
                                                </p>
                                                <div class=""form-group"">
                                                    <label for=""quick-user"">Username or email *</label>
                                                    <input type=""text""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2991, "\"", 3005, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""quick-user"">
                                                </div>
                                                <div class=""form-group"">
                                                    <label for=""quick-pass"">Password *</label>
                                                    <input type=""text""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3321, "\"", 3335, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""quick-pass"">
                                                </div>
                                                <div class=""form-group"">
                                                    <div class=""d-flex align-items-center flex-wrap"">
                                                        <a href=""#"" class=""btn btn-outlined   mr-3"">Login</a>
                                                        <div class=""d-inline-flex align-items-center"">
                                                            <input type=""checkbox"" id=""accept_terms"" class=""mb-0 mr-1"">
                                                            <label for=""accept_terms"" class=""mb-0"">
                                                                I’ve read and accept
                                                                the terms &amp; conditions
                                                            </label>
                                                        </div>
                       ");
                WriteLiteral(@"                             </div>
                                                    <p>
                                                        <a href=""javascript:"" class=""pass-lost mt-3"">
                                                            Lost your
                                                            password?
                                                        </a>
                                                    </p>
                                                </div>
                                            </div>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                    <!-- Slide Down Trigger  -->
                                    <div class=""checkout-quick-box"">
                                        <p>
                                            <i class=""far fa-sticky-note""></i>Have a coupon? <a href=""javascript:""
                                                                                                class=""slide-trigger"" data-target=""#quick-cupon"">
                                                Click here to enter your code
                                            </a>
                                        </p>
                                    </div>
                                    <!-- Slide Down Blox ==> Cupon Box -->
                                    <div class=""checkout-slidedown-box"" id=""quick-cupon"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283ca52114acfaddd96f6688cc9f412a95759a6211851", async() => {
                WriteLiteral(@"
                                            <div class=""checkout_coupon"">
                                                <input type=""text"" class=""mb-0"" placeholder=""Coupon Code"">
                                                <a href=""#"" class=""btn btn-outlined"">Apply coupon</a>
                                            </div>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-lg-7 mb--20"">
                                    <!-- Billing Address -->
                                    <div id=""billing-form"" class=""mb-40"">
                                        <h4 class=""checkout-title"">Billing Address</h4>
                                        <div class=""row"">
                                            <div class=""col-md-6 col-12 mb--20"">
                                                <label>First Name*</label>
                                                <input type=""text"" placeholder=""First Name"">
                                            </div>
                                            <div class=""col-md-6 col-12 mb--20"">
                                                <label>Last Name*</label>
                                                <input type=""text"" placeholder=""Last Name"">
                                    ");
            WriteLiteral(@"        </div>
                                            <div class=""col-12 mb--20"">
                                                <label>Company Name</label>
                                                <input type=""text"" placeholder=""Company Name"">
                                            </div>
                                            <div class=""col-12 col-12 mb--20"">
                                                <label>Country*</label>
                                                <select class=""nice-select"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283ca52114acfaddd96f6688cc9f412a95759a6215237", async() => {
                WriteLiteral("Bangladesh");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283ca52114acfaddd96f6688cc9f412a95759a6216252", async() => {
                WriteLiteral("China");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283ca52114acfaddd96f6688cc9f412a95759a6217262", async() => {
                WriteLiteral("country");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283ca52114acfaddd96f6688cc9f412a95759a6218274", async() => {
                WriteLiteral("India");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283ca52114acfaddd96f6688cc9f412a95759a6219284", async() => {
                WriteLiteral("Japan");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </select>
                                            </div>
                                            <div class=""col-md-6 col-12 mb--20"">
                                                <label>Email Address*</label>
                                                <input type=""email"" placeholder=""Email Address"">
                                            </div>
                                            <div class=""col-md-6 col-12 mb--20"">
                                                <label>Phone no*</label>
                                                <input type=""text"" placeholder=""Phone number"">
                                            </div>
                                            <div class=""col-12 mb--20"">
                                                <label>Address*</label>
                                                <input type=""text"" placeholder=""Address line 1"">
                                                <inp");
            WriteLiteral(@"ut type=""text"" placeholder=""Address line 2"">
                                            </div>
                                            <div class=""col-md-6 col-12 mb--20"">
                                                <label>Town/City*</label>
                                                <input type=""text"" placeholder=""Town/City"">
                                            </div>
                                            <div class=""col-md-6 col-12 mb--20"">
                                                <label>State*</label>
                                                <input type=""text"" placeholder=""State"">
                                            </div>
                                            <div class=""col-md-6 col-12 mb--20"">
                                                <label>Zip Code*</label>
                                                <input type=""text"" placeholder=""Zip Code"">
                                            </div>
                              ");
            WriteLiteral(@"              <div class=""col-12 mb--20 "">
                                                <div class=""block-border check-bx-wrapper"">
                                                    <div class=""check-box"">
                                                        <input type=""checkbox"" id=""create_account"">
                                                        <label for=""create_account"">Create an Acount?</label>
                                                    </div>
                                                    <div class=""check-box"">
                                                        <input type=""checkbox"" id=""shiping_address"" data-shipping>
                                                        <label for=""shiping_address"">Ship to Different Address</label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
         ");
            WriteLiteral(@"                           </div>
                                    <!-- Shipping Address -->
                                    <div id=""shipping-form"" class=""mb--40"">
                                        <h4 class=""checkout-title"">Shipping Address</h4>
                                        <div class=""row"">
                                            <div class=""col-md-6 col-12 mb--20"">
                                                <label>First Name*</label>
                                                <input type=""text"" placeholder=""First Name"">
                                            </div>
                                            <div class=""col-md-6 col-12 mb--20"">
                                                <label>Last Name*</label>
                                                <input type=""text"" placeholder=""Last Name"">
                                            </div>
                                            <div class=""col-md-6 col-12 mb--20"">
            ");
            WriteLiteral(@"                                    <label>Email Address*</label>
                                                <input type=""email"" placeholder=""Email Address"">
                                            </div>
                                            <div class=""col-md-6 col-12 mb--20"">
                                                <label>Phone no*</label>
                                                <input type=""text"" placeholder=""Phone number"">
                                            </div>
                                            <div class=""col-12 mb--20"">
                                                <label>Company Name</label>
                                                <input type=""text"" placeholder=""Company Name"">
                                            </div>
                                            <div class=""col-12 mb--20"">
                                                <label>Address*</label>
                                                <input type");
            WriteLiteral(@"=""text"" placeholder=""Address line 1"">
                                                <input type=""text"" placeholder=""Address line 2"">
                                            </div>
                                            <div class=""col-md-6 col-12 mb--20"">
                                                <label>Country*</label>
                                                <select class=""nice-select"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283ca52114acfaddd96f6688cc9f412a95759a6226105", async() => {
                WriteLiteral("Bangladesh");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283ca52114acfaddd96f6688cc9f412a95759a6227120", async() => {
                WriteLiteral("China");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283ca52114acfaddd96f6688cc9f412a95759a6228130", async() => {
                WriteLiteral("country");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283ca52114acfaddd96f6688cc9f412a95759a6229142", async() => {
                WriteLiteral("India");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "283ca52114acfaddd96f6688cc9f412a95759a6230152", async() => {
                WriteLiteral("Japan");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </select>
                                            </div>
                                            <div class=""col-md-6 col-12 mb--20"">
                                                <label>Town/City*</label>
                                                <input type=""text"" placeholder=""Town/City"">
                                            </div>
                                            <div class=""col-md-6 col-12 mb--20"">
                                                <label>State*</label>
                                                <input type=""text"" placeholder=""State"">
                                            </div>
                                            <div class=""col-md-6 col-12 mb--20"">
                                                <label>Zip Code*</label>
                                                <input type=""text"" placeholder=""Zip Code"">
                                            </div>
               ");
            WriteLiteral(@"                         </div>
                                    </div>
                                    <div class=""order-note-block mt--30"">
                                        <label for=""order-note"">Order notes</label>
                                        <textarea id=""order-note"" cols=""30"" rows=""10"" class=""order-note""
                                                  placeholder=""Notes about your order, e.g. special notes for delivery.""></textarea>
                                    </div>
                                </div>
                                <div class=""col-lg-5"">
                                    <div class=""row"">
                                        <!-- Cart Total -->
                                        <div class=""col-12"">
                                            <div class=""checkout-cart-total"">
                                                <h2 class=""checkout-title"">YOUR ORDER</h2>
                                                <h4>Produc");
            WriteLiteral("t <span>Total</span></h4>\r\n                                                <ul>\r\n");
#nullable restore
#line 230 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\PustokP201\PustokP201\Views\Book\Checkout.cshtml"
                                                     foreach (var item in Model)
                                                    {
                                                        decimal salePrice = item.Book.DiscountPercent > 0 ? (item.Book.SalePrice*(1-item.Book.DiscountPercent/100)) : item.Book.SalePrice;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <li>\r\n                                                            <span class=\"left\">");
#nullable restore
#line 235 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\PustokP201\PustokP201\Views\Book\Checkout.cshtml"
                                                                          Write(item.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" X ");
#nullable restore
#line 235 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\PustokP201\PustokP201\Views\Book\Checkout.cshtml"
                                                                                            Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"right\">$");
#nullable restore
#line 235 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\PustokP201\PustokP201\Views\Book\Checkout.cshtml"
                                                                                                                                     Write((salePrice*item.Count).ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                        </li>\r\n");
#nullable restore
#line 237 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\PustokP201\PustokP201\Views\Book\Checkout.cshtml"

                                                        total+=(salePrice * item.Count);
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                                </ul>\r\n                                                <p>Sub Total <span>$");
#nullable restore
#line 243 "C:\Users\Eagha\Desktop\CodeLessons\P201\ASP\Pustok\50. 21-12-2021\PustokP201\PustokP201\Views\Book\Checkout.cshtml"
                                                               Write(total.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                                               
                                                <div class=""method-notice mt--25"">
                                                    <article>
                                                        <h3 class=""d-none sr-only"">blog-article</h3>
                                                        Sorry, it seems that there are no available payment methods for
                                                        your state. Please contact us if you
                                                        require
                                                        assistance
                                                        or wish to make alternate arrangements.
                                                    </article>
                                                </div>
                                                <div class=""term-block"">
                                                    <input type=""checkbox""");
            WriteLiteral(@" id=""accept_terms2"">
                                                    <label for=""accept_terms2"">
                                                        I’ve read and accept the terms &
                                                        conditions
                                                    </label>
                                                </div>
                                                <button class=""place-order w-100"">Place order</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </main>
   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CheckoutItemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
