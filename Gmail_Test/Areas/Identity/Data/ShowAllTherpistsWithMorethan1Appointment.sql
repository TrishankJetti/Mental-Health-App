SELECT t.FirstName AS TherapistName, COUNT(a.AppointmentId) AS TotalAppointments
FROM Therapists t
JOIN Appointments a ON t.TherapistId = a.TherapistId
GROUP BY t.FirstName
HAVING COUNT(a.AppointmentId) > 1;


/* This query selects all the Firstnames of Therapists in the Therapist table and renames that column to TherapistName and then it counts the amount of appointments that particualr THerapist has by counting the AppointmentIds. The query then presents this data as the TotalAppointments column. Then the Query joins the Appointments to the Therapists that have that same TherapistId in the Appointments table, while grouping them by Firstname. THe Query also only returns results where only THerapists with more than 1 Appointment can be shown. */