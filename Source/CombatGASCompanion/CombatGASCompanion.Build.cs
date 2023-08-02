// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class CombatGASCompanion : ModuleRules
{
	public CombatGASCompanion(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		bEnforceIWYU = true;

		PublicDependencyModuleNames.AddRange(new[]
		{
			"Core", "CoreUObject", "Engine", "InputCore",
			"UMG",
			"EnhancedInput",
			"Niagara",
			/*AnimGraphRunTime Required to use UKismetAnimationLibraryFunctions */
			"AnimGraphRuntime",
			"GameplayAbilities"
		});

		PrivateDependencyModuleNames.AddRange(new[] { 
			"GameplayTasks",
			"GameplayTags"});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}