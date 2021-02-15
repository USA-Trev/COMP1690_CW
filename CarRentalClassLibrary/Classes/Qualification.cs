using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalClassLibrary.Classes
{
    public class Qualification
    {
        public string qualificationTitle { get; set; }
        public string qualificationExpr { get; set; }
        public string qualificationReminder { get; set; }

        public Qualification()
        {

        }

        public Qualification(string QualificationTitle, string QualificationExpr, string QualificationReminder)
        {
            this.qualificationTitle = QualificationTitle;
            this.qualificationExpr = QualificationExpr;
            this.qualificationReminder = QualificationReminder;
        }
    }
}
