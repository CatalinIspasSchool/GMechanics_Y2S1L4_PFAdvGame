// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Aurora_Y2S1L4_FPAdvEditorTarget : TargetRules
{
	public Aurora_Y2S1L4_FPAdvEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V7;

		ExtraModuleNames.AddRange( new string[] { "Aurora_Y2S1L4_FPAdv" } );
	}
}
