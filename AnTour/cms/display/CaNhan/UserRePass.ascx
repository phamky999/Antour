<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserRePass.ascx.cs" Inherits="AnTour.cms.display.CaNhan.UserRePass" %>
<div class="container" style="overflow: hidden">
    <h3 class="mb-3">Đổi Mật Khẩu: </h3>
    
    <asp:Literal ID="ltlMsg" runat="server"></asp:Literal>
    <table>
        <tr>
            <td>Tài Khoản:
            </td>
            <td>
                <asp:TextBox ID="txtTenDN" CssClass="form-control" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtTenDN" ForeColor="Red" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                
            </td>
        </tr>
        <tr>
            <td>Mật Khẩu: 
            </td>
            <td>
                <asp:TextBox ID="txtMK" type="password" CssClass="form-control" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtMK" ForeColor="Red" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Mật Khẩu Mới 
            </td>
            <td>
                <asp:TextBox ID="txtNewPass" type="password" CssClass="form-control" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtNewPass" ForeColor="Red" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Nhập Lại Mật Khẩu Mới:  
            </td>
            <td>
                <asp:TextBox ID="txtRePass" type="password" CssClass="form-control" runat="server"></asp:TextBox><asp:CompareValidator ID="CompareValidator1" ControlToValidate="txtRePass" ControlToCompare="txtNewPass" runat="server" ErrorMessage="*" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="btnHuy" CssClass="btn btn-danger mt-3 mr-5" runat="server" Text="Hủy" CausesValidation="false" OnClick="btnHuy_Click" />
                <asp:Button ID="btnLuu" CssClass="btn btn-primary mt-3" runat="server" Text="Lưu" OnClick="btnLuu_Click"  />
                
            </td>
        </tr>
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
