// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class OSP : ModuleRules
{
	public OSP(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate",
			"OnlineSubsystem",
			"OnlineSubsystemSteam"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"OSP",
			"OSP/Variant_Platforming",
			"OSP/Variant_Platforming/Animation",
			"OSP/Variant_Combat",
			"OSP/Variant_Combat/AI",
			"OSP/Variant_Combat/Animation",
			"OSP/Variant_Combat/Gameplay",
			"OSP/Variant_Combat/Interfaces",
			"OSP/Variant_Combat/UI",
			"OSP/Variant_SideScrolling",
			"OSP/Variant_SideScrolling/AI",
			"OSP/Variant_SideScrolling/Gameplay",
			"OSP/Variant_SideScrolling/Interfaces",
			"OSP/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
