using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BENFJPDMKED : IMessage<BENFJPDMKED>, IMessage, IEquatable<BENFJPDMKED>, IDeepCloneable<BENFJPDMKED>, IBufferMessage
{
	private static readonly MessageParser<BENFJPDMKED> _parser = new MessageParser<BENFJPDMKED>(() => new BENFJPDMKED());

	private UnknownFieldSet _unknownFields;

	public const int JKPGACLKEECFieldNumber = 2;

	private ulong jKPGACLKEEC_;

	public const int BICBJMPAAANFieldNumber = 6;

	private MLOFJFBHGLG bICBJMPAAAN_;

	public const int GBLCELFMOABFieldNumber = 14;

	private int gBLCELFMOAB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BENFJPDMKED> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BENFJPDMKEDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong JKPGACLKEEC
	{
		get
		{
			return jKPGACLKEEC_;
		}
		set
		{
			jKPGACLKEEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLOFJFBHGLG BICBJMPAAAN
	{
		get
		{
			return bICBJMPAAAN_;
		}
		set
		{
			bICBJMPAAAN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int GBLCELFMOAB
	{
		get
		{
			return gBLCELFMOAB_;
		}
		set
		{
			gBLCELFMOAB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BENFJPDMKED()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BENFJPDMKED(BENFJPDMKED other)
		: this()
	{
		jKPGACLKEEC_ = other.jKPGACLKEEC_;
		bICBJMPAAAN_ = other.bICBJMPAAAN_;
		gBLCELFMOAB_ = other.gBLCELFMOAB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BENFJPDMKED Clone()
	{
		return new BENFJPDMKED(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BENFJPDMKED);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BENFJPDMKED other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JKPGACLKEEC != other.JKPGACLKEEC)
		{
			return false;
		}
		if (BICBJMPAAAN != other.BICBJMPAAAN)
		{
			return false;
		}
		if (GBLCELFMOAB != other.GBLCELFMOAB)
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
		if (JKPGACLKEEC != 0L)
		{
			num ^= JKPGACLKEEC.GetHashCode();
		}
		if (BICBJMPAAAN != MLOFJFBHGLG.Kbdoljnphnc)
		{
			num ^= BICBJMPAAAN.GetHashCode();
		}
		if (GBLCELFMOAB != 0)
		{
			num ^= GBLCELFMOAB.GetHashCode();
		}
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
		if (JKPGACLKEEC != 0L)
		{
			output.WriteRawTag(16);
			output.WriteUInt64(JKPGACLKEEC);
		}
		if (BICBJMPAAAN != MLOFJFBHGLG.Kbdoljnphnc)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)BICBJMPAAAN);
		}
		if (GBLCELFMOAB != 0)
		{
			output.WriteRawTag(112);
			output.WriteInt32(GBLCELFMOAB);
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
		if (JKPGACLKEEC != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(JKPGACLKEEC);
		}
		if (BICBJMPAAAN != MLOFJFBHGLG.Kbdoljnphnc)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)BICBJMPAAAN);
		}
		if (GBLCELFMOAB != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(GBLCELFMOAB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BENFJPDMKED other)
	{
		if (other != null)
		{
			if (other.JKPGACLKEEC != 0L)
			{
				JKPGACLKEEC = other.JKPGACLKEEC;
			}
			if (other.BICBJMPAAAN != MLOFJFBHGLG.Kbdoljnphnc)
			{
				BICBJMPAAAN = other.BICBJMPAAAN;
			}
			if (other.GBLCELFMOAB != 0)
			{
				GBLCELFMOAB = other.GBLCELFMOAB;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 16u:
				JKPGACLKEEC = input.ReadUInt64();
				break;
			case 48u:
				BICBJMPAAAN = (MLOFJFBHGLG)input.ReadEnum();
				break;
			case 112u:
				GBLCELFMOAB = input.ReadInt32();
				break;
			}
		}
	}
}
