using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class HUD : MonoBehaviour
{
	public static HUD instance;
	public Text timer;
	public Text score;
    public Text round;
    public Text currentNumber;

    public GameObject gameoverUI;
    public List<Text> playerListResult;
    public Text restartText;

	void Awake()
	{
		instance = this;
		timer = timer.GetComponent<Text>();
	    score = score.GetComponent<Text>();
        foreach (Transform t in gameoverUI.transform.GetChild(1))
        {
            playerListResult.Add(t.GetComponent<Text>());
        }
        restartText = gameoverUI.transform.GetChild(2).GetComponent<Text>();
	}

	public void SetTimer (string val)
	{
		timer.text = val;
	}

	public void SetScore (string val)
	{
		score.text = val;
	}

	public void UpdateTimer (float val)
	{
		timer.text = "" + val.ToString("f0");
	}

	public void UpdateScore (float val)
	{
		score.text = "" + val.ToString("f0");
	}

    public void UpdateRound (float val)
    {
        round.text = "" + val.ToString("f0");
    }

    public void UpdateCurrentNumber (float val)
    {
        currentNumber.text = "" + val.ToString("f0");
    }

    public void UpdatePlayerResult(int i, int score)
    {
        playerListResult[i].text = i.ToString()+" Player : "+score.ToString();
    }

    public void UpdateRestartText(float value)
    {
        restartText.text = "Restart in " + value.ToString("f0") + " seconds";
    }


}
