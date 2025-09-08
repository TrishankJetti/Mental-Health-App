SELECT TOP 1
    u.Id,
    u.FirstName,
    u.LastName,
    AVG(CAST(me.Mood AS INT)) AS AverageMoodScore 
FROM
    AspNetUsers AS u
JOIN
    MoodEntries AS me ON u.Id = me.UserId
GROUP BY
    u.Id, u.FirstName, u.LastName
ORDER BY
    AverageMoodScore DESC;