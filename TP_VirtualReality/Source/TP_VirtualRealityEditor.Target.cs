using UnrealBuildTool;
using System.Collections.Generic;

public class TP_VirtualRealityEditorTarget : TargetRules
{
    public TP_VirtualRealityEditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;

        ExtraModuleNames.AddRange(new string[] { "TP_VirtualReality" });
    }
}
