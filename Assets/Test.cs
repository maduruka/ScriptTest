using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; // 体力
    private int mp = 53; // 魔力
    private int power = 25; // 攻撃力

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 魔法用の関数
    public void Magic()
    {
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃した。残りMPは" + this.mp);
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

}

public class Test : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        // 魔法用の関数を11回繰り返す
        for(int a=0; a<11; a++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}