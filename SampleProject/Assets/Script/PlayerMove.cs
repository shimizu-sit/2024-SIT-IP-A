using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // float型でspeed変数を定義し「15」を代入
    public float speed = 15f;

    void FixedUpdate()
    {
        // キー入力の取得と速度の計算
        var velox = speed * Input.GetAxisRaw("Horizontal");

        // Righdbodyコンポーネントを取得して速度を設定
        GetComponent<Rigidbody>().velocity = new Vector3(velox, 0f, 0f);
    }
}
