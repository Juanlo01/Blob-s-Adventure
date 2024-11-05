using UnityEngine.SceneManagement;
using UnityEngine;


public class DeathSound : MonoBehaviour
{

    AudioSource Death;

    void Awake(){
        Death = GetComponent<AudioSource>();    
    }

    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Player")){
            Death.Play();
            Destroy(gameObject,1f);
        }
    }
}