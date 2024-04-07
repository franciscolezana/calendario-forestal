using CalendarioForestal.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Radzen;
using System.Net.Http.Json;

namespace CalendarioForestal.Pages
{
    public partial class Registros
    {
        [Inject]
        protected DialogService? DialogService { get; set; }
        private List<DataItem> DatosCalendar = new List<DataItem>();
        private List<Registro> dats = new List<Registro>();

        //public static List<DataItem> DatosCalendar = new List<DataItem>();
        protected override async Task OnInitializedAsync()
        {
        }

        protected async Task Scheduler0LoadData(SchedulerLoadDataEventArgs args)
        {
            if (DatosCalendar.Count == 0)
            {
                DatosCalendar = await GetDatosCalendario(args);
            }

        }

        void OnAppointmentRender(SchedulerAppointmentRenderEventArgs<DataItem> args)
        {
            // Highlight today in month view
            args.Attributes["style"] = "background: #80ba27";
        }


#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
        public async Task<List<DataItem>> GetDatosCalendario(SchedulerLoadDataEventArgs args)
        {
            List<DataItem> datosCalendario = new List<DataItem>();
            DateTime dayCompare = new DateTime();
            List<Registro>? registrosList = await Http.GetFromJsonAsync<List<Registro>>("api/Forestal/GetAllRegistros");
            int contadorAct = 480;
            try
            {
                for (int i = 0; i < registrosList.Count; i++)
                {
                    DateTime calendarDay = registrosList[i].Fecha;
                    DataItem dItem = new DataItem();
                    //Primer dia del mes
                    if (dayCompare.Year == 0001)
                    {
                        dayCompare = calendarDay;
                        dItem = new DataItem
                        {
                            Start = calendarDay.AddMinutes(contadorAct),
                            End = calendarDay.AddMinutes(contadorAct + 60),
                            Nombre = registrosList[i].NombreActividad,
                            Detalles = registrosList[i].DescripcionActividad,
                            FaseLunar = registrosList[i].NombreFaseLunar,
                            Epoca = registrosList[i].NombreEpoca,
                            Tiempo = registrosList[i].NombreTiempo,
                            Arbol = registrosList[i].NombreCicloArbol,
                            CambioSol = registrosList[i].NombreCambioSol,
                            Cuatrimestre = registrosList[i].NombreCuatrimestre
                        };
                    }
                    else
                    {
                        if (dayCompare == calendarDay)
                        {
                            dItem = new DataItem
                            {
                                Start = calendarDay.AddMinutes(contadorAct),
                                End = calendarDay.AddMinutes(contadorAct + 60),
                                Nombre = registrosList[i].NombreActividad,
                                Detalles = registrosList[i].DescripcionActividad,
                                FaseLunar = registrosList[i].NombreFaseLunar,
                                Epoca = registrosList[i].NombreEpoca,
                                Tiempo = registrosList[i].NombreTiempo,
                                Arbol = registrosList[i].NombreCicloArbol,
                                CambioSol = registrosList[i].NombreCambioSol,
                                Cuatrimestre = registrosList[i].NombreCuatrimestre
                            };
                        }
                        else
                        {
                            contadorAct = 480;
                            dayCompare = calendarDay;
                            dItem = new DataItem
                            {
                                Start = calendarDay.AddMinutes(contadorAct),
                                End = calendarDay.AddMinutes(contadorAct + 60),
                                Nombre = registrosList[i].NombreActividad,
                                Detalles = registrosList[i].DescripcionActividad,
                                FaseLunar = registrosList[i].NombreFaseLunar,
                                Epoca = registrosList[i].NombreEpoca,
                                Tiempo = registrosList[i].NombreTiempo,
                                Arbol = registrosList[i].NombreCicloArbol,
                                CambioSol = registrosList[i].NombreCambioSol,
                                Cuatrimestre = registrosList[i].NombreCuatrimestre
                            };
                        }
                    }
                    datosCalendario.Add(dItem);
                    contadorAct += 60;
                }
                return datosCalendario;

            }
            catch (Exception)
            {
                throw;
            }
        }
        #pragma warning restore CS8601 // Posible asignación de referencia nula
        #pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.


        protected async Task Scheduler0AppointmentSelect(Radzen.SchedulerAppointmentSelectEventArgs<DataItem> args)
        {
            await DialogService.OpenAsync<Actividades>("", new Dictionary<string, object>()  {
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
