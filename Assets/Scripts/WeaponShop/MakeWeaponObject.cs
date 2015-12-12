using UnityEngine;
using System.Collections;
using UnityEditor;

public class MakeWeaponObject
{
    [MenuItem("Assets/Create/Weapon Object")]
    public static void Create()
    {
        WeaponObject asset = ScriptableObject.CreateInstance<WeaponObject>();
        AssetDatabase.CreateAsset(asset, "Assets/Weapons/NewWeaponObject.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }

}