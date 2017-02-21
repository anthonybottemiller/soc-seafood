USE SOCSeafood;
GO
INSERT INTO [dbo].[AspNetUsers] 
	  ([Id]
      ,[AccessFailedCount]
      ,[ConcurrencyStamp]
      ,[Email]
      ,[EmailConfirmed]
      ,[LockoutEnabled]
      ,[LockoutEnd]
      ,[NormalizedEmail]
      ,[NormalizedUserName]
      ,[PasswordHash]
      ,[PhoneNumber]
      ,[PhoneNumberConfirmed]
      ,[SecurityStamp]
      ,[TwoFactorEnabled]
      ,[UserName])
VALUES ('10f402e0-1f3d-429d-9db9-008e1dd52bf9',	0,	'929b0643-4422-452e-9cd9-27d00274aab8',	NULL,	0,	1,	NULL,	NULL,	'ADMIN',	'AQAAAAEAACcQAAAAEGTTq5cSY9h+4I3x5oepv29kz+1zkjZeYJ/RvZzH9b0SwV/8CjSXiKFLF+o3mseEGw=='	,NULL	,0	,'9cbe3394-2667-4367-9bd5-2c8548978cb4',	0,	'Admin');
GO