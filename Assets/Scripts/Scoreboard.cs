using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    // Start is called before the first frame update
    private Text textScript;
    void Start()
    {
        textScript = this.GetComponent<Text>();
        EventManager.StartListening("ScoreUpdate", OnScoreUpdate);
    }

    private void OnScoreUpdate(int score)
    {
        textScript.text = "Score: " + score;
    }

}
