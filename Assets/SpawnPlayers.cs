using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject playerPrefab2;
    GameObject a;

    void Start()
    {
        if (PhotonNetwork.CurrentRoom.PlayerCount == 1)
        {
            Vector3 position = new Vector3(-2.6f, 64.69f, 45.5f);
            a = PhotonNetwork.Instantiate(playerPrefab.name, position, Quaternion.identity);
        }

        if (PhotonNetwork.CurrentRoom.PlayerCount == 2)
        {
            Vector3 position = new Vector3(1.9f, 64.69f, 45.5f);
            PhotonNetwork.Instantiate(playerPrefab2.name, position, Quaternion.identity);
        }

        


    }

    


}
