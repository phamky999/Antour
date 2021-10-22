<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TourDetail.ascx.cs" Inherits="AnTour.cms.display.Tours.TourDetail" %>
<div class="container-detail">
    <div class="container">
        <div class="row">
            <div class="box-detail col-md-8 col-sm-8">
                <asp:Literal ID="ltlTourDetail" runat="server"></asp:Literal>
            </div>
            <div class="box-booking col-md-4 col-sm-4">
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
                            <asp:TextBox ID="txtNgayDi" type="date" CssClass="form-control" runat="server"></asp:TextBox>
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
                            <asp:Button ID="btnBooking" CssClass="btn btn-primary" runat="server" Text="Đặt Tour" OnClick="btnBooking_Click" />

                        </div>
                    </div>
                </form>

            </div>
        </div>
    </div>

</div>
<style>
    .container-detail {
        padding-top: 80px;
        padding-bottom: 80px;
    }

    .box-detail h3, .box-booking h3, .box-detail h4 {
        margin-bottom: 15px;
        line-height: 30px;
    }

    .box-detail h4 {
        margin-top: 15px;
    }

    .box-detail img {
        width: 90%;
        height: auto;
        margin: auto;
    }

    .box-detail p {
        text-align: justify;
        font-size: 16px;
        line-height: 30px;
    }
</style>
