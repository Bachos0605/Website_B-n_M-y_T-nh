/*using Microsoft.AspNetCore.Mvc;
using DungBachComputer.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

public class TaiKhoanController : Controller
{
    private readonly DungBachComputerContext _dbContext;

    public TaiKhoanController(DungBachComputerContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult DangNhap(string taiKhoan, string matKhau)
    {
        try
        {
            // Tìm khách hàng theo Email và Phone trong bảng KhachHang
            var khachHang = _dbContext.KhachHangs.FirstOrDefault(kh => kh.Email == taiKhoan && kh.Phone == matKhau);
            //var khachHang = _dbContext.KhachHangs.FirstOrDefault(kh => kh.Email == taiKhoan && kh.Phone == matKhau.ToString());

            if (khachHang != null)
            {
                // Đăng nhập thành công
                ViewData["ThongBao"] = "Đăng nhập thành công!";
            }
            else
            {
                // Đăng nhập thất bại
                ViewData["ThongBao"] = "Tài khoản hoặc mật khẩu không đúng!";
            }
        }
        catch (Exception ex)
        {
            // Xử lý lỗi khi đăng nhập
            ViewData["ThongBao"] = $"Đăng nhập thất bại. Lỗi: {ex.Message}";
        }

        return View();
    }

    [HttpPost]
    public IActionResult DangKy(KhachHang khachHang)
    {
        try
        {
            // Kiểm tra và lưu thông tin đăng ký vào cơ sở dữ liệu
            _dbContext.KhachHangs.Add(khachHang);
            _dbContext.SaveChanges();

            ViewData["ThongBao"] = "Đăng ký thành công!";
        }
        catch (Exception ex)
        {
            // Xử lý lỗi khi đăng ký
            ViewData["ThongBao"] = $"Đăng ký thất bại. Lỗi: {ex.Message}";
        }

        return View();
    }
}*/
