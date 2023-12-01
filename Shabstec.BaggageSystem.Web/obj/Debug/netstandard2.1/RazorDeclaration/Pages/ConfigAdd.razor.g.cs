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
#line 1 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
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
#line 2 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\Pages\ConfigAdd.razor"
using Microsoft.Azure.Cosmos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\Pages\ConfigAdd.razor"
using BlazorApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/configuration/add")]
    public partial class ConfigAdd : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 127 "C:\Repository\RabbitMQ\Shabstec.BaggageSystem\Shabstec.BaggageSystem.Web\Pages\ConfigAdd.razor"
       
    private Configuration model = new Configuration();
    private bool loading;

    private async void OnValidSubmit()
    {
        AlertService.Clear();

        loading = true;
        
        try
        {
            // Save the configuration using AccountService
            await AccountService.Baggage(model);
            AlertService.Success("Configuration added successfully", keepAfterRouteChange: true);
            NavigationManager.NavigateTo("configuration");
        }
        catch (Exception ex)
        {
            AlertService.Error(ex.Message);
            loading = false;
            StateHasChanged();
        }
    }

    private void ResetForm()
    {
        // Reset the form by creating a new Configuration object
        model = new Configuration();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountService AccountService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAlertService AlertService { get; set; }
    }
}
#pragma warning restore 1591
