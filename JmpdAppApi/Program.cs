namespace JmpdAppApi
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
           var host = Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuiler =>
            {
                webBuiler.UseStartup<Startup>();
            });

            return host;
        }
    }
}
