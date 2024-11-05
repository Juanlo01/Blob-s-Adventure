using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour{
    
    int newGameSceneIndex = 0;

    void Update(){
        RestartGame();
    }

    void RestartGame(){
        if (Input.GetButtonDown("Restart")){
            
            SceneManager.LoadScene(newGameSceneIndex);
        }
    }


    
            
    
}
