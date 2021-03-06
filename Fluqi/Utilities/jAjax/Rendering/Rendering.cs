﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fluqi.jAjax
{

	/// <summary>
	/// Responsible for setting how the control should be rendered to the page.  For instance
	/// should the control CSS be rendered, should pretty layout be used, etc.
	/// </summary>
	public class Rendering: Core.RenderBase {

		public Rendering(Ajax pos)
		 : base()
		{
			this.Ajax = pos;
		}

		/// <summary>
		/// Used to flag that configuration has finished, and 
		/// returns the <see cref="Ajax"/> object so we can continue defining Ajax attributes.
		/// </summary>
		/// <returns>Returns <see cref="Ajax"/> object to return chaining to the Ajax collection</returns>
		public Ajax Finish() {
			return this.Ajax;
		}

		/// <summary>
		/// Holds a reference to the <see cref="Ajax"/> object these options are for
		/// </summary>
		public Ajax Ajax { get; set; }


		/// <summary>
		/// Forces pretty rendering off so you can see the output whilst in DEBUG mode if you wish
		/// </summary>
		new public Rendering Compress() {
			base.Compress();
			return this;
		}


		/// <summary>
		/// Writes full CSS to the browser (jQuery UI classes are expanded for non-JS users)
		/// </summary>
		/// <returns>Control for chainability</returns>
		new public Rendering ShowCSS() {
			base.ShowCSS();
			return this;
		}


		/// <summary>
		/// Specifies that when writing in pretty HTML mode (see <see cref="Compress"/>) 
		/// the Html helper should start writing at a particular tab depth (so everything lines
		/// up nicely when you view the source).
		/// </summary>
		/// <param name="indentation">How far the Html helper should indent the rendered HTML</param>
		/// <returns>Ajax object for chainability</returns>
		new public Rendering SetTabDepth(int indentation) {
			base.SetTabDepth(indentation);
			return this;
		}


		/// <summary>
		/// Specifies whether the control should be self-initialising (with it's own $(document).ready
		/// section, or if this should be left to the view to declare on purpose.
		/// </summary>
		/// <param name="autoScript">
		/// If true the control initialises itself
		/// If false the initialisation is left to the [calling] view
		/// </param>
		/// <returns>Ajax object for chainability</returns>
		new public Rendering SetAutoScript(bool autoScript) {
			base.SetAutoScript(autoScript);
			return this;
		}

	}

}
