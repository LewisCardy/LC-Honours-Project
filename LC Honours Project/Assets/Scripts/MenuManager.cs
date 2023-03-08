using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//The game manager
public class MenuManager : MonoBehaviour
{
    string rigName;
    public GameObject selectMenu;
    public GameObject mainMenu;
    public GameManager gameManager;
    public string defaultRig;

    public GameObject[] playerRigs; //array of the playable rigs in the scene
    public void LoadScene(string sceneName){ //loads a scene based on the name given
        Scene newScene = SceneManager.GetSceneByName(sceneName);
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
        gameManager.SetScene(sceneName);
    }

    public void ShowPlayerModelSelect(){ //shows the player select menu
        selectMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void setPlayerRig(string selectedName){ //sets the current player rig
        rigName = selectedName;
        
    }

    void Update(){
        playerRigHandler();
    }

    void Start(){
        gameManager.SetPlayerRigName(defaultRig);
        gameManager.deactivateRigs();
    }
    public void onStartGame(){
        
    }
    void playerRigHandler(){ //handles the changing of the rigs
        switch (rigName) //switch statement to change the player rig based on the name sent from the select meny
        {
            case "Skeleton Body": //if the skeleton body name was sent then set the new rig equal to that of the skeleton body within the scene so it would be position 0 in the rigs array
                rigName = playerRigs[0].name;
                gameManager.SetPlayerRigName(rigName);
                break;
            case "Skeleton Hands":
                rigName = playerRigs[1].name;
                gameManager.SetPlayerRigName(rigName);
                break;
            case "Mage Body":
                rigName = playerRigs[2].name;
                gameManager.SetPlayerRigName(rigName);
                break;
            case "Mage Hands":
                rigName = playerRigs[3].name;
                gameManager.SetPlayerRigName(rigName);
                break;
            case "Adventurer Body":
                rigName = playerRigs[4].name;
                gameManager.SetPlayerRigName(rigName);
                break;
            case "Adventurer Hands":
                rigName = playerRigs[5].name;
                gameManager.SetPlayerRigName(rigName);
                break;
        }
    }
}
