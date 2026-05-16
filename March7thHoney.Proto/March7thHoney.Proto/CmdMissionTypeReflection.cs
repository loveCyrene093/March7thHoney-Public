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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 0) = "ChRDbWRNaXNzaW9uVHlwZS5wcm90byrWBwoOQ21kTWlzc2lvblR5cGUSGwoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 1) = "SUZKRkNHSkpNRktfUENQREhFTFBLRU0QABIdChhDbWRHZXRNaXNzaW9uU3Rh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 2) = "dHVzQ3NSZXEQ7QkSEwoOQ21kRVBQTkxOSUJQTkEQ8gkSGwoWQ21kR2V0TWlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 3) = "c2lvbkRhdGFTY1JzcBC6CRIkCh9DbWRGaW5pc2hDb3N1bWVJdGVtTWlzc2lv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 4) = "bkNzUmVxEPoJEh8KGkNtZE1haW5NaXNzaW9uQWNjZXB0Tm90aWZ5EOMJEiMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 5) = "HkNtZFVwZGF0ZVRyYWNrTWFpbk1pc3Npb25Dc1JlcRDmCRIVChBDbWRTeW5j";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 6) = "VGFza0NzUmVxEMIJEh4KGUNtZEFjY2VwdE1haW5NaXNzaW9uU2NSc3AQ5QkS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 7) = "EwoOQ21kRk5BUEtCRUxJRk8Q/wkSHgoZQ21kRmluaXNoVGFsa01pc3Npb25D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 8) = "c1JlcRCOChIhChxDbWRTdGFyUGVyZm9ybWFuY2VSZWxheUNzUmVxEOEJEikK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 9) = "JENtZFVwZGF0ZU1haW5NaXNzaW9uQ3VzdG9tVmFsdWVDc1JlcRCNChImCiFD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 10) = "bWRHZXRNYWluTWlzc2lvbkN1c3RvbVZhbHVlU2NSc3AQwQkSJgohQ21kU3Rh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 11) = "cnRGaW5pc2hNYWluTWlzc2lvblNjTm90aWZ5EPEJEiAKG0NtZE1pc3Npb25H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 12) = "cm91cFdhcm5TY05vdGlmeRCxCRIoCiNDbWRUZWxlcG9ydFRvTWlzc2lvblJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 13) = "c2V0UG9pbnRDc1JlcRDpCRIdChhDbWRHZXRNaXNzaW9uU3RhdHVzU2NSc3AQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 14) = "twkSHgoZQ21kQWNjZXB0TWFpbk1pc3Npb25Dc1JlcRD5CRIbChZDbWRHZXRN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 15) = "aXNzaW9uRGF0YUNzUmVxEIsKEhMKDkNtZE1CTUVNQkRESkRFENUJEh8KGkNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 16) = "ZEZpbmlzaGVkTWlzc2lvblNjTm90aWZ5EMQJEhMKDkNtZE9GQ0VOQUhGRkVO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 17) = "ELIJEh4KGUNtZEZpbmlzaFRhbGtNaXNzaW9uU2NSc3AQjwoSEwoOQ21kSEhB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 18) = "SE5OT0lFSUgQuQkSKAojQ21kVGVsZXBvcnRUb01pc3Npb25SZXNldFBvaW50";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 19) = "U2NSc3AQxQkSIAobQ21kU3ViTWlzc2lvblJld2FyZFNjTm90aWZ5EJAKEiYK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 20) = "IUNtZEdldE1haW5NaXNzaW9uQ3VzdG9tVmFsdWVDc1JlcRC4CRIdChhDbWRN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 21) = "aXNzaW9uUmV3YXJkU2NOb3RpZnkQvgkSJQogQ21kU3RhcnRGaW5pc2hTdWJN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 22) = "aXNzaW9uU2NOb3RpZnkQzAlCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 23) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray24<string>, string>(in buffer, 24))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMissionType) }, null, null));
	}
}
