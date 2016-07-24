USE [C:\USERS\TIM\DOCUMENTS\VISUAL STUDIO 2013\PROJECTS\MASTERSAMPLE\MASTERSAMPLE\APP_DATA\DATABASE1.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[InsertNewUser]
		@LastName = N'Brown',
		@FirstName = N'Jim',
		@UserName = N'jbrown',
		@Address = N'1234 Main',
		@City = N'Indianapolis',
		@State = N'IN',
		@Zip = N'46037',
		@Phone = N'317-555-1212',
		@Email = N'jbrown@iupui.edu',
		@Password = N'mypassword'

SELECT	@return_value as 'Return Value'

GO
