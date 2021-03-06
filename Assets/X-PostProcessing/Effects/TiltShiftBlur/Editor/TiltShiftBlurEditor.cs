
//----------------------------------------------------------------------------------------------------------
// X-PostProcessing Library
// created by QianMo @ 2020
//----------------------------------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

using UnityEditor.Rendering.PostProcessing;
using UnityEngine.Rendering.PostProcessing;

namespace XPostProcessing
{
    [PostProcessEditor(typeof(TiltShiftBlur))]
    public sealed class TiltShiftBlurEditor : PostProcessEffectEditor<TiltShiftBlur>
    {

        SerializedParameterOverride QualityLevel;
        SerializedParameterOverride AreaSize;
        SerializedParameterOverride BlurRadius;
        SerializedParameterOverride Iteration;
        SerializedParameterOverride RTDownScaling;

        public override void OnEnable()
        {
            QualityLevel = FindParameterOverride(x => x.QualityLevel);
            AreaSize = FindParameterOverride(x => x.AreaSize);
            BlurRadius = FindParameterOverride(x => x.BlurRadius);
            Iteration = FindParameterOverride(x => x.Iteration);
            RTDownScaling = FindParameterOverride(x => x.RTDownScaling);
        }

        public override string GetDisplayTitle()
        {
            return XPostProcessingEditorUtility.DISPLAY_TITLE_PREFIX + base.GetDisplayTitle();
        }

        public override void OnInspectorGUI()
        {
            PropertyField(QualityLevel);
            PropertyField(AreaSize);
            PropertyField(BlurRadius);
            PropertyField(Iteration);
            PropertyField(RTDownScaling);
        }

    }
}
        
