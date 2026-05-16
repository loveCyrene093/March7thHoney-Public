using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CECIAMENDCBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CECIAMENDCBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDRUNJQU1FTkRDQi5wcm90bypHCgtDRUNJQU1FTkRDQhIbChdDRUNJQU1F" + "TkRDQl9JS0xGSEFORENJUBAAEhsKF0NFQ0lBTUVORENCX0VMSURCQ0dIQkRL" + "EAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CECIAMENDCB) }, null, null));
	}
}
