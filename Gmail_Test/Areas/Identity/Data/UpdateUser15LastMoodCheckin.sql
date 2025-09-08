UPDATE AspNetUsers
SET LastMoodCheckIn = GETDATE() 
WHERE Id = '15'; 