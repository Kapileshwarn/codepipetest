<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true"
    Inherits="System.Web.Mvc.ViewPage<ProductsMenuModel>" %>
<%@ Import Namespace="WroxPizza.Web.Views.Shared"%>
<%@ Import Namespace="WroxPizza.Core.Web.ViewModels"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <% for (int i = 0; i < Model.Products.Count; i++) { %>
         <div class="<%=Html.GetRowClass(i) %>">
            <%= Html.Encode(Model.Products[i].Name) %><br />
            <%= Html.Encode(Model.Products[i].Description)%><br />
            <%= Model.Products[i].BasePrice%>
        </div> 
      <% } %>

</asp:Content>
