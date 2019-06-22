using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConCore
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            //IQueryable<int> lb =Queryable.Where()
            ArrayList al = new ArrayList();
            al.Cast<int>();
            IConfiguration configuration = new ConfigurationBuilder().SetBasePath(Environment.CurrentDirectory).AddJsonFile("Test.json").Build();

            var t1 = configuration.GetValue<string>("Test1");

            Rootobject rbt = new Rootobject();
            configuration.Bind(rbt);

        var t = configuration["Test1"];

        ServiceCollection service = new ServiceCollection();

        service.AddTransient<IFly, Pig>();

            service.AddLogging();

            var provider = service.BuildServiceProvider();

        provider.GetService<ILoggerFactory>().AddConsole(LogLevel.Debug);

        var fly = provider.GetService<IFly>();

        fly.Fly();

            Console.ReadKey();

            
        }
}

public interface IFly
{
    void Fly();
}
public class Pig : IFly
{
    ILogger<Pig> logger = null;

    public Pig(ILoggerFactory loggerFactory)
    {
        logger = loggerFactory.CreateLogger<Pig>();
    }
    public void Fly()
    {
        logger.LogInformation("日志");

        Console.WriteLine("猪飞了");
    }
}

    public class Rootobject
    {
        public string Test1 { get; set; }
    }
}
