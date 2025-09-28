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

<img width="1901" height="1010" alt="image" src="https://github.com/user-attachments/assets/d7043ee0-ad0b-4cc3-849d-2146c40856f8" />

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

Đặt tên project: ThoLibrary  

Ở phần Framework → chọn .NET Framework 2.0 → Create.
<img width="1899" height="998" alt="image" src="https://github.com/user-attachments/assets/144b0d30-2ee3-4851-b708-a96397a5fba5" />  

DLL này sẽ được dùng lại trong Console App, WinForm, và Web.

DLL không có Main(), chỉ có class + method để người khác gọi.

Build & Run

Chuột phải vào ThoLibrary

Build: Build → Build Solution

DLL không chạy trực tiếp. Nó chỉ được tham chiếu (reference) bởi các project khác.  
Bước 3: Tạo Project - Console App (.NET Framework 2.0)

Trong Solution Explorer chuột phải vào Solution Lamtho → Add → New Project

Gõ tìm: Console App (.NET Framework) → Chọn .NET Framework 2.0.

Đặt tên: ThoConsole → Create.
<img width="1915" height="1007" alt="image" src="https://github.com/user-attachments/assets/79b9e75d-00ff-40d7-9470-d7011b1bab66" />  

Bước 4: Tạo Project – Windows Form Application (.NET Framework 2.0)
Trong Solution Explorer chuột phải vào Solution Lamtho → Add → New Project

Gõ tìm: Windows Forms App (.NET Framework).

Chọn → Next.

Đặt tên project: ThoWinform.

Ở phần Framework → chọn .NET Framework 2.0 → Create.
<img width="1908" height="1000" alt="image" src="https://github.com/user-attachments/assets/3f586a73-19d9-4af9-b535-fa3ca5dcd6e1" /> 

Sau khi tạo xong → References → Add Reference → Projects → LamTho (DLL).  
<img width="976" height="667" alt="image" src="https://github.com/user-attachments/assets/7870b7a6-7306-4e0d-b10d-1d39d64cb93a" />   

Bước 5: Tạo Project – ASP.NET Web Application (.NET Framework 2.0)

Mục đích: Người dùng tương tác với giao diện HTML/CSS/JS để chọn ô, JavaScript gửi yêu cầu đến backend (api.aspx), backend gọi DLL ThoLibrary để xử lý logic, và trả về JSON. JavaScript xử lý JSON để cập nhật giao diện (vẽ bảng, xóa ô). 

Trong Solution Explorer chuột phải vào Solution Lamtho → Add → New Project

Tìm: ASP.NET Web Application (.NET Framework).

Đặt tên project: ThoWebApp.

Ở phần framework chọn: .NET Framework 2.0 → Create.

<img width="1907" height="929" alt="image" src="https://github.com/user-attachments/assets/24331608-a28e-42b3-be76-08d6eb05d398" />  

<img width="1913" height="1005" alt="image" src="https://github.com/user-attachments/assets/cd6a925e-ac2d-4b42-a3c8-2554ee8752fc" />

Sau khi tạo xong tham chiếu đến DLL → References → Add Reference → Projects → Lamtho (DLL).  
<img width="981" height="671" alt="image" src="https://github.com/user-attachments/assets/2eabbfcd-88ee-493c-bcd2-a4fa6b0309e9" /> 

Build & Run  

Bước 6: Cấu hình IIS cho Project Web

1. Bật IIS trên Windows
   
Mở Control Panel → Programs and Features.

Ở sidebar → chọn Turn Windows features on or off (Bật/tắt tính năng Windows).

Nhấn chọn:

Internet Information Services

Trong đó bật Web Management Tools và World Wide Web Services.

Quan trọng: Trong Application Development Features, bật:

ASP.NET 4.8 (hoặc ASP.NET 3.5 nếu cài sẵn .NET 2.0)

ISAPI Extensions

ISAPI Filters

Nhấn OK, đợi Windows cài đặt IIS.

2. Tạo Website trong IIS
   
Mở IIS Manager: Trong cây bên trái, chuột phải Sites → Add Website…. Nhập:

Site name: ThoWebApp

Physical path: chọn folder chứa project web (chính là thư mục ThoWebApp của solution).  

Binding:

Type: http

IP address: All Unassigned

Port: 80.

Host name: Tho.local Nhấn OK.

Kết quả 

<img width="1900" height="1004" alt="image" src="https://github.com/user-attachments/assets/0fa40fdd-46fd-4bb7-abb2-5e085545c38c" />












