// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System.Diagnostics;

namespace WebGPU;

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUAdapter : IEquatable<WGPUAdapter>
{
	public WGPUAdapter(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUAdapter Null => new(0);
	public static implicit operator WGPUAdapter(nint handle) => new(handle);
	public static bool operator ==(WGPUAdapter left, WGPUAdapter right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUAdapter left, WGPUAdapter right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUAdapter left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUAdapter left, nint right) => left.Handle != right;
	public bool Equals(WGPUAdapter other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUAdapter handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUAdapter)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUBindGroup : IEquatable<WGPUBindGroup>
{
	public WGPUBindGroup(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUBindGroup Null => new(0);
	public static implicit operator WGPUBindGroup(nint handle) => new(handle);
	public static bool operator ==(WGPUBindGroup left, WGPUBindGroup right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUBindGroup left, WGPUBindGroup right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUBindGroup left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUBindGroup left, nint right) => left.Handle != right;
	public bool Equals(WGPUBindGroup other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUBindGroup handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUBindGroup)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUBindGroupLayout : IEquatable<WGPUBindGroupLayout>
{
	public WGPUBindGroupLayout(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUBindGroupLayout Null => new(0);
	public static implicit operator WGPUBindGroupLayout(nint handle) => new(handle);
	public static bool operator ==(WGPUBindGroupLayout left, WGPUBindGroupLayout right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUBindGroupLayout left, WGPUBindGroupLayout right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUBindGroupLayout left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUBindGroupLayout left, nint right) => left.Handle != right;
	public bool Equals(WGPUBindGroupLayout other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUBindGroupLayout handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUBindGroupLayout)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUBuffer : IEquatable<WGPUBuffer>
{
	public WGPUBuffer(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUBuffer Null => new(0);
	public static implicit operator WGPUBuffer(nint handle) => new(handle);
	public static bool operator ==(WGPUBuffer left, WGPUBuffer right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUBuffer left, WGPUBuffer right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUBuffer left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUBuffer left, nint right) => left.Handle != right;
	public bool Equals(WGPUBuffer other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUBuffer handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUBuffer)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUCommandBuffer : IEquatable<WGPUCommandBuffer>
{
	public WGPUCommandBuffer(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUCommandBuffer Null => new(0);
	public static implicit operator WGPUCommandBuffer(nint handle) => new(handle);
	public static bool operator ==(WGPUCommandBuffer left, WGPUCommandBuffer right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUCommandBuffer left, WGPUCommandBuffer right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUCommandBuffer left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUCommandBuffer left, nint right) => left.Handle != right;
	public bool Equals(WGPUCommandBuffer other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUCommandBuffer handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUCommandBuffer)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUCommandEncoder : IEquatable<WGPUCommandEncoder>
{
	public WGPUCommandEncoder(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUCommandEncoder Null => new(0);
	public static implicit operator WGPUCommandEncoder(nint handle) => new(handle);
	public static bool operator ==(WGPUCommandEncoder left, WGPUCommandEncoder right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUCommandEncoder left, WGPUCommandEncoder right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUCommandEncoder left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUCommandEncoder left, nint right) => left.Handle != right;
	public bool Equals(WGPUCommandEncoder other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUCommandEncoder handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUCommandEncoder)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUComputePassEncoder : IEquatable<WGPUComputePassEncoder>
{
	public WGPUComputePassEncoder(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUComputePassEncoder Null => new(0);
	public static implicit operator WGPUComputePassEncoder(nint handle) => new(handle);
	public static bool operator ==(WGPUComputePassEncoder left, WGPUComputePassEncoder right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUComputePassEncoder left, WGPUComputePassEncoder right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUComputePassEncoder left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUComputePassEncoder left, nint right) => left.Handle != right;
	public bool Equals(WGPUComputePassEncoder other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUComputePassEncoder handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUComputePassEncoder)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUComputePipeline : IEquatable<WGPUComputePipeline>
{
	public WGPUComputePipeline(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUComputePipeline Null => new(0);
	public static implicit operator WGPUComputePipeline(nint handle) => new(handle);
	public static bool operator ==(WGPUComputePipeline left, WGPUComputePipeline right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUComputePipeline left, WGPUComputePipeline right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUComputePipeline left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUComputePipeline left, nint right) => left.Handle != right;
	public bool Equals(WGPUComputePipeline other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUComputePipeline handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUComputePipeline)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUDevice : IEquatable<WGPUDevice>
{
	public WGPUDevice(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUDevice Null => new(0);
	public static implicit operator WGPUDevice(nint handle) => new(handle);
	public static bool operator ==(WGPUDevice left, WGPUDevice right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUDevice left, WGPUDevice right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUDevice left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUDevice left, nint right) => left.Handle != right;
	public bool Equals(WGPUDevice other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUDevice handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUDevice)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUInstance : IEquatable<WGPUInstance>
{
	public WGPUInstance(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUInstance Null => new(0);
	public static implicit operator WGPUInstance(nint handle) => new(handle);
	public static bool operator ==(WGPUInstance left, WGPUInstance right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUInstance left, WGPUInstance right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUInstance left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUInstance left, nint right) => left.Handle != right;
	public bool Equals(WGPUInstance other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUInstance handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUInstance)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUPipelineLayout : IEquatable<WGPUPipelineLayout>
{
	public WGPUPipelineLayout(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUPipelineLayout Null => new(0);
	public static implicit operator WGPUPipelineLayout(nint handle) => new(handle);
	public static bool operator ==(WGPUPipelineLayout left, WGPUPipelineLayout right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUPipelineLayout left, WGPUPipelineLayout right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUPipelineLayout left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUPipelineLayout left, nint right) => left.Handle != right;
	public bool Equals(WGPUPipelineLayout other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUPipelineLayout handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUPipelineLayout)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUQuerySet : IEquatable<WGPUQuerySet>
{
	public WGPUQuerySet(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUQuerySet Null => new(0);
	public static implicit operator WGPUQuerySet(nint handle) => new(handle);
	public static bool operator ==(WGPUQuerySet left, WGPUQuerySet right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUQuerySet left, WGPUQuerySet right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUQuerySet left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUQuerySet left, nint right) => left.Handle != right;
	public bool Equals(WGPUQuerySet other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUQuerySet handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUQuerySet)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUQueue : IEquatable<WGPUQueue>
{
	public WGPUQueue(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUQueue Null => new(0);
	public static implicit operator WGPUQueue(nint handle) => new(handle);
	public static bool operator ==(WGPUQueue left, WGPUQueue right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUQueue left, WGPUQueue right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUQueue left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUQueue left, nint right) => left.Handle != right;
	public bool Equals(WGPUQueue other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUQueue handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUQueue)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPURenderBundle : IEquatable<WGPURenderBundle>
{
	public WGPURenderBundle(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPURenderBundle Null => new(0);
	public static implicit operator WGPURenderBundle(nint handle) => new(handle);
	public static bool operator ==(WGPURenderBundle left, WGPURenderBundle right) => left.Handle == right.Handle;
	public static bool operator !=(WGPURenderBundle left, WGPURenderBundle right) => left.Handle != right.Handle;
	public static bool operator ==(WGPURenderBundle left, nint right) => left.Handle == right;
	public static bool operator !=(WGPURenderBundle left, nint right) => left.Handle != right;
	public bool Equals(WGPURenderBundle other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPURenderBundle handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPURenderBundle)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPURenderBundleEncoder : IEquatable<WGPURenderBundleEncoder>
{
	public WGPURenderBundleEncoder(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPURenderBundleEncoder Null => new(0);
	public static implicit operator WGPURenderBundleEncoder(nint handle) => new(handle);
	public static bool operator ==(WGPURenderBundleEncoder left, WGPURenderBundleEncoder right) => left.Handle == right.Handle;
	public static bool operator !=(WGPURenderBundleEncoder left, WGPURenderBundleEncoder right) => left.Handle != right.Handle;
	public static bool operator ==(WGPURenderBundleEncoder left, nint right) => left.Handle == right;
	public static bool operator !=(WGPURenderBundleEncoder left, nint right) => left.Handle != right;
	public bool Equals(WGPURenderBundleEncoder other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPURenderBundleEncoder handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPURenderBundleEncoder)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPURenderPassEncoder : IEquatable<WGPURenderPassEncoder>
{
	public WGPURenderPassEncoder(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPURenderPassEncoder Null => new(0);
	public static implicit operator WGPURenderPassEncoder(nint handle) => new(handle);
	public static bool operator ==(WGPURenderPassEncoder left, WGPURenderPassEncoder right) => left.Handle == right.Handle;
	public static bool operator !=(WGPURenderPassEncoder left, WGPURenderPassEncoder right) => left.Handle != right.Handle;
	public static bool operator ==(WGPURenderPassEncoder left, nint right) => left.Handle == right;
	public static bool operator !=(WGPURenderPassEncoder left, nint right) => left.Handle != right;
	public bool Equals(WGPURenderPassEncoder other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPURenderPassEncoder handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPURenderPassEncoder)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPURenderPipeline : IEquatable<WGPURenderPipeline>
{
	public WGPURenderPipeline(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPURenderPipeline Null => new(0);
	public static implicit operator WGPURenderPipeline(nint handle) => new(handle);
	public static bool operator ==(WGPURenderPipeline left, WGPURenderPipeline right) => left.Handle == right.Handle;
	public static bool operator !=(WGPURenderPipeline left, WGPURenderPipeline right) => left.Handle != right.Handle;
	public static bool operator ==(WGPURenderPipeline left, nint right) => left.Handle == right;
	public static bool operator !=(WGPURenderPipeline left, nint right) => left.Handle != right;
	public bool Equals(WGPURenderPipeline other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPURenderPipeline handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPURenderPipeline)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUSampler : IEquatable<WGPUSampler>
{
	public WGPUSampler(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUSampler Null => new(0);
	public static implicit operator WGPUSampler(nint handle) => new(handle);
	public static bool operator ==(WGPUSampler left, WGPUSampler right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUSampler left, WGPUSampler right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUSampler left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUSampler left, nint right) => left.Handle != right;
	public bool Equals(WGPUSampler other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUSampler handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUSampler)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUShaderModule : IEquatable<WGPUShaderModule>
{
	public WGPUShaderModule(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUShaderModule Null => new(0);
	public static implicit operator WGPUShaderModule(nint handle) => new(handle);
	public static bool operator ==(WGPUShaderModule left, WGPUShaderModule right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUShaderModule left, WGPUShaderModule right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUShaderModule left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUShaderModule left, nint right) => left.Handle != right;
	public bool Equals(WGPUShaderModule other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUShaderModule handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUShaderModule)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUSurface : IEquatable<WGPUSurface>
{
	public WGPUSurface(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUSurface Null => new(0);
	public static implicit operator WGPUSurface(nint handle) => new(handle);
	public static bool operator ==(WGPUSurface left, WGPUSurface right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUSurface left, WGPUSurface right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUSurface left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUSurface left, nint right) => left.Handle != right;
	public bool Equals(WGPUSurface other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUSurface handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUSurface)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUSwapChain : IEquatable<WGPUSwapChain>
{
	public WGPUSwapChain(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUSwapChain Null => new(0);
	public static implicit operator WGPUSwapChain(nint handle) => new(handle);
	public static bool operator ==(WGPUSwapChain left, WGPUSwapChain right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUSwapChain left, WGPUSwapChain right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUSwapChain left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUSwapChain left, nint right) => left.Handle != right;
	public bool Equals(WGPUSwapChain other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUSwapChain handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUSwapChain)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUTexture : IEquatable<WGPUTexture>
{
	public WGPUTexture(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUTexture Null => new(0);
	public static implicit operator WGPUTexture(nint handle) => new(handle);
	public static bool operator ==(WGPUTexture left, WGPUTexture right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUTexture left, WGPUTexture right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUTexture left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUTexture left, nint right) => left.Handle != right;
	public bool Equals(WGPUTexture other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUTexture handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUTexture)} [0x{Handle.ToString("X")}]";
}

[DebuggerDisplay("{DebuggerDisplay,nq}")]
public readonly partial struct WGPUTextureView : IEquatable<WGPUTextureView>
{
	public WGPUTextureView(nint handle) { Handle = handle; }
	public nint Handle { get; }
	public bool IsNull => Handle == 0;
	public bool IsNotNull => Handle != 0;
	public static WGPUTextureView Null => new(0);
	public static implicit operator WGPUTextureView(nint handle) => new(handle);
	public static bool operator ==(WGPUTextureView left, WGPUTextureView right) => left.Handle == right.Handle;
	public static bool operator !=(WGPUTextureView left, WGPUTextureView right) => left.Handle != right.Handle;
	public static bool operator ==(WGPUTextureView left, nint right) => left.Handle == right;
	public static bool operator !=(WGPUTextureView left, nint right) => left.Handle != right;
	public bool Equals(WGPUTextureView other) => Handle == other.Handle;
	/// <inheritdoc/>
	public override bool Equals(object? obj) => obj is WGPUTextureView handle && Equals(handle);
	/// <inheritdoc/>
	public override int GetHashCode() => Handle.GetHashCode();
	private string DebuggerDisplay => $"{nameof(WGPUTextureView)} [0x{Handle.ToString("X")}]";
}

