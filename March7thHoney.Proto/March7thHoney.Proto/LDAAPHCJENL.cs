using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LDAAPHCJENL : IMessage<LDAAPHCJENL>, IMessage, IEquatable<LDAAPHCJENL>, IDeepCloneable<LDAAPHCJENL>, IBufferMessage
{
	private static readonly MessageParser<LDAAPHCJENL> _parser = new MessageParser<LDAAPHCJENL>(() => new LDAAPHCJENL());

	private UnknownFieldSet _unknownFields;

	public const int LDGJLDANJJLFieldNumber = 1;

	private uint lDGJLDANJJL_;

	public const int AINGHHOBEHPFieldNumber = 2;

	private int aINGHHOBEHP_;

	public const int DKECAGGAFHDFieldNumber = 3;

	private int dKECAGGAFHD_;

	public const int LKMEDHCBDHKFieldNumber = 4;

	private uint lKMEDHCBDHK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LDAAPHCJENL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LDAAPHCJENLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LDGJLDANJJL
	{
		get
		{
			return lDGJLDANJJL_;
		}
		set
		{
			lDGJLDANJJL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AINGHHOBEHP
	{
		get
		{
			return aINGHHOBEHP_;
		}
		set
		{
			aINGHHOBEHP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DKECAGGAFHD
	{
		get
		{
			return dKECAGGAFHD_;
		}
		set
		{
			dKECAGGAFHD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LKMEDHCBDHK
	{
		get
		{
			return lKMEDHCBDHK_;
		}
		set
		{
			lKMEDHCBDHK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LDAAPHCJENL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LDAAPHCJENL(LDAAPHCJENL other)
		: this()
	{
		lDGJLDANJJL_ = other.lDGJLDANJJL_;
		aINGHHOBEHP_ = other.aINGHHOBEHP_;
		dKECAGGAFHD_ = other.dKECAGGAFHD_;
		lKMEDHCBDHK_ = other.lKMEDHCBDHK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LDAAPHCJENL Clone()
	{
		return new LDAAPHCJENL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LDAAPHCJENL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LDAAPHCJENL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LDGJLDANJJL != other.LDGJLDANJJL)
		{
			return false;
		}
		if (AINGHHOBEHP != other.AINGHHOBEHP)
		{
			return false;
		}
		if (DKECAGGAFHD != other.DKECAGGAFHD)
		{
			return false;
		}
		if (LKMEDHCBDHK != other.LKMEDHCBDHK)
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
		if (LDGJLDANJJL != 0)
		{
			num ^= LDGJLDANJJL.GetHashCode();
		}
		if (AINGHHOBEHP != 0)
		{
			num ^= AINGHHOBEHP.GetHashCode();
		}
		if (DKECAGGAFHD != 0)
		{
			num ^= DKECAGGAFHD.GetHashCode();
		}
		if (LKMEDHCBDHK != 0)
		{
			num ^= LKMEDHCBDHK.GetHashCode();
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
		if (LDGJLDANJJL != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LDGJLDANJJL);
		}
		if (AINGHHOBEHP != 0)
		{
			output.WriteRawTag(16);
			output.WriteInt32(AINGHHOBEHP);
		}
		if (DKECAGGAFHD != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(DKECAGGAFHD);
		}
		if (LKMEDHCBDHK != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(LKMEDHCBDHK);
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
		if (LDGJLDANJJL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LDGJLDANJJL);
		}
		if (AINGHHOBEHP != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(AINGHHOBEHP);
		}
		if (DKECAGGAFHD != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(DKECAGGAFHD);
		}
		if (LKMEDHCBDHK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LKMEDHCBDHK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LDAAPHCJENL other)
	{
		if (other != null)
		{
			if (other.LDGJLDANJJL != 0)
			{
				LDGJLDANJJL = other.LDGJLDANJJL;
			}
			if (other.AINGHHOBEHP != 0)
			{
				AINGHHOBEHP = other.AINGHHOBEHP;
			}
			if (other.DKECAGGAFHD != 0)
			{
				DKECAGGAFHD = other.DKECAGGAFHD;
			}
			if (other.LKMEDHCBDHK != 0)
			{
				LKMEDHCBDHK = other.LKMEDHCBDHK;
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
			case 8u:
				LDGJLDANJJL = input.ReadUInt32();
				break;
			case 16u:
				AINGHHOBEHP = input.ReadInt32();
				break;
			case 24u:
				DKECAGGAFHD = input.ReadInt32();
				break;
			case 32u:
				LKMEDHCBDHK = input.ReadUInt32();
				break;
			}
		}
	}
}
