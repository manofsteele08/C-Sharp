<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CurrencyConverter.aspx.cs" Inherits="WebForm_CurrencyConverter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Currency Converter</title>
</head>
<body>
    <form id="form1" runat="server">
      <div style="border-right: thin ridge; padding-right: 20px; border-top: thin ridge;
            padding-left: 20px; padding-bottom: 20px; border-left: thin ridge; width: 531px;
            padding-top: 20px; border-bottom: thin ridge; font-family: Verdana; height: 211px;
            background-color: #FFFFE8">
        Convert:&nbsp;
        <input type="text" id="US" runat="server"/>
        &nbsp; U.S. dollars to &nbsp;
        <select id="currency" runat="server" />
        <br /><br />
        <input type = "submit" value = "OK" id = "Convert" runat = "server" onserverclick="Convert_ServerClick"/>
        <input type = "submit" value = "Show Graph" ID = "ShowGraph" OnServerClick = "ShowGraph_ServerClick" runat = "server" />
        <br /><br />
        <img id = "graph" src="" alt = "Currency Graph" runat = "server" />
         <br /><br />
         <p style="font-weight:bold" id="result" runat="server"></p>
      </div>
        <a href="SecondPage.aspx" target="_blank">Link to SecondPage.aspx</a>
        <br />
        <input type="submit" value="Response.Redirect to SecondPage.aspx" id="redirect" onserverclick="Response_ServerClick" runat="server" />
        <br />
        <input type="submit" value="Server.Transfer to SecondPage.aspx" id="transfer" onserverclick="Transfer_ServerClick" runat="server" />

    </form>
  </body>
</html>
