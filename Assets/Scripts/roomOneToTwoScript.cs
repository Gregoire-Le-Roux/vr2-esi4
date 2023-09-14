using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public string SceneName;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hello, world!");
        if (collision.gameObject.GetComponent<PlayerController>())
        {
            LoadLevel();
        }
    }

    void LoadLevel()
    {
        Debug.Log("on load level");
        SceneManager.LoadScene(SceneName);
    }

}