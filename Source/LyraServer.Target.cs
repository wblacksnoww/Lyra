// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

[SupportedPlatforms(UnrealPlatformClass.Server)]
public class LyraServerTarget : TargetRules
{
	public LyraServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;

		ExtraModuleNames.AddRange(new string[] { "LyraGame" });

		LyraGameTarget.ApplySharedLyraTargetSettings(this);
		// 在服务器构建中强制禁用影片渲染管线插件，防止打包错误
		DisablePlugins.AddRange(new string[] {
			"MovieRenderPipeline",
			"MovieRenderPipelineCore",
			"MovieRenderPipelineRenderPasses",
			"MovieRenderPipelineSettings",
			"MovieRenderPipelineMaskRenderPasses"
		});
		bUseChecksInShipping = true;
	}
}
