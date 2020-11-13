using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonChanger : MonoBehaviour
{
    public void OnClickStartButton1()
    {
        SceneManager.LoadScene("floer1");
    }
    public void OnClickStartButton2()
    {
        SceneManager.LoadScene("floer2");
    }
    public void OnClickStartButton3()
    {
        SceneManager.LoadScene("floer3");
    }
    public void OnClickStartButton4()
    {
        SceneManager.LoadScene("floer4");
    }
    public void OnClickStartButton5()
    {
        SceneManager.LoadScene("floer5");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
