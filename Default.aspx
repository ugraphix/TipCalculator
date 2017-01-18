<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<a href="Default.aspx.cs">Default.aspx.cs</a>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Tip Calculator</h1>
    <div>
        <p></p>
        <asp:Label ID="MealAmount" runat="server" Text="Enter Meal Amount"></asp:Label>
        <!--renamed because Conger will refer to the textbox in code-->
        <asp:TextBox ID="MealTextBox" runat="server"></asp:TextBox>
        <asp:RadioButtonList ID="TipPercentRadios" runat="server"></asp:RadioButtonList>
        <asp:TextBox ID="OtherTextbox" runat="server"></asp:TextBox>
        <br><asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" /></br>
        <asp:Label ID="Results" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
