SELECT 
    Category,
    AVG(Price) AS AveragePrice,
    COUNT(*) AS ProductCount
FROM Products
GROUP BY Category
HAVING COUNT(*) > 2
ORDER BY AveragePrice DESC;