<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserProfile.ascx.cs" Inherits="AnTour.cms.display.CaNhan.UserProfile" %>
<div class="container" style="overflow: hidden">
    <h3 class="mb-3">Thông Tin Cá Nhân: </h3>
    <table>
        <tr>
            <td>Họ Tên: 
            </td>
            <td>
                <asp:Literal ID="ltlHoten" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td>Giới Tính 
            </td>
            <td>
                <asp:Literal ID="ltlGioitinh" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td>Số CMTND: 
            </td>
            <td>
                <asp:Literal ID="ltlCmtnd" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td>Số Điện Thoại:  
            </td>
            <td>
                <asp:Literal ID="ltlSdt" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td>Email: 
            </td>
            <td>
                <asp:Literal ID="ltlEmail" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td>Địa Chỉ 
            </td>
            <td>
                <asp:Literal ID="ltlDiachi" runat="server"></asp:Literal>
            </td>
        </tr>
        <asp:PlaceHolder ID="plUserNhanVien" runat="server">
            <tr>
                <td>Quyền: 
                </td>
                <td>
                    <asp:Literal ID="ltlQuyen" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td>Trạng Thái:
                </td>
                <td>
                    <asp:Literal ID="ltlTrangthai" runat="server"></asp:Literal>
                </td>
            </tr>
        </asp:PlaceHolder>

    </table>

</div>

<style>
    div table tr {
        margin-bottom: 10px;
    }

    div table tr td {
        padding-bottom: 10px;
        padding-right: 20px;
    }
    
</style>
