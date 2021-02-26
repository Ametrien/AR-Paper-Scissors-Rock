using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Texting: MonoBehaviour
{
    public GameObject paper1;
    public GameObject paper2;
    public GameObject scissors1;
    public GameObject scissors2;
    public GameObject rock1;
    public GameObject rock2;
    public TextMesh TVText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if ((paper1.activeSelf & paper2.activeSelf) |
            (scissors1.activeSelf & scissors2.activeSelf) |
            (rock1.activeSelf & rock2.activeSelf)){
                TVText.text = "It's a tie!";
        }

        else if ((paper1.activeSelf & rock2.activeSelf) |
            (scissors1.activeSelf & paper2.activeSelf) |
            (rock1.activeSelf & scissors2.activeSelf))
        {
            TVText.text = "Player 1 wins!";
        }

        else if ((paper2.activeSelf & rock1.activeSelf) |
            (scissors2.activeSelf & paper1.activeSelf) |
            (rock1.activeSelf & scissors2.activeSelf))
        {
            TVText.text = "Player 2 wins!";
        }

        else if ((!paper2.activeSelf & !scissors2.activeSelf & !rock2.activeSelf) &
            ((rock1.activeSelf & !scissors1.activeSelf & !paper1.activeSelf)
             | (scissors1.activeSelf & !rock1.activeSelf & !paper1.activeSelf)
              | (paper1.activeSelf & !rock1.activeSelf & !scissors1.activeSelf)))
        {
            TVText.text = "Waiting for player 2";
        }

        else if ((!paper1.activeSelf & !scissors1.activeSelf & !rock1.activeSelf) &
            ((rock2.activeSelf & !scissors2.activeSelf & !paper2.activeSelf)
             | (scissors2.activeSelf & !rock2.activeSelf & !paper2.activeSelf)
              | (paper2.activeSelf & !rock2.activeSelf & !scissors2.activeSelf)))
        {
            TVText.text = "Waiting for player 1";
        }

        else if ((!paper1.activeSelf & !scissors1.activeSelf & !rock1.activeSelf) &
            (!rock2.activeSelf & !scissors2.activeSelf & !paper2.activeSelf))
        {
            TVText.text = "Waiting for both players";
        }

        // two cards of the same player are used -> you are not allowed to play
        // one cannot use more than 2 cards at once, because camera only detects 2 objects

        if ((paper1.activeSelf  & (scissors1.activeSelf | rock1.activeSelf)) |
            (scissors1.activeSelf  & (paper1.activeSelf | rock1.activeSelf)) |
            (rock1.activeSelf  & (scissors1.activeSelf | paper1.activeSelf)) |
            (paper2.activeSelf  & (scissors2.activeSelf | rock2.activeSelf)) |
            (scissors2.activeSelf  & (paper2.activeSelf | rock2.activeSelf)) |
            (rock2.activeSelf  & (scissors2.activeSelf | paper2.activeSelf)))
            {
                TVText.text = "Use different cards";
            } 

    }
}