<%@ Page Title="Đăng kí" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="CongNghePhanMem.DangKy" %>
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
            <strong>Đăng ký</strong>
        </p>
        <div class="form-group">
            <label for="txtHoVaTen">Họ và tên:</label>
            <asp:TextBox ID="txtHoVaTen" runat="server" Width="100%" Placeholder="Nhập họ và tên"></asp:TextBox>
          <p class="error-message">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ForeColor="Red" ControlToValidate="txtHoVaTen" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập Họ và Tên"></asp:RequiredFieldValidator>
        </p> 
       </div>
          <div class="form-group">
            <label for="txtEmail">Email:</label>
            <asp:TextBox ID="txtEmail" runat="server" Width="100%" Placeholder="Nhập email"></asp:TextBox>
          <p class="error-message">
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" ControlToValidate="txtEmail" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập Email"></asp:RequiredFieldValidator>
         <asp:CustomValidator ID="CustomValidator4" ForeColor="Red" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email không hợp lệ" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
         <asp:CustomValidator ID="CustomValidator5" ForeColor="Red" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email đã tồn tại" OnServerValidate="CustomValidator2_ServerValidate"></asp:CustomValidator>
        </p> 
       </div>
        <div class="form-group">
            <label for="txtPassWord">Mật khẩu:</label>
            <asp:TextBox ID="txtPassWord" runat="server" Width="100%" Placeholder="Nhập mật khẩu"></asp:TextBox>
          <p class="error-message">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" ControlToValidate="txtPassword" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập Mật khẩu"></asp:RequiredFieldValidator>
         </p> 
       </div>
       <div class="form-group">
            <label for="txtXNPassWord">Xác nhận mật khẩu:</label>
            <asp:TextBox ID="txtXNPassWord" runat="server" Width="100%" Placeholder="Nhập xác nhận mật khẩu"></asp:TextBox>
          <p class="error-message">
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red" ControlToValidate="txtXNPassWord" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập lại Mật khẩu"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator1" ForeColor="Red" runat="server" ControlToValidate="txtXNPassWord" ErrorMessage="Mật khẩu được nhập lại không khớp" OnServerValidate="CustomValidator3_ServerValidate"></asp:CustomValidator>
         </p> 
       </div>
         <div class="button-container">
            <asp:Button ID="Button1" runat="server" Text="Đăng ký" OnClientClick="return ValidateForm();" OnClick="Button1_Click" CssClass="centered-button" />
        </div>
        <p>
            <a href="Login">Đăng nhập</a>
        </p>
</div>

    <script type="text/javascript">
        function ValidateForm() {
            // Add client-side validation logic if needed
            return true;
        }
    </script>
</asp:Content>