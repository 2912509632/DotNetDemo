
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/19/2018 11:01:45
-- Generated from EDMX file: E:\Subject\EF\ModeFirst开发方式\ModeFirst开发方式\Demo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Demo];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'InfoSet'
CREATE TABLE [dbo].[InfoSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Pass] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'GradeSet'
CREATE TABLE [dbo].[GradeSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Chinese] float  NOT NULL,
    [English] float  NOT NULL,
    [IT] float  NOT NULL,
    [InfoID] int  NOT NULL
);
GO

-- Creating table 'MoreSet'
CREATE TABLE [dbo].[MoreSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Mail] nvarchar(200)  NOT NULL,
    [Adress] nvarchar(500)  NOT NULL,
    [InfoID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'InfoSet'
ALTER TABLE [dbo].[InfoSet]
ADD CONSTRAINT [PK_InfoSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'GradeSet'
ALTER TABLE [dbo].[GradeSet]
ADD CONSTRAINT [PK_GradeSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'MoreSet'
ALTER TABLE [dbo].[MoreSet]
ADD CONSTRAINT [PK_MoreSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [InfoID] in table 'GradeSet'
ALTER TABLE [dbo].[GradeSet]
ADD CONSTRAINT [FK_InfoGrade]
    FOREIGN KEY ([InfoID])
    REFERENCES [dbo].[InfoSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InfoGrade'
CREATE INDEX [IX_FK_InfoGrade]
ON [dbo].[GradeSet]
    ([InfoID]);
GO

-- Creating foreign key on [InfoID] in table 'MoreSet'
ALTER TABLE [dbo].[MoreSet]
ADD CONSTRAINT [FK_InfoMore]
    FOREIGN KEY ([InfoID])
    REFERENCES [dbo].[InfoSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InfoMore'
CREATE INDEX [IX_FK_InfoMore]
ON [dbo].[MoreSet]
    ([InfoID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------