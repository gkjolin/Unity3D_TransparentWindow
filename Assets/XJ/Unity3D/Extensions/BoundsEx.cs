using UnityEngine;

namespace XJ.Unity3D.Extensions
{
    /// <summary>
    /// Bounds 構造体の拡張メソッドやユーティリティメソッドを実装します。
    /// </summary>
    public static class BoundsEx
    {
        #region Extension

        /// <summary>
        /// Bounds 内のランダムな座標を取得します。
        /// </summary>
        /// <param name="bounds">
        /// ランダムな座標を取得する領域。
        /// </param>
        /// <returns>
        /// bounds 内のランダムな座標。
        /// </returns>
        public static Vector3 GetRandomPoint(this Bounds bounds)
        {
            return new Vector3()
            {
                x = Random.Range(bounds.min.x, bounds.max.x),
                y = Random.Range(bounds.min.y, bounds.max.y),
                z = Random.Range(bounds.min.z, bounds.max.z),
            };
        }

        /// <summary>
        /// Bounds の前面左上の座標を算出して取得します。
        /// </summary>
        /// <param name="bounds">
        /// 前面左上の座標を取得する Bounds.
        /// </param>
        /// <returns>
        /// bounds の前面左上の座標。
        /// </returns>
        public static Vector3 GetFrontTopLeftPoint(this Bounds bounds)
        {
            return new Vector3()
            {
                x = bounds.center.x - (bounds.size.x / 2f),
                y = bounds.center.y + (bounds.size.y / 2f),
                z = bounds.center.z - (bounds.size.z / 2f),
            };
        }

        /// <summary>
        /// Bounds の前面右上の座標を算出して取得します。
        /// </summary>
        /// <param name="bounds">
        /// 前面右上の座標を取得する Bounds.
        /// </param>
        /// <returns>
        /// bounds の前面右上の座標。
        /// </returns>
        public static Vector3 GetFrontTopRightPoint(this Bounds bounds)
        {
            return new Vector3()
            {
                x = bounds.center.x + (bounds.size.x / 2f),
                y = bounds.center.y + (bounds.size.y / 2f),
                z = bounds.center.z - (bounds.size.z / 2f),
            };
        }

        /// <summary>
        /// Bounds の前面左下の座標を算出して取得します。
        /// </summary>
        /// <param name="bounds">
        /// 前面左下の座標を取得する Bounds.
        /// </param>
        /// <returns>
        /// bounds の前面左下の座標。
        /// </returns>
        public static Vector3 GetFrontBottomLeftPoint(this Bounds bounds)
        {
            return new Vector3()
            {
                x = bounds.center.x - (bounds.size.x / 2f),
                y = bounds.center.y - (bounds.size.y / 2f),
                z = bounds.center.z - (bounds.size.z / 2f),
            };
        }

        /// <summary>
        /// Bounds の前面右下の座標を算出して取得します。
        /// </summary>
        /// <param name="bounds">
        /// 前面右下の座標を取得する Bounds.
        /// </param>
        /// <returns>
        /// bounds の前面右下の座標。
        /// </returns>
        public static Vector3 GetFrontBottomRightPoint(this Bounds bounds)
        {
            return new Vector3()
            {
                x = bounds.center.x + (bounds.size.x / 2f),
                y = bounds.center.y - (bounds.size.y / 2f),
                z = bounds.center.z - (bounds.size.z / 2f),
            };
        }

        /// <summary>
        /// Bounds の背面左上の座標を算出して取得します。
        /// </summary>
        /// <param name="bounds">
        /// 背面左上の座標を取得する Bounds.
        /// </param>
        /// <returns>
        /// bounds の背面左上の座標。
        /// </returns>
        public static Vector3 GetBackTopLeftPoint(this Bounds bounds)
        {
            return new Vector3()
            {
                x = bounds.center.x - (bounds.size.x / 2f),
                y = bounds.center.y + (bounds.size.y / 2f),
                z = bounds.center.z + (bounds.size.z / 2f),
            };
        }

        /// <summary>
        /// Bounds の背面右上の座標を算出して取得します。
        /// </summary>
        /// <param name="bounds">
        /// 背面右上の座標を取得する Bounds.
        /// </param>
        /// <returns>
        /// bounds の背面右上の座標。
        /// </returns>
        public static Vector3 GetBackTopRightPoint(this Bounds bounds)
        {
            return new Vector3()
            {
                x = bounds.center.x + (bounds.size.x / 2f),
                y = bounds.center.y + (bounds.size.y / 2f),
                z = bounds.center.z + (bounds.size.z / 2f),
            };
        }

        /// <summary>
        /// Bounds の背面左下の座標を算出して取得します。
        /// </summary>
        /// <param name="bounds">
        /// 背面左下の座標を取得する Bounds.
        /// </param>
        /// <returns>
        /// bounds の背面左下の座標。
        /// </returns>
        public static Vector3 GetBackBottomLeftPoint(this Bounds bounds)
        {
            return new Vector3()
            {
                x = bounds.center.x - (bounds.size.x / 2f),
                y = bounds.center.y - (bounds.size.y / 2f),
                z = bounds.center.z + (bounds.size.z / 2f),
            };
        }

        /// <summary>
        /// Bounds の背面右下の座標を算出して取得します。
        /// </summary>
        /// <param name="bounds">
        /// 背面右下の座標を取得する Bounds.
        /// </param>
        /// <returns>
        /// bounds の背面右下の座標。
        /// </returns>
        public static Vector3 GetBackBottomRightPoint(this Bounds bounds)
        {
            return new Vector3()
            {
                x = bounds.center.x + (bounds.size.x / 2f),
                y = bounds.center.y - (bounds.size.y / 2f),
                z = bounds.center.z + (bounds.size.z / 2f),
            };
        }

        #endregion Extension
    }
}