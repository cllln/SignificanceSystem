// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class SignificanceSystemEditorTarget : TargetRules
{
	public SignificanceSystemEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_5;
		BuildEnvironment = TargetBuildEnvironment.Unique;
		CppStandard = CppStandardVersion.Cpp20;
		ExtraModuleNames.Add("SignificanceSystem");
	}
}
