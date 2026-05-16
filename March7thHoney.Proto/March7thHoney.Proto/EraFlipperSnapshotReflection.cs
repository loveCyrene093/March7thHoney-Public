using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EraFlipperSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EraFlipperSnapshotReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhFcmFGbGlwcGVyU25hcHNob3QucHJvdG8aIkVyYUZsaXBwZXJSZWdpb25E" + "YXRhU25hcHNob3QucHJvdG8iTQoSRXJhRmxpcHBlclNuYXBzaG90EjcKEHJl" + "Z2lvbl9kYXRhX2xpc3QYASADKAsyHS5FcmFGbGlwcGVyUmVnaW9uRGF0YVNu" + "YXBzaG90QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { EraFlipperRegionDataSnapshotReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EraFlipperSnapshot), EraFlipperSnapshot.Parser, new string[1] { "RegionDataList" }, null, null, null, null)
		}));
	}
}
