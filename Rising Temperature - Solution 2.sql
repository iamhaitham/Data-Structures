SELECT W2.id AS Id
FROM Weather AS W1
LEFT JOIN Weather AS W2 ON DATEADD(day, 1, W1.recordDate) = W2.recordDate
WHERE W2.temperature > W1.temperature 