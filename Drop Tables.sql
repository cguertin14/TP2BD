USE [CharlesGuertinStageBd]
GO
BEGIN TRANSACTION
ALTER TABLE [dbo].[STAGIAIRES] DROP CONSTRAINT [FKNUMSVR]
GO
ALTER TABLE [dbo].[STAGES] DROP CONSTRAINT [FKNUMTR]
GO
ALTER TABLE [dbo].[STAGES] DROP CONSTRAINT [FKNUMENT2]
GO
ALTER TABLE [dbo].[STAGES] DROP CONSTRAINT [FKNUMAD]
GO
ALTER TABLE [dbo].[MONITEURS] DROP CONSTRAINT [FKNUMENT1]
GO
/****** Object:  Table [dbo].[SUPERVISEURS]    Script Date: 2017-10-19 01:51:14 ******/
DROP TABLE [dbo].[SUPERVISEURS]
GO
/****** Object:  Table [dbo].[STAGIAIRES]    Script Date: 2017-10-19 01:51:14 ******/
DROP TABLE [dbo].[STAGIAIRES]
GO
/****** Object:  Table [dbo].[STAGES]    Script Date: 2017-10-19 01:51:14 ******/
DROP TABLE [dbo].[STAGES]
GO
/****** Object:  Table [dbo].[MONITEURS]    Script Date: 2017-10-19 01:51:14 ******/
DROP TABLE [dbo].[MONITEURS]
GO
/****** Object:  Table [dbo].[ENTREPRISES]    Script Date: 2017-10-19 01:51:14 ******/
DROP TABLE [dbo].[ENTREPRISES]
GO
