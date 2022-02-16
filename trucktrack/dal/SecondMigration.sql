BEGIN TRANSACTION;
GO

ALTER TABLE [report] DROP CONSTRAINT [FK_report_location_locationId];
GO

ALTER TABLE [report] DROP CONSTRAINT [FK_report_truck_truckId];
GO

ALTER TABLE [report] ADD CONSTRAINT [FK_report_location_locationId] FOREIGN KEY ([locationId]) REFERENCES [location] ([locationId]) ON DELETE NO ACTION;
GO

ALTER TABLE [report] ADD CONSTRAINT [FK_report_truck_truckId] FOREIGN KEY ([truckId]) REFERENCES [truck] ([truckId]) ON DELETE NO ACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220216210009_SecondMigration', N'5.0.13');
GO

COMMIT;
GO

