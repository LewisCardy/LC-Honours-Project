using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//The game manager
public class GameManagerCopy : MonoBehaviour
{
    GameObject playerRig; //the avatar
    string rigName;
    public GameObject defaultPlayerRig;
    public GameObject selectMenu;
    public GameObject mainMenu;

    public GameObject[] playerRigs; //array of the playable rigs in the scene
    public void LoadScene(string sceneName){ //loads a scene based on the name given
        Scene newScene = SceneManager.GetSceneByName(sceneName);
        SceneManager.LoadScene(sceneName);
    }

    public void ShowPlayerModelSelect(){ //shows the player select menu
        selectMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void setPlayerRig(string selectedName){ //sets the current player rig
        rigName = selectedName;
    }

    void Start(){ //defaults the player rig
        playerRig = defaultPlayerRig;
        Debug.Log(playerRig);
        GameObject startRig = GameObject.Find(playerRig.name);
        startRig.SetActive(true);
        rigName = playerRig.name;
    }
    void Update(){
        playerRigHandler(); //handles the changing od player rigs
        //playerRig.SetActive(true);
        Debug.Log(rigName);
    }

    void setNewRig(){ //sets a new rig for the player
        GameObject newRig = GameObject.Find(rigName);
        playerRig = newRig;
    }

    public void StartGame(){
        setNewRig();
        playerRig.SetActive(true);
    }

    void playerRigHandler(){ //handles the changing of the rigs
        switch (rigName) //switch statement to change the player rig based on the name sent from the select meny
        {
            case "Skeleton Body": //if the skeleton body name was sent then set the new rig equal to that of the skeleton body within the scene so it would be position 0 in the rigs array
                rigName = playerRigs[0].name;
                break;
            case "Skeleton Hands":
                rigName = playerRigs[1].name;
                break;
            case "Mage Body":
                rigName = playerRigs[2].name;
                break;
            case "Mage Hands":
                rigName = playerRigs[3].name;
                break;
            case "Adventurer Body":
                rigName = playerRigs[4].name;
                break;
            case "Adventurer Hands":
                rigName = playerRigs[5].name;
                break;
        }
    }
}
