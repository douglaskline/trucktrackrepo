BEGIN TRANSACTION;
GO

ALTER TABLE [user] ADD [timeStamp] rowversion NULL;
GO

CREATE TABLE [location] (
    [locationId] int NOT NULL IDENTITY,
    [locationName] nvarchar(max) NOT NULL,
    [latitude] real NOT NULL,
    [longitude] real NOT NULL,
    [geocode] nvarchar(max) NULL,
    [locationDescription] nvarchar(max) NULL,
    [timeStamp] rowversion NULL,
    CONSTRAINT [PK_location] PRIMARY KEY ([locationId])
);
GO

CREATE TABLE [truck] (
    [truckId] int NOT NULL IDENTITY,
    [truckName] nvarchar(max) NULL,
    [homeCity] nvarchar(max) NOT NULL,
    [homeState] nvarchar(max) NOT NULL,
    [foodStyle] nvarchar(max) NOT NULL,
    [priceRange] nvarchar(max) NOT NULL,
    [tagLine] nvarchar(max) NULL,
    [truckURL] nvarchar(max) NULL,
    [timeStamp] rowversion NULL,
    CONSTRAINT [PK_truck] PRIMARY KEY ([truckId])
);
GO

CREATE TABLE [report] (
    [Id] int NOT NULL IDENTITY,
    [reportTime] datetime2 NOT NULL,
    [truckId] int NOT NULL,
    [locationId] int NOT NULL,
    [startTime] datetime2 NOT NULL,
    [endTime] datetime2 NOT NULL,
    [userId] int NOT NULL,
    [timeStamp] rowversion NULL,
    CONSTRAINT [PK_report] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_report_location_locationId] FOREIGN KEY ([locationId]) REFERENCES [location] ([locationId]) ON DELETE SET NULL,
    CONSTRAINT [FK_report_truck_truckId] FOREIGN KEY ([truckId]) REFERENCES [truck] ([truckId]) ON DELETE SET NULL,
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
VALUES (N'20220216205238_SecondMigration', N'5.0.13');
GO

COMMIT;
GO

