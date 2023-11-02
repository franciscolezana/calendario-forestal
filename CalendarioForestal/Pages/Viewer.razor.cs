using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;

namespace CalendarioForestal.Pages
{
    public partial class Viewer
    {
        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        protected int count;

        public class ImageModel
        {
            public string ImageURL { get; set; } = "";
        }

        [Parameter]
        public string imageURL { get; set; } = "";

        ImageModel model = new ImageModel();

        protected override void OnParametersSet()
        {
            model.ImageURL = imageURL;
        }


    }
}