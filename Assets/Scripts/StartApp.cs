using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartApp : MonoBehaviour
{
    public void LoadStartScene(string scene){
        SceneManager.LoadScene(scene);
    }
   public void QuitApp(){
       Application.Quit();
   }
}
