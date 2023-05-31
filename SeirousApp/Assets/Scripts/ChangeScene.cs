using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public void ToMain1()
    {
        SceneManager.LoadScene("main 1");
    }

    public void ToMain2()
    {
        SceneManager.LoadScene("main 2");
    }

}
