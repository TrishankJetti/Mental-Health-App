SELECT Name, Price, Description
FROM Products
WHERE Category = 1 
  AND Price > 10.00
ORDER BY Price ASC;