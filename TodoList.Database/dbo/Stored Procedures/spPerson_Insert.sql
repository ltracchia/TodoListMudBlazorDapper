-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spPerson_Insert]
	@FirstName varchar(50),
	@LastName varchar(50),
	@UserName nvarchar(256)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Person (FirstName, LastName, UserName, DateCreated) values (@FirstName, @LastName, @UserName, getdate());

END