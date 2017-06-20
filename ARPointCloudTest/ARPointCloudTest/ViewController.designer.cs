//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;

namespace ARPointCloudTest
{
	[Register("ViewController")]
	partial class ViewController
	{
		[Outlet]
		ARKit.ARSCNView SceneView { get; set; }

		void ReleaseDesignerOutlets()
		{
			if (SceneView != null)
			{
				SceneView.Dispose();
				SceneView = null;
			}
		}
	}
}
