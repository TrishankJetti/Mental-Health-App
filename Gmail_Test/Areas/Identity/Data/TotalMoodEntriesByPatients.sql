SELECT p.FirstName, p.LastName, COUNT(m.Id) AS TotalMoodLogs
FROM Patients p
JOIN MoodEntries m ON p.PatientId = m.PatientId
WHERE m.MoodId IN (
    SELECT MoodTypeId FROM MoodTypes WHERE Name IN ('Happy', 'Sad')
)
GROUP BY p.FirstName, p.LastName
ORDER BY TotalMoodLogs DESC;


/* This query returms the FistName and LAstName fields from the Patients table and then counts the MoodId or its alias "m" as the field TotalMoodLogs. THen the Query joins the MoodENtries table with the Patients fields but check where the PatientId from the MoodEntries Table is set the same as the PatientId form the PAtients table. The Query additonalyl checks the MoodId field from the MoodEntries table whioch is linked to the MoodTypeId in the MoodType table via One to Many, If the Name field of the MoodTypes table is either Happy or Sad. And then the Query groups the results by FirstName and LastName while ordering the TotalmoodLogs by Descending order. */