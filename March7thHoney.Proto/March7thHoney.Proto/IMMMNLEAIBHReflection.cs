using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IMMMNLEAIBHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IMMMNLEAIBHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJTU1NTkxFQUlCSC5wcm90bypkCgtJTU1NTkxFQUlCSBIbChdJTU1NTkxF" + "QUlCSF9QQ1BESEVMUEtFTRAAEhsKF0lNTU1OTEVBSUJIX0dLSUZPSE5QSUpD" + "EAESGwoXSU1NTU5MRUFJQkhfSkpQSUhFSkxKQUgQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(IMMMNLEAIBH) }, null, null));
	}
}
