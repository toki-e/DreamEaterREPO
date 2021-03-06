﻿using UnityEngine;
using System.Collections;

public class PickupObject : MonoBehaviour
{
    GameObject mainCamera;
    public bool carrying;
    GameObject carriedObject;
    public float distance;
    public float smooth;

    public GameObject player;
    Vector3 playerPos;
    

    // Use this for initialization
    void Start()
    {
        mainCamera = GameObject.FindWithTag("MainCamera");
      
    }

    // Update is called once per frame
    void Update()
    {

        playerPos = player.transform.position;



        if (carrying)
        {
            carry(carriedObject);
            checkDrop();
            rotateObject();

        }
        else
        {
            pickup();
        }

     
    }

    void rotateObject()
    {
        carriedObject.transform.rotation = Quaternion.identity;
        //carriedObject.transform.Rotate(10, 10, 20);
    }

    void carry(GameObject o)
    {
        o.transform.position = Vector3.Lerp(o.transform.position, mainCamera.transform.position + mainCamera.transform.forward * distance, Time.deltaTime * smooth);
        o.transform.rotation = Quaternion.identity;

        Vector3 posDifference = o.transform.position - playerPos;

        RaycastHit hit;

        if (Physics.SphereCast(playerPos, .05f ,posDifference.normalized, out hit, 100f))
        {
            if(hit.collider.gameObject.tag == "wall")
            {
                  Debug.Log(hit.collider.gameObject.name);

                 Vector3 newDistance = (hit.distance - 0.05f) * posDifference.normalized;
                 o.transform.position = Vector3.Lerp(o.transform.position, mainCamera.transform.position + newDistance, Time.deltaTime * smooth);

            }


        }

        int x = Screen.width / 2;
        int y = Screen.height / 2;

        Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
        

    }

    void pickup()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonUp(0))
        {
            int x = Screen.width / 2;
            int y = Screen.height / 2;

            Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Pickupable p = hit.collider.GetComponent<Pickupable>();

                if (p != null)
                {
                    carrying = true;
                    carriedObject = p.gameObject;
                    //p.gameObject.rigidbody.isKinematic = true;
                    p.gameObject.GetComponent<Rigidbody>().useGravity = false;
                }
            }
        }
    }

    void checkDrop()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonUp(0))
        {
            dropObject();
        }
    }

    void dropObject()
    {
        carrying = false;
        //carriedObject.gameObject.rigidbody.isKinematic = false;
        carriedObject.gameObject.GetComponent<Rigidbody>().useGravity = true;
        carriedObject = null;
    }
}
