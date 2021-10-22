<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserTour.ascx.cs" Inherits="AnTour.cms.display.CaNhan.UserTour" %>
<div class="box-bookingTour">
    <h3>Thông Tin Người Đặt:</h3>
    <form>
        <div class="form-group row">
            <label for="txtHoTen" class="col-sm-2 col-form-label">Họ Tên:</label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtHoTen" runat="server" ReadOnly="true" CssClass="form-control-plaintext inputReadOnly"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtHoTen" class="col-sm-2 col-form-label">Giới Tính:</label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtGT" runat="server" ReadOnly="true" CssClass="form-control-plaintext inputReadOnly"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtCmtnd" class="col-sm-2 col-form-label">Số CMTND:</label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtCmtnd" runat="server" ReadOnly="true" CssClass="form-control-plaintext inputReadOnly"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtSDT" class="col-sm-2 col-form-label">Số ĐT:</label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtSDT" runat="server" ReadOnly="true" CssClass="form-control-plaintext inputReadOnly"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtEmail" class="col-sm-2 col-form-label">Email:</label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtEmail" runat="server" ReadOnly="true" CssClass="form-control-plaintext inputReadOnly"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtDiaChi" class="col-sm-2 col-form-label">Địa Chỉ:</label>
            <div class="col-sm-10">
                <asp:TextBox ID="txtDiaChi" runat="server" ReadOnly="true" CssClass="form-control-plaintext inputReadOnly"></asp:TextBox>
            </div>
        </div>
    </form>
    <h3>Thông Tin Tour Đã Đặt:</h3>
    <table class="table table-bordered table-hover table-responsive">
        <thead>
            <tr>
                <th scope="col">Tên Tour</th>
                <th scope="col">Địa Điểm</th>
                <th scope="col">Số Ngày</th>
                <th scope="col">Đơn Giá</th>
                <th scope="col">Ngày Đặt</th>
                <th scope="col">Ngày Đi</th>
                <th scope="col">Người Lớn</th>
                <th scope="col">Trẻ Em</th>
                <th scope="col">Tình Trạng</th>
                <th scope="col">Tác Vụ</th>
            </tr>
        </thead>
        <tbody>
            <asp:Literal ID="ltlListBooking" runat="server"></asp:Literal>
            
            
        </tbody>
    </table>
    <hr />
</div>

<style>
    .box-bookingTour h3 {
        margin-bottom: 20px;
    }

    .inputReadOnly {
        background-color: transparent;
        border: 0;
    }
</style>
<script type="text/javascript">
    function XoaSanPham(MaSP) {
        if (confirm("Bạn chắc chắn muốn xóa phiếu đặt này ?")) {
            
            
            $.post("cms/display/CaNhan/ajax/UserDel.aspx",
                {
                    "tacvu": "XoaSanPham",
                    "id": MaSP
                },
                function (data, status) {
                    
                    if (data == 1) {
                        //alert("Data :" + data + "\n Status :" + status);
                        $("#maDong_"+MaSP).slideUp();

                    }
                    if (data == 2) {
                        alert("Phiếu đặt này đã được thanh toán");
                        

                    }
                });
        }
    }
    
</script>
    