﻿using UnityEngine;
using UnityEngine.Networking;

namespace XJ.Unity3D.Utility.ObjectController.UNET
{
    /// <summary>
    /// キーボードで GameObject を操作します。
    /// </summary>
    public class KeyboardController : NetworkBehaviour
    {
        // 標準的なキー入力は、WASD + RF キーで行います。

        #region Field

        /// <summary>
        /// 移動速度。
        /// </summary>
        public float speed = 1;

        /// <summary>
        /// 水平方向の操作を反転します。
        /// </summary>
        public bool invertX;

        /// <summary>
        /// 垂直方向の操作を反転します。
        /// </summary>
        public bool invertY;

        /// <summary>
        /// 前進方向の操作を反転します。
        /// </summary>
        public bool invertZ;

        /// <summary>
        /// 上方向キー。
        /// </summary>
        public KeyCode[] upKeys = new KeyCode[] { KeyCode.W };

        /// <summary>
        /// 下方向キー。
        /// </summary>
        public KeyCode[] downKeys = new KeyCode[] { KeyCode.S };

        /// <summary>
        /// 左方向キー。
        /// </summary>
        public KeyCode[] leftKeys = new KeyCode[] { KeyCode.A };

        /// <summary>
        /// 右方向キー。
        /// </summary>
        public KeyCode[] rightKeys = new KeyCode[] { KeyCode.D };

        /// <summary>
        /// 前方向キー。
        /// </summary>
        public KeyCode[] forwardKeys = new KeyCode[] { KeyCode.R };

        /// <summary>
        /// 後方向キー。
        /// </summary>
        public KeyCode[] backKeys = new KeyCode[] { KeyCode.F };

        #endregion Field

        void Update()
        {
            // 操作する権限がないときは処理させません。
            // NetworkIdentity.LocalPlayerAuthority によって制御されます。

            if (!base.hasAuthority)
            {
                return;
            }

            CheckUpKeys();
            CheckDownKeys();
            CheckLeftKeys();
            CheckRightKeys();
            CheckForwardKeys();
            CheckBackKeys();
        }

        private void CheckUpKeys()
        {
            foreach (KeyCode key in this.upKeys)
            {
                if (Input.GetKey(key))
                {
                    this.gameObject.transform.position
                        += Vector3.up * this.speed * (this.invertY ? -1 : 1);
                }
            }
        }

        private void CheckDownKeys()
        {
            foreach (KeyCode key in this.downKeys)
            {
                if (Input.GetKey(key))
                {
                    this.gameObject.transform.position
                        += Vector3.down * this.speed * (this.invertY ? -1 : 1);
                }
            }
        }

        private void CheckLeftKeys()
        {
            foreach (KeyCode key in this.leftKeys)
            {
                if (Input.GetKey(key))
                {
                    this.gameObject.transform.position
                        += Vector3.left * this.speed * (this.invertX ? -1 : 1);
                }
            }
        }

        private void CheckRightKeys()
        {
            foreach (KeyCode key in this.rightKeys)
            {
                if (Input.GetKey(key))
                {
                    this.gameObject.transform.position
                        += Vector3.right * this.speed * (this.invertX ? -1 : 1);
                }
            }
        }

        private void CheckForwardKeys()
        {
            foreach (KeyCode key in this.forwardKeys)
            {
                if (Input.GetKey(key))
                {
                    this.gameObject.transform.position
                        += Vector3.forward * this.speed * (this.invertZ ? -1 : 1);
                }
            }
        }

        private void CheckBackKeys()
        {
            foreach (KeyCode key in this.backKeys)
            {
                if (Input.GetKey(key))
                {
                    this.gameObject.transform.position
                        += Vector3.back * this.speed * (this.invertZ ? -1 : 1);
                }
            }
        }
    }
}