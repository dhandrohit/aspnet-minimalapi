namespace ASPNET6MinimalAPI.Model
{
    public class TodoItemRepImplement : ITodoRep
    {
        List<TodoItem> _listItems;

        public TodoItemRepImplement()
        {
            _listItems = new List<TodoItem>()
            {
                new TodoItem() {Id = 1, Title = "Work with AWS Redshift"},
                new TodoItem() {Id = 2, Title ="ASP.NET Core 6 Minimal API"}
            };

        }

        public TodoItem CreateNewTodoItem(TodoItem item)
        {
            int newId = _listItems.Max(x => x.Id) + 1;
            item.Id = newId;
            _listItems.Add(item); 
            return _listItems.FirstOrDefault(x => x.Id == newId); 
        }

        public List<TodoItem> GetAll()
        {
            return _listItems;
        }

        public TodoItem GetById(int id)
        {
            return _listItems.FirstOrDefault(x => x.Id == id);
        }
    }
}
