INSERT INTO [dbo].[IntTable]
           ([Value1]
           ,[Value2]
           ,[Value3]
           ,[Value4]
           ,[Value5]
           ,[Value6]
           ,[Value7]
           ,[Value8]
           ,[Value9]
           ,[Value10]
           )
    

     SELECT TOP (5000000) dbo.GenerateRandomValue(ROW_NUMBER() OVER (ORDER BY (SELECT 1)), NEWID()) AS [Value1]
           ,dbo.GenerateRandomValue(ROW_NUMBER() OVER (ORDER BY (SELECT 1)), NEWID()) as [Value2]
           ,dbo.GenerateRandomValue(ROW_NUMBER() OVER (ORDER BY (SELECT 1)), NEWID()) as [Value3]
           ,dbo.GenerateRandomValue(ROW_NUMBER() OVER (ORDER BY (SELECT 1)), NEWID()) as [Value4]
           ,dbo.GenerateRandomValue(ROW_NUMBER() OVER (ORDER BY (SELECT 1)), NEWID()) as [Value5]
           ,dbo.GenerateRandomValue(ROW_NUMBER() OVER (ORDER BY (SELECT 1)), NEWID()) as [Value6]
           ,dbo.GenerateRandomValue(ROW_NUMBER() OVER (ORDER BY (SELECT 1)), NEWID()) as [Value7]
           ,dbo.GenerateRandomValue(ROW_NUMBER() OVER (ORDER BY (SELECT 1)), NEWID()) as [Value8]
           ,dbo.GenerateRandomValue(ROW_NUMBER() OVER (ORDER BY (SELECT 1)), NEWID()) as [Value9]
           ,dbo.GenerateRandomValue(ROW_NUMBER() OVER (ORDER BY (SELECT 1)), NEWID()) as [Value10]
           
	 FROM sys.objects o
	 cross join sys.objects o2
	 cross join sys.objects o3
	 cross join sys.objects o4;