using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    public GameObject lastPlatform;
    
    [Header("Префабы платформ")]
    public GameObject oneJumpPlatform;
    public GameObject trampoline;
    public GameObject destroyablePlatform;
    
    [Header("Префабы врагов")]
    public GameObject enemy;
    public GameObject movingEnemy;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform") || collision.gameObject.CompareTag("Enemy"))
        {
            float posX = transform.position.x;
            float posY = lastPlatform.transform.position.y;
            
            collision.gameObject.transform.position = new Vector2(
                Random.Range(posX - 1.2f, posX + 1.2f),
                Random.Range(posY + 1f, posY + 1.2f)
                );
            
            lastPlatform = collision.gameObject;
            //
            int r = Random.Range(1, 100);
            if (r < 30)
            {
                posX = transform.position.x;
                posY = lastPlatform.transform.position.y;
                
                GameObject newPlatform = Instantiate(oneJumpPlatform);

                newPlatform.transform.position = new Vector2(
                    Random.Range(posX - 1.2f, posX + 1.2f),
                    Random.Range(posY + 1f, posY + 1.2f)
                    );
                
                lastPlatform = newPlatform;
            }
            
            r = Random.Range(1, 100);
            if (r < 30)
            {
                posX = transform.position.x;
                posY = lastPlatform.transform.position.y;
                
                GameObject newPlatform = Instantiate(trampoline);

                newPlatform.transform.position = new Vector2(
                    Random.Range(posX - 1.2f, posX + 1.2f),
                    Random.Range(posY + 1f, posY + 1.2f)
                );
                
                lastPlatform = newPlatform;
            }
            r = Random.Range(1, 100);
            if (r < 10)
            {
                posX = transform.position.x;
                posY = lastPlatform.transform.position.y;
                
                GameObject newPlatform = Instantiate(destroyablePlatform);

                newPlatform.transform.position = new Vector2(
                    Random.Range(posX - 1.2f, posX + 1.2f),
                    Random.Range(posY + 0.5f, posY + 0.6f)
                );
                
                lastPlatform = newPlatform;
            }
            r = Random.Range(1, 100);
            if (r < 20)
            {
                posX = transform.position.x;
                posY = lastPlatform.transform.position.y;
                
                GameObject newPlatform = Instantiate(enemy);

                newPlatform.transform.position = new Vector2(
                    Random.Range(posX - 1.2f, posX + 1.2f),
                    Random.Range(posY + 0.5f, posY + 0.6f)
                );
                
                //lastPlatform = newPlatform;
            }
            r = Random.Range(1, 100);
            if (r < 10)
            {
                posX = transform.position.x;
                posY = lastPlatform.transform.position.y;
                
                GameObject newPlatform = Instantiate(movingEnemy);

                newPlatform.transform.position = new Vector2(
                    Random.Range(posX - 1.2f, posX + 1.2f),
                    Random.Range(posY + 0.5f, posY + 0.6f)
                );
                
                //lastPlatform = newPlatform;
            }
        }
    }
}
