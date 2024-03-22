using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    // float型でbounce変数を宣言し10を代入
    public float bounce = 10f;

    void OnCollisionEnter(Collision other)
    {
        // 衝突したオブジェクトのRigidbodyに力を食わる
        // X軸方向には0の力を，Y軸方向にはbounce/6の力を，Z軸方向にはbounceの力を与える
        // 力は瞬間的に与える（ForceMode.Inpulse）
        other.rigidbody.AddForce(0f, bounce / 6, bounce, ForceMode.Impulse);
    }
}
