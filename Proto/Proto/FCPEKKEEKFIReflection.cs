using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FCPEKKEEKFIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FCPEKKEEKFIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQ1BFS0tFRUtGSS5wcm90bxoRUEFOSUdETExNQkcucHJvdG8iKgoLRkNQ" + "RUtLRUVLRkkSGwoFcGVha3MYCiADKAsyDC5QQU5JR0RMTE1CR0IWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { PANIGDLLMBGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FCPEKKEEKFI), FCPEKKEEKFI.Parser, new string[1] { "Peaks" }, null, null, null, null)
		}));
	}
}
