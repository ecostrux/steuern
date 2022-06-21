/*
 * Created by EcoStruxure Automation Expert.
 * User: labor
 * Date: 12/04/2022
 * Time: 2:59 pm
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.farberkennung
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sDefault));
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			this.label_11 = new System.HMI.Symbols.Base.Label<short>();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.farbe = new System.HMI.Symbols.Base.Label<short>();
			this.led_11 = new System.HMI.Symbols.Base.Led<short>();
			// 
			// label_11
			// 
			this.label_11.BeginInit();
			this.label_11.AngleIgnore = false;
			this.label_11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label_11.DecimalPlacesCount = ((uint)(2u));
			this.label_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58D, 0D, 0D, 1D, 8D, 56D);
			this.label_11.FontScale = false;
			this.label_11.IsOnlyInput = true;
			this.label_11.LeadingZeros = ((uint)(0u));
			this.label_11.Name = "label_11";
			this.label_11.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.label_11.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.label_11.TagName = "farbsensor";
			this.label_11.EndInit();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(32D)), ((float)(40D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.rectangle1.ImageBytes = resources.GetString("rectangle1.ImageBytes");
			this.rectangle1.Name = "rectangle1";
			// 
			// farbe
			// 
			this.farbe.BeginInit();
			this.farbe.AngleIgnore = false;
			this.farbe.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.farbe.DecimalPlacesCount = ((uint)(2u));
			this.farbe.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.41333333333333333D, 0D, 0D, 1D, 96D, 16D);
			this.farbe.FontScale = false;
			this.farbe.IsOnlyInput = true;
			this.farbe.LeadingZeros = ((uint)(0u));
			this.farbe.Name = "farbe";
			this.farbe.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			propertyDictionary2.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary2.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.farbe.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.farbe.TagName = "farbe";
			this.farbe.EndInit();
			// 
			// led_11
			// 
			this.led_11.BeginInit();
			this.led_11.AngleIgnore = false;
			this.led_11.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.led_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(3D, 0D, 0D, 3D, 66D, 26D);
			this.led_11.FrameSize = 33F;
			this.led_11.IsOnlyInput = true;
			this.led_11.Name = "led_11";
			propertyDictionary4.Add("Color", new NxtControl.Drawing.Color("Green"));
			propertyDictionary5.Add("Color", new NxtControl.Drawing.Color("SE.AppAsset.FwdCoolingInner"));
			propertyDictionary6.Add("Color", new NxtControl.Drawing.Color("SE.AppAsset.ExtractAirInner"));
			this.led_11.Ranges.Clear();
			this.led_11.Ranges.Add(new NxtControl.GuiFramework.Range<short>(((short)(0)), propertyDictionary4));
			this.led_11.Ranges.Add(new NxtControl.GuiFramework.Range<short>(((short)(1)), propertyDictionary5));
			this.led_11.Ranges.Add(new NxtControl.GuiFramework.Range<short>(((short)(2)), propertyDictionary6));
			propertyDictionary3.Add("Color", new NxtControl.Drawing.Color("LedDefaultColor"));
			this.led_11.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.led_11.TagName = "farbe";
			this.led_11.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.label_11,
			this.rectangle1,
			this.farbe,
			this.led_11});
			this.SymbolSize = new System.Drawing.Size(136, 72);

		}
		private System.HMI.Symbols.Base.Label<short> label_11;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private System.HMI.Symbols.Base.Label<short> farbe;
		private System.HMI.Symbols.Base.Led<short> led_11;
		#endregion
	}
}
