using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    //LifeManager object
    //public LifeManager lifeSystem;

    public GameObject completeLevelUI;
    public void Completelevel()
    {
        //Debug.Log("LEVEL WON!");
        completeLevelUI.SetActive(true);
    }


    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");

            //Take Life function
            //FindObjectOfType<LifeManager>().TakeLife();

            // Restart game            
            /*Invoke("Restart", restartDelay);*/
        }
    }

   /* void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }*/
}
