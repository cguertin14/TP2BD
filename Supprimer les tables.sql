USE [CharlesGuertinStageBd]
GO
ALTER TABLE [dbo].[STAGIAIRES] DROP CONSTRAINT [FKNUMSVR]
GO
ALTER TABLE [dbo].[Stages] DROP CONSTRAINT [FKNUMTR]
GO
ALTER TABLE [dbo].[Stages] DROP CONSTRAINT [FKNUMENT2]
GO
ALTER TABLE [dbo].[Stages] DROP CONSTRAINT [FKNUMAD]
GO
ALTER TABLE [dbo].[Moniteurs] DROP CONSTRAINT [FKNUMENT1]
GO
/****** Object:  Table [dbo].[SUPERVISEURS]    Script Date: 2017-10-19 01:16:36 ******/
DROP TABLE [dbo].[SUPERVISEURS]
GO
/****** Object:  Table [dbo].[STAGIAIRES]    Script Date: 2017-10-19 01:16:36 ******/
DROP TABLE [dbo].[STAGIAIRES]
GO
/****** Object:  Table [dbo].[Stages]    Script Date: 2017-10-19 01:16:36 ******/
DROP TABLE [dbo].[Stages]
GO
/****** Object:  Table [dbo].[Moniteurs]    Script Date: 2017-10-19 01:16:36 ******/
DROP TABLE [dbo].[Moniteurs]
GO
/****** Object:  Table [dbo].[Entreprises]    Script Date: 2017-10-19 01:16:36 ******/
DROP TABLE [dbo].[Entreprises]
GO
