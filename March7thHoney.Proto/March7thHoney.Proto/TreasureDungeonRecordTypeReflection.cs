using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TreasureDungeonRecordTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TreasureDungeonRecordTypeReflection()
	{
		_003C_003Ey__InlineArray21<string> buffer = default(_003C_003Ey__InlineArray21<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 0) = "Ch9UcmVhc3VyZUR1bmdlb25SZWNvcmRUeXBlLnByb3RvKscGChlUcmVhc3Vy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 1) = "ZUR1bmdlb25SZWNvcmRUeXBlEhsKF0NFTE1LSkZLQ0xLX0ZPQktHQkdIQU5D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 2) = "EAASGwoXQ0VMTUtKRktDTEtfS0hBR09MTExHRFAQARIbChdDRUxNS0pGS0NM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 3) = "S19KRk5MQ0hLRENFSxACEhsKF0NFTE1LSkZLQ0xLX05HSUhETU9FRUdJEAMS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 4) = "GwoXQ0VMTUtKRktDTEtfTUFIRkRQTkhHTkwQBRIbChdDRUxNS0pGS0NMS19I";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 5) = "T0xFS01HSk1OQxAGEhsKF0NFTE1LSkZLQ0xLX0hGTUZKT0tMSkhKEAkSGwoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 6) = "Q0VMTUtKRktDTEtfREFPUEVJREdPQkIQChIbChdDRUxNS0pGS0NMS19QQk5B";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 7) = "SExQUFBBTBALEhsKF0NFTE1LSkZLQ0xLX0NOQ0ZCQkxJSUZNEA8SGwoXQ0VM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 8) = "TUtKRktDTEtfR0hMTkNIRUNCT08QEBIbChdDRUxNS0pGS0NMS19MSUxMSEdE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 9) = "UFBERxAUEhsKF0NFTE1LSkZLQ0xLX0hORUJJTkdFQktKEBgSGwoXQ0VMTUtK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 10) = "RktDTEtfQ0hBQ1BHTkdFR00QGRIbChdDRUxNS0pGS0NMS19ITkZOS09BRURE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 11) = "ThAbEhsKF0NFTE1LSkZLQ0xLX1BETUZLQURMRUFOEBwSGwoXQ0VMTUtKRktD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 12) = "TEtfUEFDTkxMSk1HTk4QHRIbChdDRUxNS0pGS0NMS19FSlBQT0FPSktGTxAe";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 13) = "EhsKF0NFTE1LSkZLQ0xLX0RBSENDT0hBQ09QEB8SGwoXQ0VMTUtKRktDTEtf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 14) = "UE1DTUlFS1BPSUMQIRIbChdDRUxNS0pGS0NMS19IRFBET0pOQkxMShAiEhsK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 15) = "F0NFTE1LSkZLQ0xLX0ZQRkVBQkRNRkpDECMSGwoXQ0VMTUtKRktDTEtfTU1D";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 16) = "S0hPQkNCSk4QJBIbChdDRUxNS0pGS0NMS19FSUtETEtPS0hDQRAlEhsKF0NF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 17) = "TE1LSkZLQ0xLX05JUE9CTkdERUdBECgSGwoXQ0VMTUtKRktDTEtfQlBFSURD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 18) = "SU9DQ0cQKRIbChdDRUxNS0pGS0NMS19FT01NTEtLRVBMQxAqEhsKF0NFTE1L";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 19) = "SkZLQ0xLX0lMTk1ORUtCR01NECtCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray21<string>, string>(ref buffer, 20) = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray21<string>, string>(in buffer, 21))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(TreasureDungeonRecordType) }, null, null));
	}
}
