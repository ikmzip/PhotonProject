using UnityEngine;
using Photon.Pun;

/**
 * PhotonNetwork�Ő������A�e�N���C�A���g�œ������������I�u�W�F�N�g�ɂ�Photon View�R���|�[�l���g��K���ǉ�����
 * ���W��Photon Transform View�A����������Photon Rigidbody View�ƁA�p�r�ɍ��킹�ăR���|�[�l���g��ǉ�����
 * ����͊ȒP�ɍ��W�����𓯊������邽�߁APhoton View��Photon Transform View������
 */
[RequireComponent(typeof(PhotonView), typeof(PhotonTransformView))]
public class PUNMover : MonoBehaviourPun
{
    [SerializeField]
    private float speed = 5.0f;

    private void Update()
    {
        // ���g�Ő��������I�u�W�F�N�g�ȊO���͂���
        if (!photonView.IsMine) { return; }

        if (Input.GetKey(KeyCode.UpArrow)) { transform.Translate(Vector3.up * speed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.DownArrow)) { transform.Translate(Vector3.down * speed * Time.deltaTime); }

        if (Input.GetKey(KeyCode.RightArrow)) { transform.Translate(Vector3.right * speed * Time.deltaTime); }
        if (Input.GetKey(KeyCode.LeftArrow)) { transform.Translate(Vector3.left * speed * Time.deltaTime); }
    }
}
