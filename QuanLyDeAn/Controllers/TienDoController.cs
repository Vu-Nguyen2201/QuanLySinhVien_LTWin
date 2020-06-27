using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDeAn.Models;

namespace QuanLyDeAn.Controllers
{
    public class TienDoController
    {
        public static bool ThemTienDo(TienDo td)
        {
            try
            {
                using (var _context = new DBQuanLyDeAnEntities())
                {
                    _context.TienDoes.Add(td);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static List<TienDo> GetListTienDo(int IDNhom)
        {
            using (var _context = new DBQuanLyDeAnEntities())
            {
                var tiendo = (from n in _context.TienDoes
                              where n.IDNhom == IDNhom
                              && n.status == 1
                              select n)
                              .ToList();
                return tiendo;
            }
        }
        public static bool XoaTienDo(int IDTienDo)
        {
            try
            {
                using (var _context = new DBQuanLyDeAnEntities())
                {
                    var tiendo = (from n in _context.TienDoes
                                  where n.IDTienDo == IDTienDo
                                  select n)
                                .SingleOrDefault();
                    _context.TienDoes.Remove(tiendo);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static TienDo GetTienDo(int IDTienDo)
        {
            using (var _context = new DBQuanLyDeAnEntities())
            {
                var tiendo = (from td in _context.TienDoes
                                where td.IDTienDo == IDTienDo
                                && td.status == 1
                                select td)
                              .SingleOrDefault();

                if (tiendo != null)
                {
                    return tiendo;
                }
                else
                {
                    return null;
                }
            }
        }
        public static bool CapNhatTienDo(TienDo tiendo)
        {
            try
            {
                using (var _context = new DBQuanLyDeAnEntities())
                {
                    var td = (from t in _context.TienDoes
                                  where t.IDTienDo == tiendo.IDTienDo
                                  select t)
                                .SingleOrDefault();
                    td.NoiDung = tiendo.NoiDung;
                    td.TaiLieuBaoCao = tiendo.TaiLieuBaoCao;
                    td.ThoiGianBaoCao = tiendo.ThoiGianBaoCao;
                    td.HoanThanh = tiendo.HoanThanh;
                    td.NhanXet = tiendo.NhanXet;
                    td.IDSinhVien = tiendo.IDSinhVien;
                    td.status = tiendo.status;
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
