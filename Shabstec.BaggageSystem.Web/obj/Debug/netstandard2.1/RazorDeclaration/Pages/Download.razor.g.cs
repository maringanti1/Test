// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Shabstec.BaggageSystem.Web.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\_Imports.razor"
using Shabstec.BaggageSystem.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\_Imports.razor"
using Shabstec.BaggageSystem.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\_Imports.razor"
using Shabstec.BaggageSystem.Web.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\_Imports.razor"
using BlazorApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\_Imports.razor"
using BlazorApp.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\Pages\Download.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\Pages\Download.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\Pages\Download.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\Pages\Download.razor"
using BlazorApp.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\Pages\Download.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\Pages\Download.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/download")]
    public partial class Download : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\Pages\Download.razor"
       
    private bool loading;
    private IList<BrokerMessage> configurations;

    protected override async Task OnInitializedAsync()
    {
        AlertService.Clear();
        loading = true;
        configurations = await AccountService.GetAllMessages();
        loading = false;
    }
    //private async Task DownloadMessage(BrokerMessage configuration)
    //{
    //    AlertService.Clear();
    //    loading = true;
    //    //await AccountService.LaunchDeployment(configuration);
    //    AlertService.Success("Download completed successfully!", keepAfterRouteChange: true);
    //    loading = false;
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService AccountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAlertService AlertService { get; set; }
    }
}
#pragma warning restore 1591
