<%@ Page Title="" Language="C#" MasterPageFile="/admin/view/Site.Master" AutoEventWireup="true" CodeBehind="Hoso.aspx.cs" Inherits="CongNghePhanMem.admin.view.Hoso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnChiTiet" runat="server" OnClick="btnChiTiet_Click" Text="Chi tiết hồ sơ" />
&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2"  TabIndex="4" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="1386px" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="ID" />
            <asp:BoundField DataField="tieuDe" HeaderText="Tiêu đề" SortExpression="TenHoSo" ReadOnly="True" />
<asp:BoundField DataField="tomTat" HeaderText="Tóm Tắt"></asp:BoundField>
            <asp:BoundField DataField="tacGia" HeaderText="Tác giả" SortExpression="TacGia" />
            <asp:BoundField DataField="link" HeaderText="Link" SortExpression="link" />
            <asp:BoundField DataField="noiXB" HeaderText="Nơi xuất bản" />
            <asp:BoundField DataField="namXB" HeaderText="Năm xuất bản" />
            <asp:BoundField DataField="Status" HeaderText="Trạng thái" />
        </Columns>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#FFF1D4" />
        <SortedAscendingHeaderStyle BackColor="#B95C30" />
        <SortedDescendingCellStyle BackColor="#F1E5CE" />
        <SortedDescendingHeaderStyle BackColor="#93451F" />
    </asp:GridView>

        <%--<asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <div class="item">
                    <label for ="hovaten">Họ và Tên</label>
                    <asp:Label ID="HoVaTen" runat="server" Text='<%# Eval("tieuDe") %>'></asp:Label>
                </div>
                <div class="item">
                    <label for ="SoDienThoai">Số điện thoại</label>
                    <asp:Label ID="SoDienThoai" runat="server" Text='<%# Eval("tomTat") %>'></asp:Label>
                </div>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="TimKiemClick" Text ="Button" CommandArgument='<%# Eval("id") %>'></asp:LinkButton>
                
            </ItemTemplate>
        </asp:DataList>--%>
</p>
</asp:Content>
