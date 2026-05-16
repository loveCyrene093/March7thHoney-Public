using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrialActivityStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrialActivityStatusReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlUcmlhbEFjdGl2aXR5U3RhdHVzLnByb3RvKlcKE1RyaWFsQWN0aXZpdHlT" + "dGF0dXMSHgoaVFJJQUxfQUNUSVZJVFlfU1RBVFVTX05PTkUQABIgChxUUklB" + "TF9BQ1RJVklUWV9TVEFUVVNfRklOSVNIEAFCFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(TrialActivityStatus) }, null, null));
	}
}
