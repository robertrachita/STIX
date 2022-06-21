-- Select cinema that is a tv series
USE Netflix 
SELECT cinema_name, cinema_description 
FROM cinema
WHERE cinema_id = (SELECT cinema_id FROM Season)
GO

-- Determine age from date of birth
SELECT YEAR(GETDATE()) - YEAR(dateOfBirth) AS Age 
FROM Profile

SELECT DATEDIFF(YY, dateOfBirth, GETDATE()) AS Age
FROM Profile

SELECT DATEDIFF(MONTH, dateOfBirth, GETDATE()) / 12 -
CASE 
    WHEN month(dateOfBirth) = MONTH(GETDATE()) AND DAY(dateOfBirth) > DAY(GETDATE()) 
    THEN 1 ELSE 0
END
AS Age 
FROM Profile

-- Check if a subtitle is part of a series


-- 


