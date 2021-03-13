using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    private static float health;

    private static int maxHealth;

    private static float moveSpeed;

    private static float attackSpeed;

    private static float dmg;

    public static float Health { get => health; set => health = value; }
    public static int MaxHealth { get => maxHealth; set => maxHealth = value; }
    public static float MoveSpeed { get => moveSpeed; set => moveSpeed = value; }
    public static float AttackSpeed { get => attackSpeed; set => attackSpeed = value; }
    public static float Dmg { get => dmg; set => dmg = value; }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void HealPlayer(float healAmount)
    {

    }
    public static void MoveSpeedChange(float speed)
    {

    }
    public static void AttackSpeedChange(float atackSpeed)
    {

    }
    public static void HealthChange(int maxHealth)
    {

    }
    public static void DmgChange(float dmg)
    {

    }
}
