using UnityEngine;
using Photon.Pun;

/**
 * PhotonNetworkで生成し、各クライアントで同期させたいオブジェクトにはPhoton Viewコンポーネントを必ず追加する
 * 座標はPhoton Transform View、物理挙動はPhoton Rigidbody Viewと、用途に合わせてコンポーネントを追加する
 * 今回は簡単に座標だけを同期させるため、Photon ViewとPhoton Transform Viewをつける
 */
[RequireComponent(typeof(PhotonView), typeof(PhotonTransformView))]
public class PUNMover : MonoBehaviourPun
{
    [SerializeField]
    private float speed = 5.0f;

    private void Update()
    {
        // 自身で生成したオブジェクト以外をはじく
        if (!photonView.IsMine) { return; }

        if (Input.GetKey(KeyCode.UpArrow)) { transform.Translate(Vector3.up * speed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.DownArrow)) { transform.Translate(Vector3.down * speed * Time.deltaTime); }

        if (Input.GetKey(KeyCode.RightArrow)) { transform.Translate(Vector3.right * speed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.LeftArrow)) { transform.Translate(Vector3.left * speed * Time.deltaTime); }
    }
}
