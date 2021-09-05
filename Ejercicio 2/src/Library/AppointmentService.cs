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
     public class Doctor 
     {
         public static string InfoDoctor(string doctorName,string especialidad)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;
             
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }
             if (string.IsNullOrEmpty(especialidad))
            {
                stringBuilder.Append("Unable to schedule appointment, Speciality  is required\n");
                isValid = false;
            }
            return stringBuilder.ToString();
        }
     } 
     public class Patient 
     {
         public static string InfoPaciente (string name,string phoneNumber,string patientAge)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;
             
            if (string.IsNullOrEmpty(name)) 
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

             if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone Number  is required\n");
                isValid = false;
            }
             if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Patient Age is required\n");
                isValid = false;
            return stringBuilder.ToString();
        }
     } 

}


