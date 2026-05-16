using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BGNGLHHBGMIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BGNGLHHBGMIReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFCR05HTEhIQkdNSS5wcm90bxoRR0FQQkJKQ0xNR1AucHJvdG8aEVBGT0RH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "REdGQkJOLnByb3RvIoEBCgtCR05HTEhIQkdNSRITCgtJUERDTUhJRUtJShgB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "IAEoDRIhCgtFSUhITEFPS0FQSBgCIAEoDjIMLkdBUEJCSkNMTUdQEhMKC0dE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "TklLSkdBRUJIGAMgASgNEiUKD2dyaWRfdXBkYXRlX3NyYxgEIAEoDjIMLlBG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "T0RHREdGQkJOQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			GAPBBJCLMGPReflection.Descriptor,
			PFODGDGFBBNReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BGNGLHHBGMI), BGNGLHHBGMI.Parser, new string[4] { "IPDCMHIEKIJ", "EIHHLAOKAPH", "GDNIKJGAEBH", "GridUpdateSrc" }, null, null, null, null)
		}));
	}
}
