SELECT * FROM Patients WHERE PatientId IN (SELECT PatientId FROM Appointments);
