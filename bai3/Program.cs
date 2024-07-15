using bai3;

KhachSan khachSan = new KhachSan();

Console.Write("Nhap so luong khach hang: ");
int n = int.Parse(Console.ReadLine());

khachSan.NhapThongTin(n);

Console.WriteLine("\nDanh sach khach tro:");
khachSan.HienThiThongTin();
Console.Write("\nNhập số CMND để tính tiền thuê phòng: ");
string cmnd = Console.ReadLine();

Console.Write("Nhập số ngày trọ: ");
int soNgayTro = int.Parse(Console.ReadLine());

Console.Write("Nhập giá phòng mỗi ngày: "); 
double giaPhong = double.Parse(Console.ReadLine());

khachSan.TinhTienThuePhong(cmnd, soNgayTro, giaPhong);

Console.Write("\nNhập số CMND của khách hàng muốn xóa thông tin: ");
string cmndXoa = Console.ReadLine();
khachSan.XoaThongTin(cmndXoa);

Console.WriteLine("\nDanh sách cập nhật sau khi xóa: ");
khachSan.HienThiThongTin();