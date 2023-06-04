-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spTodoList_Delete]
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    --mark the todo list as deleted
	--delete from todolist where Id = @Id;

	-- mark all the todos in the list to deleted
	--update todo set IsDeleted = 1 where FkTodoListId = @Id

END