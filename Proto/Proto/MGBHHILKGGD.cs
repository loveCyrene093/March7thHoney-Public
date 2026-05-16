using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MGBHHILKGGD : IMessage<MGBHHILKGGD>, IMessage, IEquatable<MGBHHILKGGD>, IDeepCloneable<MGBHHILKGGD>, IBufferMessage
{
	private static readonly MessageParser<MGBHHILKGGD> _parser = new MessageParser<MGBHHILKGGD>(() => new MGBHHILKGGD());

	private UnknownFieldSet _unknownFields;

	public const int PMMDFFFNFIOFieldNumber = 3;

	private uint pMMDFFFNFIO_;

	public const int ECIEBGCCCGCFieldNumber = 5;

	private bool eCIEBGCCCGC_;

	public const int LHENDOOGBCKFieldNumber = 13;

	private uint lHENDOOGBCK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MGBHHILKGGD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MGBHHILKGGDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PMMDFFFNFIO
	{
		get
		{
			return pMMDFFFNFIO_;
		}
		set
		{
			pMMDFFFNFIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ECIEBGCCCGC
	{
		get
		{
			return eCIEBGCCCGC_;
		}
		set
		{
			eCIEBGCCCGC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LHENDOOGBCK
	{
		get
		{
			return lHENDOOGBCK_;
		}
		set
		{
			lHENDOOGBCK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGBHHILKGGD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGBHHILKGGD(MGBHHILKGGD other)
		: this()
	{
		pMMDFFFNFIO_ = other.pMMDFFFNFIO_;
		eCIEBGCCCGC_ = other.eCIEBGCCCGC_;
		lHENDOOGBCK_ = other.lHENDOOGBCK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGBHHILKGGD Clone()
	{
		return new MGBHHILKGGD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MGBHHILKGGD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MGBHHILKGGD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PMMDFFFNFIO != other.PMMDFFFNFIO)
		{
			return false;
		}
		if (ECIEBGCCCGC != other.ECIEBGCCCGC)
		{
			return false;
		}
		if (LHENDOOGBCK != other.LHENDOOGBCK)
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
		if (PMMDFFFNFIO != 0)
		{
			num ^= PMMDFFFNFIO.GetHashCode();
		}
		if (ECIEBGCCCGC)
		{
			num ^= ECIEBGCCCGC.GetHashCode();
		}
		if (LHENDOOGBCK != 0)
		{
			num ^= LHENDOOGBCK.GetHashCode();
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
		if (PMMDFFFNFIO != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(PMMDFFFNFIO);
		}
		if (ECIEBGCCCGC)
		{
			output.WriteRawTag(40);
			output.WriteBool(ECIEBGCCCGC);
		}
		if (LHENDOOGBCK != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(LHENDOOGBCK);
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
		if (PMMDFFFNFIO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PMMDFFFNFIO);
		}
		if (ECIEBGCCCGC)
		{
			num += 2;
		}
		if (LHENDOOGBCK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LHENDOOGBCK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MGBHHILKGGD other)
	{
		if (other != null)
		{
			if (other.PMMDFFFNFIO != 0)
			{
				PMMDFFFNFIO = other.PMMDFFFNFIO;
			}
			if (other.ECIEBGCCCGC)
			{
				ECIEBGCCCGC = other.ECIEBGCCCGC;
			}
			if (other.LHENDOOGBCK != 0)
			{
				LHENDOOGBCK = other.LHENDOOGBCK;
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
			case 24u:
				PMMDFFFNFIO = input.ReadUInt32();
				break;
			case 40u:
				ECIEBGCCCGC = input.ReadBool();
				break;
			case 104u:
				LHENDOOGBCK = input.ReadUInt32();
				break;
			}
		}
	}
}
