using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishTalkMissionScRsp : IMessage<FinishTalkMissionScRsp>, IMessage, IEquatable<FinishTalkMissionScRsp>, IDeepCloneable<FinishTalkMissionScRsp>, IBufferMessage
{
	private static readonly MessageParser<FinishTalkMissionScRsp> _parser = new MessageParser<FinishTalkMissionScRsp>(() => new FinishTalkMissionScRsp());

	private UnknownFieldSet _unknownFields;

	public const int SubMissionIdFieldNumber = 2;

	private uint subMissionId_;

	public const int RetcodeFieldNumber = 4;

	private uint retcode_;

	public const int TalkStrFieldNumber = 9;

	private string talkStr_ = "";

	public const int CustomValueListFieldNumber = 10;

	private static readonly FieldCodec<MissionCustomValue> _repeated_customValueList_codec = FieldCodec.ForMessage(82u, MissionCustomValue.Parser);

	private readonly RepeatedField<MissionCustomValue> customValueList_ = new RepeatedField<MissionCustomValue>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FinishTalkMissionScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FinishTalkMissionScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public FinishTalkMissionScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishTalkMissionScRsp(FinishTalkMissionScRsp other)
		: this()
	{
		subMissionId_ = other.subMissionId_;
		retcode_ = other.retcode_;
		talkStr_ = other.talkStr_;
		customValueList_ = other.customValueList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishTalkMissionScRsp Clone()
	{
		return new FinishTalkMissionScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FinishTalkMissionScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FinishTalkMissionScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (SubMissionId != other.SubMissionId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (TalkStr != other.TalkStr)
		{
			return false;
		}
		if (!customValueList_.Equals(other.customValueList_))
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
		if (SubMissionId != 0)
		{
			num ^= SubMissionId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (TalkStr.Length != 0)
		{
			num ^= TalkStr.GetHashCode();
		}
		num ^= customValueList_.GetHashCode();
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
		if (SubMissionId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(SubMissionId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Retcode);
		}
		if (TalkStr.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(TalkStr);
		}
		customValueList_.WriteTo(ref output, _repeated_customValueList_codec);
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
		if (SubMissionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SubMissionId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (TalkStr.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TalkStr);
		}
		num += customValueList_.CalculateSize(_repeated_customValueList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FinishTalkMissionScRsp other)
	{
		if (other != null)
		{
			if (other.SubMissionId != 0)
			{
				SubMissionId = other.SubMissionId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.TalkStr.Length != 0)
			{
				TalkStr = other.TalkStr;
			}
			customValueList_.Add(other.customValueList_);
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
				SubMissionId = input.ReadUInt32();
				break;
			case 32u:
				Retcode = input.ReadUInt32();
				break;
			case 74u:
				TalkStr = input.ReadString();
				break;
			case 82u:
				customValueList_.AddEntriesFrom(ref input, _repeated_customValueList_codec);
				break;
			}
		}
	}
}
