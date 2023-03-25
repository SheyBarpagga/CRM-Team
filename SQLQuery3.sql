CREATE TABLE [dbo].[Renter] (
    [RenterId]      INT           IDENTITY (1, 1) NOT NULL,
    [Name]             VARCHAR (50)  NOT NULL,
    [Age]              INT           NOT NULL,
    [Gender]           VARCHAR (50)  NOT NULL,
    [Address]          VARCHAR (50)  NOT NULL,
    [ContactingNumber] VARCHAR (50)  NOT NULL,
    [EmergencyContactingNumber] VARCHAR (50)  NOT NULL,
    [Familydoctor]     VARCHAR(50)   NOT NULL,
    [SharingInfo]      VARCHAR (50)  NOT NULL,
    [Income]           FLOAT (53)    NOT NULL,
    [Employer]         VARCHAR (100) NOT NULL,
    
    PRIMARY KEY CLUSTERED ([RenterId] ASC),
    
);