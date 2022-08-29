CREATE TABLE [dbo].[BookDetails]
(
                [BookId] [int] IDENTITY(1,1) NOT NULL,
                [BookName] [varchar](100),
                [Author] [varchar](100),
                [Publisher] [varchar](200),
                [Price] [decimal](18, 2) NOT NULL
)

CREATE PROCEDURE InsertBookDetails
                @BookName                    VARCHAR(100),
                @Author                             VARCHAR(100),
                @Publisher                        VARCHAR(200),
                @Price                                 DECIMAL(18,2)
AS
BEGIN
                INSERT INTO BookDetails
                 (
                                BookName,Author,Publisher,Price
                  )
                VALUES
                 (
                                @BookName,@Author,@Publisher,@Price
                 )
END

CREATE PROCEDURE UpdateBookRecord
                @BookId                            INT,
                @BookName                    VARCHAR(100),
                @Author                             VARCHAR(100),
                @Publisher                        VARCHAR(200),
                @Price                                 DECIMAL(18,2)
AS
BEGIN
                UPDATE BookDetails SET
                                BookName=@BookName,
                                Author=@Author,
                                Publisher=@Publisher,
                                Price=@Price
                WHERE BookId=@BookId
END

CREATE PROCEDURE DeleteBookRecords
                @BookId            INT
AS
BEGIN
                DELETE FROM BookDetails WHERE BookId=@BookId
END

CREATE PROCEDURE FetchBookRecords
AS
BEGIN
                SELECT * FROM BookDetails
END
