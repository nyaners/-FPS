using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class LobbyManager : MonoBehaviourPunCallbacks
{
    private void Awake() 
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    
    {
        PhotonNetwork.JoinLobby();
    }


    public override void OnJoinedLobby() 
    {
        Debug.Log($"Connected to Lobby!");
    }
}


