CREATE TABLE [dbo].[BigintTable](
	[Id] [bigint] IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[Value1] [nvarchar](255) NULL,
	[Value2] [nvarchar](255) NULL,
	[Value3] [nvarchar](255) NULL,
	[Value4] [nvarchar](255) NULL,
	[Value5] [nvarchar](255) NULL,
	[Value6] [nvarchar](255) NULL,
	[Value7] [nvarchar](255) NULL,
	[Value8] [nvarchar](255) NULL,
	[Value9] [nvarchar](255) NULL,
	[Value10] [nvarchar](255) NULL	
)WITH(DATA_COMPRESSION=PAGE);