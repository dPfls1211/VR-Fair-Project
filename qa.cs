using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class qa : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject qacanvas, acanvas, AXbtn;
    GameObject[] question;
    GameObject[] ans;
    
    string path;
    int i = 0;
    void Start()
    {
       
        
        path = @"Assets\Q.txt";
    }
    public void onclick()
    {
        qacanvas.SetActive(true);
        readq();
    }
    public void xbutton()
    {
        qacanvas.SetActive(false);
    }
    public void anserXbutton()
    {
        acanvas.SetActive(false);
    }
    public void answeron()
    {
        acanvas.SetActive(true);

        reada();
    }
    public void readq()
    {
        i = 0;
        question = GameObject.FindGameObjectsWithTag("question");
        if (File.Exists((path)))
        {
            string textvalue = System.IO.File.ReadAllText(path);
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                question[i].GetComponent<Text>().text = line;
              //  Debug.Log(line);
                i++;
            }
        }
        else
        {
            Debug.Log("파일 없음");
        }
    }
   public void reada()
    {
        int j = 0;
        string[] a = new string[5];
        string name;
        GameObject pa;
        ans = GameObject.FindGameObjectsWithTag("answer");
        path = @"Assets\A.txt";
        if (File.Exists((path)))
        {
            string textvalue = System.IO.File.ReadAllText(path);
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                //ans[j].GetComponent<Text>().text = line;
                a[j] = line;
                //Debug.Log(a[j]);
                j++;
            }
            pa = ans[0].transform.parent.gameObject;
            pa = pa.transform.parent.gameObject;
            name = pa.name.Substring(1);
            Debug.Log(a[int.Parse(name)]);
            ans[0].GetComponent<Text>().text = a[int.Parse(name)-1];
        }
        else
        {
            Debug.Log("파일 없음");
        }
    }

}
