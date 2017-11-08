
create proc KiemTraTaikhoan @user nvarchar(50), @pass nchar(20)

AS
begin
	
		SELECT 1
		FROM TaiKhoan tk
		where tk.UserName = @user and tk.Password = @pass

end
