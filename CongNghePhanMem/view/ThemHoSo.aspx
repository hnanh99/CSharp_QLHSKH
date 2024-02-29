<%@ Page Title="Thêm mới" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ThemHoSo.aspx.cs" Inherits="CongNghePhanMem.view.ThemHoSo" %>
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
            <strong>Thêm bài báo, báo cáo</strong>
        </p>
        <div class="form-group">
            <label for="txtTieuDe">Tiêu đề:</label>
            <asp:TextBox ID="txtTieuDe" runat="server" Width="100%" Placeholder="Nhập tiêu đề"></asp:TextBox>
           <p class="error-message">
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" ControlToValidate="txtTieuDe" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập Tiêu đề"></asp:RequiredFieldValidator>
            </p> 
       </div>
          <div class="form-group">
            <label for="txtTomTat">Tóm tắt:</label>
            <asp:TextBox ID="txtTomTat" runat="server" Width="100%" Placeholder="Nhập tóm tắt" Height="207px"></asp:TextBox>
         
       </div>
           <div class="form-group">
            <label for="txtTacGia">Danh sách tác giả:</label>
            <asp:TextBox ID="txtTacGia" runat="server" Width="100%" Placeholder="Nhập tác giả"></asp:TextBox>
               <p class="error-message">
         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ForeColor="Red" ControlToValidate="txtTacGia" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập Tác giả"></asp:RequiredFieldValidator>
                    </p>
       </div>
          <div class="form-group">
            <label for="txtLink">Nhập link bài báo:</label>
            <asp:TextBox ID="txtLink" runat="server" Width="100%" Placeholder="Nhập link bài báo"></asp:TextBox>
               <p class="error-message">
         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ForeColor="Red" ControlToValidate="txtLink" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập link bài báo"></asp:RequiredFieldValidator>
                         </p>
       </div>
          <div class="form-group">
            <label for="txtNoiXB">Nhập nơi xuất bản:</label>
            <asp:TextBox ID="txtNoiXB" runat="server" Width="100%" Placeholder="Nhập nơi xuất bản"></asp:TextBox>
               <p class="error-message">
          <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ForeColor="Red" ControlToValidate="txtNoiXB" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập Nơi xuất bản"></asp:RequiredFieldValidator>
                   </p>
       </div>
         
         <div class="form-group">
            <label for="txtNamXB">Nhập năm xuất bản:</label>
            <asp:TextBox ID="txtNamXB" runat="server" Width="100%" Placeholder="Nhập năm xuất bản"></asp:TextBox>
               <p class="error-message">
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red" ControlToValidate="txtNamXB" runat="server" Display="Dynamic" ErrorMessage="Vui lòng nhập Năm xuất bản"></asp:RequiredFieldValidator>
                     </p>
       </div>

        <div class="button-container">
            <asp:Button ID="Submit1" runat="server" Text="Thêm bài báo" OnClientClick="return ValidateForm();" OnClick="Submit" CssClass="centered-button" />
        </div>
        </div>

     <script type="text/javascript">
        function ValidateForm() {
            // Add client-side validation logic if needed
            return true;
        }
     </script>
    
</asp:Content>
