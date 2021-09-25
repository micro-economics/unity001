using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
  public void  OnClickStertBotton()
    {
        switch (transform.name)
        {
            case "Button01":
                SceneManager.LoadScene("scene01");
                break;

            case "Button02":
                SceneManager.LoadScene("scene02");
                break;

            case "Button03":
                SceneManager.LoadScene("scene03");
                break;
            case "Buttonre":
                SceneManager.LoadScene("SampleScene");
                break;
        }
       
    }

}