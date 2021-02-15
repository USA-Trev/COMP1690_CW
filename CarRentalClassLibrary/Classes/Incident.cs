using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalClassLibrary.Classes
{
    public class Incident
    {
        public string description { get; set; }
        public string incidentDate { get; set; }

        public Incident()
        {

        }

        public Incident(string Description, string IncidentDate)
        {
            this.description = Description;
            this.incidentDate = IncidentDate;
        }
    }
}
