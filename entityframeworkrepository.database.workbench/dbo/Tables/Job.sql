﻿CREATE TABLE [dbo].[Job] (
    [JobID]            INT           IDENTITY (1, 1) NOT NULL,
    [JobCode]          VARCHAR (20)  NULL,
    [JobTitle]         VARCHAR (50)  NULL,
    [JobDescription]   VARCHAR (200) NULL,
    [JobDepartment]    VARCHAR (50)  NULL,
    [JobStatusID]      INT           NULL,
    [CountryID]        INT           NULL,
    [City]             VARCHAR (20)  NULL,
    [IsRemoteJob]      TINYINT       NULL,
    [JobRequirement]   VARCHAR (200) NULL,
    [JobBenefit]       VARCHAR (200) NULL,
    [InHouseOrAgency]  TINYINT       NULL,
    [EmploymentTypeID] INT           NULL,
    [ExperienceID]     INT           NULL,
    [Education]        INT           NULL,
    [JobKeywords]      VARCHAR (50)  NULL,
    [SalaryFrom]       INT           NULL,
    [SalaryTo]         INT           NULL,
    [CurrencyID]       INT           NULL,
    [PersonID]         INT           NULL,
    [IsDeleted]        TINYINT       NULL,
    [IsVisible]        TINYINT       NULL,
    [UpdatedBy]        INT           NOT NULL,
    [CreatedBy]        INT           NOT NULL,
    [DateAdded]        DATETIME      NOT NULL,
    [DateUpdated]      DATETIME      NOT NULL,
    CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED ([JobID] ASC),
    CONSTRAINT [FK_Job_Person] FOREIGN KEY ([PersonID]) REFERENCES [dbo].[Person] ([PersonID]) NOT FOR REPLICATION
);

