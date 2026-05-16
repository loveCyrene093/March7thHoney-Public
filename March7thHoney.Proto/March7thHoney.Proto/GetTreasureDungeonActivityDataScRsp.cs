using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetTreasureDungeonActivityDataScRsp : IMessage<GetTreasureDungeonActivityDataScRsp>, IMessage, IEquatable<GetTreasureDungeonActivityDataScRsp>, IDeepCloneable<GetTreasureDungeonActivityDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetTreasureDungeonActivityDataScRsp> _parser = new MessageParser<GetTreasureDungeonActivityDataScRsp>(() => new GetTreasureDungeonActivityDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int BPCKFOJKCBKFieldNumber = 12;

	private static readonly FieldCodec<DOACEKEEKLJ> _repeated_bPCKFOJKCBK_codec = FieldCodec.ForMessage(98u, DOACEKEEKLJ.Parser);

	private readonly RepeatedField<DOACEKEEKLJ> bPCKFOJKCBK_ = new RepeatedField<DOACEKEEKLJ>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetTreasureDungeonActivityDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetTreasureDungeonActivityDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<DOACEKEEKLJ> BPCKFOJKCBK => bPCKFOJKCBK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetTreasureDungeonActivityDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetTreasureDungeonActivityDataScRsp(GetTreasureDungeonActivityDataScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		bPCKFOJKCBK_ = other.bPCKFOJKCBK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetTreasureDungeonActivityDataScRsp Clone()
	{
		return new GetTreasureDungeonActivityDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetTreasureDungeonActivityDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetTreasureDungeonActivityDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!bPCKFOJKCBK_.Equals(other.bPCKFOJKCBK_))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= bPCKFOJKCBK_.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		bPCKFOJKCBK_.WriteTo(ref output, _repeated_bPCKFOJKCBK_codec);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += bPCKFOJKCBK_.CalculateSize(_repeated_bPCKFOJKCBK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetTreasureDungeonActivityDataScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			bPCKFOJKCBK_.Add(other.bPCKFOJKCBK_);
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
				Retcode = input.ReadUInt32();
				break;
			case 98u:
				bPCKFOJKCBK_.AddEntriesFrom(ref input, _repeated_bPCKFOJKCBK_codec);
				break;
			}
		}
	}
}
