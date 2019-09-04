using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttoncontroller : MonoBehaviour
{

    public void ButtonClick(GameObject Player)
    {
        Player.SetActive(!Player.activeSelf);
    }
}
