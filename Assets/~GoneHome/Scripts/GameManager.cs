using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GoneHome
{
    public class GameManager : MonoBehaviour
    {

        public void NextLevel()
        {
            Scene currentScene = SceneManager.GetActiveScene();         //gets the current active scene
            SceneManager.LoadScene(currentScene.buildIndex + 1);        //Load Next scene inthe build
        }

        public void RestartLevel()
        {
            //gets the current active scene
            //loads the current scene in the build index
            //grab player in the scene
            //reset player
            FollowEnemy[] followEnemies = FindObjectsOfType<FollowEnemy>();
            PatrolEnemy[] patrolEnemies = FindObjectsOfType<PatrolEnemy>();

            foreach (var enemy in followEnemies)
            {
                enemy.Reset();
            }

            Player player = FindObjectOfType<Player>();

            player.Reset();
        }



    }
}
