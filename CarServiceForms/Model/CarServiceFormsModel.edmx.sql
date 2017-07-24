
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/22/2017 14:17:16
-- Generated from EDMX file: F:\Development\car-service-forms\CarServiceForms\Model\CarServiceFormsModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CarServiceForms];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CustomerVehicle]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vehicle] DROP CONSTRAINT [FK_CustomerVehicle];
GO
IF OBJECT_ID(N'[dbo].[FK_VehicleWorkOrder]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WorkOrder] DROP CONSTRAINT [FK_VehicleWorkOrder];
GO
IF OBJECT_ID(N'[dbo].[FK_WorkOrderWordOrderInformation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WordOrderInformation] DROP CONSTRAINT [FK_WorkOrderWordOrderInformation];
GO
IF OBJECT_ID(N'[dbo].[FK_WorkOrderWorkOrderInstruction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WorkOrderInstruction] DROP CONSTRAINT [FK_WorkOrderWorkOrderInstruction];
GO
IF OBJECT_ID(N'[dbo].[FK_WorkOrderService]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Service] DROP CONSTRAINT [FK_WorkOrderService];
GO
IF OBJECT_ID(N'[dbo].[FK_ServiceItemGroupServiceItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ServiceItem] DROP CONSTRAINT [FK_ServiceItemGroupServiceItem];
GO
IF OBJECT_ID(N'[dbo].[FK_ServiceAppliedServiceItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AppliedServiceItem] DROP CONSTRAINT [FK_ServiceAppliedServiceItem];
GO
IF OBJECT_ID(N'[dbo].[FK_ServiceItemAppliedServiceItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AppliedServiceItem] DROP CONSTRAINT [FK_ServiceItemAppliedServiceItem];
GO
IF OBJECT_ID(N'[dbo].[FK_ServiceItemServiceItemServiceType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ServiceItemServiceType] DROP CONSTRAINT [FK_ServiceItemServiceItemServiceType];
GO
IF OBJECT_ID(N'[dbo].[FK_InvoiceInvoiceItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InvoiceItem] DROP CONSTRAINT [FK_InvoiceInvoiceItem];
GO
IF OBJECT_ID(N'[dbo].[FK_WorkOrderInvoice]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Invoice] DROP CONSTRAINT [FK_WorkOrderInvoice];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Customer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customer];
GO
IF OBJECT_ID(N'[dbo].[Vehicle]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vehicle];
GO
IF OBJECT_ID(N'[dbo].[WorkOrder]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorkOrder];
GO
IF OBJECT_ID(N'[dbo].[WordOrderInformation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WordOrderInformation];
GO
IF OBJECT_ID(N'[dbo].[WorkOrderInstruction]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorkOrderInstruction];
GO
IF OBJECT_ID(N'[dbo].[Service]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Service];
GO
IF OBJECT_ID(N'[dbo].[ServiceItemGroup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServiceItemGroup];
GO
IF OBJECT_ID(N'[dbo].[ServiceItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServiceItem];
GO
IF OBJECT_ID(N'[dbo].[AppliedServiceItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AppliedServiceItem];
GO
IF OBJECT_ID(N'[dbo].[ServiceItemServiceType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServiceItemServiceType];
GO
IF OBJECT_ID(N'[dbo].[Settings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Settings];
GO
IF OBJECT_ID(N'[dbo].[Invoice]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Invoice];
GO
IF OBJECT_ID(N'[dbo].[InvoiceItem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InvoiceItem];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customer'
CREATE TABLE [dbo].[Customer] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Street] nvarchar(max)  NOT NULL,
    [Post] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Vehicle'
CREATE TABLE [dbo].[Vehicle] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [RegistrationNumber] nvarchar(max)  NOT NULL,
    [RegistrationDate] datetime  NOT NULL,
    [IdentificationNumber] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [TypeCode] nvarchar(max)  NOT NULL,
    [MKBCode] nvarchar(max)  NOT NULL,
    [GKBCode] nvarchar(max)  NOT NULL,
    [Mileage] int  NOT NULL,
    [ModelYear] int  NOT NULL,
    [Engine] nvarchar(max)  NOT NULL,
    [Transmission] nvarchar(max)  NOT NULL,
    [Customer_Id] bigint  NOT NULL
);
GO

-- Creating table 'WorkOrder'
CREATE TABLE [dbo].[WorkOrder] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Number] nvarchar(max)  NOT NULL,
    [Created] datetime  NOT NULL,
    [Deadline] datetime  NOT NULL,
    [Finished] datetime  NULL,
    [Vehicle_Id] bigint  NOT NULL
);
GO

-- Creating table 'WordOrderInformation'
CREATE TABLE [dbo].[WordOrderInformation] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Info] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NULL,
    [WorkOrder_Id] bigint  NOT NULL
);
GO

-- Creating table 'WorkOrderInstruction'
CREATE TABLE [dbo].[WorkOrderInstruction] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Position] nvarchar(max)  NULL,
    [Quantity] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NULL,
    [WorkOrder_Id] bigint  NOT NULL
);
GO

-- Creating table 'Service'
CREATE TABLE [dbo].[Service] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Type] int  NOT NULL,
    [Created] datetime  NOT NULL,
    [WorkOrder_Id] bigint  NOT NULL
);
GO

-- Creating table 'ServiceItemGroup'
CREATE TABLE [dbo].[ServiceItemGroup] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Order] int  NOT NULL,
    [Enabled] bit  NOT NULL
);
GO

-- Creating table 'ServiceItem'
CREATE TABLE [dbo].[ServiceItem] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [HasRemarks] bit  NOT NULL,
    [Order] int  NOT NULL,
    [Enabled] bit  NOT NULL,
    [ServiceItemGroup_Id] bigint  NOT NULL
);
GO

-- Creating table 'AppliedServiceItem'
CREATE TABLE [dbo].[AppliedServiceItem] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Remark] nvarchar(max)  NULL,
    [Resolution] int  NULL,
    [Service_Id] bigint  NOT NULL,
    [ServiceItem_Id] bigint  NOT NULL
);
GO

-- Creating table 'ServiceItemServiceType'
CREATE TABLE [dbo].[ServiceItemServiceType] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [ServiceType] int  NOT NULL,
    [ServiceItem_Id] bigint  NOT NULL
);
GO

-- Creating table 'Settings'
CREATE TABLE [dbo].[Settings] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Key] nvarchar(max)  NOT NULL,
    [Value] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NULL
);
GO

-- Creating table 'Invoice'
CREATE TABLE [dbo].[Invoice] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Number] nvarchar(max)  NOT NULL,
    [Created] datetime  NOT NULL,
    [WorkOrder_Id] bigint  NOT NULL
);
GO

-- Creating table 'InvoiceItem'
CREATE TABLE [dbo].[InvoiceItem] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Quantity] decimal(18,0)  NOT NULL,
    [Price] decimal(18,0)  NOT NULL,
    [Discount] decimal(18,0)  NOT NULL,
    [FinalPrice] decimal(18,0)  NOT NULL,
    [Invoice_Id] bigint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Customer'
ALTER TABLE [dbo].[Customer]
ADD CONSTRAINT [PK_Customer]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Vehicle'
ALTER TABLE [dbo].[Vehicle]
ADD CONSTRAINT [PK_Vehicle]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WorkOrder'
ALTER TABLE [dbo].[WorkOrder]
ADD CONSTRAINT [PK_WorkOrder]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WordOrderInformation'
ALTER TABLE [dbo].[WordOrderInformation]
ADD CONSTRAINT [PK_WordOrderInformation]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WorkOrderInstruction'
ALTER TABLE [dbo].[WorkOrderInstruction]
ADD CONSTRAINT [PK_WorkOrderInstruction]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Service'
ALTER TABLE [dbo].[Service]
ADD CONSTRAINT [PK_Service]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ServiceItemGroup'
ALTER TABLE [dbo].[ServiceItemGroup]
ADD CONSTRAINT [PK_ServiceItemGroup]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ServiceItem'
ALTER TABLE [dbo].[ServiceItem]
ADD CONSTRAINT [PK_ServiceItem]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AppliedServiceItem'
ALTER TABLE [dbo].[AppliedServiceItem]
ADD CONSTRAINT [PK_AppliedServiceItem]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ServiceItemServiceType'
ALTER TABLE [dbo].[ServiceItemServiceType]
ADD CONSTRAINT [PK_ServiceItemServiceType]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Settings'
ALTER TABLE [dbo].[Settings]
ADD CONSTRAINT [PK_Settings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Invoice'
ALTER TABLE [dbo].[Invoice]
ADD CONSTRAINT [PK_Invoice]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'InvoiceItem'
ALTER TABLE [dbo].[InvoiceItem]
ADD CONSTRAINT [PK_InvoiceItem]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Customer_Id] in table 'Vehicle'
ALTER TABLE [dbo].[Vehicle]
ADD CONSTRAINT [FK_CustomerVehicle]
    FOREIGN KEY ([Customer_Id])
    REFERENCES [dbo].[Customer]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerVehicle'
CREATE INDEX [IX_FK_CustomerVehicle]
ON [dbo].[Vehicle]
    ([Customer_Id]);
GO

-- Creating foreign key on [Vehicle_Id] in table 'WorkOrder'
ALTER TABLE [dbo].[WorkOrder]
ADD CONSTRAINT [FK_VehicleWorkOrder]
    FOREIGN KEY ([Vehicle_Id])
    REFERENCES [dbo].[Vehicle]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VehicleWorkOrder'
CREATE INDEX [IX_FK_VehicleWorkOrder]
ON [dbo].[WorkOrder]
    ([Vehicle_Id]);
GO

-- Creating foreign key on [WorkOrder_Id] in table 'WordOrderInformation'
ALTER TABLE [dbo].[WordOrderInformation]
ADD CONSTRAINT [FK_WorkOrderWordOrderInformation]
    FOREIGN KEY ([WorkOrder_Id])
    REFERENCES [dbo].[WorkOrder]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkOrderWordOrderInformation'
CREATE INDEX [IX_FK_WorkOrderWordOrderInformation]
ON [dbo].[WordOrderInformation]
    ([WorkOrder_Id]);
GO

-- Creating foreign key on [WorkOrder_Id] in table 'WorkOrderInstruction'
ALTER TABLE [dbo].[WorkOrderInstruction]
ADD CONSTRAINT [FK_WorkOrderWorkOrderInstruction]
    FOREIGN KEY ([WorkOrder_Id])
    REFERENCES [dbo].[WorkOrder]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkOrderWorkOrderInstruction'
CREATE INDEX [IX_FK_WorkOrderWorkOrderInstruction]
ON [dbo].[WorkOrderInstruction]
    ([WorkOrder_Id]);
GO

-- Creating foreign key on [WorkOrder_Id] in table 'Service'
ALTER TABLE [dbo].[Service]
ADD CONSTRAINT [FK_WorkOrderService]
    FOREIGN KEY ([WorkOrder_Id])
    REFERENCES [dbo].[WorkOrder]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkOrderService'
CREATE INDEX [IX_FK_WorkOrderService]
ON [dbo].[Service]
    ([WorkOrder_Id]);
GO

-- Creating foreign key on [ServiceItemGroup_Id] in table 'ServiceItem'
ALTER TABLE [dbo].[ServiceItem]
ADD CONSTRAINT [FK_ServiceItemGroupServiceItem]
    FOREIGN KEY ([ServiceItemGroup_Id])
    REFERENCES [dbo].[ServiceItemGroup]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServiceItemGroupServiceItem'
CREATE INDEX [IX_FK_ServiceItemGroupServiceItem]
ON [dbo].[ServiceItem]
    ([ServiceItemGroup_Id]);
GO

-- Creating foreign key on [Service_Id] in table 'AppliedServiceItem'
ALTER TABLE [dbo].[AppliedServiceItem]
ADD CONSTRAINT [FK_ServiceAppliedServiceItem]
    FOREIGN KEY ([Service_Id])
    REFERENCES [dbo].[Service]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServiceAppliedServiceItem'
CREATE INDEX [IX_FK_ServiceAppliedServiceItem]
ON [dbo].[AppliedServiceItem]
    ([Service_Id]);
GO

-- Creating foreign key on [ServiceItem_Id] in table 'AppliedServiceItem'
ALTER TABLE [dbo].[AppliedServiceItem]
ADD CONSTRAINT [FK_ServiceItemAppliedServiceItem]
    FOREIGN KEY ([ServiceItem_Id])
    REFERENCES [dbo].[ServiceItem]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServiceItemAppliedServiceItem'
CREATE INDEX [IX_FK_ServiceItemAppliedServiceItem]
ON [dbo].[AppliedServiceItem]
    ([ServiceItem_Id]);
GO

-- Creating foreign key on [ServiceItem_Id] in table 'ServiceItemServiceType'
ALTER TABLE [dbo].[ServiceItemServiceType]
ADD CONSTRAINT [FK_ServiceItemServiceItemServiceType]
    FOREIGN KEY ([ServiceItem_Id])
    REFERENCES [dbo].[ServiceItem]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServiceItemServiceItemServiceType'
CREATE INDEX [IX_FK_ServiceItemServiceItemServiceType]
ON [dbo].[ServiceItemServiceType]
    ([ServiceItem_Id]);
GO

-- Creating foreign key on [Invoice_Id] in table 'InvoiceItem'
ALTER TABLE [dbo].[InvoiceItem]
ADD CONSTRAINT [FK_InvoiceInvoiceItem]
    FOREIGN KEY ([Invoice_Id])
    REFERENCES [dbo].[Invoice]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InvoiceInvoiceItem'
CREATE INDEX [IX_FK_InvoiceInvoiceItem]
ON [dbo].[InvoiceItem]
    ([Invoice_Id]);
GO

-- Creating foreign key on [WorkOrder_Id] in table 'Invoice'
ALTER TABLE [dbo].[Invoice]
ADD CONSTRAINT [FK_WorkOrderInvoice]
    FOREIGN KEY ([WorkOrder_Id])
    REFERENCES [dbo].[WorkOrder]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkOrderInvoice'
CREATE INDEX [IX_FK_WorkOrderInvoice]
ON [dbo].[Invoice]
    ([WorkOrder_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------