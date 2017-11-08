--
create proc LuuDiem  @name nvarchar(50), @diem int
AS
BEGIN
	insert into BangXepHang(name, diem)
	values (@name, @diem)
END
