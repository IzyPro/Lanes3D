using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField]
    string Tag;
    [SerializeField]
    KeyCode Finish;
    [SerializeField]
    string Level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.CompareTag("Player"))
    //    {
    //        SceneManager.LoadScene("level 1");
    //    }
    //}
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == Tag && !string.IsNullOrEmpty(Level))
        {
            SceneManager.LoadScene(Level);
        }
    }
}
