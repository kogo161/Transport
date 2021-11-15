using Transport.Domain.Models.DbEntities;
using Transport.Domain.Models.Requests;
using Transport.Domain.Models.Response;
using Transport.Domain.Repositories;
using Transport.Domain.Services;
using Transport.Infrastructure.Repositories;
using Transport.Infrastructure.Store;

namespace Transport.Infrastructure.Services
{
    public class TransportService : ITransportService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TransportService(IUnitOfWork unitOfWork, TransportContext context)
        {
            _unitOfWork = unitOfWork;
            UnitOfWork s = new UnitOfWork(context);
        }

        public TransportResponse GetTrasport(int id)
        {
            var result = _unitOfWork.Transport.GetById(id);

            TransportResponse response = new TransportResponse
            {
                MarkLatName = result.MarkLatName,
                MarkGeoName = result.MarkGeoName,
                ModelLatName = result.ModelLatName,
                ModelGeoName = result.ModelGeoName,
                WinCode = result.WinCode,
                TransportNumber = result.TransportNumber,
                DateOfProduction = result.DateOfProduction,
                ColorIdentifier = result.ColorIdentifier,
                FuelType = result.FuelType,
                Photo = result.Photo
            };
            return response;
        }

        public void AddTransport(TransportRequest request)
        {
            var entity = new TransportEntity
            {
                MarkLatName = request.MarkLatName,
                MarkGeoName = request.MarkGeoName,
                ModelLatName = request.ModelLatName,
                ModelGeoName = request.ModelGeoName,
                WinCode = request.WinCode,
                TransportNumber = request.TransportNumber,
                DateOfProduction = request.DateOfProduction,
                ColorIdentifier = request.ColorIdentifier,
                FuelType = request.FuelType,
                Photo = request.Photo
            };
            _unitOfWork.Transport.Insert(entity);
            _unitOfWork.Save();
        }

        public void UpdateTransport(TransportRequest request)
        {
            var entity = new TransportEntity
            {
                Id = request.Id,
                MarkLatName = request.MarkLatName,
                MarkGeoName = request.MarkGeoName,
                ModelLatName = request.ModelLatName,
                ModelGeoName = request.ModelGeoName,
                WinCode = request.WinCode,
                TransportNumber = request.TransportNumber,
                DateOfProduction = request.DateOfProduction,
                ColorIdentifier = request.ColorIdentifier,
                FuelType = request.FuelType,
                Photo = request.Photo
            };
            _unitOfWork.Transport.Update(entity);
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            _unitOfWork.Transport.Delete(id);
            _unitOfWork.Save();
        }
    }
}