using UnityEngine;
using System.Runtime.InteropServices;
using System;

/// <summary>
/// 実行ウィンドウのフレームを非表示にするコンポーネント。
/// </summary>
public class FramelessWindowBehaviour : MonoBehaviour
{
    #region DLL Import

    /// <summary>
    /// WindowHandle を取得します。
    /// </summary>
    /// <returns>
    /// WindowHandl.(Window を参照するポインタ)
    /// </returns>
    [DllImport("user32.dll")]
    private static extern IntPtr GetActiveWindow();

    /// <summary>
    /// Window の特定のパラメータに新たな値を設定します。
    /// </summary>
    /// <param name="hWnd">
    /// WindowHandle.
    /// </param>
    /// <param name="nIndex">
    /// 設定する項目を示すインデックス。
    /// </param>
    /// <param name="dwNewLong">
    /// 設定する値。
    /// </param>
    /// <returns>
    /// 結果。
    /// </returns>
    [DllImport("user32.dll")]
    private static extern int SetWindowLong(IntPtr hWnd, int nIndex, uint dwNewLong);

    [DllImport("user32.dll")]
    static extern bool SetWindowPos
        (IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

    #endregion DLL Import

    #region Field

    /// <summary>
    /// 有効か無効か。true のとき有効。
    /// </summary>
    new public bool enabled;

    /// <summary>
    /// Window を表示する位置と大きさ。
    /// </summary>
    public Rect screenPosition;

    #endregion Field

    #region Method

    // enabled をスクリプトから変更する余地を残すために、
    // Awake ではなく Start で実行するようにしています。

    /// <summary>
    /// 開始時に呼び出されます。
    /// </summary>
    protected virtual void Start ()
    {
        if (!this.enabled)
        {
            return;
        }

#if !UNITY_EDITOR

        const uint SWP_SHOWWINDOW = 0x0040;
        const int GWL_STYLE = -16;
        const uint WS_BORDER = 1;

        IntPtr windowHandle = GetActiveWindow();
        SetWindowLong(windowHandle, GWL_STYLE, WS_BORDER);
        bool result = SetWindowPos(windowHandle,
                                   0,
                                   (int)screenPosition.x,
                                   (int)screenPosition.y,
                                   (int)screenPosition.width,
                                   (int)screenPosition.height,
                                   SWP_SHOWWINDOW);
#endif
    }

    #endregion Method
}