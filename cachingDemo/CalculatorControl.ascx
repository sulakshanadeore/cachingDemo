<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CalculatorControl.ascx.cs" Inherits="cachingDemo.CalculatorControl" %>
<%@ OutputCache Duration="10" VaryByControl="txtfno;txtsno" %>


First No:<asp:TextBox ID="txtfno" runat="server"></asp:TextBox>
<br />
<br />
Second No:
<asp:TextBox ID="txtsno" runat="server"></asp:TextBox>
<br />
<br />
Answer<asp:TextBox ID="txtans" runat="server"></asp:TextBox>
<br />
<br />
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
&nbsp;
<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Subtract" />

