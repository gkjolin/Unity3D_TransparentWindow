using UnityEngine;

namespace XJ.Unity3D.Utility.ObjectController
{
    /// <summary>
    /// 球の中をランダムに移動させます。
    /// </summary>
    public class RandomWalkInSphere : MonoBehaviour
    {
        #region Field

        /// <summary>
        /// 移動範囲の半径。
        /// </summary>
        public float movingRangeRadius = 5;

        /// <summary>
        /// 移動速度。
        /// </summary>
        public float moveSpeed = 5;

        /// <summary>
        /// 移動先。
        /// </summary>
        private Vector3 targetPosition;

        #endregion Field

        #region Method

        /// <summary>
        /// 更新の度に呼び出されます。
        /// </summary>
        protected virtual void Update()
        {
            this.transform.position
            = Vector3.MoveTowards(this.transform.position,
                                  this.targetPosition,
                                  Time.deltaTime * this.moveSpeed);

            if (this.transform.position == this.targetPosition)
            {
                UpdateTargetPosition();
            }
        }

        /// <summary>
        /// 進行方向を決定します。
        /// </summary>
        private void UpdateTargetPosition()
        {
            this.targetPosition = Random.onUnitSphere * this.movingRangeRadius;
        }

        #endregion Method
    }
}