using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class MenuManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadMenuScene();
        }
    }

    void LoadMenuScene()
    {Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("Menu"); // Replace "Menu" with the exact name of your scene
    }


    void Start()
    {
        // Lock and hide the cursor when the game starts
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}