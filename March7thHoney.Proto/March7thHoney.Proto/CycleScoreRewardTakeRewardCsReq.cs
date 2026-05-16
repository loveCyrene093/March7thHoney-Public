using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CycleScoreRewardTakeRewardCsReq : IMessage<CycleScoreRewardTakeRewardCsReq>, IMessage, IEquatable<CycleScoreRewardTakeRewardCsReq>, IDeepCloneable<CycleScoreRewardTakeRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<CycleScoreRewardTakeRewardCsReq> _parser = new MessageParser<CycleScoreRewardTakeRewardCsReq>(() => new CycleScoreRewardTakeRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GridFightScoreRankListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_gridFightScoreRankList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> gridFightScoreRankList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CycleScoreRewardTakeRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CycleScoreRewardTakeRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GridFightScoreRankList => gridFightScoreRankList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CycleScoreRewardTakeRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CycleScoreRewardTakeRewardCsReq(CycleScoreRewardTakeRewardCsReq other)
		: this()
	{
		gridFightScoreRankList_ = other.gridFightScoreRankList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CycleScoreRewardTakeRewardCsReq Clone()
	{
		return new CycleScoreRewardTakeRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CycleScoreRewardTakeRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CycleScoreRewardTakeRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!gridFightScoreRankList_.Equals(other.gridFightScoreRankList_))
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
		num ^= gridFightScoreRankList_.GetHashCode();
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
		gridFightScoreRankList_.WriteTo(ref output, _repeated_gridFightScoreRankList_codec);
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
		num += gridFightScoreRankList_.CalculateSize(_repeated_gridFightScoreRankList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CycleScoreRewardTakeRewardCsReq other)
	{
		if (other != null)
		{
			gridFightScoreRankList_.Add(other.gridFightScoreRankList_);
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
			if (num != 96 && num != 98)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				gridFightScoreRankList_.AddEntriesFrom(ref input, _repeated_gridFightScoreRankList_codec);
			}
		}
	}
}
