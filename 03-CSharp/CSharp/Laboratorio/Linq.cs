using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    internal class Linq
    {
        public class Patient
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public string Sex { get; set; }
            public double Temperature { get; set; }
            public int HeartRate { get; set; }
            public string Specialty { get; set; }
            public int Age { get; set; }
            public bool Priority { get; set; }
        }

        private static List<Patient> List()
        {
            var patients = new List<Patient>
            {
                   new Patient { Id = 1, Name = "John", LastName = "Doe", Sex = "Male", Temperature = 36.8, HeartRate = 80, Specialty = "general medicine", Age = 44},
                   new Patient { Id = 2, Name = "Jane", LastName = "Doe", Sex = "Female", Temperature = 36.8, HeartRate = 70, Specialty = "general medicine", Age = 43},
                   new Patient { Id = 3, Name = "Junior", LastName = "Doe", Sex = "Male", Temperature = 36.8, HeartRate = 90, Specialty = "pediatrics", Age = 8},
                   new Patient { Id = 4, Name = "Mary", LastName = "Wien", Sex = "Female", Temperature = 36.8, HeartRate = 120, Specialty = "general medicine", Age = 20},
                   new Patient { Id = 5, Name = "Scarlett", LastName = "Somez", Sex = "Female", Temperature = 36.8, HeartRate = 110, Specialty = "general medicine", Age = 30},
                   new Patient { Id = 6, Name = "Brian", LastName = "Kid", Sex = "Male", Temperature = 39.8, HeartRate = 80, Specialty = "pediatrics", Age = 11}
            };

            return patients;
        }

        // 1.Extraer la lista de pacientes que sean de la especialidad pediatrics y que tengan menos de 10 años.
        public void PrimerEjercicio()
        {
            var patients = List();

            var patientFromPediatricsLessThan10 = patients.Where(x => x.Specialty == "pediatrics" && x.Age < 10).Select(x => x.Name);

            foreach (var patient in patientFromPediatricsLessThan10) 
            {
                Console.WriteLine($"Patient: {patient}");
            }
        }

        // 2. Queremos activar el protocolo de urgencia si hay algún paciente con ritmo cardíaco mayor que 100 o temperatura mayor a 39.

        public void SegundoEjercicio()
        {
            var patients = List();

            var patientsUrgency = patients.Where(x => x.HeartRate > 100 || x.Temperature > 39).Select(x => x.Name);

            foreach (var patient in patientsUrgency)
            {
                Console.WriteLine($"Patients with heartRate greater than 100 or temperature greater than 39: {patient}");
            }
        }

        // 3. No podemos atender a todos los pacientes hoy por lo que vamos a crear una nueva coleccion y reasignar a los pacientes de pediatrics a general medicine

        public void TercerEjercicio()
        {
            var patients = List();

            var pediatricsFromGeneralMedicine = patients.Where(x => x.Specialty == "pediatrics").ToList();

            foreach(var patient in pediatricsFromGeneralMedicine)
            {
                patient.Specialty = "general medicine";
            }

            var patientsFromGeneralMedicine = patients.Where(x => x.Specialty == "general medicine").ToList(); 

            foreach (var patient in patientsFromGeneralMedicine) 
            {
                Console.WriteLine($"Patients from general medicine: {patient.Name}");
            }

        }

        // 4. Queremos conocer de una sola consulta el numero de pacientes que estan asignado a general medicine y a pediatrics.
        
        public void CuartoEjercicio()
        {
            var patients = List();

            var patientsGroupByForSpecialty = patients.GroupBy(x => x.Specialty);

            foreach(var patient in patientsGroupByForSpecialty)
            {
                Console.WriteLine($"{patient.Key} => {patient.Count()} patients");
            }
        }

        // 5. Devuelve una lista nueva que por cada paciente se indique si tiene prioridad o no. Se tendrá prioridad si el ritmo cardiaco es mayor 100 o la temperatura es mayor a 39.

        public void QuintoEjercicio()
        {
            var patients = List();
            var patientsWithPriority = patients.Select(x => new Patient
            {
                Name = x.Name,
                Priority = x.HeartRate > 100 || x.Temperature > 39
            }).ToList();

            foreach (var patient in patientsWithPriority) 
            {
                Console.WriteLine($"Patient: {patient.Name} => Priority: {patient.Priority}");
            }
        }

        // 6. Queremos conocer de una sola consulta La edad media de pacientes asignados a pediatrics y general medicine.

        public void SextoEjercicio()
        {
            var patients = List();

            var patientsGroupByForSpecialty = patients.GroupBy(x => x.Specialty);

            foreach(var patient in patientsGroupByForSpecialty)
            {
                Console.WriteLine($"Edad media de los pacientes de {patient.Key} => {patient.Average(x => x.Age)}");
            }
        }
    }
}
