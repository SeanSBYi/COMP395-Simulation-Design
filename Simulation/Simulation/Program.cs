using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Simulation
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }
    public class Patients
    {

        int patientID = 0;
        string patientType;
        bool firstInLine = false;

        int countPatient; //How many patients in the waiting room

        //patient array
        public Patients[] patientArray = new Patients[10];

        //The line moves forward one by one if the first in line is gone
        public void MoveForward()
        {
            int i=0;
            foreach (Patients patient in patientArray)
            {
                patientArray[i] = patientArray[i + 1];
            }

        }
        //The line moves backward one by one if the first in line is gone
        public void MoveBackward()
        {
            int i = 0;
            foreach (Patients patient in patientArray)
            {

                patientArray[i] = patientArray[i - 1];
            }
        }

        //generate a new patient with different chances to be green, red or yellow
        public  Patients GeneratePatient()
        {
            
            Patients newPatient = new Patients();
            patientID++;

            
            rand = Random.Next(1, 100);
            if (rand < 10)
            {
                patientType = "red";
            }
            if (rand >= 10 && rand < 40)
            {
                patientType = "red";
            }
            else
                patientType = "green";
            return newPatient;
        }

        //put 10 patients in a line
        public void MakeLine()
        {
            for (int i = 0; i < patientArray.Length; i++)
            {
                patientArray[i] = GeneratePatient();
            }

        }



        //generate a new patient and get him in line base on his type
        public void NewPatientInLine()
        {
            Patients newPatient = new Patients();
            newPatient = GeneratePatient();

            if (newPatient.patientType == "green" || newPatient.patientType == "yellow")
            {
                patientArray[10] = newPatient;
            }
            if (newPatient.patientType == "red")
            {
                patientArray[0] = newPatient;
            }

            countPatient++;
        }

    }
}
