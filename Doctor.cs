// Doctor.cs
using System;
using System.Collections.Generic;

public class Doctor {
    public string Name { get; set; }
    public string Specialization { get; set; }
    private List<Patient> AssignedPatients { get; } = new List<Patient>();

    public Doctor(string name, string specialization) {
        Name = name;
        Specialization = specialization;
    }

    public void AssignPatient(Patient patient) {
        AssignedPatients.Add(patient);
    }

    public void DisplayInfo() {
        Console.WriteLine("Doctor Information:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Specialization: {Specialization}");
    }

    public void DisplayAssignedPatients() {
        Console.WriteLine("Assigned Patients:");
        foreach (var patient in AssignedPatients) {
            Console.WriteLine($"- {patient.Name}");
        }
    }
}
