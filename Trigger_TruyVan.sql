
USE QLBH

GO
--Tạo trigger để tự cập nhật Thành tiền ở bản chi tiết hóa đơn 
--và Tổng tiền ở bảng hóa đơn
Create trigger update_CT_HoaDon_ThanhTien_TongTien
    on CT_HoaDon 
    for update
    as
    begin
    --update mã hóa đơn ở chi tiết hóa đơn
    if UPDATE(MAHD_CT)
       begin
       -- cập nhật lại tổng tiền khi update CT hóa đơn
       update HOADON
       set TONGTIEN=TONGTIEN - (select deleted.THANHTIEN from deleted where MAHD=deleted.MAHD_CT)	
       from deleted
       where HOADON.MAHD=deleted.MAHD_CT
       
       update HOADON
       set TONGTIEN = TONGTIEN + (select CTHD.THANHTIEN  
                                  from inserted I,CT_HOADON CTHD
                                  where MAHD=CTHD.MAHD_CT and CTHD.MAHD_CT=I.MAHD_CT and I.MASP_CT=CTHD.MASP_CT)
       from HOADON HD, inserted
       where HD.MAHD=inserted.MAHD_CT
       end 
       --update số lượng ở chi tiết hóa đơn
    if UPDATE(SOLUONG)
       begin
       update CT_HOADON
       set THANHTIEN= I.SOLUONG*(I.GIABAN-I.GIAGIAM)
       from inserted I
       where I.MAHD_CT=CT_HOADON.MAHD_CT and I.MASP_CT=CT_HOADON.MASP_CT
       
       update HOADON
       set TONGTIEN = TONGTIEN - (select D.THANHTIEN from deleted D, CT_HOADON CTHD where MAHD=D.MAHD_CT and CTHD.MAHD_CT=MAHD)
       from HOADON join deleted on HOADON.MAHD=deleted.MAHD_CT
       end
       --update giá bán ở bản chi tiết hóa đơn
    if UPDATE(GIABAN)
       begin
       update CT_HOADON
       set THANHTIEN= I.SOLUONG*(I.GIABAN-I.GIAGIAM)
       from inserted I
       where I.MAHD_CT=CT_HOADON.MAHD_CT and I.MASP_CT=CT_HOADON.MASP_CT
       
       update HOADON
       set TONGTIEN = TONGTIEN - (select D.THANHTIEN from deleted D, CT_HOADON CTHD where MAHD=D.MAHD_CT and CTHD.MAHD_CT=MAHD)
       from HOADON join deleted on HOADON.MAHD=deleted.MAHD_CT
       end
       --update giá giảm ở bản chi tiết hóa đươn
    if UPDATE(GIAGIAM)
       begin
       update CT_HOADON
       set THANHTIEN= I.SOLUONG*(I.GIABAN-I.GIAGIAM)
       from inserted I
       where I.MAHD_CT=CT_HOADON.MAHD_CT and I.MASP_CT=CT_HOADON.MASP_CT
       
       update HOADON
       set TONGTIEN = TONGTIEN - (select D.THANHTIEN from deleted D where MAHD=D.MAHD_CT)
       from HOADON join deleted on HOADON.MAHD=deleted.MAHD_CT
       end
    end 
  
GO


Create trigger delete_CT_HoaDon_TongTien
    on CT_HoaDon
    for delete
    as
    begin
       -- cập nhật lại tổng tiền khi xóa CT hóa đơn
       update HOADON
       set TONGTIEN = TONGTIEN - (select D.THANHTIEN from deleted D where MAHD=D.MAHD_CT)
       from HOADON join deleted on HOADON.MAHD=deleted.MAHD_CT
    end 
  
GO




--Truy vấn
--a. Cho danh sách các hoá đơn lập trong năm 2020
select *from HOADON where YEAR(HOADON.NGAYLAP) =  2020

--b. Cho danh sách các khách hàng ở TPHCM
select *from KHACHHANG where KHACHHANG.TPHO like N'%Thành phố Hồ Chí Minh'

--c. Cho danh sách các sản phẩm có giá trong một khoảng từ 1000 đến 2000
select *from SANPHAM where SANPHAM.GIA >= 1000 and SANPHAM.GIA<=2000

--d. Cho danh sách các sản phẩm có số lượng tồn <100
select *from SANPHAM where SANPHAM.SOLUONGTON < 100
--e. Cho danh sách các sản phẩm bán chạy nhất (số lượng bán nhiều nhất)

select MASP,TENSP,SOLUONGTON,MOTA,GIA, SUM(soluong) as TongSL
from SANPHAM,CT_HOADON
where SANPHAM.MASP=CT_HOADON.MASP_CT
group by MASP,TENSP,SOLUONGTON,MOTA,GIA
having SUM(soluong) >= ALL(select SUM(soluong) as TongSL
                           from SANPHAM, CT_HOADON
                           where SANPHAM.MASP=CT_HOADON.MASP_CT
                           group by MASP)
                           
          
--f. Cho danh sách các sản phẩm có doanh thu cao nhất

select MASP,TENSP,SOLUONGTON,MOTA,GIA,SUM(THANHTIEN) as DoanhThu
from SANPHAM,CT_HOADON
where SANPHAM.MASP=CT_HOADON.MASP_CT
group by MASP,TENSP,SOLUONGTON,MOTA,GIA
having SUM(THANHTIEN) >= ALL(select SUM(THANHTIEN) as DoanhThu
                           from SANPHAM, CT_HOADON
                           where SANPHAM.MASP=CT_HOADON.MASP_CT
                           group by MASP)


