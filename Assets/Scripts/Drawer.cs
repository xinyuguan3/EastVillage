using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shapes;

[ExecuteAlways]
public class Drawer : ImmediateModeShapeDrawer
{
    public override void DrawShapes( Camera cam ){

		using( Draw.Command( cam ) ){

			// set up static parameters. these are used for all following Draw.Line calls
			Draw.LineGeometry = LineGeometry.Flat2D;
			Draw.ThicknessSpace = ThicknessSpace.Pixels;
			Draw.Thickness = 4; // 4px wide

			// set static parameter to draw in the local space of this object
			Draw.Matrix = transform.localToWorldMatrix;

			// draw lines
			Draw.Line( Vector3.zero, Vector3.right,   Color.red   );
			Draw.Line( Vector3.zero, Vector3.up,      Color.green );
			Draw.Line( Vector3.zero, Vector3.forward, Color.blue  );
		}

	}
}
