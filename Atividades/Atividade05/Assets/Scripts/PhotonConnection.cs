using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Runtime;
PhotonNetwork.ConnectUsingSettings

public class PhotonConnection : MonoBehaviourPunCallbacks
{

    public string gameVersion = "0.0.1";
    public string nickname = "Player";

    
    void Start()
    {
        Debug.Log("Conectando ao servidor...", this);

        PhotonNetwork.GameVersion = gameVersion;
        PhotonNetwork.NickName = nickName + Random.Range(0, 9999);

        
}

    public override void OnConnectedToMaster()
    {
        Debug.Log("Conectado!", this);

        if (PhotonNetwork.CountOfRooms == 0)
        {
            PhotonNetwork.JoinRoom(roomName);
        }
        else
        {
            RoomOptions options = new RoomOptions();
            options.MaxPlayers = 4;
            PhotonNetwork.JoinOrCreateRoom(roomName, options, TypedLobby.Default);
        }

    }
    public override void OnDisconnected(Photon.Realtime.DisconnectCause cause)
{
    Debug.Log("Desconectado!");
}


void Update()
    {
        
    }
}
