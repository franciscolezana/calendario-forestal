using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.JSInterop;
using Radzen;
using Radzen.Blazor;

namespace CalendarioForestal.Shared
{
    public partial class MainLayout
    {
        private bool sidebarExpanded = true;

        void SidebarToggleClick()
        {
            sidebarExpanded = !sidebarExpanded;
        }
    }
}
