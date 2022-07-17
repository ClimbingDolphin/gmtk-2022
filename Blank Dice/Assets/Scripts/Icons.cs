using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Icons", menuName = "ScriptableObjects/Icons")]
public class Icons : ScriptableObject
{
    public List<string> actions;
    public List<Sprite> icons;
    public List<Sprite> arrow;
}
