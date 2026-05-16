using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdTrainVisitorTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdTrainVisitorTypeReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "ChlDbWRUcmFpblZpc2l0b3JUeXBlLnByb3RvKtsDChNDbWRUcmFpblZpc2l0";
		buffer[1] = "b3JUeXBlEhsKF1BHR01QTUtGRExEX1BDUERIRUxQS0VNEAASIQocQ21kTmV3";
		buffer[2] = "U3VwcGxlbWVudFZpc2l0b3JDc1JlcRCbHRIkCh9DbWRUcmFpblZpc2l0b3JS";
		buffer[3] = "ZXdhcmRTZW5kTm90aWZ5EIYdEicKIkNtZFRyYWluVmlzaXRvckJlaGF2aW9y";
		buffer[4] = "RmluaXNoU2NSc3AQ/hwSJwoiQ21kVHJhaW5WaXNpdG9yQmVoYXZpb3JGaW5p";
		buffer[5] = "c2hDc1JlcRDPHRIkCh9DbWRHZXRUcmFpblZpc2l0b3JSZWdpc3RlckNzUmVx";
		buffer[6] = "EP0cEh4KGUNtZFRyYWluUmVmcmVzaFRpbWVOb3RpZnkQgh0SEwoOQ21kUENH";
		buffer[7] = "REtIR0lMRUUQ9RwSKwomQ21kVGFrZVRyYWluVmlzaXRvckJlaGF2aW9yUmV3";
		buffer[8] = "YXJkU2NSc3AQjh0SEwoOQ21kTEpQTUNPSlBMREUQ0x0SHAoXUEdHTVBNS0ZE";
		buffer[9] = "TERfRE5QSEpQS0VLRk0Q0h0SKwomQ21kVGFrZVRyYWluVmlzaXRvckJlaGF2";
		buffer[10] = "aW9yUmV3YXJkQ3NSZXEQsx0SJAofQ21kR2V0VHJhaW5WaXNpdG9yUmVnaXN0";
		buffer[11] = "ZXJTY1JzcBDWHUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdTrainVisitorType) }, null, null));
	}
}
