using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    private Image Friend_img;
    private Image Main_img;


    public GameObject Main;
    public GameObject Friend;

    public GameObject Dialogue1;
    public GameObject Dialogue2;
    public GameObject Dialogue3;
    public GameObject Dialogue3_2;
    public GameObject Option;

    public void Awake()
    {
        Friend_img = Friend.GetComponent<Image>();
        Main_img = Main.GetComponent<Image>();
    }

    public void nextToDialogue2()
    {
        Dialogue2.SetActive(true);

        Friend_img.color = new Color(0.6f, 0.6f, 0.6f);
        Main_img.color = new Color(1, 1, 1);
    }

    public void PopUpOption()
    {
        Option.SetActive(true);
    }

    public void nextToDialogue3()
    {
        Dialogue3.SetActive(true);
        Option.SetActive(false);
        Main.SetActive(false);
    }

    public void nextToDialogue3_2()
    {
        Dialogue3_2.SetActive(true);
        Option.SetActive(false);
        
    }
}
