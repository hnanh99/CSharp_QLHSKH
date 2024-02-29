<%@ Page Title="Tìm kiếm" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TimKiem.aspx.cs" Inherits="CongNghePhanMem.view.TimKiem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <style type="text/css">
        #MainContent {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .login-container {
            width: 60%;
            background-color: #0ff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            margin: auto;
        }

        .centered-text {
            text-align: center;
            color: #0000FF;
            font-size: x-large;
            margin-bottom: 20px;
        }
        .centered-text1 {
            text-align: center;
            color: #0f18b5;
            font-size: x-large;
            margin-bottom: 5px;
        }

        .form-group {
            text-align: center;
            margin-bottom: 15px;
            justify-content: center;
        }

        label {
            display: block;
            margin-bottom: 5px;
        }

        input {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        #Button1,
        a {
            margin-top: 10px;
            display: block;
            text-align: center;
           
        }

        .button-container {
            display: flex;
            align-items: center;
            text-align: center;
            justify-content: center;
            color:#ccc;
            /*height: 100vh;*/
        }
        .error-message {
            text-align: center;
            margin-top: 5px; /* Adjust the margin as needed */
        }
        .centered-button {
        text-align: center;
        color:#0f18b5;
        }
        
    </style>
    <div class="login-container">
        <p class="centered-text1">
            <strong>Tìm kiếm</strong>
        </p>
        <div class="form-group">
            <label for="txttacGia">Tác giả:</label>
            <asp:TextBox ID="txttacGia" runat="server" Width="100%" Placeholder="Nhập tác giả"></asp:TextBox>
          
       </div>
          <div class="form-group">
            <label for="txttieuDe">Tiêu đề:</label>
            <asp:TextBox ID="txttieuDe" runat="server" Width="100%" Placeholder="Nhập tiêu đề"></asp:TextBox>
         
       </div>
        <div class="button-container">
            <asp:Button ID="TimKiemButton" runat="server" Text="Tìm kiếm" OnClientClick="return ValidateForm();" OnClick="TimKiem_Click" CssClass="centered-button" />
        </div>
        </div>
</head>
<body>
    <asp:DataList ID="DataList1" runat="server">
    <ItemTemplate>
        <div class="item">
            <label for ="hovaten">Tác giả: 
            <asp:Label ID="HoVaTen" runat="server" Text='<%# Eval("HoVaTen") %>'></asp:Label>
            </label>
        </div>
        <div class="item">
            <label for ="SoDienThoai">Số điện thoại: 
            <asp:Label ID="SoDienThoai" runat="server" Text='<%# Eval("SoDienThoai") %>'></asp:Label>
            </label>
        </div>
        <div class="item">
            <label for ="email">Email: 
            <asp:Label ID="Email" runat="server" Text='<%# Eval("email") %>'></asp:Label>
            </label>
        </div>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="Lylich_Click" Text ="Chi tiết tác giả" CommandArgument='<%# Eval("id") %>'></asp:LinkButton>
 
    </ItemTemplate>
</asp:DataList>
</body>
    <script type="text/javascript">
        function ValidateForm() {
            // Add client-side validation logic if needed
            return true;
        }
    </script>

</asp:Content>