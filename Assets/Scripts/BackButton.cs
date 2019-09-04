using UnityEngine;

public class BackButton : MonoBehaviour
{
    public void ClickBack()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
