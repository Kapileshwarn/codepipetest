<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true"
    Inherits="System.Web.Mvc.ViewPage<ProductsMenuModel>" %>
<%@ Import Namespace="WroxPizza.Core.Web.ViewModels"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <% foreach (var product in Model.Products) { %>
            <%=product.Name %>
            <%=product.Description %>
            <%=product.BasePrice %>
    <% } %>

</asp:Content>
