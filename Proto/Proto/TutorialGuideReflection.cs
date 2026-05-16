using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TutorialGuideReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TutorialGuideReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChNUdXRvcmlhbEd1aWRlLnByb3RvGhdUdXRvcmlhbEd1aWRlVHlwZS5wcm90";
		buffer[1] = "bxoUVHV0b3JpYWxTdGF0dXMucHJvdG8iXgoNVHV0b3JpYWxHdWlkZRIfCgZz";
		buffer[2] = "dGF0dXMYCSABKA4yDy5UdXRvcmlhbFN0YXR1cxIgCgR0eXBlGAwgASgOMhIu";
		buffer[3] = "VHV0b3JpYWxHdWlkZVR5cGUSCgoCaWQYDSABKA1CFqoCE01hcmNoN3RoSG9u";
		buffer[4] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			TutorialGuideTypeReflection.Descriptor,
			TutorialStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TutorialGuide), TutorialGuide.Parser, new string[3] { "Status", "Type", "Id" }, null, null, null, null)
		}));
	}
}
