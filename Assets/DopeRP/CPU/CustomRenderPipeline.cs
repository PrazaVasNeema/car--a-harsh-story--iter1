﻿using UnityEngine;
using UnityEngine.Rendering;

namespace DopeRP.CPU
{
	public class CustomRenderPipeline : RenderPipeline
	{
		DopeRP.CPU.CameraRenderer renderer = new DopeRP.CPU.CameraRenderer();
		
		bool useDynamicBatching, useGPUInstancing;

		private CustomRenderPipelineAsset m_assetSettings;

		public CustomRenderPipeline (bool useDynamicBatching, bool useGPUInstancing, bool useSRPBatcher,
			CustomRenderPipelineAsset assetSettings) {
			// GraphicsSettings.useScriptableRenderPipelineBatching = true;
			// GraphicsSettings.lightsUseLinearIntensity = true;
			m_assetSettings = assetSettings;
			this.useDynamicBatching = useDynamicBatching;
			this.useGPUInstancing = useGPUInstancing;
			GraphicsSettings.useScriptableRenderPipelineBatching = useSRPBatcher;
			GraphicsSettings.lightsUseLinearIntensity = true;
		}

		protected override void Render(ScriptableRenderContext context, Camera[] cameras)
		{
			RAPI.Context = context;
			for (int i = 0; i < cameras.Length; i++) {
				renderer.Render(cameras[i], useDynamicBatching, useGPUInstancing, m_assetSettings);
			}
		}
	}
}