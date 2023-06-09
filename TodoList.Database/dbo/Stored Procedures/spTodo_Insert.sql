﻿-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spTodo_Insert]	
	@TodoListId int,
	@Name varchar(100),
	@Description varchar(200)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Todo (FkTodoListId, [Name], [Description], DateCreated) values (@TodoListId, @Name, @Description, getdate())

	select scope_identity() as 'Id'
END
