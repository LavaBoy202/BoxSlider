
using UnityEngine;
//We'll need this for ui components
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score;
    // Update is called once per frame
    void Update()
    {
        //the value in the ToString() allows us to parse the string to terminate decimals
        score.text = player.position.z.ToString("0");
        
    }
}
