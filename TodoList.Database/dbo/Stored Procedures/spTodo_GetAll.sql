-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spTodo_GetAll]

	@TodoListId int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select t.*
	from Todo t 
	inner join TodoList tl on t.FkTodoListId = tl.Id 
	where t.IsDeleted = 0 
	and FkTodoListId = @TodoListId 
	--order by t.DateCreated desc;
END
