partial class Task
{
    string taskName;
    int doneDate;
    int dueDate;

    
    public int DueDate
    {
        get {
            return dueDate;
        }
    }


    Logger logger = Logger.GetLogger();

    public Task(string taskName, int dueDate)
    {
        this.taskName = taskName;
        this.dueDate = dueDate;
    }
    internal void Do(int day)
    {
        doneDate = day;
        logger.Write(this);
    }
}