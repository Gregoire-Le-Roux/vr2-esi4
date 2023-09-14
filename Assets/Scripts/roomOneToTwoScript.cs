using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject Tp;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            LoadLevel();
        }
    }

    void LoadLevel()
    {
        SceneManager.LoadScene("RoomTwo");
    }

}