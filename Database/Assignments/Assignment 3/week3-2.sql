-- Query #1: Total Number of Users--
SELECT COUNT(user_id) AS 'Total number of users' 
FROM [User];

-- Query #2: Total Number of Profiles --
SELECT COUNT(profile_id) AS 'Total number of profiles' 
FROM Profile;

-- Query #3: Total Number of Subscriptions --
SELECT COUNT(subscription_id) AS 'Total numbers of available subscriptions'
FROM Subscription

-- Query #4: Total number of movies--
SELECT COUNT(C.cinema_id) AS 'Total number of movies' 
FROM Cinema C
LEFT JOIN Season S
ON C.cinema_id = S.cinema_id
WHERE S.cinema_id IS NULL

-- Query #5: --
SELECT AVG(DATEDIFF(DAY, date_of_birth, GETDATE()) / 365.25) AS 'Average age of users'
FROM [User];

-- Query #6: --
SELECT SUM(DATEDIFF(DAY, date_of_birth, GETDATE()) / 365.25) AS 'Combined age of users'
FROM [User];

-- Query #7: --
SELECT COUNT(DISTINCT subtitle_text) AS 'Number of different subtitles'
FROM Subtitle;

-- Query #8: Users that have been invited by others--
SELECT COUNT(DISTINCT user_id) AS 'Number of invited users'
FROM [User]
WHERE invited_by IS NOT NULL;

-- Query #9: Unique Items on the WatchList --
SELECT COUNT(DISTINCT title_id) AS 'Unique items to be watched'
FROM Watchlist;

-- Query #10: List Preference Options--
SELECT name AS 'Preference options'
FROM sys.columns 
WHERE object_id = OBJECT_ID('Preference')
    AND name NOT LIKE '%id%';

-- Query #11: Total Number of Subscribed Users--
SELECT COUNT(user_id) AS 'Total number of subscribed users' 
FROM [User] 
WHERE subscription_id IS NOT NULL;


-- Query #12: Users that are watching for free--
SELECT COUNT(user_id) AS 'Total number of people that are watching for free'
FROM [User]
WHERE subscription_id IS NULL
    AND DATEDIFF(DAY, activation_date, GETDATE()) <= 7;

-- Query #13: Total Minutes Watched--
SELECT SUM((DATEPART(HOUR,duration) * 60) + DATEPART(MINUTE,duration)) AS 'Total minutes watched'
FROM Cinema
INNER JOIN ViewedList
ON Cinema.cinema_id = ViewedList.cinema_id;

-- Query #14: --
SELECT COUNT(L.language_id) AS 'Total number of times dutch was used as subtitle language'
FROM Language L
INNER JOIN Subtitle S
ON L.language_id = S.language_id
INNER JOIN Cinema C 
ON S.cinema_id = C.cinema_id
INNER JOIN ViewedList VL 
ON C.cinema_id = VL.cinema_id
WHERE LOWER(L.language_name) LIKE '%dutch%'

-- Query #15: Total Amount of Times no Subtitle has been used --
SELECT COUNT(viewed_list_id) AS 'Total number of times no subtitles were used'
FROM ViewedList
WHERE subtitle_id IS NULL

-- Query #16: All Users with more than 4 profiles --
SELECT user_id
    FROM Profile
    GROUP BY user_id
    HAVING Count(*) > 4;

-- Query #17: Which Users have watched the film Stenden  --
SELECT DISTINCT U.user_id AS 'Users that have watched the movie Stenden'
FROM [User] U
INNER JOIN Profile P
ON U.user_id = P.user_id
INNER JOIN ViewedList VL 
ON P.profile_id = VL.profile_id
INNER JOIN Cinema C 
ON VL.cinema_id = C.cinema_id
LEFT JOIN Season S 
ON C.cinema_id = S.cinema_id
WHERE S.cinema_id IS NULL
    AND C.cinema_name = 'Stenden'

-- Query #18: How many users prefer horror --
SELECT COUNT(DISTINCT P.user_id) AS 'Total number of users that like horror'
FROM Profile P 
INNER JOIN Preference PR
ON P.profile_id = PR.profile_id
INNER JOIN GenrePreference GPR
ON PR.preference_id = GPR.preference_id
INNER JOIN Genre G
ON GPR.genre_id = G.genre_id
WHERE G.genre_name LIKE '%horror%';

-- Query #19: Which Users have no preferences --
SELECT DISTINCT COUNT(P.user_id) AS 'Total number of users without preferences'
FROM [User] U
INNER JOIN Profile P
ON U.user_id = P.user_id
WHERE NOT EXISTS(
SELECT * 
FROM Profile
LEFT JOIN Preference PR
ON P.profile_id = PR.profile_id
WHERE PR.profile_id IS NULL
)



-- Query #20: Which Users are not yet activated--
SELECT user_id AS 'Users that have not been activated'
FROM [User]
WHERE activation_date IS NULL;

-- Query #21: Total Euros Earned --
SELECT ROUND(SUM(Sub.price),2) AS 'Total euros earned'
FROM Subscription Sub
INNER JOIN [User] U
ON Sub.subscription_id = U.subscription_id;

-- Query #22: Potential Revenue --
SELECT MIN(price) * (SELECT COUNT(*) FROM [User] WHERE subscription_id IS NULL)
FROM Subscription;

SELECT SUM(Sub.price) AS 'Euros that could be earned'
FROM Subscription Sub
LEFT JOIN [User] U 
ON Sub.subscription_id = U.subscription_id
WHERE U.subscription_id IS NULL
    AND Sub.subscription_id = 1;

-- Query #23: Users that watched with english subtitles --
SELECT DISTINCT U.user_id AS 'Users that have watched a movie with english subtitles'
FROM [User] U
INNER JOIN Profile P
ON U.user_id = P.user_id
INNER JOIN ViewedList VL
ON P.profile_id = VL.profile_id
INNER JOIN Subtitle Sub
ON VL.subtitle_id = Sub.subtitle_id
INNER JOIN Language L
ON Sub.language_id = L.language_id
WHERE L.language_name LIKE 'english';

-- Query #24: Users without UHD Subscriptions that have watched UHD movies --
SELECT U.user_id AS 'Users without a UHD subscription that have watched a UHD movie'
FROM [User] U
INNER JOIN Profile P 
ON U.user_id = P.user_id
INNER JOIN ViewedList VL
ON P.profile_id = VL.profile_id
INNER JOIN Cinema C
ON VL.cinema_id = C.cinema_id
INNER JOIN CinemaQuality CQ
ON C.cinema_id = CQ.cinema_id
INNER JOIN Quality Q
ON CQ.quality_id = Q.quality_id
LEFT JOIN Subscription Sub
ON U.subscription_id = Sub.subscription_id
WHERE q.quality_name LIKE 'UHD'
    AND (U.subscription_id IS NULL OR Sub.subscription_name NOT LIKE 'UHD');

-- Query #25: What the percentage is per subtitle that has been used to watch films --
SELECT Sub.subtitle_id, CAST(ROUND((COUNT(Sub.subtitle_id) * 100.0 / (SELECT COUNT(*) FROM ViewedList WHERE subtitle_id IS NOT NULL)),2) AS NUMERIC(10,2)) AS 'Percent'
FROM Subtitle Sub
INNER JOIN ViewedList VL
ON Sub.subtitle_id = VL.subtitle_id
GROUP BY Sub.subtitle_id;

-- Query #26: Most Used Subtitle per User - Excluding Native language :( --
SELECT TOP 1 P.profile_id, Sub.subtitle_id, COUNT(Sub.subtitle_id) AS 'Count of the most used subtitle of the user'
FROM Profile P
INNER JOIN ViewedList VL 
ON P.profile_id = VL.profile_id
INNER JOIN Subtitle Sub
ON VL.subtitle_id = Sub.subtitle_id
WHERE Sub.language_id != P.language_id
GROUP BY Sub.subtitle_id
ORDER BY 'Count of the most used subtitle of the user';

-- Query #27: Most watched genre for a specific user :(--
SELECT IF(COUNT(*) > 0 ? 'true' : 'false') AS 'Most watched genre is part of prefered genre list for user 1'
FROM Profile P
INNER JOIN Preference PR
ON P.profile_id = PR.profile_id
INNER JOIN GenrePreference GPR
ON PR.preference_id = GPR.preference_id
WHERE p.profile_id = 1
    AND GPR.genre_id IN (
        SELECT TOP 1 genre_id
        FROM Profile IP
        INNER JOIN ViewedList IVL
        ON IP.profile_id = IVL.profile_id
        INNER JOIN CinemaGenre ICG
        ON IVL.cinema_id = ICG.cinema_id
        GROUP BY ICG.genre_id
        ORDER BY COUNT(genre_id)
    );

-- Query #28: Genres viewed most on valentines day in Order --
SELECT G.genre_name AS 'Genre name', COUNT(genre_name) AS 'amount'
FROM Genre G 
INNER JOIN CinemaGenre CG
ON G.genre_id = CG.genre_id
INNER JOIN ViewedList VL
ON CG.cinema_id = VL.cinema_id
WHERE MONTH(date_watched) = 2
    AND DAY(date_watched) = 14
    AND G.genre_name IN ('Romantic Comedy', 'Action', 'Horror', 'Sci-fi', 'Anime')
GROUP BY G.genre_name
ORDER BY COUNT(G.genre_id) DESC;

