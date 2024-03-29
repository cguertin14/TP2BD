USE [CharlesGuertinStageBd]
GO
/****** Object:  StoredProcedure [dbo].[UPDATEDESCRIPTION]    Script Date: 2017-10-19 17:18:51 ******/
DROP PROCEDURE [dbo].[UPDATEDESCRIPTION]
GO
/****** Object:  StoredProcedure [dbo].[GETSTAGESFROMENTREPRISE]    Script Date: 2017-10-19 17:18:51 ******/
DROP PROCEDURE [dbo].[GETSTAGESFROMENTREPRISE]
GO
/****** Object:  StoredProcedure [dbo].[DELETESTAGE]    Script Date: 2017-10-19 17:18:51 ******/
DROP PROCEDURE [dbo].[DELETESTAGE]
GO
/****** Object:  StoredProcedure [dbo].[ADDSTAGE]    Script Date: 2017-10-19 17:18:51 ******/
DROP PROCEDURE [dbo].[ADDSTAGE]
GO
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
/****** Object:  UserDefinedFunction [dbo].[GETETUDIANTS]    Script Date: 2017-10-19 17:18:51 ******/
DROP FUNCTION [dbo].[GETETUDIANTS]
GO
/****** Object:  Table [dbo].[SUPERVISEURS]    Script Date: 2017-10-19 17:18:51 ******/
DROP TABLE [dbo].[SUPERVISEURS]
GO
/****** Object:  Table [dbo].[STAGIAIRES]    Script Date: 2017-10-19 17:18:51 ******/
DROP TABLE [dbo].[STAGIAIRES]
GO
/****** Object:  Table [dbo].[STAGES]    Script Date: 2017-10-19 17:18:51 ******/
DROP TABLE [dbo].[STAGES]
GO
/****** Object:  Table [dbo].[MONITEURS]    Script Date: 2017-10-19 17:18:51 ******/
DROP TABLE [dbo].[MONITEURS]
GO
/****** Object:  Table [dbo].[ENTREPRISES]    Script Date: 2017-10-19 17:18:51 ******/
DROP TABLE [dbo].[ENTREPRISES]
GO
/****** Object:  UserDefinedFunction [dbo].[GETNBSTAGESBYENTREPRISE]    Script Date: 2017-10-19 17:18:51 ******/
DROP FUNCTION [dbo].[GETNBSTAGESBYENTREPRISE]
GO
