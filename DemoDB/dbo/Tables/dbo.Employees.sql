﻿CREATE TABLE [dbo].[Employees] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [EmployeeId] INT           NOT NULL,
    [FirstName]  NVARCHAR (50) NOT NULL,
    [LastName]   NVARCHAR (50) NOT NULL,
    [EmailAdress]      NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

