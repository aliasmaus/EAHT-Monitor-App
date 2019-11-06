CREATE TABLE [dbo].[Monitor_Settings]
(
	[Monitor_Setting_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Patient] INT NOT NULL, 
    [Monitor_Type] INT NOT NULL, 
    [Upper_Limit] FLOAT NULL, 
    [Lower_Limit] FLOAT NULL, 
    CONSTRAINT [FK_Monitor_Settings_Patient] FOREIGN KEY ([Patient]) REFERENCES [Patients]([Patient_ID]),
	CONSTRAINT [FK_Monitor_Settings_MonType] FOREIGN KEY ([Monitor_Type]) REFERENCES [Monitors]([Monitor_ID])
)
