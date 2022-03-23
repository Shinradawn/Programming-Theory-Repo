using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI usernameField;
    [SerializeField]
    private TextMeshProUGUI welcomeText;

    public void PlayGame()
    {
        GameManager.Instance.Name = usernameField.text;
        SceneManager.LoadScene(1);
        
        welcomeText.text = "Hi  {GameManager.Instance.Name}. As you can see. All the shapes behave in different ways.";

    }
  
}
