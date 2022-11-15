using System.Collections;
using System.Collections.Generic;
using Photon.Realtime;
using UnityEngine;

public class RoomListing : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI _text;

    public void SetRoomInfo(RoomInfo roomInfo)
    {
        _text.text = roomInfo.MaxPlayers + " " + roomInfo.Name;
    }

}
