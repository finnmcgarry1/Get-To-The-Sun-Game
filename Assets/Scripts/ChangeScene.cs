using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int index;
    public string LevelName;

    void OnCollisionEnter2D(Collision2D other){
        
        if(other.collider.tag == "Player"){
            FindObjectOfType<AudioManager>().Play("Portal");
            GameScore.setLevelScore();
            //Load levels by index
            SceneManager.LoadScene(index);

            //Load levels by LevelName
            SceneManager.LoadScene(LevelName);

        }
    }
}
