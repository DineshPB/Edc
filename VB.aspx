<%@ Page Language="VB" AutoEventWireup="false" CodeFile="VB.aspx.vb" Inherits="VB" %>
<%@ Register Src = "~/UC_DateSelectorVB.ascx" TagName = "DateSelector" TagPrefix = "uc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <uc:DateSelector ID = "ucDateSelector" runat = "server" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick  = "Submit" />
    </div>
    </form>
</body>
</html>
