/*
 * Created by EcoStruxure Automation Expert.
 * User: labor
 * Date: 27/04/2022
 * Time: 8:25 am
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.farberkennung
{
	/// <summary>
	/// Description of mitEvent.
	/// </summary>
	public partial class mitEvent : NxtControl.GuiFramework.HMISymbol
	{
		public mitEvent()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.REQ_Fired += REQ_Fired_EventHandler;
		}

	

		void DrawnButton1Click(object sender, EventArgs e)
		{
			// TODO: Implement DrawnButton1Click
			FireEvent_CNF();
		}

		void REQ_Fired_EventHandler(object sender, REQEventArgs e)
		{
			// TODO: Implement REQ_Fired_EventHandler
			twoStateButton1.Checked = true;
				
	
		}
	}
}
