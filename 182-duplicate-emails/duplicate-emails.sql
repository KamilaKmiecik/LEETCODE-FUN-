/* Write your T-SQL query statement below */
SELECT P.email AS Email
FROM Person P
GROUP BY P.email
HAVING COUNT(*) > 1;