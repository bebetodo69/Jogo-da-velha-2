using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text9;

    public bool turnX = true;

    public Text messageText;
    
    public void ClickButton1()
    {
        if (turnX == true)
        {
            text1.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
        }
        else
        {
            text1.text = "O";
            turnX = true;
            messageText.text = "Jogador: X";
        }

        VictoryCheck();
    }
    
    public void ClickButton2()
    {
        if (turnX == true)
        {
            text2.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
        }
        else
        {
            text2.text = "O";
            turnX = true;
            messageText.text = "Jogador: X";
        }
        VictoryCheck();
    }
    public void ClickButton3()
    {
        if (turnX == true)
        {
            text3.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
        }
        else
        {
            text3.text = "O";
            turnX = true;
            messageText.text = "Jogador: X";
        }
        VictoryCheck();
    }
    
    public void ClickButton4()
    {
        if (turnX == true)
        {
            text4.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
        }
        else
        {
            text4.text = "O";
            turnX = true;
            messageText.text = "Jogador: X";
        }
        VictoryCheck();
    }

    public void ClickButton5()
    {
        if (turnX == true)
        {
            text5.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
        }
        else
        {
            text5.text = "O";
            turnX = true;
            messageText.text = "Jogador: X";
        }
        VictoryCheck();
    }

    public void ClickButton6()
    {
        if (turnX == true)
        {
            text6.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
        }
        else
        {
            text6.text = "O";
            turnX = true;
            messageText.text = "Jogador: X";
        }
        VictoryCheck();
    }

    public void ClickButton7()
    {
        if (turnX == true)
        {
            text7.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
        }
        else
        {
            text7.text = "O";
            turnX = true;
            messageText.text = "Jogador: X";
        }
        VictoryCheck();
    }

    public void ClickButton8()
    {
        if (turnX == true)
        {
            text8.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
        }
        else
        {
            text8.text = "O";
            turnX = true;
            messageText.text = "Jogador: X";
        }
        VictoryCheck();
    }

    public void ClickButton9()
    {
        if (turnX == true)
        {
            text9.text = "X";
            turnX = false;
            messageText.text = "Jogador: O";
        }
        else
        {
            text9.text = "O";
            turnX = true;
            messageText.text = "Jogador: X";
        }
        VictoryCheck();
    }

    public void VictoryCheck()
    {
        if (text1.text == "X" && text2.text == "X" && text3.text == "X")
        {
            messageText.text = "Jogador X Ganhou";
        }
        
        if (text1.text == "O" && text2.text == "O" && text3.text == "O")
        {
            messageText.text = "Jogador O Ganhou";
        }
        
        
        if (text4.text == "X" && text5.text == "X" && text6.text == "X")
        {
            messageText.text = "Jogador X Ganhou";
        }
        
        if (text4.text == "O" && text5.text == "O" && text6.text == "O")
        {
            messageText.text = "Jogador O Ganhou";
        }
        
        
        if (text7.text == "X" && text8.text == "X" && text9.text == "X")
        {
            messageText.text = "Jogador X Ganhou";
        }
        
        if (text7.text == "O" && text8.text == "O" && text9.text == "O")
        {
            messageText.text = "Jogador O Ganhou";
        }
        
        
        if (text1.text == "X" && text4.text == "X" && text7.text == "X")
        {
            messageText.text = "Jogador X Ganhou";
        }
        
        if (text1.text == "O" && text4.text == "O" && text7.text == "O")
        {
            messageText.text = "Jogador O Ganhou";
        }
        
        
        if (text2.text == "X" && text5.text == "X" && text8.text == "X")
        {
            messageText.text = "Jogador X Ganhou";
        }
        
        if (text2.text == "O" && text5.text == "O" && text8.text == "O")
        {
            messageText.text = "Jogador O Ganhou";
        }
        
        
        if (text3.text == "X" && text6.text == "X" && text9.text == "X")
        {
            messageText.text = "Jogador X Ganhou";
        }
        
        if (text3.text == "O" && text6.text == "O" && text9.text == "O")
        {
            messageText.text = "Jogador O Ganhou";
        }
        
        
        if (text1.text == "X" && text5.text == "X" && text9.text == "X")
        {
            messageText.text = "Jogador X Ganhou";
        }
        
        if (text1.text == "O" && text5.text == "O" && text9.text == "O")
        {
            messageText.text = "Jogador O Ganhou";
        }
        
        
        if (text3.text == "X" && text5.text == "X" && text7.text == "X")
        {
            messageText.text = "Jogador X Ganhou";
        }
        
        if (text3.text == "O" && text5.text == "O" && text7.text == "O")
        {
            messageText.text = "Jogador O Ganhou";
        }
    }
    
    public void ResetScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
