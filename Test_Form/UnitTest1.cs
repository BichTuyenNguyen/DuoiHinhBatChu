using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KiemThuPM;
using System.Windows.Forms;
namespace FormTester
{
    [TestClass]
    public class UnitTest1
    {
        // test form SignIn
        public FrmSignIn signIn;
        [TestMethod]
        public void TestSignIn_True()
        {
            signIn = new FrmSignIn();
            bool expected = true;
            Assert.AreEqual(expected, signIn.KiemTraDangNhap("tuyen", "tuyen"));

        }//tên đăng nhập, mật khẩu đúng
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestSignIn_False_Pass()
        {
            signIn = new FrmSignIn();
            signIn.KiemTraDangNhap("tuyen", "1");
        }// tên đăng nhập đúng , mật khẩu sai

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestSignIn_False_User()
        {
            signIn = new FrmSignIn();
            signIn.KiemTraDangNhap("an", "1111");
        }// tên đăng nhập sai, mật khẩu đúng

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestSignIn_False()
        {
            signIn = new FrmSignIn();
            signIn.KiemTraDangNhap("an", "1");
        }// tên đăng nhập sai , mật khẩu sai


        //test form SignUp
        public FrmSignUp signUp;
        [TestMethod, Ignore]
        public void TestSignUp_True()
        {
            signUp = new FrmSignUp();
            bool expected = true;
            Assert.AreEqual(expected, signUp.KiemTraDangKy("concho1", "concho", "cho"));

        }//tên đăng nhập, mật khẩu đúng --> muốn test lại, phải đổi user
     
    }
}
