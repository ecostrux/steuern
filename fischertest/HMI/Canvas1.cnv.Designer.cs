/*
 * Created by EcoStruxure Automation Expert.
 * User: Lernfabrik
 * Date: 21/06/2022
 * Time: 3:51 pm
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for Canvas1.
	/// </summary>
	partial class Canvas1
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CAT1 = new HMI.Main.Symbols.CAT1.sDefault();
			// 
			// CAT1
			// 
			this.CAT1.BeginInit();
			this.CAT1.AngleIgnore = false;
			this.CAT1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 120D);
			this.CAT1.Name = "CAT1";
			this.CAT1.SecurityToken = ((uint)(4294967295u));
			this.CAT1.TagName = "CF7BFD0D6D8A8A09";
			this.CAT1.EndInit();
			// 
			// Canvas1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1024D)), ((float)(688D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas1";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.CAT1});
			this.Size = new System.Drawing.Size(1024, 688);

		}
		private HMI.Main.Symbols.CAT1.sDefault CAT1;
		#endregion
	}
}
