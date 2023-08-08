using Microsoft.AspNetCore.Components;
using Radzen;

namespace CalendarioForestal.Pages
{
    public partial class Actividades
    {
        protected int count;
        protected bool isEdit = true;

        public class DataItem
        {
            public string Start { get; set; } = "";
            public string End { get; set; } = "";
            public string Nombre { get; set; } = "";
            public string Detalles { get; set; } = "";
            public string FaseLunar { get; set; } = "";
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
            model.Start = Start.AddDays(-1).ToString("dd/MM/yyyy");
            model.End = End.AddDays(1).ToString("dd/MM/yyyy");
            model.Nombre = Nombre;
            model.Detalles = Detalles;
            model.FaseLunar = FaseLunar;
            model.Epoca = Epoca;
            model.Tiempo = Tiempo;
            model.Arbol = Arbol;
            model.CambioSol = CambioSol;
            model.Cuatrimestre = Cuatrimestre;

        }
    }
}
