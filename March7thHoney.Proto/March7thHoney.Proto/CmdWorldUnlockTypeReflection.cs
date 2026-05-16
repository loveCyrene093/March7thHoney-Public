using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdWorldUnlockTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdWorldUnlockTypeReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDbWRXb3JsZFVubG9ja1R5cGUucHJvdG8qZQoSQ21kV29ybGRVbmxvY2tU" + "eXBlEhsKF0pFTUVORktET0pNX1BDUERIRUxQS0VNEAASGAoTQ21kV29ybGRV" + "bmxvY2tTY1JzcBDLOxIYChNDbWRXb3JsZFVubG9ja0NzUmVxEMo7QhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdWorldUnlockType) }, null, null));
	}
}
