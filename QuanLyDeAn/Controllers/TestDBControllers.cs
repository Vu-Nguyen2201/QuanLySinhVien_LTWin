using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDeAn.Models;

namespace QuanLyDeAn.Controllers
{
    public class TestDBController
    {
        public static void initializeDB()
        {
            using (var _context = new DBQuanLyDeAnEntities())
            {
                var sinhvien = new SinhVien
                {
                    HoTen = "Nguyễn Văn A",
                    MSSV = "18133066",
                    SDT = "0386232296",
                    Email = "VanA@gmail.com",
                    NgaySinh = DateTime.Parse("2020-06-30"),
                    GioiTinh = "Nam"
                };
                _context.SinhViens.Add(sinhvien);
                _context.SaveChanges();
            }
            MessageBox.Show("Finish!");
        }
    }
}