# Nhom11_NT101 

 Đồ án Cuối kỳ: RSA (PHIÊN BẢN BACKUP)

 ## TÍNH NĂNG
 * Mã hóa RSA: Có 3 key length: **512 bit**, **1024 bit**, **2048 bit**, **4096 bit**.
   * Cho phép lưu khóa vào file XML (.NET Framework chỉ hỗ trợ định dạng XML).
   * Hiển thị thông tin public key và private key.
 * Mã hóa file riêng lẻ hoặc một folder gồm nhiều file (file được mã hóa dưới dạng .nhom11).
 * Kiểm tra tính toàn vẹn file trước và sau khi mã hóa bằng các hàm băm MD5, SHA1, SHA256.
 * Mở file kết quả để kiểm tra.

 ## HIỆU SUẤT (trung bình)
 * Thời gian tạo khóa
   * 512 bit: 
   * 1024 bit: 
   * 2048 bit: 
   * 4096 bit: 
 * Thời gian mã hóa: **32.3s**
   * 4 file: .pdf, .txt, .jpg, .mp3 (Tổng dung lượng: _4.95MB_)
 * Thời gian giải mã: **72.95**
   * 4 file: Với loại file đã mã hoá là .nhom11 (Tổng dung lượng: _5.42MB_)

![image](https://github.com/Dkhoa-117/Nhom11_NT101/blob/main/ref.%20pic/encrypt.png)
_Chạy thử Mã hoá folder_

![image](https://github.com/Dkhoa-117/Nhom11_NT101/blob/main/ref.%20pic/decrypt.png)
_Chạy thử Giải mã folder_

### NOTE:
* Cần 1 bản backup (không dùng bộ đệm)
* chỉnh btn -> bt
* Thêm thời gian tạo key