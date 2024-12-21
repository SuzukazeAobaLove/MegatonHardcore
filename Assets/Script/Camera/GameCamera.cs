using UnityEngine;

namespace Megaton
{
    /// <summary>
    /// 绑定在摄像机上，通过接口控制相机
    /// </summary>
    public class GameCamera : MonoBehaviour
    {
        public static GameCamera Ins { get; private set; }

        private void Awake()
        {
            Ins = this;
        }

        public void MoveForward(float offset)
        {
            transform.position += new Vector3(0, 0, offset);
        }

    }
}