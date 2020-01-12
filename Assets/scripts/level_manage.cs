using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class level_manage
{
    //current level
    private static int currentLevel;

    //mark whether true/false button has been clicked or not during this level
    private static bool isClicked;

    public static void initialLevel()
    {
        currentLevel = 1;
        isClicked = false;
    }

    public static int getCurrentLevel()
    {
        return currentLevel;
    }

    public static void setNextLevel()
    {
        currentLevel = currentLevel + 1;
    }

    public static void setIsClicked(bool value)
    {
        isClicked = value;
    }

    public static bool getIsClicked()
    {
        return isClicked;
    }
}
