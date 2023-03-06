using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class UserMovement : MonoBehaviourPunCallbacks
{

    public float moveSpeed = 5f;
    public float rotateSpeed = 180f;

    private UserInput userinput;
    private Rigidbody playerRigidbody;

    public string password;

    private void Start()
    {
        userinput = GetComponent<UserInput>();
        playerRigidbody = GetComponent<Rigidbody>();

        if (photonView.IsMine)
        {
            password = photonView.Owner.NickName;
            Debug.Log(password);
        }
    }

    void Update()
    {
        if(!photonView.IsMine)
        {
            return;
        }
    }

    private void FixedUpdate()
    {
        Rotate();
        Move();
        
    }

    private void Move()
    {
        Vector3 moveDistance = userinput.move * transform.forward * moveSpeed * Time.deltaTime;
        playerRigidbody.MovePosition(playerRigidbody.position + moveDistance);

    }

    private void Rotate()
    {
        float trun = userinput.rotate * rotateSpeed * Time.deltaTime;
        playerRigidbody.rotation = playerRigidbody.rotation * Quaternion.Euler(0, trun, 0f);
    }

}
