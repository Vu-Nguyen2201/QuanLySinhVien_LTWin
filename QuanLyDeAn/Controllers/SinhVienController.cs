using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using QuanLyDeAn.Models;

namespace QuanLyDeAn.Controllers
{
    public class SinhVienController
    {
        public static bool ThemSinhVien(SinhVien sinhvien)
        {
            try
            {
                using (var _context = new DBQuanLyDeAnEntities())
                {
                    _context.SinhViens.Add(sinhvien);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static List<SinhVien> GetListSinhVien()
        {
            using (var _context = new DBQuanLyDeAnEntities())
            {
                var sv = (from n in _context.SinhViens
                          where n.status == 1
                            select n)
                            .Include("Nhom")
                            .Include("TienDoes")
                            .ToList();
                return sv;
            }
        }
        public static SinhVien GetSinhVien(int IDSinhVien)
        {
            using (var _context = new DBQuanLyDeAnEntities())
            {
                var sinhvien = (from s in _context.SinhViens
                                where s.IDSinhVien == IDSinhVien
                                && s.status == 1
                                select s)
                              .Include("Nhom")
                              .Include("TienDoes")
                              .SingleOrDefault();

                if(sinhvien != null)
                {
                    return sinhvien;
                }
                else
                {
                    return null;
                }
            }
        }
        public static List<SinhVien> GetSinhVienThuocNhom(int IDNhom)
        {
            using (var _context = new DBQuanLyDeAnEntities())
            {
                var nhom = (from n in _context.Nhoms
                            where n.IDNhom == IDNhom
                            && n.status == 1
                            select n)
                            .SingleOrDefault();
                if(nhom == null)
                {
                    return null;
                }
                var sinhvien = (from s in _context.SinhViens
                                where s.IDNhom == IDNhom
                                && s.status == 1
                                select s)
                              .Include("Nhom")
                              .Include("TienDoes")
                              .ToList();

                if (sinhvien != null)
                {
                    return sinhvien;
                }
                else
                {
                    return null;
                }
            }
        }
        public static bool CapNhatSinhVien(SinhVien sinhvien)
        {
            try
            {
                using (var _context = new DBQuanLyDeAnEntities())
                {
                    var sv = (from s in _context.SinhViens
                              where s.IDSinhVien == sinhvien.IDSinhVien
                              select s)
                              .Include("Nhom")
                              .Include("TienDoes")
                              .SingleOrDefault();

                    sv.HoTen = sinhvien.HoTen;
                    sv.MSSV = sinhvien.MSSV;
                    sv.NgaySinh = sinhvien.NgaySinh;
                    sv.Email = sinhvien.Email;
                    sv.SDT = sinhvien.SDT;
                    sv.GioiTinh = sinhvien.GioiTinh;
                    sv.IDNhom = sinhvien.IDNhom;
                    sv.status = sinhvien.status;
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool XoaSinhVien(int IDSinhVien)
        {
            try
            {
                using (var _context = new DBQuanLyDeAnEntities())
                {
                    var sinhvien = (from s in _context.SinhViens
                                    where s.IDSinhVien == IDSinhVien
                                    select s)
                                  //.Include("Nhom").Include("TienDoes")
                                  .SingleOrDefault();
                    _context.SinhViens.Remove(sinhvien);
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
