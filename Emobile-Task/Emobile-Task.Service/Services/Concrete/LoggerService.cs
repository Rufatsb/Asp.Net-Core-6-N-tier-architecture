using Emobile_Task.Service.Services.Abstractions;
using Microsoft.Extensions.Hosting;
using System.Text;

namespace Emobile_Task.Service.Services.Concrete
{
    public class LoggerService : ILoggerService
    {
        string path;
        public LoggerService(IHostEnvironment env)
        {
            try
            {
                string date = DateTime.Now.ToString("d-M-yyyy");
                 path = $"{env.ContentRootPath}../Emobile-Task.DAL/Logs/{date}.txt";
                if (!File.Exists(path))
                {
                    using (File.Create(path))
                    {};
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
         

        }
        public void InfoPostedData(string message, object obj)
        {
            try
            {
                string time = DateTime.Now.ToString("HH,mm");
                using (StreamWriter stream = new(path, true, Encoding.UTF8))
                {
                    stream.WriteLine($"#Info# && saat:{time} && mesaj: {message} {obj}");
                };
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
          
        }
    }
}
