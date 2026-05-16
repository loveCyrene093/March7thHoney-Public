using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishTalkMissionCsReq : IMessage<FinishTalkMissionCsReq>, IMessage, IEquatable<FinishTalkMissionCsReq>, IDeepCloneable<FinishTalkMissionCsReq>, IBufferMessage
{
	private static readonly MessageParser<FinishTalkMissionCsReq> _parser = new MessageParser<FinishTalkMissionCsReq>(() => new FinishTalkMissionCsReq());

	private UnknownFieldSet _unknownFields;

	public const int TalkStrFieldNumber = 1;

	private string talkStr_ = "";

	public const int CustomValueListFieldNumber = 7;

	private static readonly FieldCodec<MissionCustomValue> _repeated_customValueList_codec = FieldCodec.ForMessage(58u, MissionCustomValue.Parser);

	private readonly RepeatedField<MissionCustomValue> customValueList_ = new RepeatedField<MissionCustomValue>();

	public const int SubMissionIdFieldNumber = 10;

	private uint subMissionId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FinishTalkMissionCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FinishTalkMissionCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TalkStr
	{
		get
		{
			return talkStr_;
		}
		set
		{
			talkStr_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MissionCustomValue> CustomValueList => customValueList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SubMissionId
	{
		get
		{
			return subMissionId_;
		}
		set
		{
			subMissionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishTalkMissionCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishTalkMissionCsReq(FinishTalkMissionCsReq other)
		: this()
	{
		talkStr_ = other.talkStr_;
		customValueList_ = other.customValueList_.Clone();
		subMissionId_ = other.subMissionId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishTalkMissionCsReq Clone()
	{
		return new FinishTalkMissionCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FinishTalkMissionCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FinishTalkMissionCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TalkStr != other.TalkStr)
		{
			return false;
		}
		if (!customValueList_.Equals(other.customValueList_))
		{
			return false;
		}
		if (SubMissionId != other.SubMissionId)
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
		if (TalkStr.Length != 0)
		{
			num ^= TalkStr.GetHashCode();
		}
		num ^= customValueList_.GetHashCode();
		if (SubMissionId != 0)
		{
			num ^= SubMissionId.GetHashCode();
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
		if (TalkStr.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(TalkStr);
		}
		customValueList_.WriteTo(ref output, _repeated_customValueList_codec);
		if (SubMissionId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(SubMissionId);
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
		if (TalkStr.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TalkStr);
		}
		num += customValueList_.CalculateSize(_repeated_customValueList_codec);
		if (SubMissionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SubMissionId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FinishTalkMissionCsReq other)
	{
		if (other != null)
		{
			if (other.TalkStr.Length != 0)
			{
				TalkStr = other.TalkStr;
			}
			customValueList_.Add(other.customValueList_);
			if (other.SubMissionId != 0)
			{
				SubMissionId = other.SubMissionId;
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
			case 10u:
				TalkStr = input.ReadString();
				break;
			case 58u:
				customValueList_.AddEntriesFrom(ref input, _repeated_customValueList_codec);
				break;
			case 80u:
				SubMissionId = input.ReadUInt32();
				break;
			}
		}
	}
}
