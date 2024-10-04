SELECT p.ProductName, c.CategoryName
FROM Products p
LEFT JOIN Categories c ON p.CategoryId = c.CategoryId
ORDER BY p.ProductName;