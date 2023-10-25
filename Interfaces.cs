using Microsoft.AspNetCore.Identity;
using System;
using System.Net.Http.Json;

namespace PP_rating_module
{
    public interface IGetUser
    {
        public UserStat? GetUser(string name);
    }


    public class GetUserochek : IGetUser
    {
        public UserStat? GetUser(string name)
        {
            return null;
        }
    }

    public interface IFindUser
    {
       public Task<List<Userochek>> FindUser(string name);
    }


    public class FindUserochek : IFindUser
    {
        static HttpClient httpClient = new HttpClient();

        async public Task<List<Userochek>>  FindUser(string name)
        {

            object? data = await httpClient.GetFromJsonAsync<List<Userochek>>($"http://192.168.88.30:8080/api/users?={name}");
            if (data is List<Userochek> us)
            {
                foreach (var item in us)
                {
                    Console.WriteLine($"Id: {item.Id}   Name: {item.Name}");
                }
                return us;
            }
            else
            {
                Console.WriteLine("Big FAIL");
                return null;
            }         
        }
    }

}
