Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadkhachang() As DataSet
        ' Dim chuoiketnoi As String = "Data Source=CAST\SQLEXPRESS;Initial Catalog=tannnps03609;Integrated Security=True"
        Dim chuoiketnoi As String = "workstation id=tannnps03609.mssql.somee.com;packet size=4096;user id=nhattan0411_SQLLogin_1;pwd=n7lvlucnu2;data source=tannnps03609.mssql.somee.com;persist security info=False;initial catalog=tannnps03609"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MAKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT as 'SĐT', EMAIL from KHACHANG", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
    Public Function Loadsanpham() As DataSet
        'Dim chuoiketnoi As String = "Data Source=CAST\SQLEXPRESS;Initial Catalog=tannnps03609;Integrated Security=True"
        Dim chuoiketnoi As String = "workstation id=tannnps03609.mssql.somee.com;packet size=4096;user id=nhattan0411_SQLLogin_1;pwd=n7lvlucnu2;data source=tannnps03609.mssql.somee.com;persist security info=False;initial catalog=tannnps03609"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại',SANPHAM.SOLUONG as 'Số lượng' from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
