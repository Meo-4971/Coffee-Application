-- Tạo transaction đảm bảo khi đã quy đổi điểm thành tiền được giảm giá thì điểm tích lũy của khách hàng đó pahir bị trừ đi
SET XACT_ABORT ON
BEGIN TRAN InsertHoaDon
	
COMMIT TRAN InsertHoaDon