SELECT p.FirstName, p.LastName, a.AppointmentDate
FROM Patients p
JOIN Appointments a ON p.PatientId = a.PatientId
WHERE a.AppointmentDate = (
    SELECT MAX(AppointmentDate)
    FROM Appointments
    WHERE PatientId = p.PatientId
);

/*THis query selects the fields FistName and LAstName from the Patients table and AppointmentDate from the Appointments table. The Query then Joins the Appointments table with the Patients field where the PatientId from the Appointment table matches the PatientsID from the PAtients table. Then the Query selects all records where Appointment Date, from the Appointments table, is MAXIMUM or the Highest amongst the data. */