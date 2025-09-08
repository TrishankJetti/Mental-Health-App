SELECT Id, FirstName, LastName, LastMoodCheckIn
FROM AspNetUsers
WHERE LastMoodCheckIn IS NULL OR LastMoodCheckIn < DATEADD(day, -7, GETDATE());