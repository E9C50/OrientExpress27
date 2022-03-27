// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class OrientExpress27ClientTarget : TargetRules
{
    public OrientExpress27ClientTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Client;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("OrientExpress27");
		bUsesSteam = true;
		GlobalDefinitions.Add("UE4_PROJECT_STEAMGAMEDESC=\"E9C50_Game\"");
		GlobalDefinitions.Add("UE4_PROJECT_STEAMPRODUCTNAME=\"spacewar\"");
		GlobalDefinitions.Add("UE4_PROJECT_STEAMGAMEDIR=\"spacewar\"");
	}
}
