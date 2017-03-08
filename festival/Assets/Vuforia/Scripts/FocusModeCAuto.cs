using UnityEngine;
using System.Collections;
using Vuforia;
namespace Vuforia
{
	/// <summary>
	/// Helper behaviour used to hide augmented objects behind the video background.
	/// </summary>
	public class FocusModeCAuto : MonoBehaviour{

		void Start ()
		{


			bool focusModeSet = CameraDevice.Instance.SetFocusMode (
				CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);

		}

	}

}