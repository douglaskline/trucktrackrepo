IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [user] (
    [Id] int NOT NULL IDENTITY,
    [firstName] nvarchar(max) NULL,
    [lastName] nvarchar(max) NOT NULL,
    [username] nvarchar(max) NOT NULL,
    [email] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_user] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220131194624_InitialMigration', N'5.0.13');
GO

COMMIT;
GO

