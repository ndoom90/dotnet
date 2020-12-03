using System;
namespace AuthenticationJwt
{
    public interface IJwtAuthenticationManager
    {
        string Authenticate(string username, string password);
    }
}
