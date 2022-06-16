-- 1.) How many Netflix users there are
SELECT COUNT(user_id) AS 'Total number of users'
FROM User;

-- 2.) How many Netflix profiles there are

--  3.) How many Netflix subscriptions there are
SELECT COUNT(subscription_id) AS Netflix_subscrpitions
FROM Subscription 

-- 4.) How many films there are
SELECT COUNT(cinema_id) AS films 
FROM [dbo].[Cinema] C
JOIN [dbo][Season] S ON C.cinema_id = S.cinema_id

--  5.) What the average users age is
SELECT AVG()

-- 6.) What the combined age of all users is
SELECT SUM()
FROM [dbo].[Profile]

-- 7.) How many different subtitles there are in the database


-- 8.) How many people have been invited to join by other users


-- 9.) How many items there are that users still want to watch


-- 10.) Which preferences I can set up as user


-- 11.) How many people have a subscription
SELECT COUNT(user_id) AS 
FROM

-- 12.) How many people are currently watching for free
SELECT COUNT(user_id) AS free_users
FROM [dbo].[Users]
WHERE (
    SELECT DATEPART(DAY, GETDATE()) - DATEPART(DAY, [Users].activation_date)
) < 7

-- 13.) How many minutes users have watched in total


-- 14.) How often Dutch subtitling has been used
SELECT COUNT(viewedlist_id) AS dutch_subtitle_used
FROM [ViewedList] V
INNER JOIN Cinema C ON C.cinema_id = V.cinema_id
WHERE 

-- 15.) How often no subtitling has been used
SELECT COUNT(viewedlist_id) AS no_subtitle
FROM [dbo].[ViewedList]
WHERE subtitle_id = NULL

-- 16.) Which users have more than 4 profiles
SELECT email AS user_name 
FROM Users
WHERE EXISTS (
    SELECT COUNT(*)
    FROM [dbo].[Profile]
    WHERE [Users].user_id = [Profile].user_id
    GROUP BY user_id
    HAVING COUNT(*) > 1
)

--  17.) Which users have watched the film 'Stenden'
SELECT profile_name AS stenden_lovers
FROM [dbo].[Profile] P
WHERE 



--  18.) How many users prefer horror
SELECT COUNT(profile_id) AS horror_enjoyer 
FROM [dbo].[Profile]


-- 19.) Which users have no preference



-- 20.) Which users are not yet activated
SELECT email AS non_activated_users
FROM [dbo].[User]
WHERE activation_date IS NULL

-- 21.) How many euros are earned per month
SELECT SUM(price) AS stonks_per_month -
CASE
    U.invited_user_id <> NULL
    THEN 2 ELSE 0
END
FROM Subscription S
INNER JOIN User U 
ON S.subscription_id = U.subscription_id

-- 22.) How many extra euros can be earned per month when all users who do not subscribe would take out a subscription


-- 23.) Which users have watched a film with English subtitles