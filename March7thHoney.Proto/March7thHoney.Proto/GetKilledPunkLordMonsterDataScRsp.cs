using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetKilledPunkLordMonsterDataScRsp : IMessage<GetKilledPunkLordMonsterDataScRsp>, IMessage, IEquatable<GetKilledPunkLordMonsterDataScRsp>, IDeepCloneable<GetKilledPunkLordMonsterDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetKilledPunkLordMonsterDataScRsp> _parser = new MessageParser<GetKilledPunkLordMonsterDataScRsp>(() => new GetKilledPunkLordMonsterDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int LKFKKGNACNPFieldNumber = 6;

	private static readonly FieldCodec<JLLIDDIBOHI> _repeated_lKFKKGNACNP_codec = FieldCodec.ForMessage(50u, JLLIDDIBOHI.Parser);

	private readonly RepeatedField<JLLIDDIBOHI> lKFKKGNACNP_ = new RepeatedField<JLLIDDIBOHI>();

	public const int GPBKIHALINBFieldNumber = 8;

	private static readonly FieldCodec<LMIINHHKLNL> _repeated_gPBKIHALINB_codec = FieldCodec.ForMessage(66u, LMIINHHKLNL.Parser);

	private readonly RepeatedField<LMIINHHKLNL> gPBKIHALINB_ = new RepeatedField<LMIINHHKLNL>();

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetKilledPunkLordMonsterDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetKilledPunkLordMonsterDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JLLIDDIBOHI> LKFKKGNACNP => lKFKKGNACNP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LMIINHHKLNL> GPBKIHALINB => gPBKIHALINB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetKilledPunkLordMonsterDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetKilledPunkLordMonsterDataScRsp(GetKilledPunkLordMonsterDataScRsp other)
		: this()
	{
		lKFKKGNACNP_ = other.lKFKKGNACNP_.Clone();
		gPBKIHALINB_ = other.gPBKIHALINB_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetKilledPunkLordMonsterDataScRsp Clone()
	{
		return new GetKilledPunkLordMonsterDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetKilledPunkLordMonsterDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetKilledPunkLordMonsterDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!lKFKKGNACNP_.Equals(other.lKFKKGNACNP_))
		{
			return false;
		}
		if (!gPBKIHALINB_.Equals(other.gPBKIHALINB_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= lKFKKGNACNP_.GetHashCode();
		num ^= gPBKIHALINB_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		lKFKKGNACNP_.WriteTo(ref output, _repeated_lKFKKGNACNP_codec);
		gPBKIHALINB_.WriteTo(ref output, _repeated_gPBKIHALINB_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
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
		num += lKFKKGNACNP_.CalculateSize(_repeated_lKFKKGNACNP_codec);
		num += gPBKIHALINB_.CalculateSize(_repeated_gPBKIHALINB_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetKilledPunkLordMonsterDataScRsp other)
	{
		if (other != null)
		{
			lKFKKGNACNP_.Add(other.lKFKKGNACNP_);
			gPBKIHALINB_.Add(other.gPBKIHALINB_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
			case 50u:
				lKFKKGNACNP_.AddEntriesFrom(ref input, _repeated_lKFKKGNACNP_codec);
				break;
			case 66u:
				gPBKIHALINB_.AddEntriesFrom(ref input, _repeated_gPBKIHALINB_codec);
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
