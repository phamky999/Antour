<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EditPhieuDat.ascx.cs" Inherits="AnTour.cms.display.CaNhan.EditPhieuDat" %>
<div class="box-booking ">
    <h3>Đặt Tour:</h3>
    <asp:Literal ID="ltlMsg" runat="server"></asp:Literal>
    <form>
        <div class="form-group row">
            <label for="txtKH" class="col-sm-3 col-form-label">Khách Hàng:</label>
            <div class="col-sm-9">
                <asp:TextBox ID="txtKH" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtTour" class="col-sm-3 col-form-label">Tour Đặt: </label>
            <div class="col-sm-9">
                <asp:TextBox ID="txtTour" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtNgayDat" class="col-sm-3 col-form-label">Ngày Đặt: </label>
            <div class="col-sm-9">
                <asp:TextBox ID="txtNgayDat" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtNgayDi" class="col-sm-3 col-form-label">Ngày Đi: </label>
            <div class="col-sm-9">
                <asp:TextBox ID="txtNgayDi" TextMode="Date"  CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtSLKhach" class="col-sm-3 col-form-label">Số Lượng Khách:</label>
            <div class="col-sm-9">
                <asp:TextBox ID="txtSLKhach" type="number" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtSLTreEm" class="col-sm-3 col-form-label">Số Lượng Trẻ Em:</label>
            <div class="col-sm-9">
                <asp:TextBox ID="txtSLTreEm" type="number" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group row">
            <div class="col-sm-3"></div>
            <div class="col-sm-9">
                <asp:Button ID="btnHuy" CssClass="btn btn-dark mr-5" runat="server" Text="Hủy" CausesValidation="false" OnClick="btnHuy_Click" />
                <asp:Button ID="btnBooking" CssClass="btn btn-primary" runat="server" Text="Lưu" OnClick="btnBooking_Click" />

            </div>
        </div>
    </form>

</div>
