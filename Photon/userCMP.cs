using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class userCMP : MonoBehaviourPunCallbacks, IPunObservable
{
    public GameObject UserSpawnPos;
    public static userCMP instance
    {
        get
        {
            if(m_istance == null)
            {
                Debug.Log("NULL UserCMP");
                m_istance = FindObjectOfType<userCMP>();
            }
            return m_istance;
        }
    }

    private static userCMP m_istance;

    public GameObject userPrefab;

    //주기적으로 자동 실행되는 동기화 메서드
    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if(stream.IsWriting)
        {
            //네트워크를 통해 값보내기
            //stream.SendNext();
        }
        else
        {

        }
    }
    
    private void Awake()
    {
        if(instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        //생성 위치
        Vector3 SpawnPos = UserSpawnPos.transform.position;


        PhotonNetwork.Instantiate(userPrefab.name, SpawnPos, Quaternion.identity);
        Debug.Log("CreateUser");
        Debug.Log(SpawnPos);
    }

    private void Update()
    {

        //여기서 나가는 키? 버튼? 설정
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PhotonNetwork.LeaveRoom();
        }
    }

    public override void OnLeftRoom()
    {
        SceneManager.LoadScene("LobbyScene");
    }
}
