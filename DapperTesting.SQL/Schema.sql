
USE master
GO

IF DB_ID('DapperTesting') IS NOT NULL
DROP DATABASE [DapperTesting]
GO

CREATE DATABASE [DapperTesting]
GO

USE [DapperTesting]
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
