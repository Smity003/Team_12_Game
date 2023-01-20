using UnrealBuildTool;

public class MyProject3Target : TargetRules
{
	public MyProject3Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MyProject3");
	}
}
