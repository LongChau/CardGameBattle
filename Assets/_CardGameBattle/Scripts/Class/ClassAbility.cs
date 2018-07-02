using System;
using System.Collections;

[Serializable]
public class ClassAbility
{
    public string definition;
    public EClassAbilityType classAbilityType;

    public ClassAbility(string definition, EClassAbilityType classAbilityType)
    {
        this.definition = definition;
        this.classAbilityType = classAbilityType;
    }
}
