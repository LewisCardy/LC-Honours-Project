using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//The game manager
public class GameManager : MonoBehaviour
{
    //GameObject playerRig;
    private string currentScene;
    private string playerRigName;

    public int keysCollected;

    GameObject playerRigs;
    GameObject playerRig;
    void Start(){
        playerRigs = GameObject.Find("PlayerRigs");
        DontDestroyOnLoad(gameObject);
        ChangePlayerRig();
        DeactivateRigs();
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
            DeactivateRigs();
        }
        if(currentScene == "Credits Scene"){
            GameObject scoreTextObj = GameObject.Find("/UI Wall/Menu Canvas/CreditsMenu/txtNoKeys");
            Debug.Log("HELLO" + scoreTextObj.name);
            //TMPro.TMP_Text scoreText = scoreTextObj.GetComponent<TMPro.TextMeshProUGUI>();
            //scoreText.text = keysCollected.ToString();
        }
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

    public void CollectKey(){
        keysCollected ++;
    }

    public void EndGame(){
        Application.Quit();
    }
}
