using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    // float型でbounce変数を宣言し10を代入
    public float bounce = 10f;

    void OnCollisionEnter(Collision other)
    {
        // 衝突したオブジェクトのRigidbodyに力を加える
        // x軸方向には0の力を，Y軸方向にはbounce/6の力を，z軸方向にはbounceの力を与える
        // 力は瞬間的に与えるのでForceModeをImpulseに設定
        other.rigidbody.AddForce(0f, bounce / 6, bounce, ForceMode.Impulse);
    }
}
