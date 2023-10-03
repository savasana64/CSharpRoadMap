namespace DependencyInjectionExample
{

    //decoupling the implementation code from the calling code (the caller has control over the code)
    internal class DependencyInjection
    {
        static void Main(string[] args)
        {
            ILogger logger;

            string loggerType = "Text";


            switch (loggerType)
            {
                case "dataBase":
                    logger = new DataBaseLogger();
                    break;

                default:
                    logger = new TextLogger();
                    break;
            }
            logManager logManager = new logManager(logger);
            try
            {
                throw new DivideByZeroException();

            } catch (Exception ex)
            {
                logManager.Log(ex.Message);
            }
        }
    }

    interface ILogger
    {
        void Log(string message);
    }

    class logManager
    { 
        private readonly ILogger _logger;

        public logManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            _logger.Log(message);
        }
    }
}