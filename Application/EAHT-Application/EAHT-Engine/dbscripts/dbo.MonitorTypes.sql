CREATE TABLE [dbo].[MonitorTypes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(0, 1), 
    [Name] VARCHAR(20) NOT NULL, 
    [Default_Value] FLOAT NOT NULL, 
    [Default_Upper] FLOAT NOT NULL, 
    [Default_Lower] FLOAT NOT NULL, 
    [Default_Reading_Frequency] INT NOT NULL, 
    [Default_Reading_Variance] FLOAT NOT NULL, 
    [Default_Reading_RoundValue] FLOAT NOT NULL
)
