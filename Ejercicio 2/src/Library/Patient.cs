using System;
using System.Text;

namespace Library
{    
     
     public class Patient 

     {
        public string Name { get; set;}
        public string Numero { get; set;}
        public string Edad { get; set;}

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
             if (string.IsNullOrEmpty(patientAge))
            {
                stringBuilder.Append("Unable to schedule appointment, Patient Age is required\n");
                isValid = false;
            return stringBuilder.ToString();
            if (isValid)
            {
                stringBuilder.Append("Appointment Scheduled");
                this.Name = name;
                this.Numero = phoneNumber;
                this.Edad = patientAge
               Console.WriteLine(stringBuilder.ToString());

            }
            else 
            {
                Console.WriteLine("No se pudo crear la cita.");
            }
            
        }
        return stringBuilder.ToString();

     } 
     
}