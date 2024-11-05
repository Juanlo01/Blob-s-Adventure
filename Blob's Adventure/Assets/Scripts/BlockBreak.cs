using System.Threading;
using UnityEngine;

public class BlockBreak : MonoBehaviour{

    private PlayerMovement movement;
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Player")){
                
                Destroy(gameObject, .5f);
        }
    }
    
}
