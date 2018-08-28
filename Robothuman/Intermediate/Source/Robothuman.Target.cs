using UnrealBuildTool;

public class RobothumanTarget : TargetRules
{
	public RobothumanTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Robothuman");
	}
}
