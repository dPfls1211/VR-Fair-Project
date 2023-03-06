using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using UnityEngine.Video;
using TMPro;

public class boothCheckCollision : MonoBehaviour
{
    public bool playerCollisionCheck = false;
    public string boothNumber = "";               //발판의 부모 객체 이름(구별)
    public GameObject boothcanvas, firstcanvas;
    public VideoPlayer vi;
    public Text t;
    public string manager=""; //매니저암호
    GameObject floorParent;
    GameObject textParent,parent;
    GameObject[] text;

    string boothNameCollision, path;

    private void Start()
    {
        text = GameObject.FindGameObjectsWithTag("text");
        vi.Pause();
    }
    void OnTriggerEnter(Collider other)
    {


        path = @"Assets\"; //각자 컴터폴더위치로 바꾸기
        if (other.transform.tag == "floor")
        {
            playerCollisionCheck = true;
            //floorParent = other.transform.parent.gameObject;
            //textParent = floorParent.transform.GetChild(10).GetComponent<GameObject>();
            //boothNameCollision = textParent.transform.GetChild(0).GetComponent<Text>().text.ToString(); //Error발생.ㅎ canvas의 부스 name읽어오기
            boothNumber = other.transform.parent.name; //부모객체 이름 읽어오기
            parent = other.transform.parent.gameObject;

            if (playerCollisionCheck == true)
            {
               
                
                ontext();
            }

        }

    }
    void ontext()
    {
        if (File.Exists((path + boothNumber.ToString() + ".txt")))
        {
            boothcanvas.SetActive(true);
            firstcanvas.SetActive(false);
            Debug.Log("파일이 존재합니다.");
            string textvalue = System.IO.File.ReadAllText(path + boothNumber.ToString() + ".txt");
            string textvalue2 = System.IO.File.ReadAllText(path + boothNumber.ToString() + "manager.txt");
            StreamReader sr = new StreamReader(path + boothNumber.ToString() + "manager.txt");
            string line;
            line = sr.ReadLine();
            manager = line;

            StreamReader st = new StreamReader(path + boothNumber.ToString() + ".txt");
            string line2;
            string result = "";
            line2 = st.ReadLine();
            GameObject p= parent.transform.Find("Canvas").gameObject;
            GameObject pchild = p.transform.Find("Text (TMP)").gameObject;
            TextMeshProUGUI tex = pchild.GetComponent<TextMeshProUGUI>();
            Debug.Log(tex);
            tex.text = line2.ToString();
            while ((line2 = st.ReadLine()) != null)
            {
                result += line2;
                result += "\n";
            }
            //t = text[0].GetComponent<Text>();
            t.text = result;
            Debug.Log(result);
            st.Close();

            playerCollisionCheck = false;
        }
        else
        {
            Debug.Log("존재하지 않음");
        }

       
    }

    void OnTriggerExit(Collider other)
    {
        playerCollisionCheck = false;
    }
}
