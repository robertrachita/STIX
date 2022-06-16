-- Implement Primary Keys, Foreign Keys and Indexes
ALTER TABLE Cinema
ADD CONSTRAINT id PRIMARY KEY CLUSTERED(cinema_id)


    -- This clustered index will sort all the cinema the Netflix has from primary id and its cinema name on asceding order
CREATE CLUSTERED INDEX IX__Cinema
ON [dbo].[Cinema] (cinema_id ASC, cinema_name ASC)

-- Assign Contraints 


-- View 1, for all of the Cinema that is a series, show how many season, episode, and total duration it has
CREATE VIEW [Cinema].view_series
AS
SELECT C.cinema_name AS series_name, S.COUNT(season_id) AS seasons, E.COUNT(episode_id) AS episodes, total_minutes = SUM(DATEDIFF(HOUR, '0:00:00', E.episode_duration))
FROM Cinema C
WHERE C.cinema_id = (
    SELECT cinema_id FROM [Season] S
    WHERE S.season_id = (
        SELECT season_id FROM [Episode] E
    )
)
GROUP BY series_name
ORDER BY seasons ASC, episodes DESC

-- View 2,


-- Stored Procedure 1,


-- Stored Procedure 2,


-- Trigger 1, Checking when User has more than 3 failed attempts


-- Trigger 2, Checking when the movie is watched, it will removed from the watchlist


-- Referential Integrity
