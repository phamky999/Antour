<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListBooking.ascx.cs" Inherits="AnTour.cms.admin.Booking.ListBooking" %>


<div class="container mb-5" style="font-size: 1rem;">
    <form>
        <asp:Literal ID="LtlMsg" runat="server"></asp:Literal>
        <div class="form-group row">
            <label for="txtMa" class="col-sm-2 col-form-label">Mã Phiếu: </label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtMaPhieu" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
            </div>
            <label for="txtTenTour" class="col-sm-2 col-form-label">Mã Tour: </label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtMaTour" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            
            <label for="txtTenTour" class="col-sm-2 col-form-label">Tên Tour: </label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtTenTour" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <label for="txtGia" class="col-sm-2 col-form-label">Đơn Giá: </label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtGia" CssClass="form-control" runat="server"></asp:TextBox>

            </div>
        </div>
        <div class="form-group row">
            <label for="txtGia" class="col-sm-2 col-form-label">Mã Người Đặt: </label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtMaKH" CssClass="form-control" runat="server"></asp:TextBox>

            </div>
            <label for="txtGia" class="col-sm-2 col-form-label">Tên: </label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtHoTen" CssClass="form-control" runat="server"></asp:TextBox>

            </div>
        </div>
        <div class="form-group row">
            <label for="txtGia" class="col-sm-2 col-form-label">Ngày Đặt: </label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtNgayDat" CssClass="form-control" runat="server"></asp:TextBox>

            </div>
            <label for="txtSoNgay" class="col-sm-2 col-form-label">Ngày Đi: </label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtNgayDi" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>

            </div>
        </div>
        <div class="form-group row">
            <label for="txtSLMax" class="col-sm-2 col-form-label">Số Khách: </label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtSLKhach" CssClass="form-control" runat="server"></asp:TextBox>

            </div>
            <label for="txtSLMax" class="col-sm-2 col-form-label">Số Trẻ Em: </label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtSLTreEm" CssClass="form-control" runat="server"></asp:TextBox>

            </div>
            
        </div>
        <div class="form-group row">
            <label for="txtNgayTao" class="col-sm-2 col-form-label">Trạng Thái: </label>
            <div class="col-sm-4">
                <asp:TextBox ID="txtTrangThai" CssClass="form-control" runat="server" ReadOnly="true"></asp:TextBox>
            </div>
        </div>

        <div class="form-group row">
            <div class="col-sm-2">

            </div>
            <div class="col-sm-10">
                <asp:Button ID="btnXacNhan" CssClass="btn btn-primary mr-4 ml-2" runat="server" Text="Xác Nhận Phiếu" OnClick="btnXacNhan_Click"  />
                <asp:Button ID="btnXacNhanTT" CssClass="btn btn-primary mr-4" runat="server" Text="Xác Nhận Thanh Toán" OnClick="btnXacNhanTT_Click" />
                <asp:Button ID="btnDel" CssClass="btn btn-dark mr-4" runat="server" Text="Xóa Phiếu Đặt" OnClick="btnDel_Click"   />
            </div>
        </div>

    </form>
</div>
<h4>Danh Sách Phiếu Đặt Của Khách Hàng:</h4>
<div class="table-responsive">
    <table class="table table-bordered table-hover" style="display: block; height: 500px; overflow: auto;">
        <thead>
            <tr>
                <th scope="col">Mã Phiếu</th>
                <th scope="col">Mã Tour</th>
                <th scope="col">Tên Tour</th>
                <th scope="col">Đơn Giá</th>
                <th scope="col">Mã KH</th>
                <th scope="col">Tên KH</th>
                <th scope="col">Ngày Đặt</th>
                <th scope="col">Ngày Đi</th>
                <th scope="col">SL Khách</th>
                <th scope="col">SL Trẻ Em</th>
                <th scope="col">Trạng Thái</th>
                <th scope="col">Thao Tác</th>
            </tr>
        </thead>

        <tbody>
            <asp:Literal ID="ltlTour" runat="server"></asp:Literal>
        </tbody>
    </table>
</div>

<%--<h4>Danh Sách Phiếu Đặt Của Nhân Viên:</h4>
<div class="table-responsive">
    <table class="table table-bordered table-hover" style="overflow-x: scroll;">
        <thead>
            <tr>
                <th scope="col">Mã Phiếu</th>
                <th scope="col">Mã Tour</th>
                <th scope="col">Tên Tour</th>
                <th scope="col">Đơn Giá</th>
                <th scope="col">Mã NV</th>
                <th scope="col">Tên NV</th>
                <th scope="col">Ngày Đặt</th>
                <th scope="col">Ngày Đi</th>
                <th scope="col">SL Khách</th>
                <th scope="col">SL Trẻ Em</th>
                <th scope="col">Trạng Thái</th>
                <th scope="col">Thao Tác</th>
            </tr>
        </thead>

        <tbody>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </tbody>
    </table>
</div>--%>
