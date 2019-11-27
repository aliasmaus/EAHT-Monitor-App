CREATE TABLE [dbo].[Monitors_In_Beds] (
    [Id]             INT IDENTITY (0, 1) NOT NULL,
    [Ward]           INT NOT NULL,
    [Bed]            INT NOT NULL,
    [Bay]            INT NOT NULL,
    [Monitor_Number] INT NOT NULL,
    [Monitor_Type]   INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [Monitor_Unique] UNIQUE NONCLUSTERED ([Ward] ASC, [Bay] ASC, [Bed] ASC, [Monitor_Number] ASC),
    CONSTRAINT [MonitorKey] FOREIGN KEY ([Monitor_Type]) REFERENCES [dbo].[Monitors] ([Monitor_ID])
);

