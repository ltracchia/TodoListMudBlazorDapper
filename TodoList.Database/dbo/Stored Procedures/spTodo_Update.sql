-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spTodo_Update]
	@Id int,
	@Name varchar(100),
	@Description varchar(200),
	@IsComplete bit, 
	@IsFavorite bit,
	@IsDeleted bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Todo set [Name] = @Name, [Description] = @Description, IsComplete = @IsComplete, IsFavorite = @IsFavorite, IsDeleted = @IsDeleted, DateModified = getdate() where Id = @Id

END
