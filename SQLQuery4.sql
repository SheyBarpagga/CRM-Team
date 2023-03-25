CREATE TABLE [dbo].[Asset] (
    [AssetId]     INT          IDENTITY (1, 1) NOT NULL,
    [Description]  VARCHAR (50) NOT NULL,
    [AssetTypeId]  INT          NOT NULL,
    [RenterId]       INT          NOT NULL,
    [PlateNumber]  VARCHAR(50)    NULL,
    [SuiteNo]      VARCHAR(50)    NULL
    PRIMARY KEY CLUSTERED ([AssetId] ASC),
    FOREIGN KEY ([AssetTypeId]) REFERENCES [dbo].[AssetType] ([AssetTypeId]),
    FOREIGN KEY ([RenterId]) REFERENCES [dbo].[Renter] ([RenterId]),
);