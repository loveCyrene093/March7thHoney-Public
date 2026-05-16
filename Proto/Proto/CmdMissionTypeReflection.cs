using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdMissionTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdMissionTypeReflection()
	{
		_003C_003Ey__InlineArray24<string> buffer = default(_003C_003Ey__InlineArray24<string>);
		buffer[0] = "ChRDbWRNaXNzaW9uVHlwZS5wcm90byrWBwoOQ21kTWlzc2lvblR5cGUSGwoX";
		buffer[1] = "SUZKRkNHSkpNRktfUENQREhFTFBLRU0QABIdChhDbWRHZXRNaXNzaW9uU3Rh";
		buffer[2] = "dHVzQ3NSZXEQ7QkSEwoOQ21kRVBQTkxOSUJQTkEQ8gkSGwoWQ21kR2V0TWlz";
		buffer[3] = "c2lvbkRhdGFTY1JzcBC6CRIkCh9DbWRGaW5pc2hDb3N1bWVJdGVtTWlzc2lv";
		buffer[4] = "bkNzUmVxEPoJEh8KGkNtZE1haW5NaXNzaW9uQWNjZXB0Tm90aWZ5EOMJEiMK";
		buffer[5] = "HkNtZFVwZGF0ZVRyYWNrTWFpbk1pc3Npb25Dc1JlcRDmCRIVChBDbWRTeW5j";
		buffer[6] = "VGFza0NzUmVxEMIJEh4KGUNtZEFjY2VwdE1haW5NaXNzaW9uU2NSc3AQ5QkS";
		buffer[7] = "EwoOQ21kRk5BUEtCRUxJRk8Q/wkSHgoZQ21kRmluaXNoVGFsa01pc3Npb25D";
		buffer[8] = "c1JlcRCOChIhChxDbWRTdGFyUGVyZm9ybWFuY2VSZWxheUNzUmVxEOEJEikK";
		buffer[9] = "JENtZFVwZGF0ZU1haW5NaXNzaW9uQ3VzdG9tVmFsdWVDc1JlcRCNChImCiFD";
		buffer[10] = "bWRHZXRNYWluTWlzc2lvbkN1c3RvbVZhbHVlU2NSc3AQwQkSJgohQ21kU3Rh";
		buffer[11] = "cnRGaW5pc2hNYWluTWlzc2lvblNjTm90aWZ5EPEJEiAKG0NtZE1pc3Npb25H";
		buffer[12] = "cm91cFdhcm5TY05vdGlmeRCxCRIoCiNDbWRUZWxlcG9ydFRvTWlzc2lvblJl";
		buffer[13] = "c2V0UG9pbnRDc1JlcRDpCRIdChhDbWRHZXRNaXNzaW9uU3RhdHVzU2NSc3AQ";
		buffer[14] = "twkSHgoZQ21kQWNjZXB0TWFpbk1pc3Npb25Dc1JlcRD5CRIbChZDbWRHZXRN";
		buffer[15] = "aXNzaW9uRGF0YUNzUmVxEIsKEhMKDkNtZE1CTUVNQkRESkRFENUJEh8KGkNt";
		buffer[16] = "ZEZpbmlzaGVkTWlzc2lvblNjTm90aWZ5EMQJEhMKDkNtZE9GQ0VOQUhGRkVO";
		buffer[17] = "ELIJEh4KGUNtZEZpbmlzaFRhbGtNaXNzaW9uU2NSc3AQjwoSEwoOQ21kSEhB";
		buffer[18] = "SE5OT0lFSUgQuQkSKAojQ21kVGVsZXBvcnRUb01pc3Npb25SZXNldFBvaW50";
		buffer[19] = "U2NSc3AQxQkSIAobQ21kU3ViTWlzc2lvblJld2FyZFNjTm90aWZ5EJAKEiYK";
		buffer[20] = "IUNtZEdldE1haW5NaXNzaW9uQ3VzdG9tVmFsdWVDc1JlcRC4CRIdChhDbWRN";
		buffer[21] = "aXNzaW9uUmV3YXJkU2NOb3RpZnkQvgkSJQogQ21kU3RhcnRGaW5pc2hTdWJN";
		buffer[22] = "aXNzaW9uU2NOb3RpZnkQzAlCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		buffer[23] = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMissionType) }, null, null));
	}
}
