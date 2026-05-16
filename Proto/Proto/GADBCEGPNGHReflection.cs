using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GADBCEGPNGHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GADBCEGPNGHReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFHQURCQ0VHUE5HSC5wcm90bxoRR05NRFBNQkdMQk4ucHJvdG8ifgoLR0FE";
		buffer[1] = "QkNFR1BOR0gSEAoIZ3JvdXBfaWQYBSABKA0SEAoIcGFuZWxfaWQYByABKA0S";
		buffer[2] = "IQoLR05IQkdKQUtBQ0wYCiABKA4yDC5HTk1EUE1CR0xCThITCgtPR0hGTU9B";
		buffer[3] = "TFBFTxgMIAEoDRITCgtzd2l0Y2hfbGlzdBgPIAMoDUIWqgITTWFyY2g3dGhI";
		buffer[4] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GNMDPMBGLBNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GADBCEGPNGH), GADBCEGPNGH.Parser, new string[5] { "GroupId", "PanelId", "GNHBGJAKACL", "OGHFMOALPEO", "SwitchList" }, null, null, null, null)
		}));
	}
}
