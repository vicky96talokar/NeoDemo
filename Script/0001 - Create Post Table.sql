/*
   Saturday, May 2, 20201:58:08 PM
   User: sa
   Server: VIVEK\SQLEXPRESS
   Database: ENTITY_FRAMEWORK2020
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Table_1
	(
	PostID int NOT NULL,
	DatePublished smalldatetime NOT NULL,
	Title varchar(50) NOT NULL,
	Body varchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Table_1 SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
