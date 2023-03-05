using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject selectMenu;
    public GameObject mainMenu;
    public void LoadScene(string sceneName){
        Scene newScene = SceneManager.GetSceneByName(sceneName);
        SceneManager.LoadScene(sceneName);
    }

    public void ShowPlayerModelSelect(){
        selectMenu.SetActive(true);
        mainMenu.SetActive(false);
    }
}
