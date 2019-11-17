CREATE TABLE [dbo].[Ward_Settings] (
    [Id]               INT          IDENTITY (0, 1) NOT NULL,
    [Ward_Name]        VARCHAR (30) NOT NULL,
    [Number_Of_Bays]   INT          NOT NULL,
    [Beds_Per_Bay]     INT          NOT NULL,
    [Monitors_Per_Bed] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);