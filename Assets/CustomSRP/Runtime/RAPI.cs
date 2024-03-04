using UnityEngine;
using UnityEngine.Rendering;

namespace CustomSRP.Runtime
{
    public static class RAPI
    {
        private const string BUFFER_NAME = "DefaultBufferName";
    
        public static CommandBuffer Buffer { get; private set; } = new CommandBuffer {
            name = BUFFER_NAME
        };
        public static ScriptableRenderContext Context { get; set; }
        public static Camera CurCamera { get; set; }
        public static CullingResults CullingResults { get; private set; }
    
    
        public static void ExecuteBuffer () {
            Context.ExecuteCommandBuffer(Buffer);
            Buffer.Clear();
        }
        

        public static void CleanupTempRT(int atlasID)
        {
            Buffer.ReleaseTemporaryRT(atlasID);
            ExecuteBuffer();
        }
    
        public static bool Cull(float maxShadowDistance)
        {
            if (CurCamera.TryGetCullingParameters(out ScriptableCullingParameters p))
            {
                p.shadowDistance = Mathf.Min(maxShadowDistance, CurCamera.farClipPlane);
                CullingResults = Context.Cull(ref p);
                return true;
            }
            return false;
        }
    }
}
