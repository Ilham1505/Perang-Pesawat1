using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;
using TMPro;

public class CreateRoomMenu : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private TMP_InputField _roomName;
 
    public void OnClick_CreateRoom()
    {
        if(PhotonNetwork.IsConnected)
            return;
        
        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 10;
        PhotonNetwork.JoinOrCreateRoom(_roomName.text ,options, TypedLobby.Default);
    }

    public override void OnCreatedRoom()
    {
        print("Room created successfully");
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        print("Room creation failed: " + message + " " + returnCode);
    }
}
