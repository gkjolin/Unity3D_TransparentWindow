using UnityEngine;

namespace XJ.Unity3D.Extensions
{
    /// <summary>
    /// Gizmos のユーティリティメソッドを実装します。
    /// </summary>
    public static class GizmosEx
    {
        /// <summary>
        /// 十字を描画します。
        /// </summary>
        /// <param name="center">
        /// 十字を描画する場所。
        /// </param>
        /// <param name="lineLength">
        /// 十字の線の長さ。
        /// </param>
        public static void DrawCross(Vector3 center, float lineLength)
        {
            Vector3 from = center;
            Vector3 to = center;
            float halfLength = lineLength / 2f;

            from.x = from.x - halfLength;
            to.x = to.x + halfLength;

            Gizmos.DrawLine(from, to);

            from = center;
            to = center;

            from.y = from.y - halfLength;
            to.y = to.y + halfLength;

            Gizmos.DrawLine(from, to);
        }

        /// <summary>
        /// ワイヤーフレームの長方形を描画します。
        /// </summary>
        /// <param name="center">
        /// 中心の座標。
        /// </param>
        /// <param name="size">
        /// 長方形の大きさ。
        /// </param>
        public static void DrawWireRectangle(Vector3 center, Vector3 size)
        {
            DrawWireRectangle(center, new Vector2(size.x, size.y));
        }

        /// <summary>
        /// ワイヤーフレームの長方形を描画します。
        /// </summary>
        /// <param name="center">
        /// 中心の座標。
        /// </param>
        /// <param name="size">
        /// 長方形の大きさ。
        /// </param>
        public static void DrawWireRectangle(Vector3 center, Vector2 size)
        {
            DrawWireRectangle(center, size.x, size.y);
        }

        /// <summary>
        /// ワイヤーフレームの長方形を描画します。
        /// </summary>
        /// <param name="center">
        /// 中心の座標。
        /// </param>
        /// <param name="width">
        /// 長方形の幅。
        /// </param>
        /// <param name="height">
        /// 長方形の高さ。
        /// </param>
        public static void DrawWireRectangle(Vector3 center, float width, float height)
        {
            Gizmos.DrawWireCube(center, new Vector3(width, height, 0));
        }
    }
}