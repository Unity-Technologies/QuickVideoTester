using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void LoadSceneAt(int i)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(i);
    }
}
