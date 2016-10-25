using UnityEngine;
using XJ.Unity3D.Extensions;

public class GizmosExSample : MonoBehaviour
{
    protected virtual void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        GizmosEx.DrawCross(Vector3.zero, 1);

        GizmosEx.DrawWireRectangle(Vector3.one, 1, 1);
    }
}