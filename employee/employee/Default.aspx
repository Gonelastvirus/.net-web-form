<%@ Page Language="C#" Inherits="employee.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
	<asp:TextBox id ="txtv1"  runat="server" placeholder="Employee ID"/>
    <asp:Button id="Button1" runat="server" Text="Submit" EnableViewState="false" OnClick="Button1Clicked"/>  
    <asp:Label id="err" runat="server" Visible="true" EnableViewState="false" />
            <br><br>
        <asp:Button id="Button2" runat="server" Text="Read" EnableViewState="false" OnClick="Button2Clicked"/> <br><br>
     
        <asp:PlaceHolder id="placeholder1" runat="server" /> 
            
            <br><br>
            <asp:TextBox id ="txtv2"  runat="server" placeholder="Enter ID"/>
            <asp:Button id="Button3" runat="server" Text="Delete" EnableViewState="false" OnClick="Button3Clicked"/>
             <asp:Label id="label2" runat="server" Visible="true" EnableViewState="false" />
            
            <br><br>
            <asp:Label id="label3" runat="server" Visible="true" Text="Id" EnableViewState="false" />
            <asp:TextBox id ="txtv3"  runat="server" placeholder="Enter ID"/><br><br>
            <asp:Label id="label4" runat="server" Visible="true" Text="Name" EnableViewState="false" />
            <asp:TextBox id ="txtv4"  runat="server" placeholder="Enter Name"/>
            <asp:Button id="Button4" runat="server" Text="Update" EnableViewState="false" OnClick="Button4Clicked"/>
            <asp:Label id="label5" runat="server" Visible="true" EnableViewState="false" />
            
	</form>
</body>
</html>
