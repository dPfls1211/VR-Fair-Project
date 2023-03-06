using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class NetworkManager : MonoBehaviourPunCallbacks
{
    private string gameVersion = "1";

    public Text connectionInfoTexxt;
    public Text AllSHOWTEXT;
    public InputField InputPassword;

    public Image AllSHOWIMAGE;
    public Sprite ChangeImage;

    public Button JoinRoom;
    public Button ConttectRoom;

    
    string[] MangerPassword = { "allshow","booth1","booth2"};
    string JoinRoomSTR;

    private void Start()
    {
        PhotonNetwork.GameVersion = gameVersion;

        PhotonNetwork.ConnectUsingSettings();

        

        connectionInfoTexxt.text = "서버에 접속중...";
    }

    public override void OnConnectedToMaster()
    {
        connectionInfoTexxt.text = "서버에 접속완료";
        ConttectRoom.interactable = true;
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        connectionInfoTexxt.text = "서버에 접속실패";

        PhotonNetwork.ConnectUsingSettings();
    }

    public void ConnectXR()
    {
        ConttectRoom.interactable = true;
        if (PhotonNetwork.IsConnected)
        {
            JoinRoomSTR = "Main";
            AllSHOWTEXT.text = "XR박람회";

            AllSHOWIMAGE.sprite = ChangeImage; //이미지
        }  
    }

    public void ConnectBtn()
    {
        ConttectRoom.interactable = false;
        if (PhotonNetwork.IsConnected)
        {
            if (JoinRoomSTR != "")
            {
                Debug.Log(InputPassword.text);
                if(InputPassword.text != string.Empty)
                {
                   for(int i = 0; i < MangerPassword.Length; ++i)
                    {
                        if(MangerPassword[i] == InputPassword.text)
                        {
                            string nickname = InputPassword.text;
                            PhotonNetwork.NickName = nickname;
                        }
                    }
                }

                PhotonNetwork.JoinRoom(JoinRoomSTR, null);
                
            }
            else
            {
                connectionInfoTexxt.text = "서버에 접속실패";
                PhotonNetwork.ConnectUsingSettings();
            }
        }
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        connectionInfoTexxt.text = "빈방없음 새로운 방 개설";
        PhotonNetwork.CreateRoom(JoinRoomSTR, new RoomOptions { MaxPlayers = 4 });
    }

    public override void OnJoinedRoom()
    {
        connectionInfoTexxt.text = "방 참가 성공";
        PhotonNetwork.LoadLevel(JoinRoomSTR);
    }

}
