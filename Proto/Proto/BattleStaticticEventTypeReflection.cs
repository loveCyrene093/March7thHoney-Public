using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleStaticticEventTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleStaticticEventTypeReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "Ch5CYXR0bGVTdGF0aWN0aWNFdmVudFR5cGUucHJvdG8q2QMKGEJhdHRsZVN0";
		buffer[1] = "YXRpY3RpY0V2ZW50VHlwZRIfChtCQVRUTEVfU1RBVElDVElDX0VWRU5UX05P";
		buffer[2] = "TkUQABI3CjNCQVRUTEVfU1RBVElDVElDX0VWRU5UX1RSRUFTVVJFX0RVTkdF";
		buffer[3] = "T05fQUREX0VYUExPUkUQARI1CjFCQVRUTEVfU1RBVElDVElDX0VWRU5UX1RS";
		buffer[4] = "RUFTVVJFX0RVTkdFT05fT1BFTl9HUklEEAISNwozQkFUVExFX1NUQVRJQ1RJ";
		buffer[5] = "Q19FVkVOVF9UUkVBU1VSRV9EVU5HRU9OX1BJQ0tVUF9JVEVNEAMSNAowQkFU";
		buffer[6] = "VExFX1NUQVRJQ1RJQ19FVkVOVF9UUkVBU1VSRV9EVU5HRU9OX1VTRV9CVUZG";
		buffer[7] = "EAQSRQpBQkFUVExFX1NUQVRJQ1RJQ19FVkVOVF9URUxFVklTSU9OX0FDVElW";
		buffer[8] = "SVRZX1VQREFURV9NQVpFX0JVRkZfTEFZRVIQBRI3CjNCQVRUTEVfU1RBVElD";
		buffer[9] = "VElDX0VWRU5UX1JPR1VFX1RPVVJOX1RJVEFOX0VYVFJBX0NPSU4QBhI9CjlC";
		buffer[10] = "QVRUTEVfU1RBVElDVElDX0VWRU5UX1JPR1VFX1RPVVJOX1RJVEFOX0VYVFJB";
		buffer[11] = "X0NPSU5fVElNRVMQB0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BattleStaticticEventType) }, null, null));
	}
}
