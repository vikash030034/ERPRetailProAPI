#pragma checksum "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Emails\RegistrationEmail.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7068e3c2acad44c33a2b96fa3ec1615677300c84f6d18b86434a1343cb1ff973"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Emails_RegistrationEmail), @"mvc.1.0.view", @"/Views/Emails/RegistrationEmail.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7068e3c2acad44c33a2b96fa3ec1615677300c84f6d18b86434a1343cb1ff973", @"/Views/Emails/RegistrationEmail.cshtml")]
    #nullable restore
    public class Views_Emails_RegistrationEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.ViewModels.EmailTemplateViewModel>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7068e3c2acad44c33a2b96fa3ec1615677300c84f6d18b86434a1343cb1ff9733023", async() => {
                WriteLiteral(@"
    <title>Welcome to Auto Jazeera!</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
            color: #333;
        }

        .containerTUX12 {
            margin: auto;
        }

        .headerAutoJazeera {
            text-align: center;
        }

        .buttonAutoJazeera {
            display: inline-block;
            padding: 10px 20px;
            margin: 20px 0;
            font-size: 16px;
            color: white;
            background-color: #4CAF50;
            text-decoration: none;
            border-radius: 5px;
        }

        .featuresAutoJazeera {
            margin-top: 20px;
        }

        .featuresAutoJazeera li {
            margin-bottom: 10px;
        }
    </style>
");
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7068e3c2acad44c33a2b96fa3ec1615677300c84f6d18b86434a1343cb1ff9734783", async() => {
                WriteLiteral("\n    <div class=\"containerTUX12\">\n        <p style=\"text-align:center\">\n            <img width=\"180\" src=\"https://vehicleimages.blob.core.windows.net/images/Auto_JAZEERA_LOGO-removebg-preview.png\" alt=\"Logo\" />\n        </p>\n        <p>Dear ");
                Write(
#nullable restore
#line 47 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Emails\RegistrationEmail.cshtml"
                 Model.CompanyName

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@",</p>
        <p>Welcome to Auto Jazeera!</p>
        <p>We are thrilled to have you as a new dealer on our platform. At Auto Jazeera, we pride ourselves on providing a secure and seamless experience for buying and selling vehicles. Our commitment to integrity, transparency, and customer satisfaction sets us apart in the industry.</p>
        <p>Happy to see you on board! Here’s how to get started:</p>
        <p>To get started, please sign in using the link below:</p>
        <p><a");
                BeginWriteAttribute("href", " href=\"", 1612, "\"", 1640, 1);
                WriteAttributeValue("", 1619, 
#nullable restore
#line 52 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Emails\RegistrationEmail.cshtml"
                     Model.ApplicationUrl

#line default
#line hidden
#nullable disable
                , 1619, 21, false);
                EndWriteAttribute();
                WriteLiteral(@" class=""buttonAutoJazeera"">Sign In to Your Account</a></p>
        <p>If you have any questions or need assistance, our support team is here to help. Feel free to reach out to us at <a href=""mailto:support@autojazeera.com"">support@autojazeera.com</a> or +923123456789.</p>
        <p>We look forward to a successful partnership with you.</p>
        <p>Best regards,</p>
        <p>The Auto Jazeera Team</p>
        <div class=""featuresAutoJazeera"">
            <h3>Key Features of Auto Jazeera:</h3>
            <ul>
                <li>Secure Transactions: Ensuring safe and reliable vehicle transactions.</li>
                <li>Wide Reach: Connect with a vast network of buyers and sellers.</li>
                <li>Customer Support: Dedicated support to assist you at every step.</li>
            </ul>
        </div>
    </div>
");
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
            WriteLiteral("\n</html>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.ViewModels.EmailTemplateViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
