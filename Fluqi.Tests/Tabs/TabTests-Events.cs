﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fluqi.Widget.jTab;
using System.Web;
using System.Web.Routing;
using Fluqi.Tests.Mocks;
using Fluqi.Tests;
using Fluqi.Tests.Helpers;

namespace Fluqi.Tests
{
	[TestClass]
	public partial class Tab_Events_Tests
	{

		[TestMethod]
		public void Ensure_Tab_With_Multiple_EventHandlers_Are_Added_To_Script_Definition_Correctly()
		{
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Options
					.SetEvent("mouseover")
				.Finish()
				.Rendering
					.Compress();

			tabs.Events
				.SetCreateEvent("addToLog('Create event called');")
				.SetActivateEvent("addToLog('Activate event called');")
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "create: function(event, ui) {addToLog('Create event called');},activate: function(event, ui) {addToLog('Activate event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Tabs_With_Create_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Options
					.SetEvent("mouseover")
					.Finish()
				.Rendering
					.Compress();

			tabs.Events
				.SetCreateEvent("addToLog('Create event called');")
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "create: function(event, ui) {addToLog('Create event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Tabs_With_BeforeActivate_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Options
					.SetEvent("mouseover")
				.Finish()
				.Rendering
					.Compress();

			tabs.Events
				.SetBeforeActivateEvent("addToLog('beforeActivate event called');")
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "beforeActivate: function(event, ui) {addToLog('beforeActivate event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Tabs_With_Load_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Options
					.SetEvent("mouseover")
					.Finish()
				.Rendering
					.Compress();

			tabs.Events
				.SetLoadEvent("addToLog('Load event called');")
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "load: function(event, ui) {addToLog('Load event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Tabs_With_Activate_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs
				.Options
					.SetEvent("mouseover")
				.Finish()
				.Rendering
					.Compress();

			tabs.Events
				.SetActivateEvent("addToLog('Activate event called');")
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "activate: function(event, ui) {addToLog('Activate event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

		[TestMethod]
		public void Tabs_With_BeforeLoad_EventHandler_Wired_Up_Renders_Correctly()
		{
			// Arrange
			// Arrange
			var resp = new MockWriter();
			Tabs tabs = TestHelper.SetupSimpleTabObject(resp);

			// only testing raw output
			tabs	
				.Options
					.SetEvent("mouseover")
					.Finish()
				.Rendering
					.Compress();

			tabs.Events
				.SetBeforeLoadEvent("addToLog('beforeLoad event called');")
			;

			TestHelper.ForceRender(tabs);

			// Act - Force output we'd see on the web page
			string html = resp.Output.ToString();

		  // Assert
		  string expected = "beforeLoad: function(event, ui) {addToLog('beforeLoad event called');}";
		  Assert.IsTrue(html.Contains(expected));
		}

	} // jTab_Tests

} // ns
