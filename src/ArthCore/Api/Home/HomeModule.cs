using Nancy;

namespace NancyApp.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", args => "Hello World");
        }
    }
}