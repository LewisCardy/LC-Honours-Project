using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//The game manager
public class GameManager : MonoBehaviour
{
    //GameObject playerRig;
    string currentScene;
    string playerRigName;

    GameObject playerRigs;
    GameObject playerRig;
    void Start(){
        playerRigs = GameObject.Find("PlayerRigs");
        DontDestroyOnLoad(gameObject);
        ChangePlayerRig();
        deactivateRigs();
    }
    public void SetPlayerRigName(string name){
       playerRigName = name;
    }
    public void SetScene(string scene){
        currentScene = scene;
    }
    void Update(){
        Debug.Log(playerRigName);
        if(playerRigs == null){
            playerRigs = GameObject.Find("PlayerRigs");
            deactivateRigs();
        }
    }

    void ChangePlayerRig(){
        playerRig = GameObject.Find(playerRigName);
    }

    public void deactivateRigs(){
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
}
