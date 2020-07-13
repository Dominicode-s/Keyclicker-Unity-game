using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameScrips : MonoBehaviour
{
    public Text score ;
    public int scoreCounter;
    public int randomNumber;
    // public Image image1;
    // public Image image2;
    // public Image image3;
    // public Image image4;
    // public Image image5;
    // public Image image6;
    // public Image image7;
    // public Image image8;
    // public Image image9;
    public Image[] imageArray = new Image[9];
    public Image lastImage;
    public int lastNum = 10;

    // called first
    void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // called second
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        setRandomnumber();
        Debug.Log("OnSceneLoaded: " + scene.name);
        Debug.Log(mode);
    }

    // called third
    void Start()
    {
        Debug.Log("Start");
    }

    // called when the game is terminated
    void OnDisable()
    {
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }


    void Update(){

        if(Input.GetKeyDown("[1]")){
            ChangeScoreText(0);
        } else if(Input.GetKeyDown("[2]")) {
            ChangeScoreText(1);
        }else if(Input.GetKeyDown("[3]")) {
            ChangeScoreText(2);
        }else if(Input.GetKeyDown("[4]")) {
            ChangeScoreText(3);
        }else if(Input.GetKeyDown("[5]")) {
            ChangeScoreText(4);
        }else if(Input.GetKeyDown("[6]")) {
            ChangeScoreText(5);
        }else if(Input.GetKeyDown("[7]")) {
            ChangeScoreText(6);
        }else if(Input.GetKeyDown("[8]")) {
            ChangeScoreText(7);
        }else if(Input.GetKeyDown("[9]")) {
            ChangeScoreText(8);
        }

    }
    public void ChangeScoreText(int num) {

        if(num == randomNumber){
            scoreCounter++;
            score.text = scoreCounter.ToString();
        } else {
            scoreCounter--;
            score.text = scoreCounter.ToString();

        }

        setRandomnumber();
    }
    public void setImageColour(int num) {
        //score.text = imageArray[num].color;
        imageArray[num].color = new Color32(0,255,52,255);

        if(lastImage)
        {
            lastImage.color = new Color32(255,255,255,255);
            lastImage = imageArray[num];
        } else {
            lastImage = imageArray[num];
        }

    }
    public void setRandomnumber() {
        randomNumber = Random.Range(0,9);

        if(lastNum != 10){
            if(lastNum == randomNumber){
                setRandomnumber();
            } else{
                lastNum = randomNumber;
                setImageColour(randomNumber);
            }
        } else {
            lastNum = randomNumber;
            setImageColour(randomNumber);
        }

    }
}
