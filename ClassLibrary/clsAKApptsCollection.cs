using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class clsAKApptsCollection
    {

        //private data member to store he booking date
        private DateTime mApptDate;
        //data connection with class level scope
        clsDataConnection DB = new clsDataConnection();
        //private data member for the list of appointments
        private List<clsAKAppts> mAppts = new List<clsAKAppts>();


        //constructor for the class
        public clsAKApptsCollection(DateTime ADate)
        {
            //get appointments for this date
            FilterByDate(ADate);
            //remember the date used
            mApptDate = ADate;
        }

        //public list of appointments
        public List<clsAKAppts> Appts
        {
            get
            {
                return mAppts;
            }
        }

        //use dto generate the list of appointments
        private List<clsAKAppts> GetSchedule()
        {
            //list of appts for this function
            List<clsAKAppts> mAvailableAppts = new List<clsAKAppts>();
            //loop through the times of day 9 - 16
            for (Int32 SomeTime = 9; SomeTime < 17; SomeTime++)
            {
                //check to see if this time has an existing booking
                Int32 Index = HasBooking(SomeTime);
                //if the returned entry is <0 then it does not
                if (Index < 0)
                {
                    //create a new blank slot
                    clsAKAppts NewAppt = new clsAKAppts();
                    //record the primary key as -time
                    NewAppt.ApptNo = -SomeTime;
                    //store the date using the private data member
                    NewAppt.ApptDate = mApptDate;
                    //recod the time
                    NewAppt.ApptTime = SomeTime;
                    //set the reason to blank
                    NewAppt.ApptReason = "";
                    //add it to the list
                    mAvailableAppts.Add(NewAppt);
                }
                else //if the time has a booking
                {
                    //create a new blank appt
                    clsAKAppts NewAppt = new clsAKAppts();
                    //record the appt no from the db
                    NewAppt.ApptNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ApptNo"]);
                    //redord the appt date
                    NewAppt.ApptDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ApptDate"]);
                    //record the time
                    NewAppt.ApptTime = Convert.ToInt32(DB.DataTable.Rows[Index]["ApptTime"]);
                    //record the reason
                    NewAppt.ApptReason = Convert.ToString(DB.DataTable.Rows[Index]["ApptReason"]);
                    //add it to the list
                    mAvailableAppts.Add(NewAppt);
                }
            }
            //return the list to anybody who wants to know
            return mAvailableAppts;
        }

        private Int32 HasBooking(Int32 SomeTime)
        //checks to see if a time for the recorded date has a booking
        {
            //index for the loop
            Int32 Index = 0;
            //Boolean var to indicate if an entry is found
            Boolean Found = false;
            //loop through any records for this dat from th edatabase
            while (Index < DB.Count & Found == false)
            {
                //if a record is found
                if (SomeTime == Convert.ToInt32(DB.DataTable.Rows[Index]["ApptTime"]))
                {
                    //set found to true which will make the loop end
                    Found = true;
                }
                else
                {
                    //otherwise keep on searching to the end
                    Index++;
                }
            }
            if (Found) //if a record is found for this time
            {
                return Index;//return the index of the entry 0 or above
            }
            else
            {
                return -1;//return -1 indicating it wasn't found
            }
        }

        private void FilterByDate(DateTime ApptDate)
        //filters the data in the table based on the data in question
        {
            //reinitialise the data connection
            DB = new clsDataConnection();
            //add parameter for the date
            DB.AddParameter("@ApptDate", ApptDate);
            //execute the stored procedure
            DB.Execute("sproc_tblAKAppts_FilterByDate");
            //get the appt schedule for this date
            mAppts = GetSchedule();
        }

        //returns the count of appts
        public Int32 Count
        {
            get
            {
                return mAppts.Count;
            }
        }

        public void AddBooking(Int32 ApptTime, string ApptReason)
        //adds a new appt to the table
        {
            //reinitialise the data connection
            DB = new clsDataConnection();
            //send the procedure the parameters
            DB.AddParameter("@ApptDate", mApptDate);
            DB.AddParameter("@ApptTime", ApptTime);
            DB.AddParameter("@ApptReason", ApptReason);
            //add the new record
            DB.Execute("sproc_tblAKAppts_Insert");
        }
    }
}