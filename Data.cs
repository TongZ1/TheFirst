using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Data : MonoBehaviour
{
    private static int destroyNumber;
    private static int shootNumber;
    private static int shootBingoNumber;
    private static int number;
    public static int Number
    {
        get { return number; }
        set { number = value; }
    }

    public static int DestroyNumber
    {
        get { return destroyNumber; }
        set { destroyNumber = value; }
    }
    public static int ShootNumber
    {
        get { return shootNumber; }
        set { shootNumber = value; }
    }
    public static int ShootBingoNumber
    {
        get { return shootBingoNumber; }
        set { shootBingoNumber = value; }
    }

    // Start is called before the first frame update
    public void Start()
    {
        Number = 0;
        DestroyNumber = 0;
        ShootNumber = 0;
        ShootBingoNumber = 0;
    }


}
