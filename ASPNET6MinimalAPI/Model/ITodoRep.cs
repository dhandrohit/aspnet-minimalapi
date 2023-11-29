namespace ASPNET6MinimalAPI.Model
{
    public interface ITodoRep
    {
        List<TodoItem> GetAll();
        TodoItem GetById(int id);
        TodoItem CreateNewTodoItem (TodoItem item);
        
    }
}
