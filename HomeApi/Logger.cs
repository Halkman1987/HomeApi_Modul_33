namespace HomeApi
{
    public class Logger:ILogger
    {
        private ReaderWriterLockSlim lock_ = new ReaderWriterLockSlim();
        private string logDirectory { get; set; }   
        public Logger()
        {
            logDirectory = AppDomain.CurrentDomain.BaseDirectory + @"/_logs/" +
                DateTime.Now.ToString("G") + @"/";
            if(!Directory.Exists(logDirectory))
                Directory.CreateDirectory(logDirectory);
        }

        public void WriteEvent(string eventMess)
        {
            lock_.EnterWriteLock();
            try
            {
                using (StreamWriter sw = 
                    new StreamWriter(logDirectory + "events.txt", 
                    append: true))
                {
                    sw.WriteLine(eventMess);
                }
            }
           
            finally
            {
                lock_.ExitWriteLock();
            }
           
        }
        public void WriteError(string errorMess)
        {
            lock_.EnterWriteLock();
            try
            {
                using(StreamWriter sw = new StreamWriter("errors.txt",
                    append: true))
                {
                    sw.WriteLine(errorMess);
                }
            }
            finally { lock_.ExitWriteLock(); }
        }
    }
}
