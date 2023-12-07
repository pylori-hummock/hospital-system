// Patient.cs
using System;

public class Patient {
    public string Name { get; set; }
    public int Age { get; set; }
    public string HealthCondition { get; set; }

    public Patient(string name, int age, string healthCondition) {
        Name = name;
        Age = age;
        HealthCondition = healthCondition;
    }

    public void DisplayInfo() {
        Console.WriteLine("Patient Information:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Health Condition: {HealthCondition}");
    }
}
