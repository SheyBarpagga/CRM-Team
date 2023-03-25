CREATE TABLE [dbo].[AssetType] (
    [AssetTypeId]  INT  IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR(50) NOT NULL,
    [AvailableNumber]    INT  NOT NULL,
   
    PRIMARY KEY CLUSTERED ([AssetTypeId] ASC),
   
);