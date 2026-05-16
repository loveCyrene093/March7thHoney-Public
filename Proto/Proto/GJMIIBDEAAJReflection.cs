using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GJMIIBDEAAJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GJMIIBDEAAJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHSk1JSUJERUFBSi5wcm90byI2CgtHSk1JSUJERUFBShITCgtIREZKQUlO" + "QktKRxgBIAMoDRISCgppc19nZXRfYWxsGAggASgIQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GJMIIBDEAAJ), GJMIIBDEAAJ.Parser, new string[2] { "HDFJAINBKJG", "IsGetAll" }, null, null, null, null)
		}));
	}
}
