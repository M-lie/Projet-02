using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class panel_script : MonoBehaviour { 

    public void jouer() { 
        SceneManager.LoadScene("outdoor"); 
    }

    public void quitterPartie() { Application.Quit(); 
    }
}

    // Start is called before the first frame update

