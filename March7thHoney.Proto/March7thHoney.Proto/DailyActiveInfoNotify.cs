using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DailyActiveInfoNotify : IMessage<DailyActiveInfoNotify>, IMessage, IEquatable<DailyActiveInfoNotify>, IDeepCloneable<DailyActiveInfoNotify>, IBufferMessage
{
	private static readonly MessageParser<DailyActiveInfoNotify> _parser = new MessageParser<DailyActiveInfoNotify>(() => new DailyActiveInfoNotify());

	private UnknownFieldSet _unknownFields;

	public const int DailyActivePointFieldNumber = 2;

	private uint dailyActivePoint_;

	public const int DailyActiveLevelListFieldNumber = 9;

	private static readonly FieldCodec<DailyActivityInfo> _repeated_dailyActiveLevelList_codec = FieldCodec.ForMessage(74u, DailyActivityInfo.Parser);

	private readonly RepeatedField<DailyActivityInfo> dailyActiveLevelList_ = new RepeatedField<DailyActivityInfo>();

	public const int DailyActiveQuestIdListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_dailyActiveQuestIdList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> dailyActiveQuestIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DailyActiveInfoNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DailyActiveInfoNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DailyActivePoint
	{
		get
		{
			return dailyActivePoint_;
		}
		set
		{
			dailyActivePoint_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DailyActivityInfo> DailyActiveLevelList => dailyActiveLevelList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DailyActiveQuestIdList => dailyActiveQuestIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DailyActiveInfoNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DailyActiveInfoNotify(DailyActiveInfoNotify other)
		: this()
	{
		dailyActivePoint_ = other.dailyActivePoint_;
		dailyActiveLevelList_ = other.dailyActiveLevelList_.Clone();
		dailyActiveQuestIdList_ = other.dailyActiveQuestIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DailyActiveInfoNotify Clone()
	{
		return new DailyActiveInfoNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DailyActiveInfoNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DailyActiveInfoNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DailyActivePoint != other.DailyActivePoint)
		{
			return false;
		}
		if (!dailyActiveLevelList_.Equals(other.dailyActiveLevelList_))
		{
			return false;
		}
		if (!dailyActiveQuestIdList_.Equals(other.dailyActiveQuestIdList_))
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
		if (DailyActivePoint != 0)
		{
			num ^= DailyActivePoint.GetHashCode();
		}
		num ^= dailyActiveLevelList_.GetHashCode();
		num ^= dailyActiveQuestIdList_.GetHashCode();
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
		if (DailyActivePoint != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(DailyActivePoint);
		}
		dailyActiveLevelList_.WriteTo(ref output, _repeated_dailyActiveLevelList_codec);
		dailyActiveQuestIdList_.WriteTo(ref output, _repeated_dailyActiveQuestIdList_codec);
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
		if (DailyActivePoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DailyActivePoint);
		}
		num += dailyActiveLevelList_.CalculateSize(_repeated_dailyActiveLevelList_codec);
		num += dailyActiveQuestIdList_.CalculateSize(_repeated_dailyActiveQuestIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DailyActiveInfoNotify other)
	{
		if (other != null)
		{
			if (other.DailyActivePoint != 0)
			{
				DailyActivePoint = other.DailyActivePoint;
			}
			dailyActiveLevelList_.Add(other.dailyActiveLevelList_);
			dailyActiveQuestIdList_.Add(other.dailyActiveQuestIdList_);
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
				DailyActivePoint = input.ReadUInt32();
				break;
			case 74u:
				dailyActiveLevelList_.AddEntriesFrom(ref input, _repeated_dailyActiveLevelList_codec);
				break;
			case 96u:
			case 98u:
				dailyActiveQuestIdList_.AddEntriesFrom(ref input, _repeated_dailyActiveQuestIdList_codec);
				break;
			}
		}
	}
}
