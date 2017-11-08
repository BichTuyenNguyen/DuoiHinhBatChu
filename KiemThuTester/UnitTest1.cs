using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KiemThuPM;

namespace KiemThuTester
{
    [TestClass]
    public class UnitTest1
    {
        // Kiểm tra form đăng nhập
        FrmSignIn dn;       
        [TestMethod]
        public void TestDangNhap1() 
        {
            dn = new FrmSignIn();
            bool expected = true;
            Assert.AreEqual(expected, dn.KiemTraDangNhap("tuyen","1"));
        }// user và pass đúng

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestDangNhap2()
        {
            dn = new FrmSignIn();
            dn.KiemTraDangNhap("baodo", "1");
        }// user và pass sai

        // Kiểm tra form đăng ký
        FrmSignUp dk;
        [TestMethod, Ignore]
        public void TestDangKi1()
        {
            dk = new FrmSignUp();
            bool expected = true;
            Assert.AreEqual(expected, dk.KiemTraDangKy("conmeo", "con","con cho"));
        }// user chưa có người dùng => muốn test lại lần nữa phải đổi tên user

        [TestMethod, Ignore]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDangKi2()
        {
            dk = new FrmSignUp();
            bool expected = true;
            Assert.AreEqual(expected, dk.KiemTraDangKy("concho", "con", "con cho"));
        }// user  đã có người dùng => không test được vì liên quan đến cơ sở dữ liệu

    }

}
