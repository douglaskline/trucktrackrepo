BEGIN TRANSACTION;
GO

CREATE TABLE [location] (
    [locationId] int NOT NULL IDENTITY,
    [locationName] nvarchar(max) NOT NULL,
    [latitude] real NOT NULL,
    [longitude] real NOT NULL,
    [geocode] nvarchar(max) NULL,
    [locationDescription] VARCHAR(200) NULL,
    [timeStamp] rowversion NULL,
    CONSTRAINT [PK_location] PRIMARY KEY ([locationId])
);
GO

CREATE TABLE [truck] (
    [truckId] int NOT NULL IDENTITY,
    [truckName] VARCHAR(200) NOT NULL,
    [homeCity] VARCHAR(75) NULL,
    [homeState] CHAR(2) NULL,
    [foodStyle] VARCHAR(75) NULL,
    [priceRange] VARCHAR(10) NULL,
    [tagLine] VARCHAR(200) NULL,
    [truckURL] VARCHAR(300) NULL,
    [timeStamp] rowversion NULL,
    CONSTRAINT [PK_truck] PRIMARY KEY ([truckId])
);
GO

CREATE TABLE [user] (
    [Id] int NOT NULL IDENTITY,
    [firstName] nvarchar(max) NULL,
    [lastName] nvarchar(max) NOT NULL,
    [username] nvarchar(max) NOT NULL,
    [email] nvarchar(max) NOT NULL,
    [timeStamp] rowversion NULL,
    CONSTRAINT [PK_user] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [report] (
    [Id] int NOT NULL IDENTITY,
    [reportTime] datetime2 NOT NULL,
    [truckId] int NOT NULL,
    [locationId] int NOT NULL,
    [startTime] datetime2 NOT NULL,
    [endTime] datetime2 NOT NULL,
    [userId] int NULL,
    [timeStamp] rowversion NULL,
    CONSTRAINT [PK_report] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_report_location_locationId] FOREIGN KEY ([locationId]) REFERENCES [location] ([locationId]) ON DELETE NO ACTION,
    CONSTRAINT [FK_report_truck_truckId] FOREIGN KEY ([truckId]) REFERENCES [truck] ([truckId]) ON DELETE NO ACTION,
    CONSTRAINT [FK_report_user_userId] FOREIGN KEY ([userId]) REFERENCES [user] ([Id]) ON DELETE SET NULL
);
GO

CREATE INDEX [IX_report_locationId] ON [report] ([locationId]);
GO

CREATE INDEX [IX_report_truckId] ON [report] ([truckId]);
GO

CREATE INDEX [IX_report_userId] ON [report] ([userId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220317192423_fourthMigration', N'5.0.13');
GO

COMMIT;
GO

