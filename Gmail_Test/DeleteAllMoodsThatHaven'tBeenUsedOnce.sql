DELETE FROM MoodTypes
WHERE MoodTypeId NOT IN (
    SELECT MoodId 
    FROM MoodEntries 
    GROUP BY MoodId 
    HAVING COUNT(*) >= 1
);


/* This SQL query Delete all MoodTypes records from the MoodTypes table where the particular MoodTypeId Doesn't have one or more records associated to it. The Query does this by first gathering all the MoodId's frm the MoodEntries table and groups them by the MoodId then it Counts to see how many times each MoodId has been used using the "COunt()" fucntion. If the MoodId has the count of either 1 or more then it doesnt get deleted since these are the conditons for the record to be not deleted which is specified with the NOT INC  in the WHERE statement. */