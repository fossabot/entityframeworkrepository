﻿CREATE TABLE [dbo].[Person] (
    [PersonID]         INT           IDENTITY (1, 1) NOT NULL,
    [Email]            VARCHAR (50)  NULL,
    [FirstName]        VARCHAR (20)  NULL,
    [LastName]         VARCHAR (50)  NULL,
    [Telephone]        VARCHAR (20)  NULL,
    [MobilePhone]      VARCHAR (20)  NULL,
    [Headline]         VARCHAR (50)  NULL,
    [Password]         VARCHAR (20)  NULL,
    [IsLockedOut]      INT           NULL,
    [IsReal]           INT           NULL,
    [Picture]          VARCHAR (100) NULL,
    [TimeZone]         VARCHAR (50)  NULL,
    [Signature]        VARCHAR (100) NULL,
    [Preference]       VARCHAR (100) NULL,
    [DictionaryTypeID] INT           NULL,
    [SignatureOnOff]   INT           NULL,
    [CampaignSource]   VARCHAR (30)  NULL,
    [UpdatedBy]        INT           NULL,
    [CreatedBy]        INT           NULL,
    [DateAdded]        DATETIME      NULL,
    [DateUpdated]      DATETIME      NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([PersonID] ASC),
    CONSTRAINT [FK_Person_Dictionary] FOREIGN KEY ([DictionaryTypeID]) REFERENCES [dbo].[Dictionary] ([DictionaryTypeID]) NOT FOR REPLICATION
);

