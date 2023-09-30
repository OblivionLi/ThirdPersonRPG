// Copyright Balaur Games

using UnrealBuildTool;
using System.Collections.Generic;

public class Aura1EditorTarget : TargetRules
{
	public Aura1EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "Aura1" } );
	}
}
