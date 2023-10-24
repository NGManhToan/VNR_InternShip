using VNR_InternShip.Models;

namespace VNR_InternShip.Action.Interface
{
    public interface IKhoaHocAction
    {
        Task<List<KhoaHocModel>> GetListKhoaHoc();

        Task<List<MonHocModel>> GetListMonHocByKhoaHoc(int id);
    }
}
