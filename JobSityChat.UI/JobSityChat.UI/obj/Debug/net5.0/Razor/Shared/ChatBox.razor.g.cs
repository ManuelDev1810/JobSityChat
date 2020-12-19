#pragma checksum "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/Shared/ChatBox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1da64a9b2d33ae802afba35cdc2c6f132299228"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "p");
                __builder2.AddContent(3, "Welcome to the chat room ");
                __builder2.OpenElement(4, "strong");
                __builder2.AddContent(5, 
#nullable restore
#line 8 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/Shared/ChatBox.razor"
                                             userName.Substring(0, userName.IndexOf('@'))

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(6, ", feel free to start a new conversation or get a stock quote.");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(7, "\n        ");
                __builder2.OpenElement(8, "form");
                __builder2.AddAttribute(9, "class", "needs-validation");
                __builder2.AddAttribute(10, "novalidate");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-row");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-md-10 mb-3");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "input-group");
                __builder2.AddMarkupContent(17, "<div class=\"input-group-prepend\"><span class=\"input-group-text\">Message:</span></div>\n                        ");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "type", "text");
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "placeholder", "Write a message...");
                __builder2.AddAttribute(22, "required");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/Shared/ChatBox.razor"
                                      userMessage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userMessage = __value, userMessage));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\n                        ");
                __builder2.OpenElement(26, "button");
                __builder2.AddAttribute(27, "type", "button");
                __builder2.AddAttribute(28, "class", "btn btn-primary");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/Shared/ChatBox.razor"
                                                                                Send

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "disabled", 
#nullable restore
#line 17 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/Shared/ChatBox.razor"
                                                                                                  !IsConnected

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(31, "<span class=\"oi oi-media-play\"></span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(32, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(33, "\n        Please log in to start a new conversation\n    ");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 31 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/Shared/ChatBox.razor"
 foreach (var message in messages)
{
    //Waiting for API to be ready
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "/Users/manueldejesusguerrerovasquez/Projects/JobSityChat/JobSityChat.UI/JobSityChat.UI/Shared/ChatBox.razor"
       

    private HubConnection hubConnection;
    private List<string> messages = new List<string>();
    private Guid userID;
    private string userName;
    private string userMessage;

    protected override async Task OnInitializedAsync()
    {
        //Setting the user
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        userName = user.Identity.Name;

        //Making the hub connection
        hubConnection = new HubConnectionBuilder()
        .WithUrl(NavigationManager.ToAbsoluteUri("https://localhost:5002/jobsity_chathub"))
        .Build();

        //Receving the message from the API
        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            var recceiveMessage = $"{user}: {message}";
            messages.Add(recceiveMessage);
            StateHasChanged();
        });

        await hubConnection.StartAsync();

        //NOTE
        //REDIRECT TO ERROR PAGE WHEN AN ERROR OCCUR
    }

    //Sending the message
    public Task Send()
    {
        var task =  hubConnection.SendAsync("SendMessage",
                new {
                    UserName = userName,
                    UserMessage = userMessage,
                    CreatedAt = DateTime.Now
                });

        //Cleaning the message input
        userMessage = String.Empty;

        return task;
    }


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
