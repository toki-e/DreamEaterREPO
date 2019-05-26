using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryTextScript : MonoBehaviour
{

    public Text storyText;
    public int lineNumber;

   public AudioSource writingSource;
   public AudioClip writingClip;

    // Start is called before the first frame update
    void Start()
    {
        storyText.text = "  ";
        lineNumber = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            lineNumber++;

            if (!writingSource.isPlaying)
            {
                writingSource.PlayOneShot(writingClip, 1);
            }

        }

        if (lineNumber == 1)
        {
            storyText.text = "My name is Koto Elvi.";
        }

        if(lineNumber == 2)
        {
            storyText.text = "My name is Koto Elvi. \n Lately, a vampire named Laika has been following me...";

        }

        if(lineNumber == 3)
        {
            storyText.text = "My name is Koto Elvi. \n Lately, a vampire named Laika has been following me... \n" +
                "I don’t know why she would target me, but I know it’s not safe to leave things as it is.";

        }

        if(lineNumber == 4)
        {
            storyText.text = "My name is Koto Elvi. \n Lately, a vampire named Laika has been following me... \n" +
                "I don’t know why she would target me, but I know it’s not safe to leave things as it is." +
                "\n I decided to go to someone who might have more information about her, another dream eater called Baku.\n I asked him about her.";

        }

        if(lineNumber == 5)
        {
            storyText.text = "My name is Koto Elvi. \n Lately, a vampire named Laika has been following me... \n" +
                "I don’t know why she would target me, but I know it’s not safe to leave things as it is." +
                "\n I decided to go to someone who might have more information about her, another dream eater called Baku.\n I asked him about her." +
                "\n In the end, though, I didn't find out anything really useful.";

        }

        if (lineNumber == 6)
        {
            storyText.text = "My name is Koto Elvi. \n Lately, a vampire named Laika has been following me... \n" +
                "I don’t know why she would target me, but I know it’s not safe to leave things as it is." +
                "\n I decided to go to someone who might have more information about her, another dream eater called Baku.\n I asked him about her." +
                "\n In the end, though, I didn't find out anything really useful." +
                "\n We ended the conversation, and I’m sure he assumed I left.";

        }

        if (lineNumber == 7)
        {
            storyText.text = "My name is Koto Elvi. \n Lately, a vampire named Laika has been following me... \n" +
                "I don’t know why she would target me, but I know it’s not safe to leave things as it is." +
                "\n I decided to go to someone who might have more information about her, another dream eater called Baku.\n I asked him about her." +
                "\n In the end, though, I didn't find out anything really useful." +
                "\n We ended the conversation, and I’m sure he assumed I left." +
                "\n My eye was caught by a painting and I had stopped to look at it though.";

        }

        if (lineNumber == 8)
        {
            storyText.text = "My name is Koto Elvi. \n Lately, a vampire named Laika has been following me... \n" +
                "I don’t know why she would target me, but I know it’s not safe to leave things as it is." +
                "\n I decided to go to someone who might have more information about her, another dream eater called Baku.\n I asked him about her." +
                "\n In the end, though, I didn't find out anything really useful." +
                "\n We ended the conversation, and I’m sure he assumed I left." +
                "\n My eye was caught by a painting and I had stopped to look at it though." +
                "\n After some time, I heard a strange noise. What could that be?";
        }

        if (lineNumber == 9)
        {
            storyText.text = "My name is Koto Elvi. \n Lately, a vampire named Laika has been following me... \n" +
                "I don’t know why she would target me, but I know it’s not safe to leave things as it is." +
                "\n I decided to go to someone who might have more information about her, another dream eater called Baku.\n I asked him about her." +
                "\n In the end, though, I didn't find out anything really useful." +
                "\n We ended the conversation, and I’m sure he assumed I left." +
                "\n My eye was caught by a painting and I had stopped to look at it though." +
                "\n After some time, I heard a strange noise. What could that be?" +
                
                "\n \n \n[Chapter 1 begins here.]";
        }

        if(lineNumber == 10)
        {
            SceneManager.LoadScene(2);

        }

    }
}
