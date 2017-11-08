
create proc ktUser @user nvarchar(50)
AS
begin
	SELECT UserName
	FROM TaiKhoan
	where @user = UserName
end
