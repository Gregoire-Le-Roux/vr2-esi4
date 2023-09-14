using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

 

public class ChangeScene : MonoBehaviour
{
    public GameObject lumiere;

 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            lumiere.SetActive(false);
            LoadLevel();
        }
    }

 

    void LoadLevel()
    {
        SceneManager.LoadScene("roomOneScene");
    }

 

}
