using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IFNECJOOIGG : IMessage<IFNECJOOIGG>, IMessage, IEquatable<IFNECJOOIGG>, IDeepCloneable<IFNECJOOIGG>, IBufferMessage
{
	private static readonly MessageParser<IFNECJOOIGG> _parser = new MessageParser<IFNECJOOIGG>(() => new IFNECJOOIGG());

	private UnknownFieldSet _unknownFields;

	public const int GroupIdFieldNumber = 3;

	private uint groupId_;

	public const int NFEJLJDLAGFFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_nFEJLJDLAGF_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> nFEJLJDLAGF_ = new RepeatedField<uint>();

	public const int NBFMEMNCGMJFieldNumber = 6;

	private uint nBFMEMNCGMJ_;

	public const int LMGHANJCECFFieldNumber = 9;

	private uint lMGHANJCECF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IFNECJOOIGG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IFNECJOOIGGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GroupId
	{
		get
		{
			return groupId_;
		}
		set
		{
			groupId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> NFEJLJDLAGF => nFEJLJDLAGF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NBFMEMNCGMJ
	{
		get
		{
			return nBFMEMNCGMJ_;
		}
		set
		{
			nBFMEMNCGMJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LMGHANJCECF
	{
		get
		{
			return lMGHANJCECF_;
		}
		set
		{
			lMGHANJCECF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFNECJOOIGG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFNECJOOIGG(IFNECJOOIGG other)
		: this()
	{
		groupId_ = other.groupId_;
		nFEJLJDLAGF_ = other.nFEJLJDLAGF_.Clone();
		nBFMEMNCGMJ_ = other.nBFMEMNCGMJ_;
		lMGHANJCECF_ = other.lMGHANJCECF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFNECJOOIGG Clone()
	{
		return new IFNECJOOIGG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IFNECJOOIGG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IFNECJOOIGG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GroupId != other.GroupId)
		{
			return false;
		}
		if (!nFEJLJDLAGF_.Equals(other.nFEJLJDLAGF_))
		{
			return false;
		}
		if (NBFMEMNCGMJ != other.NBFMEMNCGMJ)
		{
			return false;
		}
		if (LMGHANJCECF != other.LMGHANJCECF)
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
		if (GroupId != 0)
		{
			num ^= GroupId.GetHashCode();
		}
		num ^= nFEJLJDLAGF_.GetHashCode();
		if (NBFMEMNCGMJ != 0)
		{
			num ^= NBFMEMNCGMJ.GetHashCode();
		}
		if (LMGHANJCECF != 0)
		{
			num ^= LMGHANJCECF.GetHashCode();
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
		if (GroupId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(GroupId);
		}
		nFEJLJDLAGF_.WriteTo(ref output, _repeated_nFEJLJDLAGF_codec);
		if (NBFMEMNCGMJ != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(NBFMEMNCGMJ);
		}
		if (LMGHANJCECF != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(LMGHANJCECF);
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
		if (GroupId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GroupId);
		}
		num += nFEJLJDLAGF_.CalculateSize(_repeated_nFEJLJDLAGF_codec);
		if (NBFMEMNCGMJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NBFMEMNCGMJ);
		}
		if (LMGHANJCECF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LMGHANJCECF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IFNECJOOIGG other)
	{
		if (other != null)
		{
			if (other.GroupId != 0)
			{
				GroupId = other.GroupId;
			}
			nFEJLJDLAGF_.Add(other.nFEJLJDLAGF_);
			if (other.NBFMEMNCGMJ != 0)
			{
				NBFMEMNCGMJ = other.NBFMEMNCGMJ;
			}
			if (other.LMGHANJCECF != 0)
			{
				LMGHANJCECF = other.LMGHANJCECF;
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
				GroupId = input.ReadUInt32();
				break;
			case 40u:
			case 42u:
				nFEJLJDLAGF_.AddEntriesFrom(ref input, _repeated_nFEJLJDLAGF_codec);
				break;
			case 48u:
				NBFMEMNCGMJ = input.ReadUInt32();
				break;
			case 72u:
				LMGHANJCECF = input.ReadUInt32();
				break;
			}
		}
	}
}
