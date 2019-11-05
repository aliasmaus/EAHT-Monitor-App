CREATE TABLE [dbo].[Staff_Logins]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Staff_Member_ID] CHAR(10) NOT NULL, 
    [Log_In_Time] DATETIME NOT NULL, 
    [Log_Out_Time] DATETIME NULL, 
    CONSTRAINT [FK_Staff_Logins_ToStaff] FOREIGN KEY ([Staff_Member_ID]) REFERENCES [Staff]([NHS_ID])
)
