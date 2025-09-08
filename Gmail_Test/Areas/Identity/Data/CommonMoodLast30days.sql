SELECT TOP 3 -- Use LIMIT 3 for MySQL/PostgreSQL
    CASE Mood
        WHEN 1 THEN 'Happy'
        WHEN 2 THEN 'Sad'
        WHEN 3 THEN 'Angry'
        WHEN 4 THEN 'Stressed'
        WHEN 5 THEN 'Excited'
        WHEN 6 THEN 'Neutral'
        ELSE 'Unknown'
    END AS MoodTypeName,
    COUNT(*) AS MoodCount
FROM MoodEntries
WHERE Date >= DATEADD(day, -30, GETDATE())
GROUP BY Mood
ORDER BY MoodCount DESC;