using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ColorChange : MonoBehaviour
{
    public static string renk = "black";
    public Camera camera1;
    
    public GameObject[] BackGround;

    public GameObject[] Buttonss;

    public GameObject[] Text;

    public GameObject[] TextLevel;


    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetString("renk").CompareTo("blue") == 0)
        {
            camera1.backgroundColor = new Color32(0, 6, 118, 0);


            for (int i = 0; i < BackGround.Length; i++)
            {
                BackGround[i].GetComponent<Image>().color = new Color32(0, 196, 255, 255);
            }
            for (int i = 0; i < Buttonss.Length; i++)
            {
                Buttonss[i].GetComponent<Image>().color = new Color32(0, 20, 255, 255);
            }
            if (Text != null)
            {
                for (int i = 0; i < Text.Length; i++)
                {
                    Text[i].GetComponent<Text>().color = new Color32(0, 20, 255, 255);
                }
            }
            if (TextLevel != null)
            {
                for (int i = 0; i < TextLevel.Length; i++)
                {
                    TextLevel[i].GetComponent<Text>().color = new Color32(0, 196, 255, 255);
                }
            }

        }

        else if (PlayerPrefs.GetString("renk").CompareTo("red") == 0)
        {

            camera1.backgroundColor = new Color32(82, 3, 0, 0);


            for (int i = 0; i < BackGround.Length; i++)
            {
                BackGround[i].GetComponent<Image>().color = new Color32(207, 4, 0, 255);
            }
            for (int i = 0; i < Buttonss.Length; i++)
            {
                Buttonss[i].GetComponent<Image>().color = new Color32(56, 0, 0, 197);
            }
            if (Text != null)
            {
                for (int i = 0; i < Text.Length; i++)
                {
                    Text[i].GetComponent<Text>().color = new Color32(56, 0, 0, 197);
                }
            }
            if (TextLevel != null)
            {
                for (int i = 0; i < TextLevel.Length; i++)
                {
                    TextLevel[i].GetComponent<Text>().color = new Color32(207, 4, 0, 255);
                }
            }
        }
        else 
        {

            camera1.backgroundColor = new Color32(0, 0, 0, 0);


            for (int i = 0; i < BackGround.Length; i++)
            {
                BackGround[i].GetComponent<Image>().color = new Color32(164, 164, 164, 255);
            }

            for (int i = 0; i < Buttonss.Length; i++)
            {
                Buttonss[i].GetComponent<Image>().color = new Color32(0, 0, 0, 255);
            }
            if (Text != null)
            {
                for (int i = 0; i < Text.Length; i++)
                {
                    Text[i].GetComponent<Text>().color = new Color32(0, 0, 0, 255);
                }
            }
            if (TextLevel != null)
            {
                for (int i = 0; i < TextLevel.Length; i++)
                {
                    TextLevel[i].GetComponent<Text>().color = new Color32(67, 67, 67, 255);
                }
            }
        }
        

    }


}

