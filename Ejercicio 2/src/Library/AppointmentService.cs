using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(string id,string appoinmentPlace)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;


            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            return stringBuilder.ToString();
        }

    }


}


