
create proc DoiMatKhau @user nvarchar(50), @pass nvarchar(10), @newPass nvarchar(50)
AS
BEGIN
	update TaiKhoan
	set [Password] = @newPass
	where UserName = @user and [Password] = @pass
END
