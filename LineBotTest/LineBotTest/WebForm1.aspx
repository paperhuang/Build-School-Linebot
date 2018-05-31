<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LineBotTest.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="傳送文字訊息" />
        </div>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="傳送貼圖" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="傳送圖片" />
        </p>
        <p>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="傳送現在時間" />
        </p>
    </form>
</body>
</html>
