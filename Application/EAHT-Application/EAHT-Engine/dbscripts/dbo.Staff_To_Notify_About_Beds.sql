CREATE TABLE [dbo].[Staff_To_Notify_About_Beds] (
    [Id]                INT IDENTITY (0, 1) NOT NULL,
    [Staff_Id]          INT NOT NULL,
    [Ward_Id]           INT NOT NULL,
    [Bay_Number]        INT NOT NULL,
    [Bed_Number]        INT NOT NULL,
    [Notification_Type] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [UniqueNotification] UNIQUE NONCLUSTERED ([Staff_Id] ASC, [Ward_Id] ASC, [Bay_Number] ASC, [Bed_Number] ASC, [Notification_Type] ASC),
    CONSTRAINT [StaffKey] FOREIGN KEY ([Staff_Id]) REFERENCES [dbo].[Staff] ([ID_Number]),
    CONSTRAINT [WardKey] FOREIGN KEY ([Ward_Id]) REFERENCES [dbo].[Ward_Settings] ([Id]),
    CONSTRAINT [NotificationTypeCheck] CHECK ([Notification_Type]>=(0)),
    CONSTRAINT [NotificationTypeCheck1] CHECK ([Notification_Type]<=(1))
);

