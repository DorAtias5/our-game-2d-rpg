using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : GenericHealth
{
    [SerializeField] private Signal hpSignal;
    [SerializeField] private FloatValue playerHeartContainer;
    public PauseMenu pauseMenu;

    public override void Update()
    {
        currHp = maxHp.runTimeValue;
    }

    public override void TakeDmg(float amount)
    {
        currHp -= amount;
        if (currHp < 0)
        {
            currHp = 0;
            Die();
        }
        maxHp.runTimeValue = currHp;
        hpSignal.Rise();
    }

    public override void Heal(float amount)
    {
        currHp = maxHp.runTimeValue;
        currHp += amount;
        if (currHp > maxHp.initialValue)
        {
            currHp = maxHp.initialValue;
        }
        maxHp.runTimeValue = currHp;
        hpSignal.Rise();
    }

    public override void FullHeal()
    {
        currHp = playerHeartContainer.runTimeValue * 2;
        maxHp.runTimeValue = currHp;
        hpSignal.Rise();
    }

    public override void Die()
    {
        pauseMenu.BackToMain();
    }
}
