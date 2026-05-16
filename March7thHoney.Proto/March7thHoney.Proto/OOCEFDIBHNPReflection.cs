using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OOCEFDIBHNPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OOCEFDIBHNPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPT0NFRkRJQkhOUC5wcm90bypkCgtPT0NFRkRJQkhOUBIbChdPT0NFRkRJ" + "QkhOUF9QQ1BESEVMUEtFTRAAEhsKF09PQ0VGRElCSE5QX0xFREVFQUhDREtJ" + "EAESGwoXT09DRUZESUJITlBfSENFS0ZFRU5OQ0EQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(OOCEFDIBHNP) }, null, null));
	}
}
