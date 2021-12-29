using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isGameOver = false;
    public GameObject completeLevelUI;
   public void EndGame(){
       if (isGameOver == false){
           isGameOver = true;
           Debug.Log("Game Over");
           //Waits 2nd param numbe rof seconds until it calls the 1st param function
           Invoke("Restart", 1f);
       }
   }
   public void CompleteLevel()
   {
      completeLevelUI.SetActive(true);
   }
   void Restart(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }
}
