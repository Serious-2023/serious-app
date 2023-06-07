using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class ChangeScene : MonoBehaviour
{
    public GameObject clickMeal;
    public GameObject line;
    public TextMeshProUGUI text;

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

    public void paneleatMeal()
    {
        clickMeal.SetActive(false);
        line.SetActive(true);
        text.text = "I'm full!!";
    }
}
