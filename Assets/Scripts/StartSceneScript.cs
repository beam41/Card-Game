using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneScript : MonoBehaviour
{

    public GameObject loginPage;
    public GameObject registerPage;

    public void openLoginPage()
    {
        registerPage.SetActive(false);
        loginPage.SetActive(true);
    }

    public void openRegisterPage()
    {
        registerPage.SetActive(true);
        loginPage.SetActive(false);
    }
    
    public void login(){
        SceneManager.LoadScene(1);
    }
}
