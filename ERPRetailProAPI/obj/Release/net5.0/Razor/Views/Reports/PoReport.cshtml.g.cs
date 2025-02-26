#pragma checksum "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "07d79f15512706f3783686ba3a32669fecd374a6e7c0650ccd12ead56b6a49bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reports_PoReport), @"mvc.1.0.view", @"/Views/Reports/PoReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"07d79f15512706f3783686ba3a32669fecd374a6e7c0650ccd12ead56b6a49bc", @"/Views/Reports/PoReport.cshtml")]
    #nullable restore
    public class Views_Reports_PoReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Data.Models.PurchaseOrder>>
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
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d79f15512706f3783686ba3a32669fecd374a6e7c0650ccd12ead56b6a49bc2979", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Import Logs Report</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH"" crossorigin=""anonymous"" />
    <style>
        body {
            font-family: Arial, sans-serif;
            color: #333;
        }

        .header {
            text-align: center;
            margin-bottom: 20px;
        }

            .header img {
                max-width: 150px; /* Adjusted size for better alignment */
                margin-bottom: 10px;
            }

            .header h1 {
                font-size: 2.5rem;
                font-weight: bold;
                color: #007BFF;
                margin: 0; /* Remove default margin */
            }

        .lbl {
            font-size: 1rem;
            font-weight: bold;
        }

        .table {
            ");
                WriteLiteral(@"width: 100%;
            border-collapse: collapse;
            margin-bottom: 0px;
            border: none !important;
        }

        .footer {
            text-align: center;
            border-top: 3px solid #007BFF;
            padding-top: 10px;
            margin-top: 20px;
            color: #6c757d;
            font-size: 0.9em;
        }

        thead {
            display: table-header-group;
        }

        tbody {
            display: table-row-group;
            page-break-inside: avoid;
        }

            tbody td {
                text-align: start;
            }

        tr {
            page-break-inside: avoid;
            page-break-after: auto;
        }

        .no-border {
            border: 0 !important;
        }

            .no-border td {
                border: 0 !important;
            }

        .width-20 {
            width: 20%;
        }

        .width-30 {
            width: 30%;
        }

        .tablehead{
            color:white;
            background: #");
                WriteLiteral("007BFF;\n            padding:3px;\n        }\n    </style>\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07d79f15512706f3783686ba3a32669fecd374a6e7c0650ccd12ead56b6a49bc6157", async() => {
                WriteLiteral("\n\n    <div class=\"container\">\n        <div class=\"header\">\n            <div class=\"d-flex justify-content-center align-items-center\">\n                <img src=\"https://i.imgur.com/jCyOVvg.png\" alt=\"Inventory360 Logo\" />\n            </div>\n        </div>\n");
#nullable restore
#line 102 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable

                WriteLiteral(@"            <table class=""table no-border"">
                <thead>
                    <th colspan=""4"" class=""tablehead"">
                    Purchase Report
                    </th>
                </thead>
                <tbody>
                    <tr>
                        <td class=""lbl width-20"">Stock Number:</td>
                        <td class=""width-30"">");
                Write(
#nullable restore
#line 113 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                              item.StockNumber

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                        <td class=\"lbl width-20\">Date:</td>\n                        <td class=\"width-30\">");
                Write(
#nullable restore
#line 115 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                              item.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                    </tr>\n                </tbody>\n            </table>\n            <table class=\"table no-border\">\n                <tbody>\n                <td class=\"lbl width-20\">First Name:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 122 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.FirstName

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                <td class=\"lbl width-20\">Last Name:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 124 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.LastName

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                </tbody>\n            </table>\n            <table class=\"table no-border\">\n                <tbody>\n                <td class=\"lbl width-20\">Email:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 130 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.Email

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                <td class=\"lbl width-20\">Phone Number:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 132 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                </tbody>\n            </table>\n            <table class=\"table no-border\">\n                <tbody>\n                <td class=\"lbl width-20\">Street Address:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 138 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.StreetAddress

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                <td class=\"lbl width-20\">Street Address Line 2:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 140 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.StreetAddress2

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                </tbody>\n            </table>\n            <table class=\"table no-border\">\n                <tbody>\n                <td class=\"lbl width-20\">Province:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 146 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.State

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                <td class=\"lbl width-20\">City:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 148 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.City

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                </tbody>\n            </table>\n            <table class=\"table no-border\">\n                <tbody>\n                <td class=\"lbl width-20\">Your Order:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 154 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.OrderType

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                <td class=\"lbl width-20\">Vehicle ID Number:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 156 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.VehicleID

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                </tbody>\n            </table>\n            <table class=\"table no-border\">\n                <tbody>\n                <td class=\"lbl width-20\">Milage:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 162 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.Mileage

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                <td class=\"lbl width-20\">Plate Number:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 164 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.PlateNumber

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                </tbody>\n            </table>\n            <table class=\"table no-border\">\n                <tbody>\n                <td class=\"lbl width-20\">Expiration Date:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 170 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.ExpirationDate.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                <td class=\"lbl width-20\">Delivery Date:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 172 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.DeliveryDate.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                </tbody>\n            </table>\n            <table class=\"table no-border\">\n                <tbody>\n                <td class=\"lbl width-20\">Additional Information About Vehicle:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 178 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.AdditionalInfo

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                <td class=\"lbl width-20\">Vehicle Price:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 180 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.VehiclePrice

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                </tbody>\n            </table>\n            <table class=\"table no-border\">\n                <tbody>\n                <td class=\"lbl width-20\">Cost(s) & Fee(s) Description:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 186 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.AdditionalCost1Description

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                <td class=\"lbl width-20\">Price $:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 188 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.AdditionalCost1Price

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                </tbody>\n            </table>\n            <table class=\"table no-border\">\n                <tbody>\n                <td class=\"lbl width-20\">Cost(s) & Fee(s) Description:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 194 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.AdditionalCost2Description

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                <td class=\"lbl width-20\">Price $:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 196 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.AdditionalCost2Price

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                </tbody>\n            </table>\n            <table class=\"table no-border\">\n                <tbody>\n                <td class=\"lbl width-20\">Cost(s) & Fee(s) Description:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 202 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.AdditionalCost3Description

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                <td class=\"lbl width-20\">Price $:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 204 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.AdditionalCost3Price

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                </tbody>\n            </table>\n            <table class=\"table no-border\">\n                <tbody>\n                <td class=\"lbl width-20\">Make:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 210 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.TradeInMake

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                <td class=\"lbl width-20\">Model:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 212 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.TradeInModel

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                </tbody>\n            </table>\n            <table class=\"table no-border\">\n                <tbody>\n                <td class=\"lbl width-20\">Color:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 218 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.TradeInColor

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</td>\n                <td class=\"lbl width-20\">Year:</td>\n                <td class=\"width-30\">");
                Write(
#nullable restore
#line 220 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
                                      item.TradeInYear

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"</td>
                </tbody>
            </table>
            <table class=""table no-border"">
                <thead>
                <th colspan=""4"" class=""tablehead"">
                    End Purchase Report
                </th>
                </thead>
                <tbody>
                <td class=""lbl width-20""></td>
                <td class=""width-30""></td>
                <td class=""lbl width-20""></td>
                <td class=""width-30""></td>
                </tbody>
            </table>
");
#nullable restore
#line 236 "F:\invent-backend_backuptillTask1\invent-backend_backuptillTask1\Inventory360API\Views\Reports\PoReport.cshtml"
        }

#line default
#line hidden
#nullable disable

                WriteLiteral("    </div>\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz\" crossorigin=\"anonymous\"></script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Data.Models.PurchaseOrder>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
