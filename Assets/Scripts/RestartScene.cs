using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    [SerializeField]
    KeyCode RestartKey;
    [SerializeField]
    string Tag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(RestartKey))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == Tag)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
