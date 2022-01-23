using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

    public Button startButton;
    public Button messageButton;
    public Label messageText;
    public Button testButton;

    private void Start () {

        // Pega os elementos da raiz do UXML
        var root = GetComponent<UIDocument> ().rootVisualElement;

        //Linka o obojeto da UXML com o objeto do codigo em C#
        startButton = root.Q<Button> ("start-button");
        messageButton = root.Q< Button > ("message-button");
        messageText = root.Q<Label> ("message-text");

        startButton.clicked += StartButtonPressed;
        messageButton.clicked += MessageButtonPressed;

        
    }

    void StartButtonPressed () {

        if(SceneManager.GetActiveScene().name == "01_New_UI_xml") {

            SceneManager.LoadScene ("02_New_UI_xml");
        }
        else {

            SceneManager.LoadScene ("01_New_UI_xml");
        }
        

    }

    void MessageButtonPressed () {

        messageText.text = "Enjoy the Game and have Fun !";
       // messageText.style.display = DisplayStyle.Flex;
        messageText.style.visibility = Visibility.Visible;


    }

}
