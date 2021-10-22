<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListTour.ascx.cs" Inherits="AnTour.cms.admin.Tour.TourLoad" %>

<div class="table-responsive">
<table class="table table-bordered table-hover" style="overflow-x:scroll;">
        <thead>
            <tr>
                <th scope="col">Mã Tour</th>
                <th scope="col">Tên Tour</th>
                <th scope="col">Ảnh Tour</th>
                <th scope="col">Địa Điểm</th>
                <th scope="col">Số Ngày</th>
                <th scope="col">Số Lượng Khách Tối Đa</th>
                <th scope="col">Đơn Giá </th>
                <th scope="col">Ngày Tạo</th>
                <th scope="col">Thao Tác</th>
            </tr>
        </thead>
    
        <tbody>
            <asp:Literal ID="ltlTour" runat="server"></asp:Literal>
        </tbody>
    </table>
</div>

