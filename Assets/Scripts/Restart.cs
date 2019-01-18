using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{

    public void ReloadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }
}
