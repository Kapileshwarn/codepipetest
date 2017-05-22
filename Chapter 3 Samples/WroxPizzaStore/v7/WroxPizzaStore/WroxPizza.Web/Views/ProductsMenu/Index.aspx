<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true"
    Inherits="System.Web.Mvc.ViewPage<ProductsMenuModel>" %>
<%@ Import Namespace="WroxPizza.Web.Views.Shared"%>
<%@ Import Namespace="WroxPizza.Core.Web.ViewModels"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <div class="Products">
        <% Html.RenderPartial("ProductGrid", Model.Products); %>
    </div>
    
</asp:Content>
