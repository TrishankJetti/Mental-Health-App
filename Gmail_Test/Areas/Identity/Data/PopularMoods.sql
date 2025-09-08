SELECT
    CASE Mood
        WHEN 1 THEN 'Happy'
        WHEN 2 THEN 'Sad'
        WHEN 3 THEN 'Angry'
        WHEN 4 THEN 'Stressed'
        WHEN 5 THEN 'Excited'
        WHEN 6 THEN 'Neutral'
        ELSE 'Unknown'
    END AS MoodName,
    COUNT(*) AS NumberOfEntries
FROM MoodEntries
GROUP BY Mood
ORDER BY NumberOfEntries DESC;
