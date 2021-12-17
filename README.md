# Đồ án Cuối kỳ nhóm 11: RSA

 ## MÔ TẢ
Ứng dụng mã hoá RSA dùng để mã hoá các tập tin hoặc thư mục với các kích thước khác nhau. Chương trình cho phép người dùng lựa chọn kích thức khoá khác nhau.

 ## TÍNH NĂNG
 * Mã hóa RSA: Có 3 key length: **512 bit**, **1024 bit**, **2048 bit**, **4096 bit**.
   * Cho phép lưu khóa vào file XML (.NET Framework chỉ hỗ trợ định dạng XML).
   * Hiển thị thông tin public key và private key.
 * Mã hóa file riêng lẻ hoặc một folder gồm nhiều file (file được mã hóa dưới dạng .nhom11).
 * Kiểm tra tính toàn vẹn file trước và sau khi mã hóa bằng các hàm băm MD5, SHA1, SHA256.
 * Mở file kết quả để kiểm tra.

 ## HIỆU SUẤT (trung bình)
 * Thời gian tạo khóa
   * 512 bit: 0.03s
   * 1024 bit: 0.15s
   * 2048 bit: 0.54s
   * 4096 bit: 8.42s
   * 8192 bit: 83.7s
 * Thời gian mã hóa: **32.3s**
   * 4 file: .pdf, .txt, .jpg, .mp3 (Tổng dung lượng: _4.95MB_)
 * Thời gian giải mã: **72.95**
   * 4 file: Với loại file đã mã hoá là .nhom11 (Tổng dung lượng: _5.42MB_)

<img src="https://github.com/Dkhoa-117/Nhom11_NT101/blob/main/ref.%20pic/encrypt.png" width="100%" height="100%">

_Hình 1: Chạy thử Mã hoá folder_

<img src="https://github.com/Dkhoa-117/Nhom11_NT101/blob/main/ref.%20pic/decrypt.png" width="100%" height="100%">

_Hình 2: Chạy thử Giải mã folder_


