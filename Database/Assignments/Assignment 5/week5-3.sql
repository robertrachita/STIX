-- Query that reduce concurrency

-- Explanation: This query shall 


-- Transaction 1, Adding a new cinema and set it with qualities and subtitles
BEGIN TRAN transaction_1
    INSERT INTO [dbo].[Cinema] (cinema_name, )

IF(@@ERROR > 0)
BEGIN
    ROLLBACK TRANSACTION transaction_1
END
ELSE
BEGIN
    COMMIT TRANSACTION transaction_1
END

-- Transaction 2, 

