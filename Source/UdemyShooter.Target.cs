// Udemy Shooter Game. All Rights Reserved

using UnrealBuildTool;
using System.Collections.Generic;

public class UdemyShooterTarget : TargetRules
{
	public UdemyShooterTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "UdemyShooter" } );
	}
}
