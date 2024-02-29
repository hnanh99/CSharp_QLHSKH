<%@ Page Title="Lý lịch cá nhân" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LylichCanhan.aspx.cs" Inherits="CongNghePhanMem.view.LylichCanhan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1 style="font-size: x-large; text-align: center;">Lý lịch khoa học cá nhân</h1>
    <p>
        <br />
        Họ và tên:
        <asp:Label ID="HoVaTen" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        Số điện thoại: <asp:Label ID="SoDienThoai" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        Giới tính: <asp:Label ID="GioiTinh" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        Năm sinh: <asp:Label ID="NamSinh" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        Quê quán: <asp:Label ID="QueQuan" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        Email: <asp:Label ID="Email" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        Học vị: <asp:Label ID="HocVi" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Các bài báo:</p>
    <p>
            <asp:DataList ID="DataList1" runat="server">
    <ItemTemplate>
        <div class="item">
            <label for ="hovaten"> </label>
            <asp:Label ID="HoVaTen" runat="server" Text='<%# Eval("HoVaTen") %>'></asp:Label>
        </div>
    </ItemTemplate>
</asp:DataList>
    </p>
</asp:Content>
