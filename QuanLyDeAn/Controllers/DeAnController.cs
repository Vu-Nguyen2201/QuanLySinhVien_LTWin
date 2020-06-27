using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDeAn.Models;
using QuanLyDeAn.Views;

namespace QuanLyDeAn.Controllers
{
    public class DeAnController
    {
        public static bool ThemDeAn(DeAn dean)
        {
            try
            {
                using (var _context = new DBQuanLyDeAnEntities())
                {
                    _context.DeAns.Add(dean);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static List<DeAn> GetListDeAn()
        {
            using (var _context = new DBQuanLyDeAnEntities())
            {
                var dean = (from n in _context.DeAns
                            where n.status == 1
                            select n)
                            .Include("TienDoes")
                            .ToList();
                return dean;
            }
        }
        public static DeAn GetDeAn(int IDDeAn)
        {
            using (var _context = new DBQuanLyDeAnEntities())
            {
                var da = (from u in _context.DeAns
                            where u.IDDeAn == IDDeAn
                            && u.status == 1
                            select u)
                            .Include("TienDoes")
                            .ToList();
                if (da.Count == 1)
                {
                    return da[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static List<DeAn> GetDeAnGV(int IDGiaoVien)
        {
            using (var _context = new DBQuanLyDeAnEntities())
            {
                var da = (from u in _context.DeAns
                          where u.IDGiaoVien == IDGiaoVien
                          && u.status == 1
                          select u)
                          .Include("TienDoes")
                          .ToList();
                return da;
            }
        }
        public static bool CapNhatDeAn(DeAn dean)
        {
            try
            {
                using (var _context = new DBQuanLyDeAnEntities())
                {
                    var da = (from s in _context.DeAns
                              where s.IDDeAn == dean.IDDeAn
                              select s)
                              .Include("TienDoes")
                              .SingleOrDefault();

                    da.IDDeAn = dean.IDDeAn;
                    da.TenDeAn = dean.TenDeAn;
                    da.NoiDung = dean.NoiDung;
                    da.IDNhom = dean.IDNhom;
                    da.IDGiaoVien = dean.IDGiaoVien;
                    da.LoaiDeAn = dean.LoaiDeAn;
                    da.status = dean.status;
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool XoaDeAn(int IDDeAn)
        {
            try
            {
                using (var _context = new DBQuanLyDeAnEntities())
                {
                    var da = (from d in _context.DeAns
                                    where d.IDDeAn == IDDeAn
                                    select d)
                                  //.Include("Nhom").Include("TienDoes").Include("GiaoViens")
                                  .SingleOrDefault();
                    _context.DeAns.Remove(da);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
