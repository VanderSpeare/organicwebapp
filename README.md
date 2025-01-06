Tích hợp thanh toán VnPayment AspNet Core
Đăng ký tài khoản sandbox
Truy cập vào link sau: https://sandbox.vnpayment.vn/devreg để đăng ký tài khoản trên Vnpayment
Sau khi đăn ký thành công ta nhận được 2 thông tin quan trọng là: vnp_TmnCode và vnp_HashSecret
Configuration appsettings
 

Giải thích
Name	Value	Data Type	Min,Max	Required	Description
vnp_Version	2.1.0	Alphanumeric	1,8	yes	Phiên bản api mà merchant kết nối
vnp_Command	pay	Alpha	1,16	yes	Mã API sử dụng, mã cho giao dịch thanh toán là pay
vnp_TmnCode	Alphanumeric	VNPAY001	8	yes	Mã định danh (app/website/dịch vụ) của merchant trên hệ thống của VNPAY
vnp_BankCode	Alphanumeric	VIETCOMBANK	3,20	no	Mã Ngân hàng thanh toán. Nếu không truyền giá trị cho tham số này, Khách hàng sẽ chọn Ngân hàng thanh toán tại VNPAY
vnp_Locale	Alpha	en hoặc vn	2,5	yes	Ngôn ngữ khách hàng đang sử dụn
vnp_CurrCode	Alpha	VND hoặc USD	3	yes	Đơn vị tiền tệ sử dụng thanh toán
vnp_TxnRef	Alphanumeric	VNPAY123	1,100	yes	Mã tham chiếu của giao dịch tại hệ thống của merchant. Mã này là duy nhất đùng để phân biệt các đơn hàng gửi sang VNPAY. Không được trùng lặp trong ngày
vnp_OrderInfo	Alphanumeric	Nap 100K cho so dien thoai 0934998386	1,255	yes	Thông tin mô tả nội dung thanh toán (Tiếng Việt, không dấu)
vnp_OrderType	Alphanumeric	topup	1,100	yes	Mã danh mục hàng hóa. Mỗi hàng hóa sẽ thuộc một nhóm danh mục do VNPAY quy định. VNPAY sẽ cung cấp bảng danh mục này tại trang dành cho merchant của VNPAY
vnp_Amount	Numeric	100000	1,12	yes	Số tiền thanh toán. Số tiền không mang các ký tự phân tách thập phân, phần nghìn, ký tự tiền tệ. Để gửi số tiền thanh toán là 10,000 VND (mười nghìn VNĐ) thì merchant cần nhân thêm 100 lần (khử phần thập phân), sau đó gửi sang VNPAY là: 1000000
vnp_ReturnUrl	http://ceb.net.vn/cart/backvnpayment	Alphanumeric	10,255	yes	Địa chỉ trả về khi khách hàng thực hiện thanh toán xong
vnp_IpAddr	Alphanumeric	127.0.0.1	7,45	yes	Địa chỉ IP của khách hàng thực hiện giao dịch
vnp_CreateDate	Numeric	20150924080900	14	yes	Thời gian ghi nhận giao dịch tại website của merchant GMT+7, định dạng: yyyyMMddHHmmss
vnp_ExpireDate	20150924083000	Numeric	14	yes	Thời gian hết hạn thanh toán GMT+7, định dạng: yyyyMMddHHmmss
vnp_SecureHash	Kiểm tra email đăng ký	Alphanumeric	32,255	yes	Mã kiểm tra (checksum) để đảm bảo dữ liệu của giao dịch không bị thay đổi trong quá trình chuyển từ merchant sang VNPAY. Việc tạo ra mã này phụ thuộc vào cấu hình của merchant và phiên bản api sử dụng. Phiên bản hiện tại, mặc định hỗ trợ HMACSHA512

Tạo model VnPayment 
Và tạo thêm file model VnPaymentRequest nằm trong Service
Tại CartController thêm đối tượng service
