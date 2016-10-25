using UnityEngine;

namespace XJ.Unity3D.Extensions
{
    /// <summary>
    /// Input の拡張メソッドやユーティリティメソッドを実装します。
    /// </summary>
    public static class InputEx
    {
        #region Method

        /// <summary>
        /// キーコンビネーションが入力されたかどうかを判定します。
        /// </summary>
        /// <param name="keys">
        /// キーコンビネーションのキー。ただし最後に指定するキー以外入力順を考慮しません。
        /// </param>
        /// <returns>
        /// 最後のキーが入力されたときに true, それ以外のとき false.
        /// </returns>
        public static bool GetKeyDownCombination(params KeyCode[] keys)
        {
            int keyLength = keys.Length - 1;

            for (int i = 0; i < keyLength; i++)
            {
                if (!Input.GetKey(keys[i]))
                {
                    return false;
                }
            }

            return Input.GetKeyDown(keys[keyLength]);
        }

        #endregion Method
    }
}