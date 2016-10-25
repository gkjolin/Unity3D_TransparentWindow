using UnityEngine;
using XJ.Unity3D.Extensions;

public class TransparentWindowSample : MonoBehaviour
{
    #region Field

    public GameObject object1;

    #endregion Field

    /// <summary>
    /// 開始時に呼び出されます。
    /// </summary>
    protected virtual void Start ()
    {
        if (Screen.fullScreen)
        {
            object1.SetColor(Color.red);
        }
    }
}