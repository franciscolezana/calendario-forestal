using Microsoft.AspNetCore.Components;
using Radzen;

namespace CalendarioForestal.Pages
{
    public partial class Biblioteca
    {
        [Inject]
        protected DialogService? DialogService { get; set; }

        public class bibliotecaItem
        {
            public string name { get; set; } = "";
            public string image { get; set; } = "";

        }

        List<bibliotecaItem> bibliotecaList = new List<bibliotecaItem>()
        {
            new bibliotecaItem() { name = "CALENDARIO 2020", image = "images/calendars/2020.jpg"},
            new bibliotecaItem() { name = "CALENDARIO 2021", image = "images/calendars/2021.jpg"},
            new bibliotecaItem() { name = "CALENDARIO 2022", image = "images/calendars/2022.jpg"},
            new bibliotecaItem() { name = "CALENDARIO 2023", image = "images/calendars/2023.jpg"},
            new bibliotecaItem() { name = "CALENDARIO 2024", image = "images/calendars/2024.jpg"},
            new bibliotecaItem() { name = "CALENDARIO 2025", image = "images/calendars/2025.jpg"},
            new bibliotecaItem() { name = "CALENDARIO 2026", image = "images/calendars/2026.jpg"},
            new bibliotecaItem() { name = "CALENDARIO 2027", image = "images/calendars/2027.jpg"},
            new bibliotecaItem() { name = "CALENDARIO 2028", image = "images/calendars/2028.jpg"},
            new bibliotecaItem() { name = "CALENDARIO 2029", image = "images/calendars/2029.jpg"},
            new bibliotecaItem() { name = "CALENDARIO 2030", image = "images/calendars/2030.jpg"},
            new bibliotecaItem() { name = "CALENDARIO 2031", image = "images/calendars/2031.jpg"},
            new bibliotecaItem() { name = "CALENDARIO 2032", image = "images/calendars/2032.jpg"}
        };

        public async Task<List<bibliotecaItem>> GetBibliotecaListAsync()
        {
            return await Task.FromResult(bibliotecaList);
        }

        IEnumerable<bibliotecaItem> bibliotecaFiles;
        protected override async Task OnInitializedAsync()
        {
            bibliotecaFiles = await Task.Run(() => GetBibliotecaListAsync());
        }

        protected async Task OpenViewer(string imageURL)
        {
            await DialogService.OpenAsync<Viewer>("", new Dictionary<string, object>()  {
                { "imageURL", imageURL }
                 });
        }

    }
}
