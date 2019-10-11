using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tareas.Models
{
    public class Ticket
    {
        public int TicketId{get;set;}

        public string Status {get;set; }

        public string AsignatedTo {get; set; }
        public string Description {get; set; }

        public string StatusSeleccionado{ get; set;}         
             
    }
}