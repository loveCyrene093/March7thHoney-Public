using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ILGOPHIAJIG : IMessage<ILGOPHIAJIG>, IMessage, IEquatable<ILGOPHIAJIG>, IDeepCloneable<ILGOPHIAJIG>, IBufferMessage
{
	private static readonly MessageParser<ILGOPHIAJIG> _parser = new MessageParser<ILGOPHIAJIG>(() => new ILGOPHIAJIG());

	private UnknownFieldSet _unknownFields;

	public const int ReasonFieldNumber = 3;

	private GridFightGlobalHpChangeReason reason_;

	public const int EHMKLNEKIOEFieldNumber = 6;

	private uint eHMKLNEKIOE_;

	public const int FGEDKOINMAGFieldNumber = 7;

	private uint fGEDKOINMAG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ILGOPHIAJIG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ILGOPHIAJIGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGlobalHpChangeReason Reason
	{
		get
		{
			return reason_;
		}
		set
		{
			reason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EHMKLNEKIOE
	{
		get
		{
			return eHMKLNEKIOE_;
		}
		set
		{
			eHMKLNEKIOE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FGEDKOINMAG
	{
		get
		{
			return fGEDKOINMAG_;
		}
		set
		{
			fGEDKOINMAG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILGOPHIAJIG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILGOPHIAJIG(ILGOPHIAJIG other)
		: this()
	{
		reason_ = other.reason_;
		eHMKLNEKIOE_ = other.eHMKLNEKIOE_;
		fGEDKOINMAG_ = other.fGEDKOINMAG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILGOPHIAJIG Clone()
	{
		return new ILGOPHIAJIG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ILGOPHIAJIG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ILGOPHIAJIG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Reason != other.Reason)
		{
			return false;
		}
		if (EHMKLNEKIOE != other.EHMKLNEKIOE)
		{
			return false;
		}
		if (FGEDKOINMAG != other.FGEDKOINMAG)
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
		if (Reason != GridFightGlobalHpChangeReason.FoohmnafkbnEigonmaefpj)
		{
			num ^= Reason.GetHashCode();
		}
		if (EHMKLNEKIOE != 0)
		{
			num ^= EHMKLNEKIOE.GetHashCode();
		}
		if (FGEDKOINMAG != 0)
		{
			num ^= FGEDKOINMAG.GetHashCode();
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
		if (Reason != GridFightGlobalHpChangeReason.FoohmnafkbnEigonmaefpj)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Reason);
		}
		if (EHMKLNEKIOE != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(EHMKLNEKIOE);
		}
		if (FGEDKOINMAG != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(FGEDKOINMAG);
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
		if (Reason != GridFightGlobalHpChangeReason.FoohmnafkbnEigonmaefpj)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Reason);
		}
		if (EHMKLNEKIOE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EHMKLNEKIOE);
		}
		if (FGEDKOINMAG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FGEDKOINMAG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ILGOPHIAJIG other)
	{
		if (other != null)
		{
			if (other.Reason != GridFightGlobalHpChangeReason.FoohmnafkbnEigonmaefpj)
			{
				Reason = other.Reason;
			}
			if (other.EHMKLNEKIOE != 0)
			{
				EHMKLNEKIOE = other.EHMKLNEKIOE;
			}
			if (other.FGEDKOINMAG != 0)
			{
				FGEDKOINMAG = other.FGEDKOINMAG;
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
				Reason = (GridFightGlobalHpChangeReason)input.ReadEnum();
				break;
			case 48u:
				EHMKLNEKIOE = input.ReadUInt32();
				break;
			case 56u:
				FGEDKOINMAG = input.ReadUInt32();
				break;
			}
		}
	}
}
