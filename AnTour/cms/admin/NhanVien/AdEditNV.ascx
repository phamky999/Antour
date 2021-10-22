<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AdEditNV.ascx.cs" Inherits="AnTour.cms.admin.NhanVien.WebUserControl1" %>
<asp:Literal ID="ltlMsg" runat="server"></asp:Literal>
<div class="form-row mb-5">
    
    <div class="col-2">
        <asp:TextBox type="text" ID="txtMaNV" CssClass="form-control" Enabled="false" placeholder="Mã NV" runat="server"></asp:TextBox>
        
    </div>
    
    <div class="col-4">
        <asp:TextBox type="text" ID="txtHoten" CssClass="form-control" Enabled="false" placeholder="Họ Tên" runat="server"></asp:TextBox>
        
    </div>
    
    <div class="col-3">
        <asp:DropDownList ID="ddlQuyen"  class="form-control" runat="server"></asp:DropDownList>
    </div>
    <div class="col-3">
        <asp:DropDownList ID="ddlTrangthai" class="form-control" runat="server"></asp:DropDownList>
    </div>
</div>
<div class="form-row mb-5">
    <asp:Button ID="btnHuy" CssClass="btn btn-danger mr-3" runat="server" Text="Hủy" CausesValidation="false" OnClick="btnHuy_Click" />
    
    <asp:Button ID="btnUpdate" CssClass="btn btn-primary" runat="server" Text="Lưu" OnClick="btnUpdate_Click" OnClientClick="return confirm_user();" />
</div>



<div class="table-responsive">
    <table class="table table-bordered table-hover">
        <thead>
            <tr>
                <th scope="col">Mã NV</th>
                <th scope="col">Họ Tên</th>
                <th scope="col">Giới Tính</th>
                <th scope="col">CMTND</th>
                <th scope="col">SDT</th>
                <th scope="col">Email</th>
                <th scope="col">Địa Chỉ</th>
                <th scope="col">Tài Khoản</th>
                <th scope="col">Quyền</th>
                <th scope="col">Trạng Thái</th>
                <th scope="col">Tác Vụ</th>
            </tr>
        </thead>
        <tbody>
            <asp:Literal ID="ltlLoadListNV" runat="server"></asp:Literal>

        </tbody>
    </table>
</div>

<script type="text/javascript" language="javascript"> 
function confirm_user()
{
  if (confirm("Bạn có chắc muốn lưu thay đổi ?")==true)
    return true;
  else
    return false;
}
</script>