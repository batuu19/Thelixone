using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


namespace Giereczka.Config
{
    [CustomEditor(typeof(Models))]
    public class ModelsEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            Models myScript = (Models)target;
            if(GUILayout.Button("Load Models"))
            {
                myScript.LoadModels();
            }
            if(GUILayout.Button("Save Models"))
            {
                myScript.SaveModels();
            }
        }
    }
}
