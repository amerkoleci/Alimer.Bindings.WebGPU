// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

#pragma warning disable CS0649;
namespace WebGPU;

public partial struct WGPUAdapterProperties
{
	public unsafe WGPUChainedStructOut* nextInChain;
	public uint vendorID;
	public unsafe sbyte* vendorName;
	public unsafe sbyte* architecture;
	public uint deviceID;
	public unsafe sbyte* name;
	public unsafe sbyte* driverDescription;
	public WGPUAdapterType adapterType;
	public WGPUBackendType backendType;
}

public partial struct WGPUBindGroupEntry
{
	public unsafe WGPUChainedStruct* nextInChain;
	public uint binding;
	public WGPUBuffer buffer;
	public ulong offset;
	public ulong size;
	public WGPUSampler sampler;
	public WGPUTextureView textureView;
}

public partial struct WGPUBlendComponent
{
	public WGPUBlendOperation operation;
	public WGPUBlendFactor srcFactor;
	public WGPUBlendFactor dstFactor;
}

public partial struct WGPUBufferBindingLayout
{
	public unsafe WGPUChainedStruct* nextInChain;
	public WGPUBufferBindingType type;
	public bool hasDynamicOffset;
	public ulong minBindingSize;
}

public partial struct WGPUBufferDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
	public WGPUBufferUsage usage;
	public ulong size;
	public bool mappedAtCreation;
}

public partial struct WGPUColor
{
	public double r;
	public double g;
	public double b;
	public double a;
}

public partial struct WGPUCommandBufferDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
}

public partial struct WGPUCommandEncoderDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
}

public partial struct WGPUCompilationMessage
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* message;
	public WGPUCompilationMessageType type;
	public ulong lineNum;
	public ulong linePos;
	public ulong offset;
	public ulong length;
	public ulong utf16LinePos;
	public ulong utf16Offset;
	public ulong utf16Length;
}

public partial struct WGPUComputePassTimestampWrite
{
	public WGPUQuerySet querySet;
	public uint queryIndex;
	public WGPUComputePassTimestampLocation location;
}

public partial struct WGPUConstantEntry
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* key;
	public double value;
}

public partial struct WGPUExtent3D
{
	public uint width;
	public uint height;
	public uint depthOrArrayLayers;
}

public partial struct WGPUInstanceDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
}

public partial struct WGPULimits
{
	public uint maxTextureDimension1D;
	public uint maxTextureDimension2D;
	public uint maxTextureDimension3D;
	public uint maxTextureArrayLayers;
	public uint maxBindGroups;
	public uint maxBindingsPerBindGroup;
	public uint maxDynamicUniformBuffersPerPipelineLayout;
	public uint maxDynamicStorageBuffersPerPipelineLayout;
	public uint maxSampledTexturesPerShaderStage;
	public uint maxSamplersPerShaderStage;
	public uint maxStorageBuffersPerShaderStage;
	public uint maxStorageTexturesPerShaderStage;
	public uint maxUniformBuffersPerShaderStage;
	public ulong maxUniformBufferBindingSize;
	public ulong maxStorageBufferBindingSize;
	public uint minUniformBufferOffsetAlignment;
	public uint minStorageBufferOffsetAlignment;
	public uint maxVertexBuffers;
	public ulong maxBufferSize;
	public uint maxVertexAttributes;
	public uint maxVertexBufferArrayStride;
	public uint maxInterStageShaderComponents;
	public uint maxInterStageShaderVariables;
	public uint maxColorAttachments;
	public uint maxColorAttachmentBytesPerSample;
	public uint maxComputeWorkgroupStorageSize;
	public uint maxComputeInvocationsPerWorkgroup;
	public uint maxComputeWorkgroupSizeX;
	public uint maxComputeWorkgroupSizeY;
	public uint maxComputeWorkgroupSizeZ;
	public uint maxComputeWorkgroupsPerDimension;
}

public partial struct WGPUMultisampleState
{
	public unsafe WGPUChainedStruct* nextInChain;
	public uint count;
	public uint mask;
	public bool alphaToCoverageEnabled;
}

public partial struct WGPUOrigin3D
{
	public uint x;
	public uint y;
	public uint z;
}

public partial struct WGPUPipelineLayoutDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
	public nuint bindGroupLayoutCount;
	public unsafe WGPUBindGroupLayout* bindGroupLayouts;
}

public partial struct WGPUPrimitiveDepthClipControl
{
	public WGPUChainedStruct chain;
	public bool unclippedDepth;
}

public partial struct WGPUPrimitiveState
{
	public unsafe WGPUChainedStruct* nextInChain;
	public WGPUPrimitiveTopology topology;
	public WGPUIndexFormat stripIndexFormat;
	public WGPUFrontFace frontFace;
	public WGPUCullMode cullMode;
}

public partial struct WGPUQuerySetDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
	public WGPUQueryType type;
	public uint count;
	public unsafe WGPUPipelineStatisticName* pipelineStatistics;
	public nuint pipelineStatisticsCount;
}

public partial struct WGPUQueueDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
}

public partial struct WGPURenderBundleDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
}

public partial struct WGPURenderBundleEncoderDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
	public nuint colorFormatsCount;
	public unsafe WGPUTextureFormat* colorFormats;
	public WGPUTextureFormat depthStencilFormat;
	public uint sampleCount;
	public bool depthReadOnly;
	public bool stencilReadOnly;
}

public partial struct WGPURenderPassDepthStencilAttachment
{
	public WGPUTextureView view;
	public WGPULoadOp depthLoadOp;
	public WGPUStoreOp depthStoreOp;
	public float depthClearValue;
	public bool depthReadOnly;
	public WGPULoadOp stencilLoadOp;
	public WGPUStoreOp stencilStoreOp;
	public uint stencilClearValue;
	public bool stencilReadOnly;
}

public partial struct WGPURenderPassDescriptorMaxDrawCount
{
	public WGPUChainedStruct chain;
	public ulong maxDrawCount;
}

public partial struct WGPURenderPassTimestampWrite
{
	public WGPUQuerySet querySet;
	public uint queryIndex;
	public WGPURenderPassTimestampLocation location;
}

public partial struct WGPURequestAdapterOptions
{
	public unsafe WGPUChainedStruct* nextInChain;
	public WGPUSurface compatibleSurface;
	public WGPUPowerPreference powerPreference;
	public WGPUBackendType backendType;
	public bool forceFallbackAdapter;
}

public partial struct WGPUSamplerBindingLayout
{
	public unsafe WGPUChainedStruct* nextInChain;
	public WGPUSamplerBindingType type;
}

public partial struct WGPUSamplerDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
	public WGPUAddressMode addressModeU;
	public WGPUAddressMode addressModeV;
	public WGPUAddressMode addressModeW;
	public WGPUFilterMode magFilter;
	public WGPUFilterMode minFilter;
	public WGPUMipmapFilterMode mipmapFilter;
	public float lodMinClamp;
	public float lodMaxClamp;
	public WGPUCompareFunction compare;
	public ushort maxAnisotropy;
}

public partial struct WGPUShaderModuleCompilationHint
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* entryPoint;
	public WGPUPipelineLayout layout;
}

public partial struct WGPUShaderModuleSPIRVDescriptor
{
	public WGPUChainedStruct chain;
	public uint codeSize;
	public unsafe uint* code;
}

public partial struct WGPUShaderModuleWGSLDescriptor
{
	public WGPUChainedStruct chain;
	public unsafe sbyte* code;
}

public partial struct WGPUStencilFaceState
{
	public WGPUCompareFunction compare;
	public WGPUStencilOperation failOp;
	public WGPUStencilOperation depthFailOp;
	public WGPUStencilOperation passOp;
}

public partial struct WGPUStorageTextureBindingLayout
{
	public unsafe WGPUChainedStruct* nextInChain;
	public WGPUStorageTextureAccess access;
	public WGPUTextureFormat format;
	public WGPUTextureViewDimension viewDimension;
}

public partial struct WGPUSurfaceDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
}

public partial struct WGPUSurfaceDescriptorFromAndroidNativeWindow
{
	public WGPUChainedStruct chain;
	public nint window;
}

public partial struct WGPUSurfaceDescriptorFromCanvasHTMLSelector
{
	public WGPUChainedStruct chain;
	public unsafe sbyte* selector;
}

public partial struct WGPUSurfaceDescriptorFromMetalLayer
{
	public WGPUChainedStruct chain;
	public nint layer;
}

public partial struct WGPUSurfaceDescriptorFromWaylandSurface
{
	public WGPUChainedStruct chain;
	public nint display;
	public nint surface;
}

public partial struct WGPUSurfaceDescriptorFromWindowsHWND
{
	public WGPUChainedStruct chain;
	public nint hinstance;
	public nint hwnd;
}

public partial struct WGPUSurfaceDescriptorFromXcbWindow
{
	public WGPUChainedStruct chain;
	public nint connection;
	public uint window;
}

public partial struct WGPUSurfaceDescriptorFromXlibWindow
{
	public WGPUChainedStruct chain;
	public nint display;
	public uint window;
}

public partial struct WGPUSwapChainDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
	public WGPUTextureUsage usage;
	public WGPUTextureFormat format;
	public uint width;
	public uint height;
	public WGPUPresentMode presentMode;
}

public partial struct WGPUTextureBindingLayout
{
	public unsafe WGPUChainedStruct* nextInChain;
	public WGPUTextureSampleType sampleType;
	public WGPUTextureViewDimension viewDimension;
	public bool multisampled;
}

public partial struct WGPUTextureDataLayout
{
	public unsafe WGPUChainedStruct* nextInChain;
	public ulong offset;
	public uint bytesPerRow;
	public uint rowsPerImage;
}

public partial struct WGPUTextureViewDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
	public WGPUTextureFormat format;
	public WGPUTextureViewDimension dimension;
	public uint baseMipLevel;
	public uint mipLevelCount;
	public uint baseArrayLayer;
	public uint arrayLayerCount;
	public WGPUTextureAspect aspect;
}

public partial struct WGPUVertexAttribute
{
	public WGPUVertexFormat format;
	public ulong offset;
	public uint shaderLocation;
}

public partial struct WGPUBindGroupDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
	public WGPUBindGroupLayout layout;
	public nuint entryCount;
	public unsafe WGPUBindGroupEntry* entries;
}

public partial struct WGPUBindGroupLayoutEntry
{
	public unsafe WGPUChainedStruct* nextInChain;
	public uint binding;
	public WGPUShaderStage visibility;
	public WGPUBufferBindingLayout buffer;
	public WGPUSamplerBindingLayout sampler;
	public WGPUTextureBindingLayout texture;
	public WGPUStorageTextureBindingLayout storageTexture;
}

public partial struct WGPUBlendState
{
	public WGPUBlendComponent color;
	public WGPUBlendComponent alpha;
}

public partial struct WGPUCompilationInfo
{
	public unsafe WGPUChainedStruct* nextInChain;
	public nuint messageCount;
	public unsafe WGPUCompilationMessage* messages;
}

public partial struct WGPUComputePassDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
	public nuint timestampWriteCount;
	public unsafe WGPUComputePassTimestampWrite* timestampWrites;
}

public partial struct WGPUDepthStencilState
{
	public unsafe WGPUChainedStruct* nextInChain;
	public WGPUTextureFormat format;
	public bool depthWriteEnabled;
	public WGPUCompareFunction depthCompare;
	public WGPUStencilFaceState stencilFront;
	public WGPUStencilFaceState stencilBack;
	public uint stencilReadMask;
	public uint stencilWriteMask;
	public int depthBias;
	public float depthBiasSlopeScale;
	public float depthBiasClamp;
}

public partial struct WGPUImageCopyBuffer
{
	public unsafe WGPUChainedStruct* nextInChain;
	public WGPUTextureDataLayout layout;
	public WGPUBuffer buffer;
}

public partial struct WGPUImageCopyTexture
{
	public unsafe WGPUChainedStruct* nextInChain;
	public WGPUTexture texture;
	public uint mipLevel;
	public WGPUOrigin3D origin;
	public WGPUTextureAspect aspect;
}

public partial struct WGPUProgrammableStageDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public WGPUShaderModule module;
	public unsafe sbyte* entryPoint;
	public nuint constantCount;
	public unsafe WGPUConstantEntry* constants;
}

public partial struct WGPURenderPassColorAttachment
{
	public WGPUTextureView view;
	public WGPUTextureView resolveTarget;
	public WGPULoadOp loadOp;
	public WGPUStoreOp storeOp;
	public WGPUColor clearValue;
}

public partial struct WGPURequiredLimits
{
	public unsafe WGPUChainedStruct* nextInChain;
	public WGPULimits limits;
}

public partial struct WGPUShaderModuleDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
	public nuint hintCount;
	public unsafe WGPUShaderModuleCompilationHint* hints;
}

public partial struct WGPUSupportedLimits
{
	public unsafe WGPUChainedStructOut* nextInChain;
	public WGPULimits limits;
}

public partial struct WGPUTextureDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
	public WGPUTextureUsage usage;
	public WGPUTextureDimension dimension;
	public WGPUExtent3D size;
	public WGPUTextureFormat format;
	public uint mipLevelCount;
	public uint sampleCount;
	public nuint viewFormatCount;
	public unsafe WGPUTextureFormat* viewFormats;
}

public partial struct WGPUVertexBufferLayout
{
	public ulong arrayStride;
	public WGPUVertexStepMode stepMode;
	public nuint attributeCount;
	public unsafe WGPUVertexAttribute* attributes;
}

public partial struct WGPUBindGroupLayoutDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
	public nuint entryCount;
	public unsafe WGPUBindGroupLayoutEntry* entries;
}

public partial struct WGPUColorTargetState
{
	public unsafe WGPUChainedStruct* nextInChain;
	public WGPUTextureFormat format;
	public unsafe WGPUBlendState* blend;
	public WGPUColorWriteMask writeMask;
}

public partial struct WGPUComputePipelineDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
	public WGPUPipelineLayout layout;
	public WGPUProgrammableStageDescriptor compute;
}

public partial struct WGPUDeviceDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
	public nuint requiredFeaturesCount;
	public unsafe WGPUFeatureName* requiredFeatures;
	public unsafe WGPURequiredLimits* requiredLimits;
	public WGPUQueueDescriptor defaultQueue;
	public unsafe delegate* unmanaged<WGPUDeviceLostReason, sbyte*, nint, void> deviceLostCallback;
	public nint deviceLostUserdata;
}

public partial struct WGPURenderPassDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
	public nuint colorAttachmentCount;
	public unsafe WGPURenderPassColorAttachment* colorAttachments;
	public unsafe WGPURenderPassDepthStencilAttachment* depthStencilAttachment;
	public WGPUQuerySet occlusionQuerySet;
	public nuint timestampWriteCount;
	public unsafe WGPURenderPassTimestampWrite* timestampWrites;
}

public partial struct WGPUVertexState
{
	public unsafe WGPUChainedStruct* nextInChain;
	public WGPUShaderModule module;
	public unsafe sbyte* entryPoint;
	public nuint constantCount;
	public unsafe WGPUConstantEntry* constants;
	public nuint bufferCount;
	public unsafe WGPUVertexBufferLayout* buffers;
}

public partial struct WGPUFragmentState
{
	public unsafe WGPUChainedStruct* nextInChain;
	public WGPUShaderModule module;
	public unsafe sbyte* entryPoint;
	public nuint constantCount;
	public unsafe WGPUConstantEntry* constants;
	public nuint targetCount;
	public unsafe WGPUColorTargetState* targets;
}

public partial struct WGPURenderPipelineDescriptor
{
	public unsafe WGPUChainedStruct* nextInChain;
	public unsafe sbyte* label;
	public WGPUPipelineLayout layout;
	public WGPUVertexState vertex;
	public WGPUPrimitiveState primitive;
	public unsafe WGPUDepthStencilState* depthStencil;
	public WGPUMultisampleState multisample;
	public unsafe WGPUFragmentState* fragment;
}

public partial struct WGPUChainedStruct
{
	public unsafe WGPUChainedStruct* next;
	public WGPUSType sType;
}

public partial struct WGPUChainedStructOut
{
	public unsafe WGPUChainedStructOut* next;
	public WGPUSType sType;
}

public partial struct WGPUInstanceExtras
{
	public WGPUChainedStruct chain;
	public WGPUInstanceBackend backends;
	public WGPUDx12Compiler dx12ShaderCompiler;
	public unsafe sbyte* dxilPath;
	public unsafe sbyte* dxcPath;
}

public partial struct WGPUDeviceExtras
{
	public WGPUChainedStruct chain;
	public unsafe sbyte* tracePath;
}

public partial struct WGPURequiredLimitsExtras
{
	public WGPUChainedStruct chain;
	public uint maxPushConstantSize;
}

public partial struct WGPUSupportedLimitsExtras
{
	public WGPUChainedStructOut chain;
	public uint maxPushConstantSize;
}

public partial struct WGPUPushConstantRange
{
	public WGPUShaderStage stages;
	public uint start;
	public uint end;
}

public partial struct WGPUPipelineLayoutExtras
{
	public WGPUChainedStruct chain;
	public uint pushConstantRangeCount;
	public unsafe WGPUPushConstantRange* pushConstantRanges;
}

public partial struct WGPUWrappedSubmissionIndex
{
	public WGPUQueue queue;
	public ulong submissionIndex;
}

public partial struct WGPUShaderDefine
{
	public unsafe sbyte* name;
	public unsafe sbyte* value;
}

public partial struct WGPUShaderModuleGLSLDescriptor
{
	public WGPUChainedStruct chain;
	public WGPUShaderStage stage;
	public unsafe sbyte* code;
	public uint defineCount;
	public unsafe WGPUShaderDefine* defines;
}

public partial struct WGPUStorageReport
{
	public nuint numOccupied;
	public nuint numVacant;
	public nuint numError;
	public nuint elementSize;
}

public partial struct WGPUHubReport
{
	public WGPUStorageReport adapters;
	public WGPUStorageReport devices;
	public WGPUStorageReport pipelineLayouts;
	public WGPUStorageReport shaderModules;
	public WGPUStorageReport bindGroupLayouts;
	public WGPUStorageReport bindGroups;
	public WGPUStorageReport commandBuffers;
	public WGPUStorageReport renderBundles;
	public WGPUStorageReport renderPipelines;
	public WGPUStorageReport computePipelines;
	public WGPUStorageReport querySets;
	public WGPUStorageReport buffers;
	public WGPUStorageReport textures;
	public WGPUStorageReport textureViews;
	public WGPUStorageReport samplers;
}

public partial struct WGPUGlobalReport
{
	public WGPUStorageReport surfaces;
	public WGPUBackendType backendType;
	public WGPUHubReport vulkan;
	public WGPUHubReport metal;
	public WGPUHubReport dx12;
	public WGPUHubReport dx11;
	public WGPUHubReport gl;
}

public partial struct WGPUSurfaceCapabilities
{
	public nuint formatCount;
	public unsafe WGPUTextureFormat* formats;
	public nuint presentModeCount;
	public unsafe WGPUPresentMode* presentModes;
	public nuint alphaModeCount;
	public unsafe WGPUCompositeAlphaMode* alphaModes;
}

public partial struct WGPUSwapChainDescriptorExtras
{
	public WGPUChainedStruct chain;
	public WGPUCompositeAlphaMode alphaMode;
	public nuint viewFormatCount;
	public unsafe WGPUTextureFormat* viewFormats;
}

public partial struct WGPUInstanceEnumerateAdapterOptions
{
	public unsafe WGPUChainedStruct* nextInChain;
	public WGPUInstanceBackend backends;
}

