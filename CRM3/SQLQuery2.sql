CREATE TABLE [dbo].[Applicant] (
    [ApplicantId]  INT  IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR(50)  NOT NULL,
    [Age]    INT  NOT NULL,
    [Gender] VARCHAR(50)  NOT NULL,
    [Address] VARCHAR(50)  NOT NULL,
    [ContactingNumber] VARCHAR(50)  NOT NULL,
    [SharingInfo] VARCHAR(50) NOT NULL,
    [Income] FLOAT NOT NULL,
    [Employer] VARCHAR(100)  NOT NULL,
    [AskingAssetType1]  INT NOT NULL ,
    [AskingAssetType2]  INT,
    [AskingAssetType3]  INT,
    [AskingAssetType4]  INT,


    PRIMARY KEY CLUSTERED ([ApplicantId] ASC),
    FOREIGN KEY ([AskingAssetType1]) REFERENCES [dbo].[AssetType] ([AssetTypeId]),
    FOREIGN KEY ([AskingAssetType2]) REFERENCES [dbo].[AssetType] ([AssetTypeId]),
    FOREIGN KEY ([AskingAssetType3]) REFERENCES [dbo].[AssetType] ([AssetTypeId]),
    FOREIGN KEY ([AskingAssetType4]) REFERENCES [dbo].[AssetType] ([AssetTypeId]),
);