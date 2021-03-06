// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
namespace ERsimulation
{
	public class Patients
	{

		int patientID=0;
		string patientType;
		bool firstInLine = false;

		int countPatient; //How many patients in the waiting room

		//patient array
		public Patients[] patientArray = new Patients[10];

		//The line moves forward one by one if the first in line is gone
		public void MoveForward()
		{
			foreach (Patients patient in patientArray) {
                patientArray[i] = patientArray[i + 1];
			}

		}
        //The line moves backward one by one if the first in line is gone
        public void MoveBackward()
        {
            foreach (Patients patient in patientArray)
            {
                
                patientArray[i] = patientArray[i - 1];
            }
        }

        //generate a new patient with different chances to be green, red or yellow
        public Patients GeneratePatient()
		{
			Patients newPatient = new Patients();
			patientID++;
			int rand = Random.Next(1,100);
			if (rand< 10) {
				patientType = "red";
			}
			if (rand >= 10 && rand < 40) {
				patientType = "red";
			} else
				patientType = "green";
			return newPatient;
		}

		//put 10 patients in a line
		public void MakeLine()
		{
			for (int i=0; i<patientArray.Length; i++) {
				patientArray[i] = GeneratePatient();
			}

		}



        //generate a new patient and get him in line base on his type
		public void NewPatientInLine()
		{
			Patients newPatient = new Patients();
            newPatient = GeneratePatient();

            if (newPatient.patientType == green || newPatient.patientType == yellow) {
				patientArray [10] = newPatient;
			}
            if(newPatient.patientType == red)
            {
                patientArray[0] = newPatient;
            }

			countPatient++;
		}

	}
    static int Main(string[] args)
    {
        Patients patient = new Patients();
        patient.MakeLine();
        Console.WriteLine(patient.patientArray);
    }
}

