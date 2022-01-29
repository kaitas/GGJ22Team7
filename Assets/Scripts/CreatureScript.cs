using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    private Vector3 coordinate;
    private string type;
    private int hp;
    private int fullHp; // HP‚Ìfulló‘Ô‚ğ‹L˜^‚·‚é‚½‚ß‚É•K—v
    private int fullness = 0;

    public Creature(Vector3 coordinate, string type, int hp)
    {
        this.coordinate = coordinate;
        this.type = type;
        this.hp = hp;
        fullHp = this.hp;
    }

    public abstract void seek(GameObject target);   //ŠF‚³‚ñ‚Ì‚¨—Í‚ğ‘İ‚µ‚Ä‰º‚³‚¢B

    public abstract void think();                   //ŠF‚³‚ñ‚Ì‚¨—Í‚ğ‘İ‚µ‚Ä‰º‚³‚¢B

    public abstract void eat(GameObject target);    //ŠF‚³‚ñ‚Ì‚¨—Í‚ğ‘İ‚µ‚Ä‰º‚³‚¢B

    public abstract void move(GameObject target);   //ŠF‚³‚ñ‚Ì‚¨—Í‚ğ‘İ‚µ‚Ä‰º‚³‚¢B

    public void sleep()
    {
        if(hp != fullHp)
        {
            while (hp != fullHp)
                hp = +1;
        }
    }

    public abstract void copy();                    //ŠF‚³‚ñ‚Ì‚¨—Í‚ğ‘İ‚µ‚Ä‰º‚³‚¢B

    public void death()
    {
        if (hp == 0)
            Destroy(gameObject);
    }
}
