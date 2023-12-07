// HospitalManagementSystem.cs
class HospitalManagementSystem {
    static void Main() {
        // Create patients
        Patient patient1 = new Patient("John Doe", 25, "Fever");
        Patient patient2 = new Patient("Jane Smith", 30, "Broken Leg");

        // Create doctors
        Doctor doctor1 = new Doctor("Dr. Smith", "Cardiologist");
        Doctor doctor2 = new Doctor("Dr. Johnson", "Orthopedic Surgeon");

        // Assign patients to doctors
        doctor1.AssignPatient(patient1);
        doctor2.AssignPatient(patient2);

        // Display information
        patient1.DisplayInfo();
        patient2.DisplayInfo();

        doctor1.DisplayInfo();
        doctor1.DisplayAssignedPatients();

        doctor2.DisplayInfo();
        doctor2.DisplayAssignedPatients();
    }
}
