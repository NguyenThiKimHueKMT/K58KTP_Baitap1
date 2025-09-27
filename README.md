# K58KTP_Baitap1  
Nguyễn Thị Kim Huệ  - K225480106026

K58KTP - Môn: Phát triển ứng dụng trên nền web

BÀI TẬP VỀ NHÀ 01:

TẠO SOLUTION GỒM CÁC PROJECT SAU:

DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL.

DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).

Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE

Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE

Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.

Projects cần tạo

1. Class Library (.NET Framework 2.0) — tạo DLL đa năng (ví dụ YourNameLib.dll):
   
Quan trọng: DLL độc lập — không đọc/ghi file, không sử dụng UI, không dùng console trực tiếp.

Nhận dữ liệu bằng thuộc tính public (ví dụ Input), trả kết quả bằng thuộc tính khác hoặc giá trị trả về của hàm (ví dụ Result, Execute() trả bool).

Biên dịch ra *.dll.

3. Console App (.NET Framework 2.0):

Gọi DLL: truyền input vào DLL qua thuộc tính/ hàm, lấy kết quả và in ra console.

Biên dịch ra EXE.

5. Windows Form Application (.NET Framework 2.0):
   
Giao diện lấy input (textbox, button), gọi DLL, show kết quả trong form (multiline textbox, label...).

7. Web App — ASP.NET Web Application (.NET Framework 2.0):
   
Client: index.html (HTML + CSS + JS) dùng để nhập input, tiền xử lý (nếu cần) bằng JS.

Client JS: gửi dữ liệu qua AJAX (ví dụ XMLHttpRequest hoặc fetch) tới api.aspx.

Server: api.aspx + api.aspx.cs (code-behind) — trong code-behind gọi DLL để xử lý dữ liệu và trả JSON cho client.

Web project build ra DLL (ASP.NET assemblies) và phải chạy qua IIS (cài site, bind host name bằng file hosts).

Bài toán: 

<img width="655" height="695" alt="image" src="https://github.com/user-attachments/assets/c591fc92-6c8f-4ffa-9ddb-4eab4995377c" />   

Các bước thực hiện

Bước 1: Tạo Solution

Mở Visual Studio 2022.

Chọn File → New → Project.

Tìm template Blank Solution (hoặc gõ từ khóa "Blank Solution" trong ô tìm kiếm).  

Đặt tên Solution : Lamtho → Create.  

<img width="1919" height="1005" alt="image" src="https://github.com/user-attachments/assets/44964471-d2a2-4bae-a850-fd20d903735b" />   

Bước 2: Tạo Project - Class Library (DLL) — ThoLibrary  

Trong Solution Explorer, click phải vào Solution : Pikachu → Add → New Project.

Gõ tìm: Class Library (.NET Framework).  

Chọn → Next.   

Đặt tên project: Pikachu.  

Ở phần Framework → chọn .NET Framework 2.0 → Create.  

Trong Solution Explorer, click phải vào Solution : Pikachu → Add → New Project.

Gõ tìm: Class Library (.NET Framework).

Chọn → Next.

Đặt tên project: Tho

Ở phần Framework → chọn .NET Framework 2.0 → Create.



