﻿using UnityEngine;
using System.Collections;

/// <summary>
/// Modifier that takes a percentage of the stat's value
/// </summary>
public class RPGStatModBasePercent : RPGStatModifier {
    public override int Order {
        get { return 1; }
    }

    public override int ApplyModifier(int statValue, float modValue) {
        return (int)(statValue * modValue);
    }

    public RPGStatModBasePercent(float value) : base (value) { }
    public RPGStatModBasePercent(float value, bool stacks) : base(value, stacks) { }
}
