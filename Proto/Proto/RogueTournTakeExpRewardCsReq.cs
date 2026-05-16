using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournTakeExpRewardCsReq : IMessage<RogueTournTakeExpRewardCsReq>, IMessage, IEquatable<RogueTournTakeExpRewardCsReq>, IDeepCloneable<RogueTournTakeExpRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueTournTakeExpRewardCsReq> _parser = new MessageParser<RogueTournTakeExpRewardCsReq>(() => new RogueTournTakeExpRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int FPFIHHBNBANFieldNumber = 3;

	private uint fPFIHHBNBAN_;

	public const int PBBHJEFLBCBFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_pBBHJEFLBCB_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> pBBHJEFLBCB_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournTakeExpRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournTakeExpRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FPFIHHBNBAN
	{
		get
		{
			return fPFIHHBNBAN_;
		}
		set
		{
			fPFIHHBNBAN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PBBHJEFLBCB => pBBHJEFLBCB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournTakeExpRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournTakeExpRewardCsReq(RogueTournTakeExpRewardCsReq other)
		: this()
	{
		fPFIHHBNBAN_ = other.fPFIHHBNBAN_;
		pBBHJEFLBCB_ = other.pBBHJEFLBCB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournTakeExpRewardCsReq Clone()
	{
		return new RogueTournTakeExpRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournTakeExpRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournTakeExpRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FPFIHHBNBAN != other.FPFIHHBNBAN)
		{
			return false;
		}
		if (!pBBHJEFLBCB_.Equals(other.pBBHJEFLBCB_))
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
		if (FPFIHHBNBAN != 0)
		{
			num ^= FPFIHHBNBAN.GetHashCode();
		}
		num ^= pBBHJEFLBCB_.GetHashCode();
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
		if (FPFIHHBNBAN != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FPFIHHBNBAN);
		}
		pBBHJEFLBCB_.WriteTo(ref output, _repeated_pBBHJEFLBCB_codec);
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
		if (FPFIHHBNBAN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FPFIHHBNBAN);
		}
		num += pBBHJEFLBCB_.CalculateSize(_repeated_pBBHJEFLBCB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournTakeExpRewardCsReq other)
	{
		if (other != null)
		{
			if (other.FPFIHHBNBAN != 0)
			{
				FPFIHHBNBAN = other.FPFIHHBNBAN;
			}
			pBBHJEFLBCB_.Add(other.pBBHJEFLBCB_);
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
				FPFIHHBNBAN = input.ReadUInt32();
				break;
			case 112u:
			case 114u:
				pBBHJEFLBCB_.AddEntriesFrom(ref input, _repeated_pBBHJEFLBCB_codec);
				break;
			}
		}
	}
}
