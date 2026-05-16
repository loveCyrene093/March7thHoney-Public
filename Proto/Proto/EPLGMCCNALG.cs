using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EPLGMCCNALG : IMessage<EPLGMCCNALG>, IMessage, IEquatable<EPLGMCCNALG>, IDeepCloneable<EPLGMCCNALG>, IBufferMessage
{
	private static readonly MessageParser<EPLGMCCNALG> _parser = new MessageParser<EPLGMCCNALG>(() => new EPLGMCCNALG());

	private UnknownFieldSet _unknownFields;

	public const int StatusFieldNumber = 6;

	private LKBGOMGHGLG status_;

	public const int NOFLNIMBDOFFieldNumber = 13;

	private uint nOFLNIMBDOF_;

	public const int MKBIOANPMKEFieldNumber = 14;

	private uint mKBIOANPMKE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EPLGMCCNALG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EPLGMCCNALGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKBGOMGHGLG Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NOFLNIMBDOF
	{
		get
		{
			return nOFLNIMBDOF_;
		}
		set
		{
			nOFLNIMBDOF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MKBIOANPMKE
	{
		get
		{
			return mKBIOANPMKE_;
		}
		set
		{
			mKBIOANPMKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPLGMCCNALG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPLGMCCNALG(EPLGMCCNALG other)
		: this()
	{
		status_ = other.status_;
		nOFLNIMBDOF_ = other.nOFLNIMBDOF_;
		mKBIOANPMKE_ = other.mKBIOANPMKE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EPLGMCCNALG Clone()
	{
		return new EPLGMCCNALG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EPLGMCCNALG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EPLGMCCNALG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (NOFLNIMBDOF != other.NOFLNIMBDOF)
		{
			return false;
		}
		if (MKBIOANPMKE != other.MKBIOANPMKE)
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
		if (Status != LKBGOMGHGLG.Jdinpiohiei)
		{
			num ^= Status.GetHashCode();
		}
		if (NOFLNIMBDOF != 0)
		{
			num ^= NOFLNIMBDOF.GetHashCode();
		}
		if (MKBIOANPMKE != 0)
		{
			num ^= MKBIOANPMKE.GetHashCode();
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
		if (Status != LKBGOMGHGLG.Jdinpiohiei)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)Status);
		}
		if (NOFLNIMBDOF != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(NOFLNIMBDOF);
		}
		if (MKBIOANPMKE != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(MKBIOANPMKE);
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
		if (Status != LKBGOMGHGLG.Jdinpiohiei)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (NOFLNIMBDOF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NOFLNIMBDOF);
		}
		if (MKBIOANPMKE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MKBIOANPMKE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EPLGMCCNALG other)
	{
		if (other != null)
		{
			if (other.Status != LKBGOMGHGLG.Jdinpiohiei)
			{
				Status = other.Status;
			}
			if (other.NOFLNIMBDOF != 0)
			{
				NOFLNIMBDOF = other.NOFLNIMBDOF;
			}
			if (other.MKBIOANPMKE != 0)
			{
				MKBIOANPMKE = other.MKBIOANPMKE;
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
			case 48u:
				Status = (LKBGOMGHGLG)input.ReadEnum();
				break;
			case 104u:
				NOFLNIMBDOF = input.ReadUInt32();
				break;
			case 112u:
				MKBIOANPMKE = input.ReadUInt32();
				break;
			}
		}
	}
}
