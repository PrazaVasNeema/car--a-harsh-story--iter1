using UnityEngine;
using UnityEngine.Rendering;

public partial class PostFXStack {

    const string bufferName = "Post FX";
    
    enum Pass {
        Copy
    }
    
    int fxSourceId = Shader.PropertyToID("_PostFXSource");
    
    public bool IsActive => settings != null;

    CommandBuffer buffer = new CommandBuffer {
        name = bufferName
    };

    ScriptableRenderContext context;
	
    Camera camera;

    PostFXSettings settings;

    public void Setup (
        ScriptableRenderContext context, Camera camera, PostFXSettings settings
    ) {
        this.context = context;
        this.camera = camera;
        this.settings = settings;
        this.settings =
            camera.cameraType <= CameraType.SceneView ? settings : null;
        ApplySceneViewState();
    }
    
    public void Render (int sourceId) {
        Draw(sourceId, BuiltinRenderTextureType.CameraTarget, Pass.Copy);
        context.ExecuteCommandBuffer(buffer);
        buffer.Clear();
    }
    
    void Draw (
        RenderTargetIdentifier from, RenderTargetIdentifier to, Pass pass
    ) {
        buffer.SetGlobalTexture(fxSourceId, from);
        buffer.SetRenderTarget(
            to, RenderBufferLoadAction.DontCare, RenderBufferStoreAction.Store
        );
        buffer.DrawProcedural(
            Matrix4x4.identity, settings.Material, (int)pass,
            MeshTopology.Triangles, 3
        );
    }
}