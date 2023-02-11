SELECT W1.id AS Id
FROM Weather AS W1
WHERE W1.temperature > ANY(
    SELECT temperature
    FROM Weather AS W2
    WHERE W1.id != W2.id
    AND DATEDIFF(day, W2.recordDate, W1.recordDate) = 1
);