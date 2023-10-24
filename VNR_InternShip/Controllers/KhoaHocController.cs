using Microsoft.AspNetCore.Mvc;
using VNR_InternShip.Service.Interface;

namespace VNR_InternShip.Controllers
{
    public class KhoaHocController: Controller
    {
        private readonly IKhoaHocService _khoaHocService;

        public KhoaHocController(IKhoaHocService khoaHocService)
        {
            _khoaHocService = khoaHocService;
        }
        [HttpGet]
        public async Task<IActionResult> ListKhoaHoc()
        {
            var list = await _khoaHocService.GetListKhoaHoc();
            return View(list);
        }

        [HttpGet]
        public async Task<IActionResult>ListMonHoc(int idKhoahoc)
        {
            var listKH = await _khoaHocService.GetListMonHocByKhoaHoc(idKhoahoc);
            return View(listKH);
        }
    }
}
