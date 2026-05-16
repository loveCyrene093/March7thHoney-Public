using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FBLOOEBBJLNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FBLOOEBBJLNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQkxPT0VCQkpMTi5wcm90byI2CgtGQkxPT0VCQkpMThIQCghldmVudF9p" + "ZBgGIAEoDRIVCg1kaXNwbGF5X3ZhbHVlGA8gASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FBLOOEBBJLN), FBLOOEBBJLN.Parser, new string[2] { "EventId", "DisplayValue" }, null, null, null, null)
		}));
	}
}
