using Transport.Domain.Models.DbEntities;
using Transport.Domain.Models.Requests;
using Transport.Domain.Models.Response;
using Transport.Domain.Repositories;
using Transport.Domain.Services;
using Transport.Infrastructure.Store;

namespace Transport.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly TransportContext _context;

        public UserService(IUnitOfWork unitOfWork, TransportContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }

        public UserResponse GetUser(int id)
        {
            var result = _unitOfWork.User.GetById(id);
            var response = new UserResponse
            {
                FirstName = result.FirstName,
                LastName = result.LastName,
                PersonalNumber = result.PersonalNumber
            };

            return response;
        }

        public void AddUser(UserRequest request)
        {
            UserEntity entity = new UserEntity
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                PersonalNumber = request.PersonalNumber
            };
            _unitOfWork.User.Insert(entity);
            _unitOfWork.Save();
        }

        public void DeleteUser(int id)
        {
            _unitOfWork.User.Delete(id);
            _unitOfWork.Save();
        }
    }
}