CREATE TABLE [dbo].[Monitors_In_Beds]
(
    [Ward] INT NOT NULL, 
    [Bed] INT NOT NULL, 
    [Bay] INT NOT NULL, 
    [Monitor_Number] INT NOT NULL, 
    [Monitor_Type] INT NOT NULL
	CONSTRAINT Monitor_Unique UNIQUE (Ward, Bed, Bay, Monitor_Number), 
    CONSTRAINT [MonitorKey] FOREIGN KEY ([Monitor_Type]) REFERENCES [Monitors]([Monitor_ID])
)
