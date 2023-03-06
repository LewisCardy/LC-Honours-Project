using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//The game manager
public class GameManager : MonoBehaviour
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
        playerRig.SetActive(true);
        rigName = playerRig.name;
    }
    void Update(){
        playerRigHandler(); //handles the changing od player rigs
        //playerRig.SetActive(true);
        Debug.Log(playerRig);
    }

    void setNewRig(GameObject oldRig, GameObject newRig){ //sets a new rig for the player
        oldRig.SetActive(false);
        playerRig = newRig;
        playerRig.SetActive(true);
    }

    void playerRigHandler(){ //handles the changing of the rigs
        switch (rigName) //switch statement to change the player rig based on the name sent from the select meny
        {
            case "Skeleton Body": //if the skeleton body name was sent then set the new rig equal to that of the skeleton body within the scene so it would be position 0 in the rigs array
                setNewRig(playerRig ,playerRigs[0]);
                break;
            case "Skeleton Hands":
                setNewRig(playerRigs[0], playerRigs[1]);
                break;
            case "Mage Body":
                setNewRig(playerRigs[1], playerRigs[2]);
                break;
            case "Mage Hands":
                setNewRig(playerRigs[2], playerRigs[3]);
                break;
            case "Adventurer Body":
                setNewRig(playerRigs[3], playerRigs[4]);
                break;
            case "Adventurer Hands":
                setNewRig(playerRigs[4], playerRigs[5]);
                break;
        }
    }
}
