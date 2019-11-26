CREATE TABLE [dbo].[Alarm_Records] (
    [Id]                       INT           IDENTITY (1, 1) NOT NULL,
    [Ward]                     VARCHAR (30)  NOT NULL,
    [Bay]                      INT           NOT NULL,
    [Bed]                      INT           NOT NULL,
    [Monitor]                  INT           NOT NULL,
    [Monitor_Type]             VARCHAR (50)  NOT NULL,
    [Start_Time]               DATETIME      NOT NULL,
    [End_Time]                 DATETIME      NOT NULL,
    [Notes]                    VARCHAR (100) NULL,
    [Intervening_Staff_Member] VARCHAR (50)  NULL,
    [Time_Silenced]             DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

