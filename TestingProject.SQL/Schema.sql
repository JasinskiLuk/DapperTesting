
USE master
GO

IF DB_ID('TestingProject') IS NOT NULL
DROP DATABASE [TestingProject]
GO

CREATE DATABASE [TestingProject]
GO

USE [TestingProject]
GO

CREATE SCHEMA [testing]
GO

CREATE TABLE [testing].[DateTest]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Date1] DATE NOT NULL,
    [DateTime1] DATETIME,
    [DateTime2] DATETIME2
);

CREATE TABLE [testing].[Cars]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Name] NVARCHAR(50),
    [Price] MONEY,
    [DateId] INT NOT NULL FOREIGN KEY REFERENCES [testing].[DateTest]([Id])
);

CREATE TABLE [testing].[Attachments]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [FileName] NVARCHAR(50),
    [OriginalFileName] NVARCHAR(50) NOT NULL,
    [FilePath] NVARCHAR(100),
    [DateAdded] DATETIME2
);