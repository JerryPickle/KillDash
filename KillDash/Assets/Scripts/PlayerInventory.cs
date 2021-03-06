using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public bool hasDough;
    public bool hasSauce;
    public bool hasTopping;
    public bool hasDrink;
    public bool hasSide;
    public bool hasPoison;
    int money;
    public string doughType;
    public string sauceType;
    public string toppingType;
    public string drinkType;
    public string sideType;

    List<FoodOrder> orders;


    public void throwAway()
    {
        hasDough = false;
        hasSauce = false;
        hasTopping = false;
        hasDrink = false;
        hasSide = false;
        hasPoison = false;
    }

    public bool isEmpty()
    {

        if(!hasDough && !hasSauce && !hasTopping && !hasDrink && !hasSide && !hasPoison)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        money = 0;
        doughType = sauceType = toppingType = drinkType = sideType = "none";
        orders = new List<FoodOrder>();
    }

    
}
