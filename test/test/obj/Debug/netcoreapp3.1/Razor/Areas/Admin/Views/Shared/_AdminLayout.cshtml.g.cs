#pragma checksum "C:\Users\Ferid\Desktop\Code Academy\BackEnd\test\test\Areas\Admin\Views\Shared\_AdminLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27a8e8031b50b63cd6e09d27e70f68d4f38bd9b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__AdminLayout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_AdminLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27a8e8031b50b63cd6e09d27e70f68d4f38bd9b5", @"/Areas/Admin/Views/Shared/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27a8e8031b50b63cd6e09d27e70f68d4f38bd9b53046", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"" />
    <meta
      name=""viewport""
      content=""width=device-width, initial-scale=1, shrink-to-fit=no""
    />
    <title>Corona Admin</title>
    <!-- plugins:css -->
    <link
      rel=""stylesheet""
      href=""assets/vendors/mdi/css/materialdesignicons.min.css""
    />
    <link rel=""stylesheet"" href=""assets/vendors/css/vendor.bundle.base.css"" />
    <!-- endinject -->
    <!-- Plugin css for this page -->
    <link
      rel=""stylesheet""
      href=""assets/vendors/jvectormap/jquery-jvectormap.css""
    />
    <link
      rel=""stylesheet""
      href=""assets/vendors/flag-icon-css/css/flag-icon.min.css""
    />
    <link
      rel=""stylesheet""
      href=""assets/vendors/owl-carousel-2/owl.carousel.min.css""
    />
    <link
      rel=""stylesheet""
      href=""assets/vendors/owl-carousel-2/owl.theme.default.min.css""
    />
    <!-- End plugin css for this page -->
    <!-- inject:css -->
    <!-- endinject -->
    <!-- L");
                WriteLiteral("ayout styles -->\r\n    <link rel=\"stylesheet\" href=\"assets/css/style.css\" />\r\n    <!-- End layout styles -->\r\n    <link rel=\"shortcut icon\" href=\"assets/images/favicon.png\" />\r\n  ");
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
            WriteLiteral("\r\n  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27a8e8031b50b63cd6e09d27e70f68d4f38bd9b55294", async() => {
                WriteLiteral(@"
    <div class=""container-scroller"">
      <!-- partial:partials/_sidebar.html -->
      <nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
        <div
          class=""sidebar-brand-wrapper d-none d-lg-flex align-items-center justify-content-center fixed-top""
        >
          <a class=""sidebar-brand brand-logo"" href=""index.html""
            ><img src=""assets/images/logo.svg"" alt=""logo""
          /></a>
          <a class=""sidebar-brand brand-logo-mini"" href=""index.html""
            ><img src=""assets/images/logo-mini.svg"" alt=""logo""
          /></a>
        </div>
        <ul class=""nav"">
          <li class=""nav-item profile"">
            <div class=""profile-desc"">
              <div class=""profile-pic"">
                <div class=""count-indicator"">
                  <img
                    class=""img-xs rounded-circle""
                    src=""assets/images/faces/face15.jpg""");
                BeginWriteAttribute("alt", "\r\n                    alt=\"", 2180, "\"", 2207, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                  />
                  <span class=""count bg-success""></span>
                </div>
                <div class=""profile-name"">
                  <h5 class=""mb-0 font-weight-normal"">Henry Klein</h5>
                  <span>Gold Member</span>
                </div>
              </div>
              <a href=""#"" id=""profile-dropdown"" data-toggle=""dropdown""
                ><i class=""mdi mdi-dots-vertical""></i
              ></a>
              <div
                class=""dropdown-menu dropdown-menu-right sidebar-dropdown preview-list""
                aria-labelledby=""profile-dropdown""
              >
                <a href=""#"" class=""dropdown-item preview-item"">
                  <div class=""preview-thumbnail"">
                    <div class=""preview-icon bg-dark rounded-circle"">
                      <i class=""mdi mdi-settings text-primary""></i>
                    </div>
                  </div>
                  <div class=""preview-item-content"">
                    <p");
                WriteLiteral(@" class=""preview-subject ellipsis mb-1 text-small"">
                      Account settings
                    </p>
                  </div>
                </a>
                <div class=""dropdown-divider""></div>
                <a href=""#"" class=""dropdown-item preview-item"">
                  <div class=""preview-thumbnail"">
                    <div class=""preview-icon bg-dark rounded-circle"">
                      <i class=""mdi mdi-onepassword text-info""></i>
                    </div>
                  </div>
                  <div class=""preview-item-content"">
                    <p class=""preview-subject ellipsis mb-1 text-small"">
                      Change Password
                    </p>
                  </div>
                </a>
                <div class=""dropdown-divider""></div>
                <a href=""#"" class=""dropdown-item preview-item"">
                  <div class=""preview-thumbnail"">
                    <div class=""preview-icon bg-dark rounded-circle"">
            ");
                WriteLiteral(@"          <i class=""mdi mdi-calendar-today text-success""></i>
                    </div>
                  </div>
                  <div class=""preview-item-content"">
                    <p class=""preview-subject ellipsis mb-1 text-small"">
                      To-do list
                    </p>
                  </div>
                </a>
              </div>
            </div>
          </li>
          <li class=""nav-item nav-category"">
            <span class=""nav-link"">Navigation</span>
          </li>
          <li class=""nav-item menu-items"">
            <a class=""nav-link"" href=""index.html"">
              <span class=""menu-icon"">
                <i class=""mdi mdi-speedometer""></i>
              </span>
              <span class=""menu-title"">Dashboard</span>
            </a>
          </li>
          <li class=""nav-item menu-items"">
            <a
              class=""nav-link""
              data-toggle=""collapse""
              href=""#ui-basic""
              aria-expanded=""");
                WriteLiteral(@"false""
              aria-controls=""ui-basic""
            >
              <span class=""menu-icon"">
                <i class=""mdi mdi-laptop""></i>
              </span>
              <span class=""menu-title"">Basic UI Elements</span>
              <i class=""menu-arrow""></i>
            </a>
            <div class=""collapse"" id=""ui-basic"">
              <ul class=""nav flex-column sub-menu"">
                <li class=""nav-item"">
                  <a class=""nav-link"" href=""pages/ui-features/buttons.html""
                    >Buttons</a
                  >
                </li>
                <li class=""nav-item"">
                  <a class=""nav-link"" href=""pages/ui-features/dropdowns.html""
                    >Dropdowns</a
                  >
                </li>
                <li class=""nav-item"">
                  <a class=""nav-link"" href=""pages/ui-features/typography.html""
                    >Typography</a
                  >
                </li>
              </ul>
            ");
                WriteLiteral(@"</div>
          </li>
          <li class=""nav-item menu-items"">
            <a class=""nav-link"" href=""pages/forms/basic_elements.html"">
              <span class=""menu-icon"">
                <i class=""mdi mdi-playlist-play""></i>
              </span>
              <span class=""menu-title"">Form Elements</span>
            </a>
          </li>
          <li class=""nav-item menu-items"">
            <a class=""nav-link"" href=""pages/tables/basic-table.html"">
              <span class=""menu-icon"">
                <i class=""mdi mdi-table-large""></i>
              </span>
              <span class=""menu-title"">Tables</span>
            </a>
          </li>
          <li class=""nav-item menu-items"">
            <a class=""nav-link"" href=""pages/charts/chartjs.html"">
              <span class=""menu-icon"">
                <i class=""mdi mdi-chart-bar""></i>
              </span>
              <span class=""menu-title"">Charts</span>
            </a>
          </li>
          <li class=""nav-item menu");
                WriteLiteral(@"-items"">
            <a class=""nav-link"" href=""pages/icons/mdi.html"">
              <span class=""menu-icon"">
                <i class=""mdi mdi-contacts""></i>
              </span>
              <span class=""menu-title"">Icons</span>
            </a>
          </li>
          <li class=""nav-item menu-items"">
            <a
              class=""nav-link""
              data-toggle=""collapse""
              href=""#auth""
              aria-expanded=""false""
              aria-controls=""auth""
            >
              <span class=""menu-icon"">
                <i class=""mdi mdi-security""></i>
              </span>
              <span class=""menu-title"">User Pages</span>
              <i class=""menu-arrow""></i>
            </a>
            <div class=""collapse"" id=""auth"">
              <ul class=""nav flex-column sub-menu"">
                <li class=""nav-item"">
                  <a class=""nav-link"" href=""pages/samples/blank-page.html"">
                    Blank Page
                  </a>
   ");
                WriteLiteral(@"             </li>
                <li class=""nav-item"">
                  <a class=""nav-link"" href=""pages/samples/error-404.html"">
                    404
                  </a>
                </li>
                <li class=""nav-item"">
                  <a class=""nav-link"" href=""pages/samples/error-500.html"">
                    500
                  </a>
                </li>
                <li class=""nav-item"">
                  <a class=""nav-link"" href=""pages/samples/login.html"">
                    Login
                  </a>
                </li>
                <li class=""nav-item"">
                  <a class=""nav-link"" href=""pages/samples/register.html"">
                    Register
                  </a>
                </li>
              </ul>
            </div>
          </li>
          <li class=""nav-item menu-items"">
            <a
              class=""nav-link""
              href=""http://www.bootstrapdash.com/demo/corona-free/jquery/documentation/documentation.htm");
                WriteLiteral(@"l""
            >
              <span class=""menu-icon"">
                <i class=""mdi mdi-file-document-box""></i>
              </span>
              <span class=""menu-title"">Documentation</span>
            </a>
          </li>
        </ul>
      </nav>
      <!-- partial -->
      <div class=""container-fluid page-body-wrapper"">
        <!-- partial:partials/_navbar.html -->
        <nav class=""navbar p-0 fixed-top d-flex flex-row"">
          <div
            class=""navbar-brand-wrapper d-flex d-lg-none align-items-center justify-content-center""
          >
            <a class=""navbar-brand brand-logo-mini"" href=""index.html""
              ><img src=""assets/images/logo-mini.svg"" alt=""logo""
            /></a>
          </div>
          <div class=""navbar-menu-wrapper flex-grow d-flex align-items-stretch"">
            <button
              class=""navbar-toggler navbar-toggler align-self-center""
              type=""button""
              data-toggle=""minimize""
            >
          ");
                WriteLiteral(@"    <span class=""mdi mdi-menu""></span>
            </button>
            <ul class=""navbar-nav w-100"">
              <li class=""nav-item w-100"">
                <form class=""nav-link mt-2 mt-md-0 d-none d-lg-flex search"">
                  <input
                    type=""text""
                    class=""form-control""
                    placeholder=""Search products""
                  />
                </form>
              </li>
            </ul>
            <ul class=""navbar-nav navbar-nav-right"">
              <li class=""nav-item dropdown d-none d-lg-block"">
                <a
                  class=""nav-link btn btn-success create-new-button""
                  id=""createbuttonDropdown""
                  data-toggle=""dropdown""
                  aria-expanded=""false""
                  href=""#""
                  >+ Create New Project</a
                >
                <div
                  class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list""
                  a");
                WriteLiteral(@"ria-labelledby=""createbuttonDropdown""
                >
                  <h6 class=""p-3 mb-0"">Projects</h6>
                  <div class=""dropdown-divider""></div>
                  <a class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                      <div class=""preview-icon bg-dark rounded-circle"">
                        <i class=""mdi mdi-file-outline text-primary""></i>
                      </div>
                    </div>
                    <div class=""preview-item-content"">
                      <p class=""preview-subject ellipsis mb-1"">
                        Software Development
                      </p>
                    </div>
                  </a>
                  <div class=""dropdown-divider""></div>
                  <a class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                      <div class=""preview-icon bg-dark rounded-circle"">
                        <i class=""mdi mdi-web text-i");
                WriteLiteral(@"nfo""></i>
                      </div>
                    </div>
                    <div class=""preview-item-content"">
                      <p class=""preview-subject ellipsis mb-1"">
                        UI Development
                      </p>
                    </div>
                  </a>
                  <div class=""dropdown-divider""></div>
                  <a class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                      <div class=""preview-icon bg-dark rounded-circle"">
                        <i class=""mdi mdi-layers text-danger""></i>
                      </div>
                    </div>
                    <div class=""preview-item-content"">
                      <p class=""preview-subject ellipsis mb-1"">
                        Software Testing
                      </p>
                    </div>
                  </a>
                  <div class=""dropdown-divider""></div>
                  <p class=""p-3 mb-0 text-center""");
                WriteLiteral(@">See all projects</p>
                </div>
              </li>
              <li class=""nav-item nav-settings d-none d-lg-block"">
                <a class=""nav-link"" href=""#"">
                  <i class=""mdi mdi-view-grid""></i>
                </a>
              </li>
              <li class=""nav-item dropdown border-left"">
                <a
                  class=""nav-link count-indicator dropdown-toggle""
                  id=""messageDropdown""
                  href=""#""
                  data-toggle=""dropdown""
                  aria-expanded=""false""
                >
                  <i class=""mdi mdi-email""></i>
                  <span class=""count bg-success""></span>
                </a>
                <div
                  class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list""
                  aria-labelledby=""messageDropdown""
                >
                  <h6 class=""p-3 mb-0"">Messages</h6>
                  <div class=""dropdown-divider""></div>
      ");
                WriteLiteral(@"            <a class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                      <img
                        src=""assets/images/faces/face4.jpg""
                        alt=""image""
                        class=""rounded-circle profile-pic""
                      />
                    </div>
                    <div class=""preview-item-content"">
                      <p class=""preview-subject ellipsis mb-1"">
                        Mark send you a message
                      </p>
                      <p class=""text-muted mb-0"">1 Minutes ago</p>
                    </div>
                  </a>
                  <div class=""dropdown-divider""></div>
                  <a class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                      <img
                        src=""assets/images/faces/face2.jpg""
                        alt=""image""
                        class=""rounded-circle profile-pic""
        ");
                WriteLiteral(@"              />
                    </div>
                    <div class=""preview-item-content"">
                      <p class=""preview-subject ellipsis mb-1"">
                        Cregh send you a message
                      </p>
                      <p class=""text-muted mb-0"">15 Minutes ago</p>
                    </div>
                  </a>
                  <div class=""dropdown-divider""></div>
                  <a class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                      <img
                        src=""assets/images/faces/face3.jpg""
                        alt=""image""
                        class=""rounded-circle profile-pic""
                      />
                    </div>
                    <div class=""preview-item-content"">
                      <p class=""preview-subject ellipsis mb-1"">
                        Profile picture updated
                      </p>
                      <p class=""text-muted mb-0"">18 M");
                WriteLiteral(@"inutes ago</p>
                    </div>
                  </a>
                  <div class=""dropdown-divider""></div>
                  <p class=""p-3 mb-0 text-center"">4 new messages</p>
                </div>
              </li>
              <li class=""nav-item dropdown border-left"">
                <a
                  class=""nav-link count-indicator dropdown-toggle""
                  id=""notificationDropdown""
                  href=""#""
                  data-toggle=""dropdown""
                >
                  <i class=""mdi mdi-bell""></i>
                  <span class=""count bg-danger""></span>
                </a>
                <div
                  class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list""
                  aria-labelledby=""notificationDropdown""
                >
                  <h6 class=""p-3 mb-0"">Notifications</h6>
                  <div class=""dropdown-divider""></div>
                  <a class=""dropdown-item preview-item"">
                ");
                WriteLiteral(@"    <div class=""preview-thumbnail"">
                      <div class=""preview-icon bg-dark rounded-circle"">
                        <i class=""mdi mdi-calendar text-success""></i>
                      </div>
                    </div>
                    <div class=""preview-item-content"">
                      <p class=""preview-subject mb-1"">Event today</p>
                      <p class=""text-muted ellipsis mb-0"">
                        Just a reminder that you have an event today
                      </p>
                    </div>
                  </a>
                  <div class=""dropdown-divider""></div>
                  <a class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                      <div class=""preview-icon bg-dark rounded-circle"">
                        <i class=""mdi mdi-settings text-danger""></i>
                      </div>
                    </div>
                    <div class=""preview-item-content"">
                      <p");
                WriteLiteral(@" class=""preview-subject mb-1"">Settings</p>
                      <p class=""text-muted ellipsis mb-0"">Update dashboard</p>
                    </div>
                  </a>
                  <div class=""dropdown-divider""></div>
                  <a class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                      <div class=""preview-icon bg-dark rounded-circle"">
                        <i class=""mdi mdi-link-variant text-warning""></i>
                      </div>
                    </div>
                    <div class=""preview-item-content"">
                      <p class=""preview-subject mb-1"">Launch Admin</p>
                      <p class=""text-muted ellipsis mb-0"">New admin wow!</p>
                    </div>
                  </a>
                  <div class=""dropdown-divider""></div>
                  <p class=""p-3 mb-0 text-center"">See all notifications</p>
                </div>
              </li>
              <li class=""nav-item dropd");
                WriteLiteral(@"own"">
                <a
                  class=""nav-link""
                  id=""profileDropdown""
                  href=""#""
                  data-toggle=""dropdown""
                >
                  <div class=""navbar-profile"">
                    <img
                      class=""img-xs rounded-circle""
                      src=""assets/images/faces/face15.jpg""");
                BeginWriteAttribute("alt", "\r\n                      alt=\"", 19993, "\"", 20022, 0);
                EndWriteAttribute();
                WriteLiteral(@"
                    />
                    <p class=""mb-0 d-none d-sm-block navbar-profile-name"">
                      Henry Klein
                    </p>
                    <i class=""mdi mdi-menu-down d-none d-sm-block""></i>
                  </div>
                </a>
                <div
                  class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list""
                  aria-labelledby=""profileDropdown""
                >
                  <h6 class=""p-3 mb-0"">Profile</h6>
                  <div class=""dropdown-divider""></div>
                  <a class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                      <div class=""preview-icon bg-dark rounded-circle"">
                        <i class=""mdi mdi-settings text-success""></i>
                      </div>
                    </div>
                    <div class=""preview-item-content"">
                      <p class=""preview-subject mb-1"">Settings</p>
          ");
                WriteLiteral(@"          </div>
                  </a>
                  <div class=""dropdown-divider""></div>
                  <a class=""dropdown-item preview-item"">
                    <div class=""preview-thumbnail"">
                      <div class=""preview-icon bg-dark rounded-circle"">
                        <i class=""mdi mdi-logout text-danger""></i>
                      </div>
                    </div>
                    <div class=""preview-item-content"">
                      <p class=""preview-subject mb-1"">Log out</p>
                    </div>
                  </a>
                  <div class=""dropdown-divider""></div>
                  <p class=""p-3 mb-0 text-center"">Advanced settings</p>
                </div>
              </li>
            </ul>
            <button
              class=""navbar-toggler navbar-toggler-right d-lg-none align-self-center""
              type=""button""
              data-toggle=""offcanvas""
            >
              <span class=""mdi mdi-format-line-spacing""><");
                WriteLiteral("/span>\r\n            </button>\r\n          </div>\r\n        </nav>\r\n        ");
#nullable restore
#line 534 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\test\test\Areas\Admin\Views\Shared\_AdminLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
     </div>
      <!-- page-body-wrapper ends -->
    </div>
    <!-- container-scroller -->
    <!-- plugins:js -->
    <script src=""assets/vendors/js/vendor.bundle.base.js""></script>
    <!-- endinject -->
    <!-- Plugin js for this page -->
    <script src=""assets/vendors/chart.js/Chart.min.js""></script>
    <script src=""assets/vendors/progressbar.js/progressbar.min.js""></script>
    <script src=""assets/vendors/jvectormap/jquery-jvectormap.min.js""></script>
    <script src=""assets/vendors/jvectormap/jquery-jvectormap-world-mill-en.js""></script>
    <script src=""assets/vendors/owl-carousel-2/owl.carousel.min.js""></script>
    <!-- End plugin js for this page -->
    <!-- inject:js -->
    <script src=""assets/js/off-canvas.js""></script>
    <script src=""assets/js/hoverable-collapse.js""></script>
    <script src=""assets/js/misc.js""></script>
    <script src=""assets/js/settings.js""></script>
    <script src=""assets/js/todolist.js""></script>
    <!-- endinject -->
    <!-- Custom js for ");
                WriteLiteral("this page -->\r\n    <script src=\"assets/js/dashboard.js\"></script>\r\n    <!-- End custom js for this page -->\r\n  ");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
