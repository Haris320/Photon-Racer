using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System;

public class Players : MonoBehaviour
{
    public GameObject camera;
    GameObject cam;
    PhotonView view;
    // Vector3(-3,69.1999969,34.2000008)
    void Start()
    {
        view = GetComponent<PhotonView>();
        //cam = Instantiate(camera, new Vector3(transform.position.x, transform.position.y + 4, transform.position.z - 10));
        //camera.transform.position = new Vector3(transform.position.x,transform.position.y+4,transform.position.z-10);
    }


    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            if (Input.GetKey(KeyCode.W))
               transform.Translate(Vector3.forward * Time.deltaTime * 10);
            if (Input.GetKey(KeyCode.S))
                transform.Translate(Vector3.back * Time.deltaTime * 10);
            if (Input.GetKey(KeyCode.D))
            {
                Vector3 temp = transform.rotation.eulerAngles;
                temp.y = 45f;
                transform.rotation = Quaternion.Euler(temp);
            }
            if (Input.GetKey(KeyCode.A))
            {
                Vector3 temp = transform.rotation.eulerAngles;
                temp.y = -45f;
                transform.rotation = Quaternion.Euler(temp);

            }

            if (!Input.anyKey)
            {
                Vector3 temp = transform.rotation.eulerAngles;
                temp.y = 0;
                temp.x = 0;
                temp.z = 0;
                transform.rotation = Quaternion.Euler(temp);

            }
        }

        
    }
}
