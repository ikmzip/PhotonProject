using UnityEngine;
using Photon.Pun;

public class PUNConnector : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private GameObject prefab;

    private void Start()
    {
        Debug.Log("Photonへの接続を開始します。");

        // Photonに接続する
        PhotonNetwork.ConnectUsingSettings();
    }

    // Photonに接続すると呼ばれるコールバック
    public override void OnConnectedToMaster()
    {
        Debug.Log("Photonに接続できました。");

        // ロビーに入る
        PhotonNetwork.JoinLobby();
    }

    // ロビーに入ると呼ばれるコールバック
    public override void OnJoinedLobby()
    {
        Debug.Log("ロビーに入りました。");

        // ルームに入る
        PhotonNetwork.JoinRandomOrCreateRoom();
    }

    // ルームに入ると呼ばれるコールバック
    public override void OnJoinedRoom()
    {
        Debug.Log("ルームに入りました。");

        // プレハブを生成
        // PhotonNetworkのInstantiateを使用しないと同期されない
        PhotonNetwork.Instantiate(prefab.name, Vector3.zero, Quaternion.identity);
    }
}
