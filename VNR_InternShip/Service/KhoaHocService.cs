using VNR_InternShip.Action.Interface;
using VNR_InternShip.Models;
using VNR_InternShip.Service.Interface;

namespace VNR_InternShip.Service
{
    public class KhoaHocService:IKhoaHocService
    {
        private readonly IKhoaHocAction _khoaHocAction;

        public KhoaHocService(IKhoaHocAction khoaHocAction)
        {
            _khoaHocAction = khoaHocAction;
        }

        public async Task<List<KhoaHocModel>> GetListKhoaHoc()
        {
            return await _khoaHocAction.GetListKhoaHoc();
        }

        public async Task<List<MonHocModel>> GetListMonHocByKhoaHoc(int Id)
        {
            return await _khoaHocAction.GetListMonHocByKhoaHoc(Id);
        }
    }
}
