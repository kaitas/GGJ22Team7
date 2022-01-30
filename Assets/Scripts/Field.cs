using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class field
{
    public int F;
    //1岩場 2砂漠 3土地 4肥沃な土地 5草原 6森林 7海 0建造物
    public int[] touchF = new int[4];
    //隣のフィールドの状態
}
