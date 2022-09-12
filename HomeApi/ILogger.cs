namespace HomeApi
{
    public interface ILogger
    {
        public void WriteEvent(string eventMess);
        public void WriteError(string errorMess);
    }
}
