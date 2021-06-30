using UnityEngine;
using System.Collections;
public class Teleport : MonoBehaviour
{
    public bool restart = false;
    public string levelToLoad = "nameOfLevelToLoad";
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (restart)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
            else
            {
                Application.LoadLevel(levelToLoad);
            }
        }
    }
}