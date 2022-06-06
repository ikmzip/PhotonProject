using UnityEngine;
using Photon.Pun;

public class PUNConnector : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private GameObject prefab;

    private void Start()
    {
        Debug.Log("Photon�ւ̐ڑ����J�n���܂��B");

        // Photon�ɐڑ�����
        PhotonNetwork.ConnectUsingSettings();
    }

    // Photon�ɐڑ�����ƌĂ΂��R�[���o�b�N
    public override void OnConnectedToMaster()
    {
        Debug.Log("Photon�ɐڑ��ł��܂����B");

        // ���r�[�ɓ���
        PhotonNetwork.JoinLobby();
    }

    // ���r�[�ɓ���ƌĂ΂��R�[���o�b�N
    public override void OnJoinedLobby()
    {
        Debug.Log("���r�[�ɓ���܂����B");

        // ���[���ɓ���
        PhotonNetwork.JoinRandomOrCreateRoom();
    }

    // ���[���ɓ���ƌĂ΂��R�[���o�b�N
    public override void OnJoinedRoom()
    {
        Debug.Log("���[���ɓ���܂����B");

        // �v���n�u�𐶐�
        // PhotonNetwork��Instantiate���g�p���Ȃ��Ɠ�������Ȃ�
        PhotonNetwork.Instantiate(prefab.name, Vector3.zero, Quaternion.identity);
    }
}
