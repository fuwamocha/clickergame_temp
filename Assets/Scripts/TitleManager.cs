using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
   public void ToMain()
    {
        SceneManager.LoadScene("Main");
    }
}
