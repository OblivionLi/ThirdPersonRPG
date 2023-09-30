// Copyright Balaur Games

using UnrealBuildTool;
using System.Collections.Generic;

public class Aura1Target : TargetRules
{
	public Aura1Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "Aura1" } );
	}
}
