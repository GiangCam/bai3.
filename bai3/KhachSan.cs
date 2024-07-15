namespace bai3;
internal class KhachSan

{
    private List<Nguoi> danhSachKhachHang;
    public KhachSan()
    {
        danhSachKhachHang = new List<Nguoi>();
    }
    // Phương thức nhập thông tin khách trọ
    public void NhapThongTin(int soLuongKhach)
    {
        for (int i = 0; i < soLuongKhach; i++)
        {
            Console.WriteLine($"Nhập thông tin cho khách hàng thứ {1 + 1}:");
            Console.Write("Họ và tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Ngày sinh (dd/MM/yyyy): ");
            string ngaySinh = Console.ReadLine();
            Console.Write("Số CMND: ");
            string soCMND = Console.ReadLine();
            // Tạo đối tượng Nguoi và thêm vào danh sách
            Nguoi khachHang = new Nguoi(hoTen, ngaySinh, soCMND);
            danhSachKhachHang.Add(khachHang);
            Console.WriteLine();
        }
    }
    // Phương thức hiển thị thông tin các khách hàng đang trọ
    public void HienThiThongTin()
    {
        Console.WriteLine("Danh sách các khách hàng đang trọ tại khách sạn: ");
        foreach (var khachHang in danhSachKhachHang)
        {
            khachHang.Hienthithongtin();
            Console.WriteLine();
        }
    }
    // Phương thức tính số tiền cần phải trả dựa vào số CMND
    public double TinhTienThuePhong(string soCMND, int soNgayTro, double giaPhong)
    {
        // Tìm khách hàng trong danh sách
        foreach (Nguoi khachhang in danhSachKhachHang)
        {
            if (khachhang.CCCD == soCMND)
            {
                double tongTien = soNgayTro * giaPhong;
                Console.WriteLine($"Số tiến cần phải trả của khách hàng (khachhang. Hoten) là: (tongTien)");
                return tongTien;
            }
        }
        return 0;
    }
    public void XoaThongTin(string soCHND)
    {
        var khachhang = danhSachKhachHang.FirstOrDefault(kh => kh.CCCD == soCHND);
        if (khachhang != null)
        {
            danhSachKhachHang.Remove(khachhang);
            Console.WriteLine($"Đã xóa thông tin khách hangfcos số CMND {soCHND}");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy khách hàng có số CMND (soCMND) để xóa");
        }
    }
}
