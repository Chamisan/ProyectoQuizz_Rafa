using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioBehavior : MonoBehaviour
{
    void Start()
    {
        
    }

    public void NextScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
