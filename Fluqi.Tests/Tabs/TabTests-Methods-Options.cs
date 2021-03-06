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
	public partial class Tab_Methods_Options_Tests
	{
		
		[TestMethod]
		public void Ensure_GetCollapsible_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.GetCollapsible();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"collapsible\")", html);
		}

		[TestMethod]
		public void Ensure_SetCollaspsible_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetCollapsible(true);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"collapsible\",true)", html);
		}

		[TestMethod]
		public void Ensure_GetHeightStyle_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.GetHeightStyle();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"heightStyle\")", html);
		}

		[TestMethod]
		public void Ensure_SetHeightStyle_ByEnum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetHeightStyle(Core.HeightStyle.eHeightStyle.Fill);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"heightStyle\",\"fill\")", html);
		}

		[TestMethod]
		public void Ensure_SetHeightStyle_ByString_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetHeightStyle("fill");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"heightStyle\",\"fill\")", html);
		}

		[TestMethod]
		public void Ensure_SetShowEffect_ByEnum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetShow(Core.Animation.eAnimation.Blind, Core.Ease.eEase.easeInCirc, 222);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"show\",{ effect: \"blind\", easing: \"easeInCirc\", duration: 222 })", html);
		}

		[TestMethod]
		public void Ensure_SetShowEffect_ByJSON_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetShow("{ effect: 'blind', easing: 'easeInCirc', duration: 456}");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"show\",{ effect: 'blind', easing: 'easeInCirc', duration: 456})", html);
		}

		[TestMethod]
		public void Ensure_SetShowEffect_ByString_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetShow("slideDown");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"show\",\"slideDown\")", html);
		}

		[TestMethod]
		public void Ensure_SetShowDuration_ByNumber_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetShow(789);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"show\",789)", html);
		}

		[TestMethod]
		public void Ensure_SetDefaultShowDuration_Is_Rendered_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetShow(Fluqi.Utilities.jAnimation.Options.DEFAULT_DURATION);

		  // Act
			string html = resp.Output.ToString();

		  // Assert - Default should still be output because we may have set it to a non-default value after initialisation
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"show\",400)", html);
		}

		[TestMethod]
		public void Ensure_SetHideEffect_ByEnum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetHide(Core.Animation.eAnimation.Blind, Core.Ease.eEase.easeInCirc, 222);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"hide\",{ effect: \"blind\", easing: \"easeInCirc\", duration: 222 })", html);
		}

		[TestMethod]
		public void Ensure_SetHideEffect_ByJSON_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetHide("{ effect: 'blind', easing: 'easeInCirc', duration: 456}");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"hide\",{ effect: 'blind', easing: 'easeInCirc', duration: 456})", html);
		}

		[TestMethod]
		public void Ensure_SetHideEffect_ByString_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetHide("slideDown");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"hide\",\"slideDown\")", html);
		}

		[TestMethod]
		public void Ensure_SetHideDuration_ByNumber_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetHide(789);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"hide\",789)", html);
		}

		[TestMethod]
		public void Ensure_SetDefaultHideDuration_Is_Rendered_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetHide(Fluqi.Utilities.jAnimation.Options.DEFAULT_DURATION);

		  // Act
			string html = resp.Output.ToString();

		  // Assert - Default should still be output because we may have set it to a non-default value after initialisation
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"hide\",400)", html);
		}

		[TestMethod]
		public void Ensure_GetEvent_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.GetEvent();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"event\")", html);
		}

		[TestMethod]
		public void Ensure_SetEvent_By_Enum_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetEvent(Core.BrowserEvent.eBrowserEvent.DblClick);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"event\",\"dblclick\")", html);
		}
				
		[TestMethod]
		public void Ensure_SetEvent_By_String_Without_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetEventJS("some_javascript_variable");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"event\",some_javascript_variable)", html);
		}

		[TestMethod]
		public void Ensure_SetEvent_By_String_With_Quotes_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetEvent("dblclick");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"event\",\"dblclick\")", html);
		}

		[TestMethod]
		public void Ensure_GetShowEffect_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.GetShow();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"show\")", html);
		}

		[TestMethod]
		public void Ensure_GetHideEffect_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.GetHide();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"hide\")", html);
		}

		[TestMethod]
		public void Ensure_DisableShow_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.DisableShow();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"show\",false)", html);
		}

		[TestMethod]
		public void Ensure_DisableHide_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.DisableHide();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"hide\",false)", html);
		}

		[TestMethod]
		public void Ensure_SetShowEffect_By_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetShow("easeInOutBounce");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"show\",\"easeInOutBounce\")", html);
		}

		[TestMethod]
		public void Ensure_SetHideEffect_By_String_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetHide("easeInOutBounce");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"hide\",\"easeInOutBounce\")", html);
		}

		[TestMethod]
		public void Ensure_SetShowEffect_By_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetShow(123);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"show\",123)", html);
		}

		[TestMethod]
		public void Ensure_SetHideEffect_By_Number_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetHide(123);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"hide\",123)", html);
		}
		
		[TestMethod]
		public void Ensure_SetShowEffect_By_Enum_Parameters_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetShow(Core.Animation.eAnimation.Drop, Core.Ease.eEase.easeInOutBounce, 1500);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"show\",{ effect: \"drop\", easing: \"easeInOutBounce\", duration: 1500 })", html);
		}

		[TestMethod]
		public void Ensure_SetHideEffect_By_Enum_Parameters_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetHide(Core.Animation.eAnimation.Drop, Core.Ease.eEase.easeInOutBounce, 1500);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"hide\",{ effect: \"drop\", easing: \"easeInOutBounce\", duration: 1500 })", html);
		}

		[TestMethod]
		public void Ensure_SetShowEffect_By_JSON_Parameters_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetShow("{ effect: \"drop\", easing: \"easeInOutBounce\", duration: 1499 }");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"show\",{ effect: \"drop\", easing: \"easeInOutBounce\", duration: 1499 })", html);
		}

		[TestMethod]
		public void Ensure_SetHideEffect_By_JSON_Parameters_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetHide("{ effect: \"drop\", easing: \"easeInOutBounce\", duration: 1499 }");

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"hide\",{ effect: \"drop\", easing: \"easeInOutBounce\", duration: 1499 })", html);
		}

		[TestMethod]
		public void Ensure_GetActive_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.GetActive();

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"active\")", html);
		}

		[TestMethod]
		public void Ensure_SetActive_Renders_Correctly()
		{
		  // Arrange
		  var resp = new MockWriter();
			var ctl = TestHelper.SetupSimpleTabObject(resp);

		  ctl.Methods.SetActive(3);

		  // Act
			string html = resp.Output.ToString();

		  // Assert
		  Assert.AreEqual("$(\"#myTabs\").tabs(\"option\",\"active\",3)", html);
		}

	} // jTab_Tests

} // ns
