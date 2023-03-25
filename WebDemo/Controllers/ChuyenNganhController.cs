using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManCityUnited.Models;

namespace ManCityUnited.Controllers
{
    public class ChuyenNganhController : Controller
    {
        static List<PhieuDangKy> phieuDangKy = new List<PhieuDangKy>();


        public ActionResult DangKy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LuuDangKy()
        {
            string hoTen = Request.Form["hoten"];
            string mssv = Request.Form["mssv"];
            string chuyenNganh = Request.Form["chuyennganh"];

            //ViewBag.hoTen = hoTen;
            //ViewBag.mssv = mssv;
            //ViewBag.chuyennganh = chuyenNganh;

            PhieuDangKy phieu = new PhieuDangKy()
            {
                HoTen = hoTen,
                ChuyenNganh = chuyenNganh,
                mssv = mssv
            };

            int sl = phieuDangKy.Count(p => p.ChuyenNganh == chuyenNganh);

            ViewBag.message = "abc" + sl;

            phieuDangKy.Add(phieu);

            //Gửi thông tin đã nhận và thông báo kết quả
            return View("KetQuaDangKy", phieu);
        }

        public ActionResult LayDanhSach()
        {
            return View("DanhSach", phieuDangKy);
        }
    }
}