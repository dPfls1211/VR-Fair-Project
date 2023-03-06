using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coun : MonoBehaviour
{
    public GameObject counplane,xbtn,_manager, counsObj, collision,counsUI,Users;
    public Transform User;
    public int _xPos = 45;
    // Start is called before the first frame update
    void Start()
    {
        _xPos = 45;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void couns()
    {
        
        //매니저 찾기
        GameObject [] _managers = GameObject.FindGameObjectsWithTag("USER");
        for (int i = 0; i < _managers.Length; i++) {
            if (_managers[i].transform.GetComponent<UserMovement>().password == collision.GetComponent<boothCheckCollision>().manager) //cube
            {
                _manager = _managers[i].transform.GetComponent<GameObject>();
                counplane=counsUI.GetComponent<GameObject>(); //canvas
                counplane.SetActive(true);
            }
        }
        //User찾기
        User=gameObject.transform.parent.parent.parent.GetComponent<Transform>();
        //수락버튼 나타나기.
        Debug.Log(User.name);
        
    }
    public void counsfalse()
    {
        counplane.SetActive(false);
    }
    public void counsMove()
    {
        counplane.SetActive(false);
        //예스버튼 누르면 이동...
        _xPos += 25;
        //상담방 생성
        Instantiate(counsObj, new Vector3(_xPos, 0, 15),Quaternion.identity);
        //유저이동
        Users.transform.position= new Vector3(_xPos, 2, 15);
        //매니저이동
        _manager.transform.position = new Vector3(_xPos, 2, 10);
        
    }
}
