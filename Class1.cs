using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Training
    {
        private string location;
        private int days;
        private static int trainingCounter;
        private int trainingID;
        private DateTime startDate, endDate;
        public enum Skills { DotNet, Java, Testing }
        public string LOCATION
        {
            get { return location; }
            set { location = value; }
        }
        public Skills SKILL { get; set; }
        public int TRAINING_ID
        {
            get { return trainingID; }
            private set { trainingID = value; }
        }
        public int DAYS
        {
            get { return days; }
            set
            {
                if (value > 0 && value < 50)
                {
                    days = value;
                }
                else
                {
                    Console.WriteLine("Wrong Number of Days");
                };
            }
        }
        public DateTime START_DATE
        {
            get { return startDate; }
            set
            {
                if (value > DateTime.Now)
                {
                    startDate = value;
                }
                else
                {
                    Console.WriteLine("Date entered must be in the future");
                };
            }
        }
        public DateTime END_DATE
        {
            get { return endDate; }
            set
            {
                if (value > startDate)
                {
                    endDate = value;
                }
                else
                {
                    Console.WriteLine("End date must be after start date");
                };
            }
        }
        static Training()
        {
            trainingCounter= 0;
        }
        public Training()
        {
           this.TRAINING_ID = ++trainingCounter;
        }
    }
}