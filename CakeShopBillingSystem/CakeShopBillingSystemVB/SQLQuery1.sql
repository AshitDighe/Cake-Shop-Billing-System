CREATE TABLE [dbo].[OrderDetails] (
    [OrderNo] Int  Not NULL,
    [Date]  NVARCHAR (50) NULL,
    [FirstName] NVARCHAR (50) NULL,
    [LastName]    NVARCHAR (50) NULL,
    [Address]  NVARCHAR (50) NULL,
    [MobNumber]  Int  NULL,
    [Category]   NVARCHAR (50) NULL,
    [Flavours]  NVARCHAR (50) NULL,
    [Candle]     NVARCHAR (50) NULL,
    [CakeValue]   Int NULL,
    [CandleValue]   Int NULL,
    [OtherValue]   Int NULL,
    [DeliveryValue]   Int NULL,
    [Total]   Int NULL,
    PRIMARY KEY CLUSTERED ([OrderNo] ASC)
);
