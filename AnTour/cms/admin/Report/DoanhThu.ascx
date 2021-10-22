<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DoanhThu.ascx.cs" Inherits="AnTour.cms.admin.Report.DoanhThu" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<div class="box-reportDay" style="font-size: 1rem;">
    <h3>Doanh thu theo ngày:</h3>
    <asp:Literal ID="ltlMsg" runat="server"></asp:Literal>
    <form>
        <div class="form-group row">
            <label for="txtKH" class="col-sm-3 col-form-label">Chọn Ngày:</label>
            <div class="col-sm-6">
                <asp:TextBox ID="txtDay" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-3">

                <asp:Button ID="btnXem" CssClass="btn btn-primary" runat="server" Text="Xem" OnClick="btnXem_Click" />

            </div>
        </div>

        <div class="form-group row">
            <label for="txtTour" class="col-sm-3 col-form-label">Doanh Thu: </label>
            <div class="col-sm-6">
                <asp:TextBox ID="txtDoanhThu" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtNgayDat" class="col-sm-3 col-form-label">Số Phiếu Đặt: </label>
            <div class="col-sm-6">
                <asp:TextBox ID="txtSLPhieu" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox>
            </div>
        </div>
    </form>
</div>
<asp:PlaceHolder ID="PlLoadTable" Visible="false" runat="server">

    <div class="table-responsive">
        <table class="table table-bordered table-hover">
            <thead>
                <tr>
                    <th scope="col">Mã Phiếu</th>
                    <th scope="col">Khách Hàng</th>
                    <th scope="col">Tour</th>
                    <th scope="col">Đơn Giá</th>
                    <th scope="col">Ngày Thanh Toán</th>
                    <th scope="col">Ngày Đi</th>
                    <th scope="col">Người Lớn</th>
                    <th scope="col">Trẻ Em</th>
                    <th scope="col">Trạng Thái</th>
                    <th scope="col">Hóa Đơn</th>
                </tr>
            </thead>
            <tbody>
                <asp:Literal ID="ltlLoadListPhieu" runat="server"></asp:Literal>

            </tbody>
        </table>
    </div>
</asp:PlaceHolder>

<div class="box-reportMonth">
    <h3>Doanh thu theo tháng:</h3>
    <asp:Literal ID="ltlMessage" runat="server"></asp:Literal>
    <div>
        <div class="form-group row">
            <label for="txtKH" class="col-sm-2 col-form-label">Tháng:</label>
            <div class="col-sm-3">
                <asp:DropDownList ID="ddlMonth" CssClass="form-control" runat="server">
                    <asp:ListItem Value="01"> 01 </asp:ListItem>
                    <asp:ListItem Value="02"> 02 </asp:ListItem>
                    <asp:ListItem Value="03"> 03 </asp:ListItem>
                    <asp:ListItem Value="04"> 04 </asp:ListItem>
                    <asp:ListItem Value="05"> 05 </asp:ListItem>
                    <asp:ListItem Value="06"> 06 </asp:ListItem>
                    <asp:ListItem Value="07"> 07 </asp:ListItem>
                    <asp:ListItem Value="08"> 08 </asp:ListItem>
                    <asp:ListItem Value="09"> 09 </asp:ListItem>
                    <asp:ListItem Value="10"> 10 </asp:ListItem>
                    <asp:ListItem Value="11"> 11 </asp:ListItem>
                    <asp:ListItem Value="12"> 12 </asp:ListItem>
                    

                </asp:DropDownList>
                
            </div>
            <label for="txtYear" class="col-sm-2 col-form-label">Năm:</label>
            <div class="col-sm-3">
                <asp:TextBox ID="txtYear" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtYear" runat="server" ErrorMessage="Năm Không Hợp Lệ" ForeColor="Red" ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
            </div>
            <div class="col-sm-2">

                <asp:Button ID="btnXemMonth" CssClass="btn btn-primary" runat="server" Text="Xem" OnClick="btnXemMonth_Click" />
                
            </div>
        </div>
         <div class="form-group row">
            <label for="txtTour" class="col-sm-2 col-form-label">Tổng Doanh Thu: </label>
            <div class="col-sm-3">
                <asp:TextBox ID="txtTongDThu" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox>
            </div>
            <label for="txtNgayDat" class="col-sm-2 col-form-label">Tổng Số Phiếu Đặt: </label>
            <div class="col-sm-3">
                <asp:TextBox ID="txtTongPDat" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            
        </div>
        <div class="form-group row">
            
            <asp:Chart ID="ChartDoanhThuThang" runat="server" Height="331px" Width="1000px" style="margin-left: 11px">
                <Titles><asp:Title Text="Biểu Đồ Doanh Thu Trong Một Tháng"></asp:Title></Titles>
                <Series>
                    <asp:Series Name="Series1" ChartArea="ChartArea1" ChartType="Line">
                        <Points>
                        </Points>
                    </asp:Series>
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1">
                        <AxisX Title="Tháng"></AxisX>
                        <AxisY Title="Doanh Thu"></AxisY>
                    </asp:ChartArea>
                </ChartAreas>
            </asp:Chart>
            
        </div>
        <div class="table-responsive ">
        <table class="table table-bordered table-hover" style="display: block; height: 500px; overflow: auto;">
            <thead style="background-color:#ffffff;">
                <tr>
                    <th scope="col" style="position: sticky; top: 0; background-color:#ffffff;">Mã Phiếu</th>
                    <th scope="col" style="position: sticky; top: 0; background-color:#ffffff;">Khách Hàng</th>
                    <th scope="col" style="position: sticky; top: 0; background-color:#ffffff;">Tour</th>
                    <th scope="col" style="position: sticky; top: 0; background-color:#ffffff;">Đơn Giá</th>
                    <th scope="col" style="position: sticky; top: 0; background-color:#ffffff;">Ngày Thanh Toán</th>
                    <th scope="col" style="position: sticky; top: 0; background-color:#ffffff;">Ngày Đi</th>
                    <th scope="col" style="position: sticky; top: 0; background-color:#ffffff;">Người Lớn</th>
                    <th scope="col" style="position: sticky; top: 0; background-color:#ffffff;">Trẻ Em</th>
                    <th scope="col" style="position: sticky; top: 0; background-color:#ffffff;">Trạng Thái</th>
                    <th scope="col" style="position: sticky; top: 0; background-color:#ffffff;">Hóa Đơn</th>
                </tr>
            </thead>
            <tbody>
                <asp:Literal ID="ltlLoadListMonth" runat="server"></asp:Literal>

            </tbody>
        </table>
    </div>
    </div>
</div>
