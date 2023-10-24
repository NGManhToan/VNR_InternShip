using Microsoft.EntityFrameworkCore;
using System.Linq;
using VNR_InternShip.Action.Interface;
using VNR_InternShip.DBContext;
using VNR_InternShip.Models;

namespace VNR_InternShip.Action
{
    public class KhoaHocAction:IKhoaHocAction
    {
        private readonly VnrInternShipContext _context;
        public KhoaHocAction(VnrInternShipContext context)
        {
            _context = context;
        }

        public async Task<List<KhoaHocModel>> GetListKhoaHoc()
        {
             var listKhoaHoc = await _context.KhoaHocs
                .Select(kh => new KhoaHocModel
                {
                    Id = kh.Id,
                    Image = kh.Image,
                    NameCourse = kh.TenKhoaHoc,
                }).ToListAsync();
            return listKhoaHoc;
        }

        public async Task<List<MonHocModel>> GetListMonHocByKhoaHoc(int Id)
        {
            var listMonHoc = await _context.MonHocs.Where(mh => mh.KhoaHocId == Id)
                .Select(mh => new MonHocModel
                {
                    Id = mh.Id,
                    ImageKH = mh.ImageKh,
                    NameTitle = mh.TenMonHoc,
                    Description = mh.MoTa,
                }).ToListAsync();

            return listMonHoc;
        }
    }
}
