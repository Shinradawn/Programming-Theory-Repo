using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DisplayUsername : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI welcomeText;
    
    

    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        if (currentScene.buildIndex == 1)
        {
            welcomeText.text = "Hi " + GameManager.Instance.Name +". As you can see. All the shapes behave in different ways. Click on them too.";

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
