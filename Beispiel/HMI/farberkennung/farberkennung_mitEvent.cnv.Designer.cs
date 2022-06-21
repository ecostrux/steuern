/*
 * Created by EcoStruxure Automation Expert.
 * User: labor
 * Date: 27/04/2022
 * Time: 8:25 am
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.farberkennung
{
	/// <summary>
	/// Summary description for mitEvent.
	/// </summary>
	partial class mitEvent
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			this.twoStateButton1 = new NxtControl.GuiFramework.TwoStateButton();
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(16D)), ((float)(80D)), ((float)(25D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.Text = "Event";
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			this.drawnButton1.Click += new System.EventHandler(this.DrawnButton1Click);
			// 
			// twoStateButton1
			// 
			this.twoStateButton1.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(56D)), ((float)(80D)), ((float)(25D)));
			this.twoStateButton1.DrawStyle = NxtControl.GuiFramework.TwoStateButton.ButtonDrawStyle.CheckBox;
			this.twoStateButton1.FalseBrush = new NxtControl.Drawing.Brush("ButtonFalseBrush");
			this.twoStateButton1.FalseText = "OFF";
			this.twoStateButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.twoStateButton1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.twoStateButton1.Name = "twoStateButton1";
			this.twoStateButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.twoStateButton1.Radius = 8D;
			this.twoStateButton1.TextColorFalse = new NxtControl.Drawing.Color("ButtonTextColorFalse");
			this.twoStateButton1.TextColorTrue = new NxtControl.Drawing.Color("ButtonTextColorTrue");
			this.twoStateButton1.TrueText = "ON";
			this.twoStateButton1.Use3DEffect = false;
			// 
			// mitEvent
			// 
			this.Name = "mitEvent";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.drawnButton1,
			this.twoStateButton1});
			this.SymbolSize = new System.Drawing.Size(144, 96);

		}
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private NxtControl.GuiFramework.TwoStateButton twoStateButton1;
		#endregion
	}
}
