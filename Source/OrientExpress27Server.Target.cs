// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class OrientExpress27ServerTarget : TargetRules
{
    public OrientExpress27ServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("OrientExpress27");
		bUsesSteam = true;
		GlobalDefinitions.Add("UE4_PROJECT_STEAMGAMEDESC=\"E9C50_Game\"");
		GlobalDefinitions.Add("UE4_PROJECT_STEAMPRODUCTNAME=\"spacewar\"");
		GlobalDefinitions.Add("UE4_PROJECT_STEAMGAMEDIR=\"spacewar\"");

	}
}
