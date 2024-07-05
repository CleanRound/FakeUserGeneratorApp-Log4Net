using log4net;
using log4net.Config;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config", Watch = true)]

namespace FakeUserGeneratorApp
{
    class Program
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            XmlConfigurator.Configure(new FileInfo("log4net.config"));

            logger.Info("Application started.");

            for (int i = 0; i < 5; i++)
            {
                var fakeUser = FakeUser.GenerateFakeUser();
                logger.Info($"Generated User: {fakeUser.Name} {fakeUser.Surname}, {fakeUser.ContactPhoneNumber}, {fakeUser.Email}, {fakeUser.Address}");
                Console.WriteLine($"Name: {fakeUser.Name}");
                Console.WriteLine($"Surname: {fakeUser.Surname}");
                Console.WriteLine($"Contact Phone Number: {fakeUser.ContactPhoneNumber}");
                Console.WriteLine($"Email: {fakeUser.Email}");
                Console.WriteLine($"Address: {fakeUser.Address}");
                Console.WriteLine("----------------------------");
            }

            logger.Info("Application finished.");
        }
    }
}
