using System.Collections.Generic;
using Transport.Domain.Models.Requests;
using Transport.Domain.Models.Response;

namespace Transport.Domain.Services
{
    public interface IUserService
    {
        UserResponse GetUser(int id);
        void AddUser(UserRequest request);
        void DeleteUser(int id);
        List<UserResponse> GetUserWithTransport(int id);
    }
}