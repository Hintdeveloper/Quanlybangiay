Insert into NhanVien(ID, IDCV,Username,HoTen,GioiTinh,Email,AnhNv,NgaySinh,SoDienThoai,CCCD,MatKhau, DiaChi, TrangThai,GhiChu)
values(NEWID(), (Select ID from ChucVu where Ten like N'Trưởng phòng'), 'C', N'Nguyễn Văn C', 1, 'abcxyz@gmail.com', '', '1999-02-02', '0123456789', '001203035741', 'TP', 'Hanoi', 1, '')

select * from NhanVien

select * from ChucVu