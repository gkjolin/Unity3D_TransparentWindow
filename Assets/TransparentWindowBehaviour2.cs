using System;
using System.Runtime.InteropServices;
using UnityEngine;

// この方法では完全に透過することができません。ブラーがかかります。

/// <summary>
/// 実行ウィンドウを透過させるコンポーネント。
/// </summary>
public class TransparentWindowBehaviour2 : MonoBehaviour
{
    #region Struct

    [StructLayout(LayoutKind.Sequential)]
    internal struct WindowCompositionAttributeData
    {
        public WindowCompositionAttribute Attribute;
        public IntPtr Data;
        public int SizeOfData;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct AccentPolicy
    {
        public AccentState AccentState;
        public int AccentFlags;
        public int GradientColor;
        public int AnimationId;
    }

    #endregion Struct

    #region Enum

    internal enum WindowCompositionAttribute
    {
        // ...
        WCA_ACCENT_POLICY = 19
        // ...
    }

    internal enum AccentState
    {
        ACCENT_DISABLED = 0,
        ACCENT_ENABLE_GRADIENT = 1,
        ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
        ACCENT_ENABLE_BLURBEHIND = 3,
        ACCENT_INVALID_STATE = 4
    }

    #endregion Enum

    #region Dll Import

    /// <summary>
    /// WindowHandle を取得します。
    /// </summary>
    /// <returns>
    /// WindowHandl.(Window を参照するポインタ)
    /// </returns>
    [DllImport("user32.dll")]
    private static extern IntPtr GetActiveWindow();


    [DllImport("user32.dll")]
    internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

    #endregion Dll Import

    #region Field

    /// <summary>
    /// 有効か無効か。true のとき有効。
    /// </summary>
    new public bool enabled;

    #endregion Field

    #region Method

    // enabled をスクリプトから変更する余地を残すために、
    // Awake ではなく Start で実行するようにしています。

    /// <summary>
    /// 開始時に呼び出されます。
    /// </summary>
    protected virtual void Start()
    {
        if (!this.enabled)
        {
            return;
        }

//#if !UNITY_EDITOR
        IntPtr windowHandle = GetActiveWindow();
    
        var accent = new AccentPolicy();
        var accentStructSize = Marshal.SizeOf(accent);
        accent.AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND;
    
        var accentPtr = Marshal.AllocHGlobal(accentStructSize);
        Marshal.StructureToPtr(accent, accentPtr, false);
    
        var data = new WindowCompositionAttributeData();
        data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
        data.SizeOfData = accentStructSize;
        data.Data = accentPtr;

        SetWindowCompositionAttribute(windowHandle, ref data);
    
        Marshal.FreeHGlobal(accentPtr);
//#endif
    }

    #endregion Method
}