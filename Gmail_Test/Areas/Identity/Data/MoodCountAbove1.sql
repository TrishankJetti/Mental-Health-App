SELECT MoodId, COUNT(*) AS MoodCount
FROM MoodEntries
GROUP BY MoodId
HAVING COUNT(*) > 1;
