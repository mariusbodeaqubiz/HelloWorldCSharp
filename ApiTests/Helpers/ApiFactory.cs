using RestSharp;

namespace ApiTests.Helpers
{
    public static class ApiFactory
    {
        public static IRestResponse<T> GetMethod<T>(string route) where T : new()
        {
            var client = BaseClass.Client();
            var request = new RestRequest(route, Method.GET);

            request.RequestFormat = DataFormat.Json;
            var response = client.Execute<T>(request);

            return response;
        }

        public static IRestResponse<T> PostMethod<T>(string route, T data) where T : new()
        {
            var client = BaseClass.Client();
            var request = new RestRequest(route, Method.POST);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");

            request.RequestFormat = DataFormat.Json;
            request.AddBody(data);
            var response = client.Execute<T>(request);

            return response;
        }
    }
}
