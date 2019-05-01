using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LudusData : MonoBehaviour
{
    public Text coin;
    public Text food;
    public Text influence;

    public int servantsMax;
    public int servantsHave;

    public int coinMax;
    public int coinCur;

    public int numberTurn;

    public int cornMax;
    public int cornCur;

    public int foodMax;
    public int foodCur;

    public void Start()
    {
        foodMax = 100;
        coinMax = 300;
        ChangeResource(100,"coin");
        ChangeResource(30,"food");
    }

    public void ChangeResource(int value, string type)
    {
        switch (type)
        {
            case "servant":
                if (servantsHave + value <= servantsMax) servantsHave = servantsHave + value;
                else servantsHave = servantsMax;
                break;
            case "coin":
                if (coinCur + value <= coinMax) coinCur = coinCur + value;
                else coinCur = coinMax;
                coin.text = coinCur+"";
                break;
            case "corn":
                if (cornCur + value <= cornMax) cornCur = cornCur + value;
                else cornCur = cornMax;
                break;
            case "food":
                if (foodCur + value <= foodMax) foodCur = foodCur + value;
                else foodCur = foodMax;
                food.text = foodCur+"";
                break;
            case "turn":
                numberTurn += value;
                break;
        }
    }
}
