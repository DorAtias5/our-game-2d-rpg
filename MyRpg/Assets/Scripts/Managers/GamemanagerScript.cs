using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class GamemanagerScript : MonoBehaviour
{
    public static GamemanagerScript saveGame;

    private void Awake()
    {
        if(saveGame == null)
        {
            saveGame = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this);
    }

    //debug buttons
    /*public void Reset()
    {
        for (int i = 0; i < objects.Count; i++)
        {
            if (File.Exists(Application.persistentDataPath + string.Format("/{0}Object.dat", i)))
            {
                File.Delete(Application.persistentDataPath + string.Format("/{0}Object.dat", i));
            }
        }
    }*/
}
