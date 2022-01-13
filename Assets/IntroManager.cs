using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroManager : MonoBehaviour
{
    public GameObject firstScreen;
    public GameObject secondScreen;
    public GameObject thirdScreen;

    public RawImage cursor;
    private RectTransform cursorTransform;
    

    AsyncOperation mainSceneLoad;
    
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;
    
    // void OnMouseEnter()
    // {
    //     Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    // }
    //
    // void OnMouseExit()
    // {
    //     Cursor.SetCursor(null, Vector2.zero, cursorMode);
    // }

    private void Start()
    {
        //Cursor.visible = true;
        cursorTransform = cursor.GetComponent<RectTransform>();
        cursorTransform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
    }
    public void StartGame() //Loads the main scene
    {
        mainSceneLoad = SceneManager.LoadSceneAsync("SarahTestScene");
    }

    public void FirstScreen()
    {

    }
    public void SecondScreen()
    {

    }
    public void ThirdScreen()
    {

    }

    
    public void QuitGame()
    {
        Application.Quit(); //quits the game
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartGame();
        }
    }
}
