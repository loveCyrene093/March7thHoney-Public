using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetDailyActiveInfoScRsp : IMessage<GetDailyActiveInfoScRsp>, IMessage, IEquatable<GetDailyActiveInfoScRsp>, IDeepCloneable<GetDailyActiveInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetDailyActiveInfoScRsp> _parser = new MessageParser<GetDailyActiveInfoScRsp>(() => new GetDailyActiveInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int DailyActiveLevelListFieldNumber = 9;

	private static readonly FieldCodec<DailyActivityInfo> _repeated_dailyActiveLevelList_codec = FieldCodec.ForMessage(74u, DailyActivityInfo.Parser);

	private readonly RepeatedField<DailyActivityInfo> dailyActiveLevelList_ = new RepeatedField<DailyActivityInfo>();

	public const int DailyActiveQuestIdListFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_dailyActiveQuestIdList_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> dailyActiveQuestIdList_ = new RepeatedField<uint>();

	public const int DailyActivePointFieldNumber = 14;

	private uint dailyActivePoint_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetDailyActiveInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetDailyActiveInfoScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<DailyActivityInfo> DailyActiveLevelList => dailyActiveLevelList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DailyActiveQuestIdList => dailyActiveQuestIdList_;

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
	public GetDailyActiveInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetDailyActiveInfoScRsp(GetDailyActiveInfoScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		dailyActiveLevelList_ = other.dailyActiveLevelList_.Clone();
		dailyActiveQuestIdList_ = other.dailyActiveQuestIdList_.Clone();
		dailyActivePoint_ = other.dailyActivePoint_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetDailyActiveInfoScRsp Clone()
	{
		return new GetDailyActiveInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetDailyActiveInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetDailyActiveInfoScRsp other)
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
		if (!dailyActiveLevelList_.Equals(other.dailyActiveLevelList_))
		{
			return false;
		}
		if (!dailyActiveQuestIdList_.Equals(other.dailyActiveQuestIdList_))
		{
			return false;
		}
		if (DailyActivePoint != other.DailyActivePoint)
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
		num ^= dailyActiveLevelList_.GetHashCode();
		num ^= dailyActiveQuestIdList_.GetHashCode();
		if (DailyActivePoint != 0)
		{
			num ^= DailyActivePoint.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		dailyActiveLevelList_.WriteTo(ref output, _repeated_dailyActiveLevelList_codec);
		dailyActiveQuestIdList_.WriteTo(ref output, _repeated_dailyActiveQuestIdList_codec);
		if (DailyActivePoint != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(DailyActivePoint);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += dailyActiveLevelList_.CalculateSize(_repeated_dailyActiveLevelList_codec);
		num += dailyActiveQuestIdList_.CalculateSize(_repeated_dailyActiveQuestIdList_codec);
		if (DailyActivePoint != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DailyActivePoint);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetDailyActiveInfoScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			dailyActiveLevelList_.Add(other.dailyActiveLevelList_);
			dailyActiveQuestIdList_.Add(other.dailyActiveQuestIdList_);
			if (other.DailyActivePoint != 0)
			{
				DailyActivePoint = other.DailyActivePoint;
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
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 74u:
				dailyActiveLevelList_.AddEntriesFrom(ref input, _repeated_dailyActiveLevelList_codec);
				break;
			case 80u:
			case 82u:
				dailyActiveQuestIdList_.AddEntriesFrom(ref input, _repeated_dailyActiveQuestIdList_codec);
				break;
			case 112u:
				DailyActivePoint = input.ReadUInt32();
				break;
			}
		}
	}
}
