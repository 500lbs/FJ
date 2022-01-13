using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BugCounter : MonoBehaviour
{
    public int bugCounter = 0;
    public TMP_Text bugCounterText;
    public PlayerMovement playerRef;
    void Start()
    {
        playerRef = FindObjectOfType<PlayerMovement>();
        bugCounter = playerRef.bugCounter;

    }

    void Update()
    {
        UpdateBugCounter();
    }
    public void UpdateBugCounter()
    {
        bugCounter = playerRef.bugCounter;

            bugCounterText.text = "Bugs: " + bugCounter + "/5";

            if (bugCounter == 5)
            {
                SceneManager.LoadSceneAsync("EndScene");
            }

    }
}
