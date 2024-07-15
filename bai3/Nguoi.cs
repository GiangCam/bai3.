namespace bai3;

internal class Nguoi
{
    public string Hoten;
    public string Ngaysinh;
    public string CCCD;
    public Nguoi (string hoten, string ngaysinh, string cccd)
    {
        Hoten = hoten;
        Ngaysinh = ngaysinh;
        CCCD = cccd;
    }
    public void Hienthithongtin()
    {
        Console.WriteLine("ho ten" + Hoten);    
        Console.WriteLine("ngay sinh" + Ngaysinh);  
        Console.WriteLine("cccd " + CCCD);
    }
}
