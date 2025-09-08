SELECT u.FirstName, u.LastName
FROM AspNetUsers AS u
WHERE NOT EXISTS (
    SELECT 1
    FROM MoodEntries AS me
    WHERE me.UserId = u.Id AND me.Mood = 1 
);