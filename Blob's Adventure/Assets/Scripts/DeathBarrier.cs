using UnityEngine.SceneManagement;
using UnityEngine;


public class DeathBarrier : MonoBehaviour
{

    AudioSource Death;

    void Awake(){
        Death = GetComponent<AudioSource>();    
    }

    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Player")){
            Death.Play();
        }

        if (collision.gameObject.CompareTag("Player")){
                int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentSceneIndex);
            }
    }
}
