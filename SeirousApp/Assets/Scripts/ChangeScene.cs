using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class ChangeScene : MonoBehaviour
{
    public GameObject clickMeal;
    public GameObject line;
    public GameObject shop;
    public GameObject buy;
    public GameObject Calendar;
    public GameObject Chair;
    public GameObject Char_sad;
    public GameObject Char_happy;

    public TextMeshProUGUI text;
    public TextMeshProUGUI coinValue;



    /*public void ToMain1()
    {
        SceneManager.LoadScene("main 1");
    }

    public void ToMain2()
    {
        SceneManager.LoadScene("main 2");
    }*/

    public void panelClickMeal()
    {
        clickMeal.SetActive(true);
    }

    public void panelMealOff()
    {
        clickMeal.SetActive(false);
    }

    public void paneleatMeal()
    {
        clickMeal.SetActive(false);
        line.SetActive(true);
        Char_sad.SetActive(false);
        Char_happy.SetActive(true);
        text.text = "배부르다 ....";
    }

    public void panelShop()
    {
        shop.SetActive(true);
    }

    public void panelShopOff()
    {
        shop.SetActive(false);

    }

    public void panelBuy()
    {
        buy.SetActive(true);
    }

    //buy
    public void panelBuyOff()
    {
        buy.SetActive(false);
        coinValue.text = "89900";

    }

    public void panelBuyOff2()
    {
        buy.SetActive(false);
    }

    public void panelCalendar()
    {
        Calendar.SetActive(true);
    }

    public void panelCalendarOff()
    {
        Calendar.SetActive(false);
    }

    public void panelChair()
    {
        Chair.SetActive(true);
    }
}
