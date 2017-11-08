create proc [dbo].[TaoTaiKhoan] @user nvarchar(50), @pass nchar(20), @name nvarchar(50)
AS
BEGIN
	insert into TaiKhoan(UserName, [Password], NickName)
	values (@user, @pass, @name)
END
