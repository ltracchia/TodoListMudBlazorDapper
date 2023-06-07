-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spPerson_Insert
	@FirstName varchar(50),
	@LastName varchar(50),
	@UserId nvarchar(250)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Person (FirstName, LastName, FkUserId, DateCreated) values (@FirstName, @LastName, @UserId, getdate());

END