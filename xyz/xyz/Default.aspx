<%@ Page Language="C#" Inherits="xyz.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Sum of Two Numbers</title>
</head>
<body>
	<form id="form1" runat="server">
            <asp:Label Text="Num1" runat="server"/>
            <asp:TextBox id="txtv1" runat="server" />
            <br><br>
            <asp:Label Text="Num2" runat="server"/>
            <asp:TextBox id="txtv2" runat="server" /><br><br>
            <asp:Button id="button2" runat="server" Text="Sum" OnClick="button1Clicked" /><br><br>
            <asp:Label Text="Result" runat="server"/>
            <asp:TextBox id="txtv3" runat="server"/>
            <asp:Label id ="err" runat="server" EnableViewState="false" ForeColor="Red"/>
		
	</form>
</body>
</html>
