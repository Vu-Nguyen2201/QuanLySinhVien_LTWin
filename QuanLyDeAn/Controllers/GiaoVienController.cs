using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDeAn.Models;

namespace QuanLyDeAn.Controllers
{
    public class GiaoVienController
    {
        public static bool ThemGV(GiaoVien giaovien)
        {
            try
            {
                using (var _context = new DBQuanLyDeAnEntities())
                {
                    _context.GiaoViens.Add(giaovien);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static List<GiaoVien> GetListGiaoVien()
        {
            using (var _context = new DBQuanLyDeAnEntities())
            {
                var gv = (from n in _context.GiaoViens.AsEnumerable()
                          where n.status == 1
                          && n.status == 1
                          select n)
                          .Select(x => new GiaoVien
                          {
                              IDGiaoVien = x.IDGiaoVien,
                              BoMon = x.BoMon,
                              SDT = x.SDT,
                              GioiTinh = x.GioiTinh,
                              NgaySinh = x.NgaySinh,
                              Email = x.Email,
                              HoTen = x.HoTen,
                              ad = x.ad,
                              pass=x.pass,
                              username=x.username,
                              status=x.status
                          }).ToList();

                return gv;
            }
        }
        public static GiaoVien GetGV(int ID)
        {
            using (var _context = new DBQuanLyDeAnEntities())
            {
                var task = (from u in _context.GiaoViens
                            where u.IDGiaoVien == ID
                            && u.status == 1
                            select u)
                            .ToList();
                if (task.Count == 1)
                {
                    return task[0];
                }
                else
                {
                    return null;
                }
            }

        }
        public static bool deleteGV(int row)
        {
            try
            {
                using (var _context = new DBQuanLyDeAnEntities())
                {
                    var gv = (from u in _context.GiaoViens
                              where u.IDGiaoVien == row
                              select u).Single();    
                    _context.GiaoViens.Remove(gv);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool UpdateGV(GiaoVien GV)
        {
            try
            {
                using (var _context = new DBQuanLyDeAnEntities())
                {
                    var userdb = _context.GiaoViens.Single(u => u.IDGiaoVien == GV.IDGiaoVien);
                    userdb.IDGiaoVien = GV.IDGiaoVien;
                    userdb.NgaySinh = GV.NgaySinh;
                    userdb.BoMon = GV.BoMon;
                    userdb.GioiTinh = GV.GioiTinh;
                    userdb.SDT = GV.SDT;
                    userdb.Email = GV.Email;
                    userdb.HoTen = GV.HoTen;
                    userdb.username = GV.username;
                    userdb.pass = GV.pass;
                    userdb.status = GV.status;
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static GiaoVien DangNhap(GiaoVien giaovien)
        {
            using (var _context = new DBQuanLyDeAnEntities())
            {
                var task = (from u in _context.GiaoViens
                            where u.username == giaovien.username
                            && u.pass == giaovien.pass
                            && u.status == 1
                            select u)
                            .ToList();
                if (task.Count == 1)
                {
                    return task[0];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
