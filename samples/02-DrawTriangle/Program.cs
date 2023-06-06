// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using Alimer.WebGPU.SampleFramework;
using static WebGPU;

namespace DrawTriangle;

public static unsafe class Program
{
    public static void Main()
    {
        using TestApp testApp = new();
        testApp.Run();
    }

    class TestApp : Application
    {
        private GraphicsDevice _graphicsDevice;
        public override string Name => "02-DrawTriangle";

        private WGPUPipelineLayout _pipelineLayout;
        private WGPURenderPipeline _pipeline;
        //private WGPUBuffer _vertexBuffer;

        protected override void Initialize()
        {
            _graphicsDevice = new GraphicsDevice(MainWindow);

            WGPUPipelineLayoutDescriptor layoutDesc = new()
            {
                nextInChain = null,
                bindGroupLayoutCount = 0,
                bindGroupLayouts = null
            };
            _pipelineLayout = wgpuDeviceCreatePipelineLayout(_graphicsDevice.Device, &layoutDesc);

            string shaderSource = File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "Assets", $"Triangle.wgsl"));
            WGPUShaderModule shaderModule = wgpuDeviceCreateShaderModule(_graphicsDevice.Device, shaderSource);

            fixed (sbyte* pVertexEntryPoint = "vertexMain".GetUtf8Span())
            fixed (sbyte* pFragmentEntryPoint = "fragmentMain".GetUtf8Span())
            {
                WGPURenderPipelineDescriptor pipelineDesc = new();
                pipelineDesc.layout = _pipelineLayout;

                // Vertex fetch
                // (We don't use any input buffer so far)
                pipelineDesc.vertex.bufferCount = 0;
                pipelineDesc.vertex.buffers = null;

                // Vertex shader
                pipelineDesc.vertex.module = shaderModule;
                pipelineDesc.vertex.entryPoint = pVertexEntryPoint;
                pipelineDesc.vertex.constantCount = 0;
                pipelineDesc.vertex.constants = null;

                // Primitive assembly and rasterization
                // Each sequence of 3 vertices is considered as a triangle
                pipelineDesc.primitive.topology = WGPUPrimitiveTopology.TriangleList;
                // We'll see later how to specify the order in which vertices should be
                // connected. When not specified, vertices are considered sequentially.
                pipelineDesc.primitive.stripIndexFormat = WGPUIndexFormat.Undefined;
                // The face orientation is defined by assuming that when looking
                // from the front of the face, its corner vertices are enumerated
                // in the counter-clockwise (CCW) order.
                pipelineDesc.primitive.frontFace = WGPUFrontFace.CCW;
                // But the face orientation does not matter much because we do not
                // cull (i.e. "hide") the faces pointing away from us (which is often
                // used for optimization).
                pipelineDesc.primitive.cullMode = WGPUCullMode.None;

                // Fragment shader
                WGPUFragmentState fragmentState = new()
                {
                    nextInChain = null,
                    module = shaderModule,
                    entryPoint = pFragmentEntryPoint,
                    constantCount = 0,
                    constants = null
                };
                pipelineDesc.fragment = &fragmentState;

                // Configure blend state
                WGPUBlendState blendState = new();
                // Usual alpha blending for the color:
                blendState.color.srcFactor = WGPUBlendFactor.SrcAlpha;
                blendState.color.dstFactor = WGPUBlendFactor.OneMinusSrcAlpha;
                blendState.color.operation = WGPUBlendOperation.Add;
                // We leave the target alpha untouched:
                blendState.alpha.srcFactor = WGPUBlendFactor.Zero;
                blendState.alpha.dstFactor = WGPUBlendFactor.One;
                blendState.alpha.operation = WGPUBlendOperation.Add;

                WGPUColorTargetState colorTarget = new()
                {
                    nextInChain = null,
                    format = _graphicsDevice.SwapChainFormat,
                    blend = &blendState,
                    writeMask = WGPUColorWriteMask.All // We could write to only some of the color channels.
                };

                // We have only one target because our render pass has only one output color
                // attachment.
                fragmentState.targetCount = 1;
                fragmentState.targets = &colorTarget;

                // Depth and stencil tests are not used here
                pipelineDesc.depthStencil = null;

                // Multi-sampling
                // Samples per pixel
                pipelineDesc.multisample.count = 1;
                // Default value for the mask, meaning "all bits on"
                pipelineDesc.multisample.mask = ~0u;
                // Default value as well (irrelevant for count = 1 anyways)
                pipelineDesc.multisample.alphaToCoverageEnabled = false;

                _pipeline = wgpuDeviceCreateRenderPipeline(_graphicsDevice.Device, &pipelineDesc);
            }

            wgpuShaderModuleRelease(shaderModule);
        }

        public override void Dispose()
        {
            wgpuPipelineLayoutRelease(_pipelineLayout);
            wgpuRenderPipelineRelease(_pipeline);

            _graphicsDevice.Dispose();

            base.Dispose();
        }

        protected override void OnTick()
        {
            _graphicsDevice!.RenderFrame(OnDraw);
        }

        private void OnDraw(WGPUCommandEncoder encoder, WGPUTextureView swapChainTextureView)
        {
            WGPURenderPassColorAttachment renderPassColorAttachment = new();
            // The attachment is tighed to the view returned by the swap chain, so that
            // the render pass draws directly on screen.
            renderPassColorAttachment.view = swapChainTextureView;
            // Not relevant here because we do not use multi-sampling
            renderPassColorAttachment.resolveTarget = WGPUTextureView.Null;
            renderPassColorAttachment.loadOp = WGPULoadOp.Clear;
            renderPassColorAttachment.storeOp = WGPUStoreOp.Store;
            renderPassColorAttachment.clearValue = new WGPUColor(0.9, 0.1, 0.2, 1.0);

            // Describe a render pass, which targets the texture view
            WGPURenderPassDescriptor renderPassDesc = new()
            {
                nextInChain = null,
                colorAttachmentCount = 1,
                colorAttachments = &renderPassColorAttachment,
                // No depth buffer for now
                depthStencilAttachment = null,

                // We do not use timers for now neither
                timestampWriteCount = 0,
                timestampWrites = null
            };

            // Create a render pass. We end it immediately because we use its built-in
            // mechanism for clearing the screen when it begins (see descriptor).
            WGPURenderPassEncoder renderPass = wgpuCommandEncoderBeginRenderPass(encoder, &renderPassDesc);

            wgpuRenderPassEncoderSetPipeline(renderPass, _pipeline);
            // Draw 1 instance of a 3-vertices shape
            wgpuRenderPassEncoderDraw(renderPass, 3, 1, 0, 0);

            wgpuRenderPassEncoderEnd(renderPass);
        }
    }
}
