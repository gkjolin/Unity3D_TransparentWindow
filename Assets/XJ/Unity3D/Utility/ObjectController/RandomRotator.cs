﻿using UnityEngine;

namespace XJ.Unity3D.Utility.ObjectController
{
    /// <summary>
    /// GameObject をランダムに回転させます。
    /// </summary>
    public class RandomRotator : MonoBehaviour
    {
        #region Field

        /// <summary>
        /// 回転速度。
        /// </summary>
        public float rotateSpeed = 100;

        /// <summary>
        /// 次の回転を示すクォータニオン。
        /// </summary>
        private Quaternion targetRotation;

        /// <summary>
        /// 直前の回転を示すクォータニオン。
        /// </summary>
        private Quaternion previousQuaternion;

        #endregion Field

        #region Method

        /// <summary>
        /// 開始時に呼び出されます。
        /// </summary>
        protected virtual void Start()
        {
            this.targetRotation = Random.rotation;
            this.previousQuaternion = base.transform.rotation;
        }

        /// <summary>
        /// 更新の度に呼び出されます。
        /// </summary>
        protected virtual void Update()
        {
            this.previousQuaternion = this.transform.rotation;

            this.transform.rotation
                = Quaternion.RotateTowards(base.transform.rotation,
                                           this.targetRotation,
                                           Time.deltaTime * this.rotateSpeed);

            if (base.transform.rotation == this.previousQuaternion
                || this.transform.rotation == this.targetRotation)
            {
                this.targetRotation = Random.rotation;
            }
       }

        #endregion Method
    }
}