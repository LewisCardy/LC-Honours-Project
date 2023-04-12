using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
//The game manager
public class GameManager : MonoBehaviour
{
    //GameObject playerRig;
    private string currentScene;
    private string playerRigName;
    public InputActionReference screenshotKey;

    public int keysCollected = 0;

    GameObject playerRigs;
    GameObject playerRig;
    void Start(){
        playerRigs = GameObject.Find("PlayerRigs");
        DontDestroyOnLoad(gameObject);
        ChangePlayerRig();
        DeactivateRigs();
    }
    public void LoadScene(string sceneName){ //loads a scene based on the name given
        Scene newScene = SceneManager.GetSceneByName(sceneName);
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
        SetScene(sceneName);
    }
    public void SetPlayerRigName(string name){
       playerRigName = name;
    }
    public void SetScene(string scene){
        currentScene = scene;
    }
    void Update(){
        //Debug.Log(playerRigName);
        if(playerRigs == null){
            playerRigs = GameObject.Find("PlayerRigs");
            DeactivateRigs();
        }

        if(screenshotKey.action.WasPressedThisFrame()){ //screenshot functionality
            ScreenCapture.CaptureScreenshot("Screenshot1.png", 4);
        };
        //Debug.Log("KEYS COLLECTED " + keysCollected);
    }

    void ChangePlayerRig(){
        playerRig = GameObject.Find(playerRigName);
    }

    public void DeactivateRigs(){
        for (int i = 0; i < playerRigs.transform.childCount; i++)
        {
            var childRig = playerRigs.transform.GetChild(i).gameObject;
            if(childRig.name == playerRigName){
                childRig.SetActive(true);
            } else {
                childRig.SetActive(false);
            }
            
        }
    }

    public void CollectKey(){ //adds key to tally
        keysCollected ++;
    }

    public void EndGame(){ //ends the game
        Application.Quit();
    }
}
