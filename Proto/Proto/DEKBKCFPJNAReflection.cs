using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DEKBKCFPJNAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DEKBKCFPJNAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFERUtCS0NGUEpOQS5wcm90byINCgtERUtCS0NGUEpOQUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DEKBKCFPJNA), DEKBKCFPJNA.Parser, null, null, null, null, null)
		}));
	}
}
