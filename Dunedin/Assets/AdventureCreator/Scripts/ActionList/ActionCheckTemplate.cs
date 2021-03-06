/*
 *
 *	Adventure Creator
 *	by Chris Burton, 2013-2016
 *	
 *	"ActionCheckTemplate.cs"
 * 
 *	This is a blank action template, which has two outputs.
 * 
 */

using UnityEngine;
using System.Collections;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace AC
{

	[System.Serializable]
	public class ActionCheckTemplate : ActionCheck
	{
		
		// Declare variables here
		
		
		public ActionCheckTemplate ()
		{
			this.isDisplayed = true;
			category = ActionCategory.Custom;
			title = "Check template";
			description = "This is a blank 'Check' Action template.";
		}


		public override bool CheckCondition ()
		{
			// Return 'true' if the condition is met, and 'false' if it is not met.

			return false;
		}

		
		#if UNITY_EDITOR

		override public void ShowGUI ()
		{
			// Action-specific Inspector GUI code here.  The "Condition is met" / "Condition is not met" GUI is rendered automatically afterwards.
		}
		

		public override string SetLabel ()
		{
			// Return a string used to describe the specific action's job.
			
			string labelAdd = "";
			return labelAdd;
		}

		#endif
		
	}

}