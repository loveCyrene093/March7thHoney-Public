using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FCIANJKGMCHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FCIANJKGMCHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQ0lBTkpLR01DSC5wcm90bxoRSUZDQkNCTEZBTE0ucHJvdG8iMAoLRkNJ" + "QU5KS0dNQ0gSIQoLT1BPR0VNQURMRUkYByABKAsyDC5JRkNCQ0JMRkFMTUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { IFCBCBLFALMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FCIANJKGMCH), FCIANJKGMCH.Parser, new string[1] { "OPOGEMADLEI" }, null, null, null, null)
		}));
	}
}
