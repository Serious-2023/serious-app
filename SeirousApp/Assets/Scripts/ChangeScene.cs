using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class ChangeScene : MonoBehaviour
{
    public GameObject Quest;
    public GameObject SleepQuestText;
    public GameObject WalkQuestText;
    public GameObject FoodQuestText;
    public GameObject CleanQuestText;
    public GameObject QuestPop;

    public GameObject MealLine;
    public GameObject WalkLine;
    public GameObject SleepLine;
    public GameObject CleanLine;
    public GameObject shop;
    public GameObject buy;
    public GameObject Calendar;
    public GameObject Chair;
    public GameObject trash;

    public GameObject Char_sad;
    public GameObject Char_happy;
    public GameObject Char_Sleep;
    public GameObject Char_health;

    public GameObject MainCanvas;
    public GameObject SchoolCanvas;
    public GameObject StartCanvas;

    public TextMeshProUGUI text;
    public TextMeshProUGUI coinValue;

    public int num = 0; // 1: Sleep, 2: Walk, 3: Clean, 4:Meal
    public int count = 0; //수행도 체크

    /*public void ToMain1()
    {
        SceneManager.LoadScene("main 1");
    }

    public void ToMain2()
    {
        SceneManager.LoadScene("main 2");
    }*/

    void Update()
    {
        if(count == 4)
        {
            Invoke("QuestClear", 2.0f);
        }
    }
    
    public void startGame()
    {
        StartCanvas.SetActive(false);
    }

    public void QuestClear()
    {
        MainCanvas.SetActive(false);
        SchoolCanvas.SetActive(true);
    }

    public void panelClickSleep()
    {
        num = 1;
        QuestPop.SetActive(true);
        Quest.SetActive(true);
        SleepQuestText.SetActive(true);
    }

    public void panelClickWalk()
    {
        num = 2;
        QuestPop.SetActive(true);
        Quest.SetActive(true);
        WalkQuestText.SetActive(true);
    }

    public void panelClickClean()
    {
        num = 3;
        QuestPop.SetActive(true);
        Quest.SetActive(true);
        CleanQuestText.SetActive(true);
    }

    public void panelClickMeal()
    {
        num = 4;
        QuestPop.SetActive(true);
        Quest.SetActive(true);
        FoodQuestText.SetActive(true);
    }


    public void panelQuestOff()
    {
        QuestPop.SetActive(false);
        SleepQuestText.SetActive(false);
        WalkQuestText.SetActive(false);
        CleanQuestText.SetActive(false);
        FoodQuestText.SetActive(false);
    }

    
    public void DoQuest()
    {
        QuestPop.SetActive(false);
        SleepQuestText.SetActive(false);
        WalkQuestText.SetActive(false);
        CleanQuestText.SetActive(false);
        FoodQuestText.SetActive(false);


        switch (num)
        {
            case 1://Sleep
                if (SleepLine.activeSelf == false) //반복 방지
                {
                    count += 1;
                }

                SleepLine.SetActive(true);

                Char_sad.SetActive(false);
                Char_health.SetActive(false);
                Char_Sleep.SetActive(true);
                Char_happy.SetActive(false);

                text.text = "개운해!";
                
                break;
            case 2://Walk
                if (WalkLine.activeSelf == false)
                {
                    count += 1;
                }

                WalkLine.SetActive(true);

                Char_sad.SetActive(false);
                Char_health.SetActive(true);
                Char_Sleep.SetActive(false);
                Char_happy.SetActive(false);

                text.text = "상쾌해!";
                
                break;
            case 3://Clean
                if (CleanLine.activeSelf == false)
                {
                    count += 1;
                }

                CleanLine.SetActive(true);

                trash.SetActive(false);
                break;
            case 4://Meal
                if (MealLine.activeSelf == false)
                {
                    count += 1;
                }

                MealLine.SetActive(true);

                Char_sad.SetActive(false);
                Char_health.SetActive(false);
                Char_Sleep.SetActive(false);
                Char_happy.SetActive(true);

                text.text = "배부르다 ....";
                break;
        }
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
