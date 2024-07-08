// Nhap danh sach hoc sinh 
using bai1;
  
List<HocSinh>dshs = new List<HocSinh>();
Console.Write("Nhap so luong hoc sinh:");
int n=int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.Write("Nhap thong tin hoc sinh" + (i + 1) + ":");
    Console.WriteLine("Ma hoc sinh: ");
    string mahs = Console.ReadLine();
    Console.WriteLine("hoten hoc sinh:");
    string hoten = Console.ReadLine();
    Console.WriteLine("Gioi Tinh:");
    string gioitinh = Console.ReadLine();
    Console.WriteLine("Dia chi:");
    string diachi = Console.ReadLine();
    Console.WriteLine("Diem toan:");
    float toan = float.Parse(Console.ReadLine());
    Console.WriteLine("Diem ly;");
    float ly = float.Parse(Console.ReadLine());
    Console.WriteLine("Diem hoa:");
    float hoa = float.Parse(Console.ReadLine());
    HocSinh hs = new HocSinh(mahs, hoten, gioitinh, diachi, toan, ly, hoa);
    dshs.Add(hs);
}
    // xuat danh sach hoc sinh
    Console.WriteLine("Danh sach hoc sinh");
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(dshs[i].Mahs + "\t" + dshs[i].Hoten + "\t" + dshs[i].Phai + "\t" + dshs[i].diachi + "\t" + dshs[i].Diemtoan + "\t" + dshs[i].DiemLy + "\t" + dshs[i].DiemHoa + "\t" + dshs[i].Dtb);
    }


