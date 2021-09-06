using System;
using System.Text;

namespace Library
{
    
    public class Doctor 
     {
         public string Name { get; set;}
         public string Special { get; set;}
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
            if (isValid)
            {
                stringBuilder.Append("Appointment Scheduled");
                this.Name = doctorName;
                this.Special = especialidad;
               Console.WriteLine(stringBuilder.ToString());

            }
            else 
            {
                Console.WriteLine("No se pudo crear la cita.");
            }
            

        }
     }
}