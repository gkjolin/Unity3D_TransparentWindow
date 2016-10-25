using UnityEngine;

namespace XJ.Unity3D.Utility.ObjectController
{
    /// <summary>
    /// 指定した座標を順にめぐるように GameObject を動かします。
    /// </summary>
    public class CheckPointWalker : MonoBehaviour
    {
        #region Field

        /// <summary>
        /// Gizmo を描画するかどうか。
        /// </summary>
        public bool drawGizmos = true;

        /// <summary>
        /// Gizmo の色。
        /// </summary>
        public Color gizmosColor = Color.green;

        /// <summary>
        /// Gizmo の大きさ。
        /// </summary>
        public float gizmoSize = 0.3f;

        /// <summary>
        /// 移動速度。
        /// </summary>
        public float moveSpeed = 1;

        /// <summary>
        /// GameObject が通過するチェックポイント。
        /// </summary>
        public Vector3[] checkPoints;

        /// <summary>
        /// 現在のチェックポイントを示すインデックス。
        /// </summary>
        public int checkPointIndex = 0;

        #endregion Filed

        protected virtual void Start()
        {
            if (this.checkPointIndex >= this.checkPoints.Length)
            {
                this.checkPointIndex = this.checkPointIndex % this.checkPoints.Length;
            }

            base.transform.position = this.checkPoints[this.checkPointIndex];
        }

        protected virtual void Update()
        {
            if (this.checkPoints == null)
            {
                return;
            }

            if (this.checkPointIndex >= this.checkPoints.Length)
            {
                this.checkPointIndex = this.checkPointIndex % this.checkPoints.Length;
            }

            Vector3 checkPoint = this.checkPoints[this.checkPointIndex];

            this.transform.position = Vector3.MoveTowards
                (this.transform.position, checkPoint, Time.deltaTime * this.moveSpeed);

            if (this.transform.position == checkPoint)
            {
                this.checkPointIndex = this.checkPointIndex + 1;
            }
        }

        protected virtual void OnDrawGizmos()
        {
            if (!this.drawGizmos)
            {
                return;
            }

            Gizmos.color = this.gizmosColor;

            foreach (Vector3 checkPoint in this.checkPoints)
            {
                Gizmos.DrawSphere(checkPoint, this.gizmoSize);
            }

            if (this.checkPointIndex >= this.checkPoints.Length)
            {
                return;
            }

            Gizmos.DrawLine(base.transform.position,
                           (this.checkPoints[this.checkPointIndex] + base.transform.position) / 2f);
        }
    }
}