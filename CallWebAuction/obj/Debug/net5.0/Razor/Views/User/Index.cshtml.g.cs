#pragma checksum "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c306a3c401ffc7a06cc36f43c84074d171d7966d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\_ViewImports.cshtml"
using CallWebAuction;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\_ViewImports.cshtml"
using CallWebAuction.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c306a3c401ffc7a06cc36f43c84074d171d7966d", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abba4d2281b6bfbe0e057aceb4d86a929decc823", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CallWebAuction.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\User\Index.cshtml"
  
    ViewData["AdminView"] = "Index";
    int stt = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Left Sidebar End -->
<!-- ============================================================== -->
<!-- Start right Content here -->
<!-- ============================================================== -->
<!-- Start right Content here -->
<!-- ============================================================== -->
<div class=""content-page"">
    <!-- Start content -->
    <div class=""content"">
        <div class=""container-fluid"">
            <div class=""page-title-box"">
                <div class=""wrapper-editor"">

                    <div class=""block my-4"">
                        <div class=""d-flex justify-content-center"">
                            <p class=""h5 text-primary createShowP"">0 row selected</p>
                        </div>
                    </div>

                    <div class=""row d-flex justify-content-center modalWrapper"">


                        <div class=""text-center"">
                            <a href=""https://localhost:44363/user/create"" class=""btn btn-info");
            WriteLiteral(@" btn-rounded btn-sm"">
                                Add<i class=""fas fa-plus-square ml-1""></i>

                            </a>
                        </div>


                        <div class=""text-center buttonEditWrapper"">
                            <button class=""btn btn-info btn-rounded btn-sm buttonEdit"">
                                Edit<i class=""fas fa-pencil-square-o ml-1""></i>
                            </button>
                        </div>

                        <div class=""modal fade"" id=""modalDelete"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modalDelete""
                             aria-hidden=""true"">
                            <div class=""modal-dialog"" role=""document"">
                                <div class=""modal-content"">
                                    <div class=""modal-header text-center"">
                                        <h4 class=""modal-title w-100 font-weight-bold ml-5 text-danger"">Delete</h4>
                                        <");
            WriteLiteral(@"button type=""button"" class=""close text-danger"" data-dismiss=""modal"" aria-label=""Close"">
                                            <span aria-hidden=""true"">&times;</span>
                                        </button>
                                    </div>
                                    <div class=""modal-body mx-3"">
                                        <p class=""text-center h4"">Are you sure to delete selected row?</p>

                                    </div>
                                    <div class=""modal-footer d-flex justify-content-center deleteButtonsWrapper"">
                                        <button type=""button"" class=""btn btn-danger btnYesClass"" id=""btnYes"" data-dismiss=""modal"">Yes</button>
                                        <button type=""button"" class=""btn btn-primary btnNoClass"" id=""btnNo"" data-dismiss=""modal"">No</button>
                                    </div>
                                </div>
                            </div>
             ");
            WriteLiteral(@"           </div>

                        <div class=""text-center"">
                            <button class=""btn btn-danger btn-sm btn-rounded buttonDelete"" data-toggle=""modal"" data-target=""#modalDelete"">
                                Delete<i class=""fas fa-times ml-1""></i>
                            </button>
                        </div>
                    </div>

                    <table id=""dtBasicExample"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
                        <thead>
                            <tr>
                                <th class=""th-sm"">
                                    #
                                </th>
                                <th class=""th-sm"">
                                    Id

                                </th>
                                <th class=""th-sm"">
                                    Name

                                </th>
                                <th class=""th-sm"">
");
            WriteLiteral(@"                                    UserName

                                </th>
                                <th class=""th-sm"">
                                    Password

                                </th>
                                <th class=""th-sm"">
                                    Coin
                                </th>
                                <th class=""th-sm"">
                                    Email
                                </th>
                                <th class=""th-sm"">
                                    Phone
                                </th>
                                <th class=""th-sm"">
                                    Role
                                </th>
                                <th class=""th-sm"">
                                    CreateDate
                                </th>
                            </tr>
                        </thead>

");
#nullable restore
#line 112 "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\User\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tbody>\r\n                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 117 "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\User\Index.cshtml"
                                    Write(stt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 120 "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\User\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 123 "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\User\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 126 "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\User\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 129 "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\User\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 132 "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\User\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Coin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 135 "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\User\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 138 "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\User\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 141 "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\User\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.roles.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 144 "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\User\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </td>
                                    <td>

                                        <div class=""text-center buttonEditWrapper"">
                                            <a class=""btn btn-info btn-rounded btn-sm buttonEdit""");
            BeginWriteAttribute("href", " href=\"", 7217, "\"", 7243, 2);
            WriteAttributeValue("", 7224, "/User/Edit/", 7224, 11, true);
#nullable restore
#line 149 "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\User\Index.cshtml"
WriteAttributeValue("", 7235, item.Id, 7235, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                Edit<i class=\"fas fa-pencil-square-o ml-1\"></i>\r\n                                            </a>\r\n                                            <a class=\"btn btn-info btn-rounded btn-sm buttonEdit\"");
            BeginWriteAttribute("href", " href=\"", 7491, "\"", 7519, 2);
            WriteAttributeValue("", 7498, "/User/Delete/", 7498, 13, true);
#nullable restore
#line 152 "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\User\Index.cshtml"
WriteAttributeValue("", 7511, item.Id, 7511, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                Delete<i class=""fas fa-pencil-square-o ml-1""></i>
                                            </a>
                                        </div>

                                    </td>
                                </tr>
                            </tbody>
");
#nullable restore
#line 160 "C:\Users\KienNguyen\Desktop\B8764_Nguyen_Khac_Hoa_lu_c2002m\CallWebAuction\Views\User\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </table>
                </div>

            </div>

        </div>
        <!-- END ROW -->

    </div>
    <!-- container-fluid -->

</div>
<!-- content -->
<script type=""text/javascript"">
    $('#dtBasicExample').mdbEditor({
        mdbEditor: true
    });
    $('.dataTables_length').addClass('bs-select');
</script>
<!-- ============================================================== -->
<!-- End Right content here -->
<!-- ============================================================== -->
<!-- END wrapper -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CallWebAuction.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
