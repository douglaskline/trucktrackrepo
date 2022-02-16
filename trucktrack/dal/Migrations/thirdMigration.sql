BEGIN TRANSACTION;
GO

ALTER TABLE [report] DROP CONSTRAINT [FK_report_user_userId];
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[report]') AND [c].[name] = N'userId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [report] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [report] ALTER COLUMN [userId] int NULL;
GO

ALTER TABLE [report] ADD CONSTRAINT [FK_report_user_userId] FOREIGN KEY ([userId]) REFERENCES [user] ([Id]) ON DELETE SET NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220216235244_thirdMigration', N'5.0.13');
GO

COMMIT;
GO

