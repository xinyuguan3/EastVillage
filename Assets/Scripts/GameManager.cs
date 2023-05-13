using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public InputField[] inputField; // Reference to the InputField component
    public UnityEvent onEnterPressed; // Event to be triggered when the Enter key is pressed

    public AudioClip uiSound;

    private void Update()
    {
        inputField=GetComponents<InputField>();
        // foreach (InputField IF in inputField)
        // {
        //     // Check if the InputField is focused and the Enter key is pressed
        // if (IF.isFocused && Input.GetKeyDown(KeyCode.Return) ||   Input.GetKeyDown(KeyCode.KeypadEnter))
        // {
        //     // If the Enter key is pressed, invoke the onEnterPressed event
        //     onEnterPressed.Invoke();

        //     // Optionally, you can clear the InputField text after the message is sent
        //     //inputField.text = "";
        // }
        // }
        
        //quit when pressing Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            Init();
            return;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //whenever load a new scene, for every button in the scene, add a listener to play the sound
    private void OnLevelWasLoaded(int level)
    {
        Button[] buttons = FindObjectsOfType<Button>();
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => SoundManager.Instance.PlaySound(uiSound));
        }
    }
        

    private string highScoreKey = "HighScore";

    public int HighScore
    {
        get
        {
            return PlayerPrefs.GetInt(highScoreKey, 0);
        }
        set
        {
            PlayerPrefs.SetInt(highScoreKey, value);
        }
    }

    public int CurrentScore { get; set; }

    public bool IsInitialized { get; set; }

    private void Init()
    {
        

        CurrentScore = 0;
        IsInitialized = false;
    }

    public const string MainMenu = "MainMenu";
    public const string Gameplay = "饭店大堂";

    public void GoToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void GoToGameplay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void GoToScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
