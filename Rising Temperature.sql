/*
    Solution 1
*/
SELECT W1.id AS Id
FROM Weather AS W1
WHERE W1.temperature > ANY(
    SELECT temperature
    FROM Weather AS W2
    WHERE W1.id != W2.id
    AND DATEDIFF(day, W2.recordDate, W1.recordDate) = 1
);



/*
    Solution 2
*/
SELECT W2.id AS Id
FROM Weather AS W1
LEFT JOIN Weather AS W2 ON DATEADD(day, 1, W1.recordDate) = W2.recordDate
WHERE W2.temperature > W1.temperature 