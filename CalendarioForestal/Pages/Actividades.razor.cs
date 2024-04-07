using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Radzen;

namespace CalendarioForestal.Pages
{
    public partial class Actividades
    {
        protected int count;
        protected bool isEdit = true;

        public class DataItem
        {
            public string Cenit { get; set; } = "";
            public string Start { get; set; } = "";
            public string End { get; set; } = "";
            public string Nombre { get; set; } = "";
            public string Detalles { get; set; } = "";
            public string FaseLunar { get; set; } = "";
            public string RutaFase { get; set; } = "";
            public string Epoca { get; set; } = "";
            public string Tiempo { get; set; } = "";
            public string Arbol { get; set; } = "";
            public string CambioSol { get; set; } = "";
            public string Cuatrimestre { get; set; } = "";
        }


        [Parameter]
        public DateTime Start { get; set; }

        [Parameter]
        public DateTime End { get; set; }

        [Parameter]
        public string Nombre { get; set; } = "";

        [Parameter]
        public string Detalles { get; set; } = "";

        [Parameter]
        public string FaseLunar { get; set; } = "";

        [Parameter]
        public string Epoca { get; set; } = "";

        [Parameter]
        public string Tiempo { get; set; } = "";

        [Parameter]
        public string Arbol { get; set; } = "";

        [Parameter]
        public string CambioSol { get; set; } = "";

        [Parameter]
        public string Cuatrimestre { get; set; } = "";

        DataItem model = new DataItem();

        protected override void OnParametersSet()
        {
            model.Cenit = Start.ToString("dd/MM/yyyy");
            model.Start = Start.AddDays(-3).ToString("dd/MM/yyyy");
            model.End = End.AddDays(3).ToString("dd/MM/yyyy");
            model.Nombre = Nombre;
            model.Detalles = Detalles;
            model.FaseLunar = FaseLunar;
            model.Epoca = Epoca;
            model.Tiempo = Tiempo;
            model.Arbol = Arbol;
            model.CambioSol = CambioSol;
            model.Cuatrimestre = Cuatrimestre;
            if (FaseLunar == "Luna Llena")
            {
                model.RutaFase = "images/llena.png";
            }
            else if (FaseLunar == "Cuarto Creciente")
            {
                model.RutaFase = "images/creciente.png";
            }
            else if (FaseLunar == "Cuarto Menguante")
            {
                model.RutaFase = "images/menguante.png";
            }
            else if (FaseLunar == "Luna Nueva")
            {
                model.RutaFase = "images/nueva.png";
            }

        }

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                // Scroll to the top of the page
                JSRuntime.InvokeAsync<object>("scrollToTop");
            }
        }
    }
}
