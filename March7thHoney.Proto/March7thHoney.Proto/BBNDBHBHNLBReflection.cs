using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BBNDBHBHNLBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BBNDBHBHNLBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQk5EQkhCSE5MQi5wcm90byI3CgtCQk5EQkhCSE5MQhITCgtMTEtPRk5E" + "QUtIRxgLIAEoDRITCgtHSUpISkNETFBKRhgPIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BBNDBHBHNLB), BBNDBHBHNLB.Parser, new string[2] { "LLKOFNDAKHG", "GIJHJCDLPJF" }, null, null, null, null)
		}));
	}
}
