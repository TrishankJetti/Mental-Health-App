UPDATE Appointments
SET Status = 'Canceled'
WHERE AppointmentDate < GETDATE() AND Status = 'Scheduled';


/* This query essentially updates the Appointments table and sets the Status to "Cancelled", where the AppointmentDate is less than the current Date with the use og "GETDAT()" function, and where tDhe Status is set to "Scheduled". */