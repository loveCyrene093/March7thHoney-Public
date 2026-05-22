using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartySyncUpdateScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartySyncUpdateScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJUcmFpblBhcnR5U3luY1VwZGF0ZVNjTm90aWZ5LnByb3RvGhFEQ0lFQUlE" + "QkJDSS5wcm90byJJChxUcmFpblBhcnR5U3luY1VwZGF0ZVNjTm90aWZ5EikK" + "E3VwZGF0ZV9keW5hbWljX2xpc3QYCyADKAsyDC5EQ0lFQUlEQkJDSUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DCIEAIDBBCIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartySyncUpdateScNotify), TrainPartySyncUpdateScNotify.Parser, new string[1] { "UpdateDynamicList" }, null, null, null, null)
		}));
	}
}
