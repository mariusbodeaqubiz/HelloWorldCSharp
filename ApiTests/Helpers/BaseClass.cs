using RestSharp;

namespace ApiTests.Helpers
{
    class BaseClass
    {
        public static RestClient Client()
        {
            var client = new RestClient("http://bodeamariuscosmin.pythonanywhere.com/mlot/api");
            return client;
        }
    }
}
