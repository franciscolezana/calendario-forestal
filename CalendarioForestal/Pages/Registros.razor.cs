using CalendarioForestal.Models;
using Microsoft.AspNetCore.Components;
using Radzen;

namespace CalendarioForestal.Pages
{
    public partial class Registros
    {
        [Inject]
        protected DialogService? DialogService { get; set; }

        public static List<DataItem> datosCalendar = new List<DataItem>();

        protected override async Task OnInitializedAsync()
        {
        }

        protected async Task Scheduler0LoadData(Radzen.SchedulerLoadDataEventArgs args)
        {
            if (datosCalendar.Count == 0)
            {
                datosCalendar = await GetDatosCalendario(args);
            }
        }
        public async Task<List<DataItem>> GetDatosCalendario(Radzen.SchedulerLoadDataEventArgs args)
        {
            List<DataItem> datosCalendario = new List<DataItem>();
            return datosCalendario;
        }

        protected async Task Scheduler0AppointmentSelect(Radzen.SchedulerAppointmentSelectEventArgs<DataItem> args)
        {
            await DialogService.OpenAsync<Actividades>("Detalle de Actividad", new Dictionary<string, object>()  {
                { "Start", args.Start },
                { "End", args.End },
                { "Nombre", args.Data.Nombre },
                { "Detalles", args.Data.Detalles },
                { "FaseLunar", args.Data.FaseLunar },
                { "Epoca", args.Data.Epoca },
                { "Tiempo", args.Data.Tiempo },
                { "Arbol", args.Data.Arbol },
                { "CambioSol", args.Data.CambioSol },
                { "Cuatrimestre", args.Data.Cuatrimestre },
                 });
        }

    }
}
