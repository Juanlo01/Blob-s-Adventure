using UnityEngine.SceneManagement;
using UnityEngine;


public class NextLevelTrigger : MonoBehaviour{

    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Player")){
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }

}
