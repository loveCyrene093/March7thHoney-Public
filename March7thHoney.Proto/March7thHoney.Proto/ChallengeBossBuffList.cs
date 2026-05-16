using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChallengeBossBuffList : IMessage<ChallengeBossBuffList>, IMessage, IEquatable<ChallengeBossBuffList>, IDeepCloneable<ChallengeBossBuffList>, IBufferMessage
{
	private static readonly MessageParser<ChallengeBossBuffList> _parser = new MessageParser<ChallengeBossBuffList>(() => new ChallengeBossBuffList());

	private UnknownFieldSet _unknownFields;

	public const int BuffListFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_buffList_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> buffList_ = new RepeatedField<uint>();

	public const int ChallengeBossConstFieldNumber = 8;

	private uint challengeBossConst_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChallengeBossBuffList> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChallengeBossBuffListReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BuffList => buffList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ChallengeBossConst
	{
		get
		{
			return challengeBossConst_;
		}
		set
		{
			challengeBossConst_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossBuffList()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossBuffList(ChallengeBossBuffList other)
		: this()
	{
		buffList_ = other.buffList_.Clone();
		challengeBossConst_ = other.challengeBossConst_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChallengeBossBuffList Clone()
	{
		return new ChallengeBossBuffList(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChallengeBossBuffList);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChallengeBossBuffList other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!buffList_.Equals(other.buffList_))
		{
			return false;
		}
		if (ChallengeBossConst != other.ChallengeBossConst)
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
		num ^= buffList_.GetHashCode();
		if (ChallengeBossConst != 0)
		{
			num ^= ChallengeBossConst.GetHashCode();
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
		buffList_.WriteTo(ref output, _repeated_buffList_codec);
		if (ChallengeBossConst != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(ChallengeBossConst);
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
		num += buffList_.CalculateSize(_repeated_buffList_codec);
		if (ChallengeBossConst != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ChallengeBossConst);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChallengeBossBuffList other)
	{
		if (other != null)
		{
			buffList_.Add(other.buffList_);
			if (other.ChallengeBossConst != 0)
			{
				ChallengeBossConst = other.ChallengeBossConst;
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
			case 32u:
			case 34u:
				buffList_.AddEntriesFrom(ref input, _repeated_buffList_codec);
				break;
			case 64u:
				ChallengeBossConst = input.ReadUInt32();
				break;
			}
		}
	}
}
