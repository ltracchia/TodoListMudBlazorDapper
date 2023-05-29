-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spTodoList_Insert]
	
	@Id int,
	@ProjectId int = null,
	@Name varchar(50),
	@Description varchar(200)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into TodoList (FkProjectId, [Name], [Description]) values (@ProjectId, @Name, @Description)
END
GO

