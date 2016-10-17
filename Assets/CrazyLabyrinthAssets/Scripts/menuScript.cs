using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuScript : MonoBehaviour {

    //Reference: https://www.youtube.com/watch?v=pT4uca2bSgc

    public Canvas quitMenu;
    public Button playText;
    public Button quitText;

	// Use this for initialization
	void Start () {
        quitMenu = quitMenu.GetComponent<Canvas>();
        playText = playText.GetComponent<Button>();
        quitText = quitText.GetComponent<Button>();
        quitMenu.enabled = false;


	}

    // if the user want to exit the game
    // it will bring up the do you want to quit
    public void ExitPress()
    {
        quitMenu.enabled = true;
        playText.enabled = false;
        quitMenu.enabled = false;
    }

    // if the user does not want to Quit and selects no
    public void noPress()
    {
        quitMenu.enabled = false;
        playText.enabled = true;
        quitMenu.enabled = true;
    }
    public void StartLevel()
    {
        Application.LoadLevel(1);
    }

    public void quitGame()
    {
        Application.Quit();
    }


    // Update is called once per frame
    void Update () {
		
	}
}
