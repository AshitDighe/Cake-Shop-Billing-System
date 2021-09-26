CREATE TABLE [dbo].[order] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [name]   NVARCHAR (50) NULL,
    [addr]   NVARCHAR (50) NULL,
    [mobile] NVARCHAR (50) NULL,
    [center] NVARCHAR (50) NULL,
    [fat] NVARCHAR (50) NULL,
    [liter] NVARCHAR (50) NULL,
    [total] NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
