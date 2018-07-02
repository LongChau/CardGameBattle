using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Contains class card infos
/// </summary>
[Serializable]
public class ClassCardInfo
{
    public string className;
    public int defensePoint;
    public int classAbilityTokensCount;
    public ClassAbility classAbility;

    public ClassCardInfo(string className, int defensePoint, int classAbilityTokensCount, ClassAbility classAbility)
    {
        this.className = className;
        this.defensePoint = defensePoint;
        this.classAbilityTokensCount = classAbilityTokensCount;
        this.classAbility = classAbility;
    }
}
