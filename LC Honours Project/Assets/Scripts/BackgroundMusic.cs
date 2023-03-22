using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    void Awake(){
        DontDestroyOnLoad(transform.gameObject);//dont destroy background music
    }
}
