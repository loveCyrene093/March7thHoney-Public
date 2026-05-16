using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JIONEBIHOIP : IMessage<JIONEBIHOIP>, IMessage, IEquatable<JIONEBIHOIP>, IDeepCloneable<JIONEBIHOIP>, IBufferMessage
{
	private static readonly MessageParser<JIONEBIHOIP> _parser = new MessageParser<JIONEBIHOIP>(() => new JIONEBIHOIP());

	private UnknownFieldSet _unknownFields;

	public const int ECIEBGCCCGCFieldNumber = 2;

	private bool eCIEBGCCCGC_;

	public const int PMMDFFFNFIOFieldNumber = 8;

	private uint pMMDFFFNFIO_;

	public const int LHENDOOGBCKFieldNumber = 9;

	private uint lHENDOOGBCK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JIONEBIHOIP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JIONEBIHOIPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public JIONEBIHOIP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIONEBIHOIP(JIONEBIHOIP other)
		: this()
	{
		eCIEBGCCCGC_ = other.eCIEBGCCCGC_;
		pMMDFFFNFIO_ = other.pMMDFFFNFIO_;
		lHENDOOGBCK_ = other.lHENDOOGBCK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIONEBIHOIP Clone()
	{
		return new JIONEBIHOIP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JIONEBIHOIP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JIONEBIHOIP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ECIEBGCCCGC != other.ECIEBGCCCGC)
		{
			return false;
		}
		if (PMMDFFFNFIO != other.PMMDFFFNFIO)
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
		if (ECIEBGCCCGC)
		{
			num ^= ECIEBGCCCGC.GetHashCode();
		}
		if (PMMDFFFNFIO != 0)
		{
			num ^= PMMDFFFNFIO.GetHashCode();
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
		if (ECIEBGCCCGC)
		{
			output.WriteRawTag(16);
			output.WriteBool(ECIEBGCCCGC);
		}
		if (PMMDFFFNFIO != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PMMDFFFNFIO);
		}
		if (LHENDOOGBCK != 0)
		{
			output.WriteRawTag(72);
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
		if (ECIEBGCCCGC)
		{
			num += 2;
		}
		if (PMMDFFFNFIO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PMMDFFFNFIO);
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
	public void MergeFrom(JIONEBIHOIP other)
	{
		if (other != null)
		{
			if (other.ECIEBGCCCGC)
			{
				ECIEBGCCCGC = other.ECIEBGCCCGC;
			}
			if (other.PMMDFFFNFIO != 0)
			{
				PMMDFFFNFIO = other.PMMDFFFNFIO;
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
			case 16u:
				ECIEBGCCCGC = input.ReadBool();
				break;
			case 64u:
				PMMDFFFNFIO = input.ReadUInt32();
				break;
			case 72u:
				LHENDOOGBCK = input.ReadUInt32();
				break;
			}
		}
	}
}
