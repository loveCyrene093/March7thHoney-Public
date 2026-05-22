using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DADHPAFJDAG : IMessage<DADHPAFJDAG>, IMessage, IEquatable<DADHPAFJDAG>, IDeepCloneable<DADHPAFJDAG>, IBufferMessage
{
	public enum JNLIOCCECBGOneofCase
	{
		None = 0,
		HEOCPFGBEDH = 2,
		KJEIJKPPNBM = 9
	}

	private static readonly MessageParser<DADHPAFJDAG> _parser = new MessageParser<DADHPAFJDAG>(() => new DADHPAFJDAG());

	private UnknownFieldSet _unknownFields;

	public const int PJMIEMAONINFieldNumber = 3;

	private uint pJMIEMAONIN_;

	public const int ICALOODHAOJFieldNumber = 8;

	private bool iCALOODHAOJ_;

	public const int HEOCPFGBEDHFieldNumber = 2;

	public const int KJEIJKPPNBMFieldNumber = 9;

	private object jNLIOCCECBG_;

	private JNLIOCCECBGOneofCase jNLIOCCECBGCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DADHPAFJDAG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DADHPAFJDAGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PJMIEMAONIN
	{
		get
		{
			return pJMIEMAONIN_;
		}
		set
		{
			pJMIEMAONIN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ICALOODHAOJ
	{
		get
		{
			return iCALOODHAOJ_;
		}
		set
		{
			iCALOODHAOJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BENODCCGBKA HEOCPFGBEDH
	{
		get
		{
			if (jNLIOCCECBGCase_ != JNLIOCCECBGOneofCase.HEOCPFGBEDH)
			{
				return null;
			}
			return (BENODCCGBKA)jNLIOCCECBG_;
		}
		set
		{
			jNLIOCCECBG_ = value;
			jNLIOCCECBGCase_ = ((value != null) ? JNLIOCCECBGOneofCase.HEOCPFGBEDH : JNLIOCCECBGOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EKJGLIIJIBD KJEIJKPPNBM
	{
		get
		{
			if (jNLIOCCECBGCase_ != JNLIOCCECBGOneofCase.KJEIJKPPNBM)
			{
				return null;
			}
			return (EKJGLIIJIBD)jNLIOCCECBG_;
		}
		set
		{
			jNLIOCCECBG_ = value;
			jNLIOCCECBGCase_ = ((value != null) ? JNLIOCCECBGOneofCase.KJEIJKPPNBM : JNLIOCCECBGOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JNLIOCCECBGOneofCase JNLIOCCECBGCase => jNLIOCCECBGCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DADHPAFJDAG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DADHPAFJDAG(DADHPAFJDAG other)
		: this()
	{
		pJMIEMAONIN_ = other.pJMIEMAONIN_;
		iCALOODHAOJ_ = other.iCALOODHAOJ_;
		switch (other.JNLIOCCECBGCase)
		{
		case JNLIOCCECBGOneofCase.HEOCPFGBEDH:
			HEOCPFGBEDH = other.HEOCPFGBEDH.Clone();
			break;
		case JNLIOCCECBGOneofCase.KJEIJKPPNBM:
			KJEIJKPPNBM = other.KJEIJKPPNBM.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DADHPAFJDAG Clone()
	{
		return new DADHPAFJDAG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearJNLIOCCECBG()
	{
		jNLIOCCECBGCase_ = JNLIOCCECBGOneofCase.None;
		jNLIOCCECBG_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DADHPAFJDAG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DADHPAFJDAG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PJMIEMAONIN != other.PJMIEMAONIN)
		{
			return false;
		}
		if (ICALOODHAOJ != other.ICALOODHAOJ)
		{
			return false;
		}
		if (!object.Equals(HEOCPFGBEDH, other.HEOCPFGBEDH))
		{
			return false;
		}
		if (!object.Equals(KJEIJKPPNBM, other.KJEIJKPPNBM))
		{
			return false;
		}
		if (JNLIOCCECBGCase != other.JNLIOCCECBGCase)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (PJMIEMAONIN != 0)
		{
			num ^= PJMIEMAONIN.GetHashCode();
		}
		if (ICALOODHAOJ)
		{
			num ^= ICALOODHAOJ.GetHashCode();
		}
		if (jNLIOCCECBGCase_ == JNLIOCCECBGOneofCase.HEOCPFGBEDH)
		{
			num ^= HEOCPFGBEDH.GetHashCode();
		}
		if (jNLIOCCECBGCase_ == JNLIOCCECBGOneofCase.KJEIJKPPNBM)
		{
			num ^= KJEIJKPPNBM.GetHashCode();
		}
		num ^= (int)jNLIOCCECBGCase_;
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (jNLIOCCECBGCase_ == JNLIOCCECBGOneofCase.HEOCPFGBEDH)
		{
			output.WriteRawTag(18);
			output.WriteMessage(HEOCPFGBEDH);
		}
		if (PJMIEMAONIN != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PJMIEMAONIN);
		}
		if (ICALOODHAOJ)
		{
			output.WriteRawTag(64);
			output.WriteBool(ICALOODHAOJ);
		}
		if (jNLIOCCECBGCase_ == JNLIOCCECBGOneofCase.KJEIJKPPNBM)
		{
			output.WriteRawTag(74);
			output.WriteMessage(KJEIJKPPNBM);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (PJMIEMAONIN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PJMIEMAONIN);
		}
		if (ICALOODHAOJ)
		{
			num += 2;
		}
		if (jNLIOCCECBGCase_ == JNLIOCCECBGOneofCase.HEOCPFGBEDH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HEOCPFGBEDH);
		}
		if (jNLIOCCECBGCase_ == JNLIOCCECBGOneofCase.KJEIJKPPNBM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KJEIJKPPNBM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DADHPAFJDAG other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PJMIEMAONIN != 0)
		{
			PJMIEMAONIN = other.PJMIEMAONIN;
		}
		if (other.ICALOODHAOJ)
		{
			ICALOODHAOJ = other.ICALOODHAOJ;
		}
		switch (other.JNLIOCCECBGCase)
		{
		case JNLIOCCECBGOneofCase.HEOCPFGBEDH:
			if (HEOCPFGBEDH == null)
			{
				HEOCPFGBEDH = new BENODCCGBKA();
			}
			HEOCPFGBEDH.MergeFrom(other.HEOCPFGBEDH);
			break;
		case JNLIOCCECBGOneofCase.KJEIJKPPNBM:
			if (KJEIJKPPNBM == null)
			{
				KJEIJKPPNBM = new EKJGLIIJIBD();
			}
			KJEIJKPPNBM.MergeFrom(other.KJEIJKPPNBM);
			break;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 18u:
			{
				BENODCCGBKA bENODCCGBKA = new BENODCCGBKA();
				if (jNLIOCCECBGCase_ == JNLIOCCECBGOneofCase.HEOCPFGBEDH)
				{
					bENODCCGBKA.MergeFrom(HEOCPFGBEDH);
				}
				input.ReadMessage(bENODCCGBKA);
				HEOCPFGBEDH = bENODCCGBKA;
				break;
			}
			case 24u:
				PJMIEMAONIN = input.ReadUInt32();
				break;
			case 64u:
				ICALOODHAOJ = input.ReadBool();
				break;
			case 74u:
			{
				EKJGLIIJIBD eKJGLIIJIBD = new EKJGLIIJIBD();
				if (jNLIOCCECBGCase_ == JNLIOCCECBGOneofCase.KJEIJKPPNBM)
				{
					eKJGLIIJIBD.MergeFrom(KJEIJKPPNBM);
				}
				input.ReadMessage(eKJGLIIJIBD);
				KJEIJKPPNBM = eKJGLIIJIBD;
				break;
			}
			}
		}
	}
}
