SELECT CONCAT(c.FirstName, ', ', c.LastName) AS FullName,
       c.Age,
       o.OrderID,
       o.DateCreated,
       o.MethodofPurchase AS PurchaseMethod,
       od.ProductNumber,
       od.ProductOrigin
FROM Customer AS c
JOIN Orders AS o ON c.PersonID = o.PersonID
JOIN OrdersDetails AS od ON o.OrderID = od.OrderID
WHERE od.ProductID = 1112222333;