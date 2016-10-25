using UnityEngine;

namespace XJ.Unity3D.Extensions
{
    /// <summary>
    /// Vector3 型の拡張メソッドやユーティリティメソッドを実装します。
    /// </summary>
    public static class Vector3Ex
    {
        /// <summary>
        /// ランダムな数値を与えたインスタンスを生成します。
        /// </summary>
        /// <param name="min">最小値。</param>
        /// <param name="max">最大値。</param>
        /// <returns>
        /// ランダムな数値を与えられたインスタンス。
        /// </returns>
        public static Vector3 Random(float min, float max)
        {
            return new Vector3()
            {
                x = UnityEngine.Random.Range(min, max),
                y = UnityEngine.Random.Range(min, max),
                z = UnityEngine.Random.Range(min, max),
            };
        }
    }
}