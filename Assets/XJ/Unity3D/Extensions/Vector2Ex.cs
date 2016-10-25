using UnityEngine;

namespace XJ.Unity3D.Extensions
{
    /// <summary>
    /// Vector2 型の拡張メソッドやユーティリティメソッドを実装します。
    /// </summary>
    public static class Vector2Ex
    {
        /// <summary>
        /// ランダムな数値を与えたインスタンスを生成します。
        /// </summary>
        /// <param name="min">最小値。</param>
        /// <param name="max">最大値。</param>
        /// <returns>
        /// ランダムな数値を与えられたインスタンス。
        /// </returns>
        public static Vector2 Random(float min, float max)
        {
            return new Vector2()
            {
                x = UnityEngine.Random.Range(min, max),
                y = UnityEngine.Random.Range(min, max)
            };
        }
    }
}