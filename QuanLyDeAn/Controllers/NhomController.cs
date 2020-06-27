using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDeAn.Models;

namespace QuanLyDeAn.Controllers
{
    public class NhomController
    {
        public static bool ThemNhom (Nhom nhom)
        {
            try
            {
                using (var _context = new DBQuanLyDeAnEntities())
                {
                    _context.Nhoms.Add(nhom);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static List<Nhom> GetListNhom()
        {
            using (var _context = new DBQuanLyDeAnEntities())
            {
                var nhom = (from n in _context.Nhoms
                            where n.status == 1
                            select n)
                            .Include("DeAns")
                            .Include("SinhViens")
                            .Include("TienDoes")
                            .ToList();
                return nhom;
            }
        }
        public static Nhom GetNhom(int IDNhom)
        {
            using (var _context = new DBQuanLyDeAnEntities())
            {
                var nhom = (from n in _context.Nhoms
                            where n.IDNhom == IDNhom
                            && n.status == 1
                            select n)
                            .SingleOrDefault();
                if (nhom != null)
                {
                    return nhom;
                }
                else
                {
                    return null;
                }
            }
        }
        public static bool CapNhatNhom(Nhom nhom)
        {
            try
            {
                using (var _context = new DBQuanLyDeAnEntities())
                {
                    var dbNhom = (from n in _context.Nhoms
                                where n.IDNhom == nhom.IDNhom
                                select n)
                            .Include("DeAns")
                            .Include("SinhViens")
                            .SingleOrDefault();
                    dbNhom.TenNhom = nhom.TenNhom;
                    dbNhom.status = nhom.status;
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool XoaNhom(int IDNhom)
        {
            try
            {
                using (var _context = new DBQuanLyDeAnEntities())
                {
                    var dbNhom = (from n in _context.Nhoms
                                  where n.IDNhom == IDNhom
                                  select n)
                            .Include("DeAns")
                            .Include("SinhViens")
                            .SingleOrDefault();
                    _context.Nhoms.Remove(dbNhom);
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
