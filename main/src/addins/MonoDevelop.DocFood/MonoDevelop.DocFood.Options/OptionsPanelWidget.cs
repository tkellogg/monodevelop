// 
// OptionsPanelWidget.cs
//  
// Author:
//       mkrueger <${AuthorEmail}>
// 
// Copyright (c) 2010 mkrueger
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using MonoDevelop.Ide.Gui.Dialogs;

namespace MonoDevelop.DocFood.Options
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class OptionsPanelWidget : Gtk.Bin
	{
//		DocConfig config;
		
		public OptionsPanelWidget (DocConfig config)
		{
//			this.config = config;
			this.Build ();
		}
	}
	
	public class OptionsPanelPanel : OptionsPanel
	{
		OptionsPanelWidget panel;
		
		public override Gtk.Widget CreatePanelWidget ()
		{
			panel = new OptionsPanelWidget (DocConfig.Instance);
			return panel;
		}
		
		public override void ApplyChanges ()
		{
		//	panel.Store ();
		}
	}
}

