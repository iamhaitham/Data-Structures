SELECT E2.name AS Employee
FROM Employee AS E1
INNER JOIN Employee AS E2 ON E1.id = E2.managerId
WHERE E2.salary > E1.salary;