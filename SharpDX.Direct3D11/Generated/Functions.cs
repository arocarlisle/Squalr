// Copyright (c) 2010-2014 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

//------------------------------------------------------------------------------
// <auto-generated>
//     Types declaration for SharpDX.Direct3D11 namespace.
//     This code was generated by a tool.
//     Date : 6/25/2016 10:38:14 PM
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
namespace SharpDX.Direct3D11 {

#pragma warning disable 419
#pragma warning disable 1587
#pragma warning disable 1574

        /// <summary>	
        /// Functions	
        /// </summary>	
        /// <include file='.\..\Documentation\CodeComments.xml' path="/comments/comment[@id='SharpDX.Direct3D11.CommonShaderStage']/*"/>	
    public abstract  partial class CommonShaderStage {   
        
        /// <summary>Constant SamplerRegisterComponents.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_SAMPLER_REGISTER_COMPONENTS</unmanaged>
        public const int SamplerRegisterComponents = 1;
        
        /// <summary>Constant SamplerRegisterCount.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_SAMPLER_REGISTER_COUNT</unmanaged>
        public const int SamplerRegisterCount = 16;
        
        /// <summary>Constant ConstantBufferComponentBitCount.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENT_BIT_COUNT</unmanaged>
        public const int ConstantBufferComponentBitCount = 32;
        
        /// <summary>Constant TextureCoordRangeReductionMinimum.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MIN</unmanaged>
        public const int TextureCoordRangeReductionMinimum = -0x00000000a;
        
        /// <summary>Constant TempRegisterComponents.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENTS</unmanaged>
        public const int TempRegisterComponents = 4;
        
        /// <summary>Constant ConstantBufferPartialUpdateExtentsByteAlignment.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_CONSTANT_BUFFER_PARTIAL_UPDATE_EXTENTS_BYTE_ALIGNMENT</unmanaged>
        public const int ConstantBufferPartialUpdateExtentsByteAlignment = 16;
        
        /// <summary>Constant InputResourceSlotCount.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT</unmanaged>
        public const int InputResourceSlotCount = 128;
        
        /// <summary>Constant ImmediateConstantBufferRegisterCount.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COUNT</unmanaged>
        public const int ImmediateConstantBufferRegisterCount = 1;
        
        /// <summary>Constant TextureElOffsetMaximumPositive.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_POSITIVE</unmanaged>
        public const int TextureElOffsetMaximumPositive = 7;
        
        /// <summary>Constant ConstantBufferComponents.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_CONSTANT_BUFFER_COMPONENTS</unmanaged>
        public const int ConstantBufferComponents = 4;
        
        /// <summary>Constant TempRegisterReadsPerInst.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_TEMP_REGISTER_READS_PER_INST</unmanaged>
        public const int TempRegisterReadsPerInst = 3;
        
        /// <summary>Constant SubRoutineNestingLimit.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_SUBROUTINE_NESTING_LIMIT</unmanaged>
        public const int SubRoutineNestingLimit = 32;
        
        /// <summary>Constant ImmediateConstantBufferRegisterReadPorts.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READ_PORTS</unmanaged>
        public const int ImmediateConstantBufferRegisterReadPorts = 1;
        
        /// <summary>Constant ConstantBufferApiSlotCount.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT</unmanaged>
        public const int ConstantBufferApiSlotCount = 14;
        
        /// <summary>Constant InputResourceRegisterReadPorts.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READ_PORTS</unmanaged>
        public const int InputResourceRegisterReadPorts = 1;
        
        /// <summary>Constant ImmediateConstantBufferRegisterReadsPerInst.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_READS_PER_INST</unmanaged>
        public const int ImmediateConstantBufferRegisterReadsPerInst = 1;
        
        /// <summary>Constant InputResourceRegisterCount.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COUNT</unmanaged>
        public const int InputResourceRegisterCount = 128;
        
        /// <summary>Constant InputResourceRegisterReadsPerInst.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_READS_PER_INST</unmanaged>
        public const int InputResourceRegisterReadsPerInst = 1;
        
        /// <summary>Constant ConstantBufferRegisterReadPorts.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READ_PORTS</unmanaged>
        public const int ConstantBufferRegisterReadPorts = 1;
        
        /// <summary>Constant FlowcontrolNestingLimit.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_FLOWCONTROL_NESTING_LIMIT</unmanaged>
        public const int FlowcontrolNestingLimit = 64;
        
        /// <summary>Constant ImmediateValueComponentBitCount.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_IMMEDIATE_VALUE_COMPONENT_BIT_COUNT</unmanaged>
        public const int ImmediateValueComponentBitCount = 32;
        
        /// <summary>Constant SamplerRegisterReadsPerInst.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_SAMPLER_REGISTER_READS_PER_INST</unmanaged>
        public const int SamplerRegisterReadsPerInst = 1;
        
        /// <summary>Constant TempRegisterComponentBitCount.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_TEMP_REGISTER_COMPONENT_BIT_COUNT</unmanaged>
        public const int TempRegisterComponentBitCount = 32;
        
        /// <summary>Constant SamplerRegisterReadPorts.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_SAMPLER_REGISTER_READ_PORTS</unmanaged>
        public const int SamplerRegisterReadPorts = 1;
        
        /// <summary>Constant TextureElOffsetMaximumNegative.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_TEXEL_OFFSET_MAX_NEGATIVE</unmanaged>
        public const int TextureElOffsetMaximumNegative = -0x000000008;
        
        /// <summary>Constant TextureCoordRangeReductionMaximum.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_TEXCOORD_RANGE_REDUCTION_MAX</unmanaged>
        public const int TextureCoordRangeReductionMaximum = 10;
        
        /// <summary>Constant TempRegisterCount.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_TEMP_REGISTER_COUNT</unmanaged>
        public const int TempRegisterCount = 4096;
        
        /// <summary>Constant ConstantBufferRegisterCount.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COUNT</unmanaged>
        public const int ConstantBufferRegisterCount = 15;
        
        /// <summary>Constant ImmediateConstantBufferRegisterComponents.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_IMMEDIATE_CONSTANT_BUFFER_REGISTER_COMPONENTS</unmanaged>
        public const int ImmediateConstantBufferRegisterComponents = 4;
        
        /// <summary>Constant TempRegisterReadPorts.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_TEMP_REGISTER_READ_PORTS</unmanaged>
        public const int TempRegisterReadPorts = 3;
        
        /// <summary>Constant InputResourceRegisterComponents.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_INPUT_RESOURCE_REGISTER_COMPONENTS</unmanaged>
        public const int InputResourceRegisterComponents = 1;
        
        /// <summary>Constant ConstantBufferRegisterComponents.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_COMPONENTS</unmanaged>
        public const int ConstantBufferRegisterComponents = 4;
        
        /// <summary>Constant ConstantBufferHwSlotCount.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_CONSTANT_BUFFER_HW_SLOT_COUNT</unmanaged>
        public const int ConstantBufferHwSlotCount = 15;
        
        /// <summary>Constant SamplerSlotCount.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT</unmanaged>
        public const int SamplerSlotCount = 16;
        
        /// <summary>Constant ConstantBufferRegisterReadsPerInst.</summary>
        /// <unmanaged>D3D11_COMMONSHADER_CONSTANT_BUFFER_REGISTER_READS_PER_INST</unmanaged>
        public const int ConstantBufferRegisterReadsPerInst = 1;
    }
        /// <summary>	
        /// Functions	
        /// </summary>	
        /// <include file='.\..\Documentation\CodeComments.xml' path="/comments/comment[@id='SharpDX.Direct3D11.D3D11']/*"/>	
    static  partial class D3D11 {   
        
        /// <summary>Constant SdkVersion.</summary>
        /// <unmanaged>D3D11_SDK_VERSION</unmanaged>
        public const int SdkVersion = 7;
        
        /// <summary>	
        /// <p>Creates a device that represents the display adapter.</p>	
        /// </summary>	
        /// <param name="adapterRef"><dd>  <p>A reference to the video adapter to use when creating a device. Pass <strong><c>null</c></strong> to use the default adapter, which is the first adapter that is enumerated by <strong>IDXGIFactory1::EnumAdapters</strong>. </p> <p><strong>Note</strong>??Do not mix the use of DXGI 1.0 (<strong><see cref="SharpDX.DXGI.Factory"/></strong>) and DXGI 1.1 (<strong><see cref="SharpDX.DXGI.Factory1"/></strong>) in an application. Use <strong><see cref="SharpDX.DXGI.Factory"/></strong> or <strong><see cref="SharpDX.DXGI.Factory1"/></strong>, but not both in an application.</p> </dd></param>	
        /// <param name="driverType"><dd>  <p>The <strong><see cref="SharpDX.Direct3D.DriverType"/></strong>, which represents the driver type to create.</p> </dd></param>	
        /// <param name="software"><dd>  <p>A handle to a DLL that implements a software rasterizer.  If <em>DriverType</em> is <em><see cref="SharpDX.Direct3D.DriverType.Software"/></em>,  <em>Software</em> must not be <strong><c>null</c></strong>. Get the handle by  calling LoadLibrary,  LoadLibraryEx ,  or GetModuleHandle.</p> </dd></param>	
        /// <param name="flags"><dd>  <p>The runtime layers to enable (see <strong><see cref="SharpDX.Direct3D11.DeviceCreationFlags"/></strong>);  values can be bitwise OR'd together.</p> </dd></param>	
        /// <param name="featureLevelsRef"><dd>  <p>A reference to an array of <strong><see cref="SharpDX.Direct3D.FeatureLevel"/></strong>s, which determine the order of feature levels to attempt to create.  If <em>pFeatureLevels</em> is set to <strong><c>null</c></strong>,  this function uses the following array of feature levels:</p>  <pre> { <see cref="SharpDX.Direct3D.FeatureLevel.Level_11_0"/>, <see cref="SharpDX.Direct3D.FeatureLevel.Level_10_1"/>, <see cref="SharpDX.Direct3D.FeatureLevel.Level_10_0"/>, <see cref="SharpDX.Direct3D.FeatureLevel.Level_9_3"/>, <see cref="SharpDX.Direct3D.FeatureLevel.Level_9_2"/>, <see cref="SharpDX.Direct3D.FeatureLevel.Level_9_1"/>,}; </pre>  <p><strong>Note</strong>??If the Direct3D 11.1 runtime is present on the computer and <em>pFeatureLevels</em> is set to <strong><c>null</c></strong>, this function won't create a <strong><see cref="SharpDX.Direct3D.FeatureLevel.Level_11_1"/></strong> device. To create a <strong><see cref="SharpDX.Direct3D.FeatureLevel.Level_11_1"/></strong> device, you must explicitly provide a <strong><see cref="SharpDX.Direct3D.FeatureLevel"/></strong> array that includes <strong><see cref="SharpDX.Direct3D.FeatureLevel.Level_11_1"/></strong>. If you provide a <strong><see cref="SharpDX.Direct3D.FeatureLevel"/></strong> array that contains <strong><see cref="SharpDX.Direct3D.FeatureLevel.Level_11_1"/></strong> on a computer that doesn't have the Direct3D 11.1 runtime installed, this function immediately fails with E_INVALIDARG.</p> </dd></param>	
        /// <param name="featureLevels"><dd>  <p>The number of elements in <em>pFeatureLevels</em>.</p> </dd></param>	
        /// <param name="sDKVersion"><dd>  <p>The SDK version; use <em><see cref="SharpDX.Direct3D11.D3D11.SdkVersion"/></em>.</p> </dd></param>	
        /// <param name="deviceOut"><dd>  <p>Returns the address of a reference to an <strong><see cref="SharpDX.Direct3D11.Device"/></strong> object that represents the device created.</p> </dd></param>	
        /// <param name="featureLevelRef"><dd>  <p>If successful, returns the first <strong><see cref="SharpDX.Direct3D.FeatureLevel"/></strong> from the <em>pFeatureLevels</em> array which succeeded. Otherwise, returns 0.</p> </dd></param>	
        /// <param name="immediateContextOut"><dd>  <p>Returns the address of a reference to an <strong><see cref="SharpDX.Direct3D11.DeviceContext"/></strong> object that represents the device context.</p> </dd></param>	
        /// <returns><p>This method can return one of the Direct3D 11 Return Codes.</p><p>This method returns E_INVALIDARG if you set the <em>pAdapter</em> parameter to a non-<strong><c>null</c></strong> value and the <em>DriverType</em> parameter to the <see cref="SharpDX.Direct3D.DriverType.Hardware"/> value.</p></returns>	
        /// <remarks>	
        /// <p>This entry-point is supported by the Direct3D 11 runtime, which is available on Windows 7, Windows Server 2008 R2, and as an update to  Windows Vista (KB971644).</p><p>To create a Direct3D 11.1 device (<strong><see cref="SharpDX.Direct3D11.Device1"/></strong>), which is available on Windows?8, Windows Server?2012, and Windows?7 and Windows Server?2008?R2 with the Platform Update for Windows 7 installed, you first create a <strong><see cref="SharpDX.Direct3D11.Device"/></strong> with this function, and then call the <strong>QueryInterface</strong> method on the <strong><see cref="SharpDX.Direct3D11.Device"/></strong> object to obtain the <strong><see cref="SharpDX.Direct3D11.Device1"/></strong> interface.	
        /// </p><p>To create a Direct3D 11.2 device (<strong><see cref="SharpDX.Direct3D11.Device2"/></strong>), which is available on Windows?8.1 and Windows Server?2012?R2, you first create a <strong><see cref="SharpDX.Direct3D11.Device"/></strong> with this function, and then call the <strong>QueryInterface</strong> method on the <strong><see cref="SharpDX.Direct3D11.Device"/></strong> object to obtain the <strong><see cref="SharpDX.Direct3D11.Device2"/></strong> interface.	
        /// </p><p>Set <em>ppDevice</em> and <em>ppImmediateContext</em> to <strong><c>null</c></strong> to determine which feature level is supported by looking  at pFeatureLevel without creating a device.</p><p>For an example, see How To: Create a Device and Immediate Context; to create a device and a swap chain at the same time,  use <strong>D3D11CreateDeviceAndSwapChain</strong>.</p><p>If you set the <em>pAdapter</em> parameter to a non-<strong><c>null</c></strong> value, you must also set the <em>DriverType</em> parameter to the <see cref="SharpDX.Direct3D.DriverType.Unknown"/> value. If you set the <em>pAdapter</em> parameter to a non-<strong><c>null</c></strong> value and the <em>DriverType</em> parameter to the <see cref="SharpDX.Direct3D.DriverType.Hardware"/> value, <strong><see cref="SharpDX.Direct3D11.D3D11.CreateDevice"/></strong> returns an <strong><see cref="SharpDX.Result"/></strong> of E_INVALIDARG.</p><table> <tr><td> <p>Differences between Direct3D 10 and Direct3D 11:</p> <p>In Direct3D 10, the presence of <em>pAdapter</em> dictated which adapter to use and the <em>DriverType</em> could  mismatch what the adapter was.</p> <p>In Direct3D 11, if you are trying to create a hardware or a software device, set <em>pAdapter</em> != <strong><c>null</c></strong> which constrains  the other inputs to be:</p> <ul> <li><em>DriverType</em> must be <see cref="SharpDX.Direct3D.DriverType.Unknown"/></li> <li><em>Software</em> must be <strong><c>null</c></strong>.</li> </ul> <p>On the other hand, if <em>pAdapter</em> == <strong><c>null</c></strong>, the <em>DriverType</em> cannot be set to <see cref="SharpDX.Direct3D.DriverType.Unknown"/>; it can be set to either:</p> <ul> <li>If <em>DriverType</em> == <see cref="SharpDX.Direct3D.DriverType.Software"/>,  <em>Software</em> cannot be <strong><c>null</c></strong>.</li> <li>If <em>DriverType</em> == <see cref="SharpDX.Direct3D.DriverType.Hardware"/>, the adapter used will be the default adapter, which is the first adapter that is enumerated by <strong>IDXGIFactory1::EnumAdapters</strong> </li> </ul> </td></tr> </table><p>?</p><p><strong>Windows?Phone?8:</strong> This API is supported.</p><p><strong>Windows Phone 8.1:</strong> This API is supported.</p>	
        /// </remarks>	
        /// <include file='.\..\Documentation\CodeComments.xml' path="/comments/comment[@id='D3D11CreateDevice']/*"/>	
        /// <msdn-id>ff476082</msdn-id>	
        /// <unmanaged>HRESULT D3D11CreateDevice([In, Optional] IDXGIAdapter* pAdapter,[In] D3D_DRIVER_TYPE DriverType,[In] HINSTANCE Software,[In] D3D11_CREATE_DEVICE_FLAG Flags,[In, Buffer, Optional] const D3D_FEATURE_LEVEL* pFeatureLevels,[In] unsigned int FeatureLevels,[In] unsigned int SDKVersion,[Out, Fast] ID3D11Device** ppDevice,[Out, Optional] D3D_FEATURE_LEVEL* pFeatureLevel,[Out, Optional] ID3D11DeviceContext** ppImmediateContext)</unmanaged>	
        /// <unmanaged-short>D3D11CreateDevice</unmanaged-short>	
        public static SharpDX.Result CreateDevice(SharpDX.DXGI.Adapter adapterRef, SharpDX.Direct3D.DriverType driverType, System.IntPtr software, SharpDX.Direct3D11.DeviceCreationFlags flags, SharpDX.Direct3D.FeatureLevel[] featureLevelsRef, int featureLevels, int sDKVersion, SharpDX.Direct3D11.Device deviceOut, out SharpDX.Direct3D.FeatureLevel featureLevelRef, out SharpDX.Direct3D11.DeviceContext immediateContextOut) {
            unsafe {
                SharpDX.Direct3D.FeatureLevel[] featureLevelsRef__ = featureLevelsRef;
                IntPtr deviceOut_ = IntPtr.Zero;
                IntPtr immediateContextOut_ = IntPtr.Zero;
                SharpDX.Result __result__;
                fixed (void* featureLevelsRef_ = featureLevelsRef__)
                    fixed (void* featureLevelRef_ = &featureLevelRef)
                        __result__= 
        				D3D11CreateDevice_((void*)((adapterRef == null)?IntPtr.Zero:adapterRef.NativePointer), unchecked((int)driverType), (void*)software, unchecked((int)flags), featureLevelsRef_, featureLevels, sDKVersion, &deviceOut_, featureLevelRef_, &immediateContextOut_);		
                ((SharpDX.Direct3D11.Device)deviceOut).NativePointer = deviceOut_;
                immediateContextOut= (immediateContextOut_ == IntPtr.Zero)?null:new SharpDX.Direct3D11.DeviceContext(immediateContextOut_);	
                return __result__;
            }
        }
        [DllImport("d3d11.dll", EntryPoint = "D3D11CreateDevice", CallingConvention = CallingConvention.StdCall)]
        private unsafe static extern int D3D11CreateDevice_(void* arg0,int arg1,void* arg2,int arg3,void* arg4,int arg5,int arg6,void* arg7,void* arg8,void* arg9);
        
        /// <summary>	
        /// <p> Creates a device that uses Direct3D 11 functionality in Direct3D 12, specifying a pre-existing D3D12 device to use for D3D11 interop. </p>	
        /// </summary>	
        /// <param name="deviceRef"><dd>  <p> Specifies a pre-existing D3D12 device to use for D3D11 interop. May not be <c>null</c>. </p> </dd></param>	
        /// <param name="flags"><dd>  <p> Any of those documented for <strong>D3D11CreateDeviceAndSwapChain</strong>. Specifies which runtime layers to enable (see the <strong><see cref="SharpDX.Direct3D11.DeviceCreationFlags"/></strong> enumeration); values can be bitwise OR'd together. <em>Flags</em> must be compatible with device flags, and its <em>NodeMask</em> must be a subset of the <em>NodeMask</em> provided to the present API. </p> </dd></param>	
        /// <param name="featureLevelsRef"><dd>  <p> An array of any of the following: </p> <ul> <li><see cref="SharpDX.Direct3D.FeatureLevel.Level_12_1"/></li> <li><see cref="SharpDX.Direct3D.FeatureLevel.Level_12_0"/></li> <li><see cref="SharpDX.Direct3D.FeatureLevel.Level_11_1"/></li> <li><see cref="SharpDX.Direct3D.FeatureLevel.Level_11_0"/></li> <li><see cref="SharpDX.Direct3D.FeatureLevel.Level_10_1"/></li> <li><see cref="SharpDX.Direct3D.FeatureLevel.Level_10_0"/></li> <li><see cref="SharpDX.Direct3D.FeatureLevel.Level_9_3"/></li> <li><see cref="SharpDX.Direct3D.FeatureLevel.Level_9_2"/></li> <li><see cref="SharpDX.Direct3D.FeatureLevel.Level_9_1"/></li> </ul> <p> The first feature level which is less than or equal to the D3D12 device's feature level will be used to perform D3D11 validation. Creation will fail if no acceptable feature levels are provided. Providing <c>null</c> will default to the D3D12 device's feature level. </p> </dd></param>	
        /// <param name="featureLevels"><dd>  <p> The size of the feature levels array, in bytes. </p> </dd></param>	
        /// <param name="commandQueuesOut"><dd>  <p> An array of unique queues for D3D11On12 to use. Valid queue types: 3D command queue. </p> </dd></param>	
        /// <param name="numQueues"><dd>  <p> The size of the command queue array, in bytes. </p> </dd></param>	
        /// <param name="nodeMask"><dd>  <p> Which node of the D3D12 device to use. Only 1 bit may be set. </p> </dd></param>	
        /// <param name="deviceOut"><dd>  <p> Pointer to the returned <strong><see cref="SharpDX.Direct3D11.Device"/></strong>. May be <c>null</c>. </p> </dd></param>	
        /// <param name="immediateContextOut"><dd>  <p> A reference to the returned <strong><see cref="SharpDX.Direct3D11.DeviceContext"/></strong>. May be <c>null</c>. </p> </dd></param>	
        /// <param name="chosenFeatureLevelRef"><dd>  <p> A reference to the returned feature level. May be <c>null</c>. </p> </dd></param>	
        /// <returns><p> This method returns one of the Direct3D 12 Return Codes that are documented for <strong><see cref="SharpDX.Direct3D11.D3D11.CreateDevice"/></strong>. See Direct3D 12 Return Codes. </p><p> This method returns <strong><see cref="SharpDX.DXGI.ResultCode.SdkComponentMissing"/></strong> if you specify <strong><see cref="SharpDX.Direct3D11.DeviceCreationFlags.Debug"/></strong> in <em>Flags</em> and the incorrect version of the debug layer is installed on your computer. Install the latest Windows SDK to get the correct version. </p></returns>	
        /// <remarks>	
        /// <p> The function signature PFN_D3D11ON12_CREATE_DEVICE is provided as a typedef, so that you can use dynamic linking techniques (GetProcAddress) instead of statically linking. </p>	
        /// </remarks>	
        /// <include file='.\..\Documentation\CodeComments.xml' path="/comments/comment[@id='D3D11On12CreateDevice']/*"/>	
        /// <msdn-id>dn933209</msdn-id>	
        /// <unmanaged>HRESULT D3D11On12CreateDevice([In] IUnknown* pDevice,[In] D3D11_CREATE_DEVICE_FLAG Flags,[In, Buffer, Optional] const D3D_FEATURE_LEVEL* pFeatureLevels,[In] unsigned int FeatureLevels,[In, Buffer, Optional] const IUnknown** ppCommandQueues,[In] unsigned int NumQueues,[In] unsigned int NodeMask,[Out] ID3D11Device** ppDevice,[Out, Optional] ID3D11DeviceContext** ppImmediateContext,[Out, Optional] D3D_FEATURE_LEVEL* pChosenFeatureLevel)</unmanaged>	
        /// <unmanaged-short>D3D11On12CreateDevice</unmanaged-short>	
        public static void On12CreateDevice(SharpDX.ComObject deviceRef, SharpDX.Direct3D11.DeviceCreationFlags flags, SharpDX.Direct3D.FeatureLevel[] featureLevelsRef, int featureLevels, SharpDX.ComObject[] commandQueuesOut, int numQueues, int nodeMask, out SharpDX.Direct3D11.Device deviceOut, out SharpDX.Direct3D11.DeviceContext immediateContextOut, out SharpDX.Direct3D.FeatureLevel chosenFeatureLevelRef) {
            unsafe {
                SharpDX.Direct3D.FeatureLevel[] featureLevelsRef__ = featureLevelsRef;
                IntPtr* commandQueuesOut_ = (IntPtr*)0;
                if ( commandQueuesOut != null ) {
                    IntPtr* commandQueuesOut__ = stackalloc IntPtr[commandQueuesOut.Length];
                    commandQueuesOut_ = commandQueuesOut__;
                    for (int i = 0; i < commandQueuesOut.Length; i++)                        
                        commandQueuesOut_[i] =  (commandQueuesOut[i] == null)? IntPtr.Zero : commandQueuesOut[i].NativePointer;
                }
                IntPtr deviceOut_ = IntPtr.Zero;
                IntPtr immediateContextOut_ = IntPtr.Zero;
                SharpDX.Result __result__;
                fixed (void* featureLevelsRef_ = featureLevelsRef__)
                    fixed (void* chosenFeatureLevelRef_ = &chosenFeatureLevelRef)
                        __result__= 
        				D3D11On12CreateDevice_((void*)((deviceRef == null)?IntPtr.Zero:deviceRef.NativePointer), unchecked((int)flags), featureLevelsRef_, featureLevels, commandQueuesOut_, numQueues, nodeMask, &deviceOut_, &immediateContextOut_, chosenFeatureLevelRef_);		
                deviceOut= (deviceOut_ == IntPtr.Zero)?null:new SharpDX.Direct3D11.Device(deviceOut_);	
                immediateContextOut= (immediateContextOut_ == IntPtr.Zero)?null:new SharpDX.Direct3D11.DeviceContext(immediateContextOut_);	
                __result__.CheckError();
            }
        }
        [DllImport("d3d11.dll", EntryPoint = "D3D11On12CreateDevice", CallingConvention = CallingConvention.StdCall)]
        private unsafe static extern int D3D11On12CreateDevice_(void* arg0,int arg1,void* arg2,int arg3,void* arg4,int arg5,int arg6,void* arg7,void* arg8,void* arg9);
    }
        /// <summary>	
        /// Functions	
        /// </summary>	
        /// <include file='.\..\Documentation\CodeComments.xml' path="/comments/comment[@id='SharpDX.Direct3D11.D3DCSX']/*"/>	
    static  partial class D3DCSX {   
    }
        /// <summary>	
        /// Functions	
        /// </summary>	
        /// <include file='.\..\Documentation\CodeComments.xml' path="/comments/comment[@id='SharpDX.Direct3D11.D3DX11']/*"/>	
    static  partial class D3DX11 {   
    }
        /// <summary>	
        /// Functions	
        /// </summary>	
        /// <include file='.\..\Documentation\CodeComments.xml' path="/comments/comment[@id='SharpDX.Direct3D11.ResultCode']/*"/>	
    public static  partial class ResultCode {   
        
        /// <summary>Constant TooManyUniqueViewObjects.</summary>
        /// <unmanaged>D3D11_ERROR_TOO_MANY_UNIQUE_VIEW_OBJECTS</unmanaged>
        public static readonly SharpDX.ResultDescriptor TooManyUniqueViewObjects = new SharpDX.ResultDescriptor(-0x07783fffd, "SharpDX.Direct3D11", "D3D11_ERROR_TOO_MANY_UNIQUE_VIEW_OBJECTS", "TooManyUniqueViewObjects");
        
        /// <summary>Constant DeferredContextMapWithoutInitialDiscard.</summary>
        /// <unmanaged>D3D11_ERROR_DEFERRED_CONTEXT_MAP_WITHOUT_INITIAL_DISCARD</unmanaged>
        public static readonly SharpDX.ResultDescriptor DeferredContextMapWithoutInitialDiscard = new SharpDX.ResultDescriptor(-0x07783fffc, "SharpDX.Direct3D11", "D3D11_ERROR_DEFERRED_CONTEXT_MAP_WITHOUT_INITIAL_DISCARD", "DeferredContextMapWithoutInitialDiscard");
        
        /// <summary>Constant TooManyUniqueStateObjects.</summary>
        /// <unmanaged>D3D11_ERROR_TOO_MANY_UNIQUE_STATE_OBJECTS</unmanaged>
        public static readonly SharpDX.ResultDescriptor TooManyUniqueStateObjects = new SharpDX.ResultDescriptor(-0x07783ffff, "SharpDX.Direct3D11", "D3D11_ERROR_TOO_MANY_UNIQUE_STATE_OBJECTS", "TooManyUniqueStateObjects");
        
        /// <summary>Constant FileNotFound.</summary>
        /// <unmanaged>D3D11_ERROR_FILE_NOT_FOUND</unmanaged>
        public static readonly SharpDX.ResultDescriptor FileNotFound = new SharpDX.ResultDescriptor(-0x07783fffe, "SharpDX.Direct3D11", "D3D11_ERROR_FILE_NOT_FOUND", "FileNotFound");
    }
}
