using VNR_InternShip.Models;

namespace VNR_InternShip.Service.Interface
{
    public interface IKhoaHocService
    {
        Task<List<KhoaHocModel>> GetListKhoaHoc();
        Task<List<MonHocModel>> GetListMonHocByKhoaHoc(int Id);
    }
}
