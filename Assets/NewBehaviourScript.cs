using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class NewBehaviourScript : MonoBehaviourPunCallbacks
{
    public Text text;

    void Start()
    {
        //PhotonNetwork.ConnectUsingSettings();
    
    }

    private void FixedUpdate()
    {
        Debug.Log("Joined");
        text.text = "Number of Players: " + PhotonNetwork.CurrentRoom.PlayerCount;

       

        
    }
}
