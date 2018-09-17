using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    float gameScore;
    float startpos;
    // Use this for initialization
    void Start()
    {
        startpos = player.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        gameScore = (startpos - player.position.z) * (startpos - player.position.z);
        scoreText.text = gameScore.ToString("0");
    }
}