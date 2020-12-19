// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace JobSityChat.UI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/_Imports.razor"
using JobSityChat.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/_Imports.razor"
using JobSityChat.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/Shared/ChatBox.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    public partial class ChatBox : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/Shared/ChatBox.razor"
       
    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private string userMessage;
    private string userName;

    protected override async Task OnInitializedAsync()
    {
        //Setting the user
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        userName = user.Identity.Name;

        //Making the hub connection
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/jobsity_chathub"))
            .Build();

        //Receving the message from the API
        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            var recceiveMessage = $"{user}: {message}";
            messages.Add(recceiveMessage);
            StateHasChanged();
        });
    }

    //Sending the message
    Task Send() =>
        hubConnection.SendAsync("SendMessage", userName, userName);

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        await hubConnection.DisposeAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591