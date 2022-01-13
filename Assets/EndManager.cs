using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndManager : MonoBehaviour
{
   public void QuitGame()
    {
        Application.Quit(); //quits the game
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            QuitGame();
        }
    }
}
