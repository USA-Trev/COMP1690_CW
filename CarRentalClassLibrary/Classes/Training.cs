using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalClassLibrary.Classes
{
    public class Training
    {
        public string trainingTitle { get; set; }
        public string trainingExpr { get; set; }
        public string trainingReminder { get; set; }

        public Training()
        {

        }

        public Training(string TrainingTitle, string TrainingExpr, string TrainingReminder)
        {
            this.trainingTitle = TrainingTitle;
            this.trainingExpr = TrainingExpr;
            this.trainingReminder = TrainingReminder;
        }
    }
}
