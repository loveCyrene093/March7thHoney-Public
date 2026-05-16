using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EHJACNICCPKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EHJACNICCPKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFSEpBQ05JQ0NQSy5wcm90bypkCgtFSEpBQ05JQ0NQSxIbChdFSEpBQ05J" + "Q0NQS19ESkhQS0VMRVBHSxAAEhsKF0VISkFDTklDQ1BLX0FISENQTEFQS0hK" + "EAESGwoXRUhKQUNOSUNDUEtfREdLSVBJT09ORk0QAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(EHJACNICCPK) }, null, null));
	}
}
