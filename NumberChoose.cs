using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberChoose : MonoBehaviour
{
    public Text warmingText;
    public InputField input;

    private void Start()
    {
        warmingText.enabled = false;
    }

    public void OnClick()
    {
        if (  input.text.ToString() == "")
        {
            print("输入错误");
            StartCoroutine(Warming());
        }
        else
        {
            if (JudgeInt(input.text))
            {
                Data.Number = int.Parse(input.text);
                if (Data.Number <= 0)
                {
                    print("输入错误");
                    StartCoroutine(Warming());
                }
                else if (Data.Number >= 10)
                {
                    Data.Number = 10;
                }
                print(Data.Number);
                this.GetComponent<SceneChange>().EnterGame();
            }
            else
            {
                print("输入错误");
                StartCoroutine(Warming());
            }
        }
       
    }

    public bool JudgeInt(string s)
    {
        string pattern = "^[0-9]*$";
        Regex rx = new Regex(pattern);
        return rx.IsMatch(s);
    }

    IEnumerator Warming()
    {
        warmingText.enabled = true;
        yield return new WaitForSeconds(1f);
        warmingText.enabled = false;
        StopCoroutine(Warming());
    }

}
