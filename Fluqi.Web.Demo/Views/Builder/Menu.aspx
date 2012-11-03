﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Builder.Master" Inherits="System.Web.Mvc.ViewPage<Fluqi.Models.MenuModel>" %>
<%@ Import Namespace="Fluqi.Web.Demo.Helpers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="DemoMainContent" runat="server">
<script src="<%=Url.Content("~/Scripts/menu.js")%>" type="text/javascript"></script>
<%
	var iconCheatDlg = Html.CreateDialog("icon-cheat");
	this.Model.ConfigureIconCheatSheetDialog(iconCheatDlg);

	var mnu = Html.CreateMenu("mnu");
	this.Model.ConfigureMenu(mnu);
%>
	<label for="myMenu">Menu:</label>
	<br />

<%mnu.Render();%>

<%using (iconCheatDlg.RenderDialog()) { %>
	<%Html.RenderPartial("Icons");%>
<%} %>
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="DemoExampleContent" runat="server">
<%
	var showIcons = Html.CreateButton("showIcons", "...")
		.Rendering.SetPrettyRender(true).Finish()
		.Events
			.SetClickEvent("return openIconsDialog('Icons');")
		.Finish()
	;
%>
<%
	string positionTooltip = "Identifies the position of the Autocomplete widget in relation to the associated input element, best looking at the documentation for the Position utility at jQuery UI website.";
	using (Html.BeginForm("Menu", "Builder")) {
%>
	<input type="submit" value="UPDATE" />
	<ul class="small-label">
		<li><%=Html.LabelFor(vm=>vm.Disabled)    %><%=Html.CheckBoxFor(vm=>vm.Disabled, "Disables the menu.")%></li>
		<li><%=Html.LabelFor(vm=>vm.Icons)       %><%=Html.DropDownTipListFor(vm=>vm.Icons, List.IconListNames(), "Overrides the icon for the unselected panel, try 'ui-icon-plusthick' for example.")%> <%showIcons.Render();%></li> 
		<li><%=Html.Label("Position.at")       %><%=Html.DropDownTipListFor(vm=>vm.At1, List.DirectionItems(), positionTooltip)%> <%=Html.DropDownTipListFor(vm=>vm.At2, List.DirectionItems(), positionTooltip)%></li>
		<li><%=Html.Label("Position.my")       %><%=Html.DropDownTipListFor(vm=>vm.My1, List.DirectionItems(), positionTooltip)%> <%=Html.DropDownTipListFor(vm=>vm.My2, List.DirectionItems(), positionTooltip)%></li>
		<li><%=Html.Label("Position.collision")%><%=Html.DropDownTipListFor(vm=>vm.Collision1, List.CollisionItems(), positionTooltip)%> <%=Html.DropDownTipListFor(vm=>vm.Collision2, List.CollisionItems(), positionTooltip)%></li>
	</ul>
	<hr />
	<h2>Test Harness Options</h2>
	<ul>
		<li><%=Html.LabelFor(vm=>vm.showEvents)    %><%=Html.CheckBoxFor(vm=>vm.showEvents, "Shows how events are wired up.")%></li>
		<li><%=Html.LabelFor(vm=>vm.renderCSS)     %><%=Html.CheckBoxFor(vm=>vm.renderCSS, "Shows the CSS generated by jQuery UI (so non-JavaScript users still see the layout/colours).")%></li>
		<li><%=Html.LabelFor(vm=>vm.prettyRender)  %><%=Html.CheckBoxFor(vm=>vm.prettyRender, "Shows the rendered control/JavaScript in a readable layout.  Turn this option off to see the compressed version (which is the default in a RELEASE build).")%></li>
	</ul>
	<input type="submit" value="UPDATE" />
<%}//form %>
</asp:Content>



<asp:Content ID="Content3" ContentPlaceHolderID="DemoCodeContent" runat="server">
<%
	var mnu = Html.CreateMenu("mnu");
	this.Model.ConfigureMenu(mnu)	;
%>
<%=this.Model.CSharpCode(mnu)%>
</asp:Content>



<asp:Content ID="Content4" ContentPlaceHolderID="DemoHtmlContent" runat="server">
<%
	var mnu = Html.CreateMenu("mnu");
	this.Model.ConfigureMenu(mnu);

	mnu
		.Rendering
			.SetAutoScript(false)
		.Finish()
	.Render();
%>
</asp:Content>



<asp:Content ID="Content5" ContentPlaceHolderID="DemoJavaScriptCodeContent" runat="server">
<%
	var mnu = Html.CreateMenu("mnu");
	this.Model.ConfigureMenu(mnu)	;
%>
<%=this.Model.JavaScriptCode(mnu)%>
</asp:Content>



<asp:Content ID="Content6" ContentPlaceHolderID="DemoMethodsContent" runat="server">
	<ul class="horizontal">
		<li><button id="disable" title="Disables the menu.">Disable</button></li>
		<li><button id="enable" title="Enables the menu.">Enable</button></li>
		<li><button id="refresh" title="Refresh the menu.">Refresh</button></li>
		<li><button id="widget" title="Shows the HTML for the .ui-menu element.">Widget</button></li>
		<li><button id="destroy" title="Returns the button to it's pre-init state.">Destroy</button></li>
	</ul>
<%
	var mnu = Html.CreateMenu("mnu");
	this.Model.ConfigureMenu(mnu);
%>
	<script type="text/javascript">
	$(document).ready(function() {
		$("#enable").click(function() { <%mnu.Methods.Enable();%>; });
		$("#disable").click(function() { <%mnu.Methods.Disable();%>; });
		$("#refresh").click(function() { <%mnu.Methods.Refresh();%>; });
		$("#widget").click(function() { alert( "Widget HTML:\n\n" + <%mnu.Methods.Widget();%>.html() ); });
		$("#destroy").click(function() {  if (confirm("are you sure you want to destroy the menu?")) <%mnu.Methods.Destroy();%>; });
	});
	</script>
</asp:Content>

