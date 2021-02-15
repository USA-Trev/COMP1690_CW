using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalClassLibrary.Classes
{
    public class TrainingSession
    {
        public string sessionDate { get; set; }
        public int sessionTime { get; set; }
        public int status { get; set; }

        public TrainingSession()
        {

        }

        public TrainingSession(string SessionDate, int SessionTime, int Status)
        {
            this.sessionDate = SessionDate;
            this.sessionTime = SessionTime;
            this.status = Status;
        }
    }
}
