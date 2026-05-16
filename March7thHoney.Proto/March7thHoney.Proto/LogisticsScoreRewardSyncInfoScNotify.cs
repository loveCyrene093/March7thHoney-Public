using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LogisticsScoreRewardSyncInfoScNotify : IMessage<LogisticsScoreRewardSyncInfoScNotify>, IMessage, IEquatable<LogisticsScoreRewardSyncInfoScNotify>, IDeepCloneable<LogisticsScoreRewardSyncInfoScNotify>, IBufferMessage
{
	private static readonly MessageParser<LogisticsScoreRewardSyncInfoScNotify> _parser = new MessageParser<LogisticsScoreRewardSyncInfoScNotify>(() => new LogisticsScoreRewardSyncInfoScNotify());

	private UnknownFieldSet _unknownFields;

	public const int OAIKIFEKFLGFieldNumber = 13;

	private static readonly FieldCodec<JCCMGOOPHBO> _repeated_oAIKIFEKFLG_codec = FieldCodec.ForMessage(106u, JCCMGOOPHBO.Parser);

	private readonly RepeatedField<JCCMGOOPHBO> oAIKIFEKFLG_ = new RepeatedField<JCCMGOOPHBO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LogisticsScoreRewardSyncInfoScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LogisticsScoreRewardSyncInfoScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<JCCMGOOPHBO> OAIKIFEKFLG => oAIKIFEKFLG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LogisticsScoreRewardSyncInfoScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LogisticsScoreRewardSyncInfoScNotify(LogisticsScoreRewardSyncInfoScNotify other)
		: this()
	{
		oAIKIFEKFLG_ = other.oAIKIFEKFLG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LogisticsScoreRewardSyncInfoScNotify Clone()
	{
		return new LogisticsScoreRewardSyncInfoScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LogisticsScoreRewardSyncInfoScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LogisticsScoreRewardSyncInfoScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!oAIKIFEKFLG_.Equals(other.oAIKIFEKFLG_))
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
		num ^= oAIKIFEKFLG_.GetHashCode();
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
		oAIKIFEKFLG_.WriteTo(ref output, _repeated_oAIKIFEKFLG_codec);
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
		num += oAIKIFEKFLG_.CalculateSize(_repeated_oAIKIFEKFLG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LogisticsScoreRewardSyncInfoScNotify other)
	{
		if (other != null)
		{
			oAIKIFEKFLG_.Add(other.oAIKIFEKFLG_);
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
			if (num != 106)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				oAIKIFEKFLG_.AddEntriesFrom(ref input, _repeated_oAIKIFEKFLG_codec);
			}
		}
	}
}
