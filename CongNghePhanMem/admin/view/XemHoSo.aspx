<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="XemHoSo.aspx.cs" Inherits="CongNghePhanMem.admin.view.XemHoSo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <head>
    <style>
        table {
            width: 50%;
            margin: auto;
            text-align: left;
        }

        td {
            padding: 5px;
        }

        input {
            width: 100%;
        }

        button {
            width: 100%;
            margin-top: 10px;
        }
        .auto-style1 {
        margin-left: 374px;
        margin-right: 0;
    }
    .auto-style2 {
        margin-left: 616px;
    }
    .auto-style3 {
        margin-left: 614px;
    }
        </style>
</head>
<body>
    <h1 style="font-size: x-large; text-align: center;">Chi tiết hồ so</h1>
    <asp:DataList ID="DataList1" runat="server">
    <ItemTemplate>
        <div class="item">
            <label for ="hovaten">Họ và Tên</label>
            <asp:Label ID="HoVaTen" runat="server" Text='<%# Eval("HoVaTen") %>'></asp:Label>
        </div>
        <div class="item">
            <label for ="SoDienThoai">Số điện thoại</label>
            <asp:Label ID="SoDienThoai" runat="server" Text='<%# Eval("SoDienThoai") %>'></asp:Label>
        </div>
        <div class="item">
            <label for ="email">Email</label>
            <asp:Label ID="Email" runat="server" Text='<%# Eval("email") %>'></asp:Label>
        </div>
        <div class="item">
            <label for ="TomTat">Tóm tắt</label>
            <asp:Label ID="TomTat" runat="server" Text='<%# Eval("TomTat") %>'></asp:Label>
        </div>
             <div class="item">
            <label for ="Link">Link</label>
            <asp:Label ID="Link" runat="server" Text='<%# Eval("Link") %>'></asp:Label>
        </div>
    </ItemTemplate>
</asp:DataList>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nhận xét:<br />
    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1" Height="144px" Width="543px"></asp:TextBox>
</body>

<br />
<br />
<asp:Button ID="Button2" runat="server" CssClass="auto-style3" OnClick="Button2_Click" Text="Duyệt" Width="121px" />
<br />
<br />
<asp:Button ID="Button1" runat="server" CssClass="auto-style2" OnClick="Button1_Click" Text="Từ chối" Width="119px" />
<br />

</asp:Content>