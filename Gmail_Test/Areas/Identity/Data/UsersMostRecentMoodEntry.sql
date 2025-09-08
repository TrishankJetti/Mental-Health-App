SELECT 
    u.FirstName,
    u.LastName,
    CASE me.Mood
      WHEN 1 THEN 'Happy'
        WHEN 2 THEN 'Sad'
        WHEN 3 THEN 'Angry'
        WHEN 4 THEN 'Stressed'
        WHEN 5 THEN 'Excited'
        WHEN 6 THEN 'Neutral'
        ELSE 'Unknown'
    END AS MoodName,
    me.Date,
    me.Notes
FROM AspNetUsers u
CROSS APPLY (
    SELECT TOP 1 
        m.Mood,
        m.Date,
        m.Notes
    FROM MoodEntries m
    WHERE m.UserId = u.Id
    ORDER BY m.Date DESC
) me;
