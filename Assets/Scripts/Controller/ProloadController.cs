using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class ProloadController : MonoBehaviour
{
    void Awake()
    {
        GameManager.Load();
    }

    //ADMIN LEVEL CONTROLL
    void Update()
    {
        if (Keyboard.current.bKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene(2);
        }

        if (Keyboard.current.nKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene(3);
        }

        if (Keyboard.current.mKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene(4);
        }
    }
}
