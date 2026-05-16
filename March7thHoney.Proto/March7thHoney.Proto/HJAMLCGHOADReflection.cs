using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HJAMLCGHOADReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HJAMLCGHOADReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISkFNTENHSE9BRC5wcm90bypkCgtISkFNTENHSE9BRBIbChdISkFNTENH" + "SE9BRF9QQ1BESEVMUEtFTRAAEhsKF0hKQU1MQ0dIT0FEX09CSE9JR0xJQU1K" + "EAESGwoXSEpBTUxDR0hPQURfS0JKTkZHT01IUEMQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(HJAMLCGHOAD) }, null, null));
	}
}
