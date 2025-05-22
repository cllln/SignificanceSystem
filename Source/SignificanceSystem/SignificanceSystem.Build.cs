// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SignificanceSystem : ModuleRules
{
	public SignificanceSystem(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" ,"ExtensibleSignificanceSystem"});
	}
}
