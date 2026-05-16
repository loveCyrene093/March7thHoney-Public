using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EraFlipperRegionDataSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EraFlipperRegionDataSnapshotReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJFcmFGbGlwcGVyUmVnaW9uRGF0YVNuYXBzaG90LnByb3RvIkAKHEVyYUZs" + "aXBwZXJSZWdpb25EYXRhU25hcHNob3QSEQoJcmVnaW9uX2lkGAEgASgNEg0K" + "BXN0YXRlGAIgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EraFlipperRegionDataSnapshot), EraFlipperRegionDataSnapshot.Parser, new string[2] { "RegionId", "State" }, null, null, null, null)
		}));
	}
}
