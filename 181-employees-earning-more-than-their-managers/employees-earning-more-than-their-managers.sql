/* Write your T-SQL query statement below */
SELECT Emp.name as Employee
FROM Employee Emp
JOIN Employee Man ON Emp.managerId = Man.id
WHERE Emp.salary > Man.salary