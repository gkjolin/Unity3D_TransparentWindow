using UnityEngine;

namespace XJ.Unity3D.Utility
{
    /// <summary>
    /// カーソルの自動非表示をコントロールします。
    /// カーソルが動いているときだけカーソルを表示します。
    /// </summary>
    public class AutoHideCursorController : MonoBehaviour
    {
        #region Field

        /// <summary>
        /// カーソルを常に表示するかどうか。
        /// </summary>
        public bool showAlways = false;

        /// <summary>
        /// カーソルを表示するために必要な移動量。
        /// </summary>
        public float showMoveAmount = 1;

        /// <summary>
        /// 自動で隠す時間(sec)。
        /// </summary>
        public float autoHideTimeSec = 2;

        /// <summary>
        /// 経過した時間(sec)。
        /// </summary>
        private float lastMoveTime;

        /// <summary>
        /// 最後に更新されたマウスの座標。
        /// </summary>
        private Vector3 lastMousePosition;

        #endregion Field

        /// <summary>
        /// 開始時に呼び出されます。
        /// </summary>
        protected virtual void Start()
        {
            this.lastMoveTime = Time.timeSinceLevelLoad;
        }

        /// <summary>
        /// 更新時に呼び出されます。
        /// </summary>
        protected virtual void Update()
        {
            if (this.showAlways)
            {
                Cursor.visible = true;
                return;
            }

            // 入力を取得して移動したかどうかを算出する。

            Vector3 move = Input.mousePosition - this.lastMousePosition;
            this.lastMousePosition = Input.mousePosition;

            // 動いているかどうか判定して、動いていたら時間を更新する。

            if (move.magnitude > this.showMoveAmount)
            {
                this.lastMoveTime = Time.timeSinceLevelLoad;
            }

            // 最後に動いた時間と現在の時間とを比較して、カーソルを隠すべきか判定する。

            Cursor.visible = Time.timeSinceLevelLoad - this.lastMoveTime < this.autoHideTimeSec;
        }
    }
}