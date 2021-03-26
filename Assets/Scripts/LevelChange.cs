using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelChange : MonoBehaviour
{
    public string levelToLoad;

    public void ApplicationLoadLevel()
    {
        Application.LoadLevel(levelToLoad);
    }
}