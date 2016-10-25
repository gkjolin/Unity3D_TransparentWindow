using UnityEngine;

namespace XJ.Unity3D.Extensions
{
    /// <summary>
    /// Color 型の拡張メソッドやユーティリティメソッドを実装します。
    /// </summary>
    public static class ColorEx
    {
        /// <summary>
        /// 基本的な色の配列です。ただし clear を除きます。
        /// </summary>
        public static Color[] DefaultColors = new Color[]
        {
        Color.black,
        Color.blue,
        Color.cyan,
        Color.gray,
        Color.green,
        Color.magenta,
        Color.red,
        Color.white,
        Color.yellow
        };

        /// <summary>
        /// DefaultColors の数。
        /// </summary>
        public static int DefaultColorsLength = DefaultColors.Length;

        /// <summary>
        /// 基本的な色からランダムな色を取得します。
        /// </summary>
        /// <returns>
        /// 基本的な色から選択されたランダムな色。
        /// </returns>
        public static Color GetRandomDefaultColor()
        {
            return ColorEx.DefaultColors[Random.Range(0, ColorEx.DefaultColorsLength)];
        }
    }
}