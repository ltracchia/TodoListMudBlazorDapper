namespace TodoList.DataAccess.Models
{
    public class TodoModel
    {
        public int Id { get; set; }
        public int TodoListId { get; set; }
        public string TodoName { get; set; }
        public string Description { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsComplete { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DueDate { get; set; }
        public bool HideDueIn { get; set; }
        public string DueInDays { get; set; }
        public string DueInColor { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string LineThroughCSS
        {
            get
            {
                if (IsComplete) return "text-decoration:line-through; color:#ccc;";
                else return string.Empty;
            }
        }
    }
}
