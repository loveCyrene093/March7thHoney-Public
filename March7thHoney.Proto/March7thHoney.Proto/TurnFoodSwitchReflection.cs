using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TurnFoodSwitchReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TurnFoodSwitchReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRUdXJuRm9vZFN3aXRjaC5wcm90bypnCg5UdXJuRm9vZFN3aXRjaBIbChdI" + "SU5ES09ET0JBQV9QQ1BESEVMUEtFTRAAEhsKF0hJTkRLT0RPQkFBX0tFQlBH" + "Rk1PQ0REEAESGwoXSElOREtPRE9CQUFfRU1MQ0ZPRUlBSE0QAkIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(TurnFoodSwitch) }, null, null));
	}
}
