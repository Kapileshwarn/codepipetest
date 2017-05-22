<%@ Import Namespace="WroxPizza.Web.Views.Shared"%>
<%@ Import Namespace="WroxPizza.Core.Model"%>
<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<List<Product>>" %>
<div class="grid">
    <% for (int i = 0; i < Model.Count; i++) { %>
             <div class="<%=Html.GetRowClass(i) %>">
                <% Html.RenderPartial("ProductItem", Model[i]); %>
            </div> 
      <% } %>
</div>      