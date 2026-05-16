using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetHeartDialInfoScRsp : IMessage<GetHeartDialInfoScRsp>, IMessage, IEquatable<GetHeartDialInfoScRsp>, IDeepCloneable<GetHeartDialInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetHeartDialInfoScRsp> _parser = new MessageParser<GetHeartDialInfoScRsp>(() => new GetHeartDialInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int OOGJAKIPFDJFieldNumber = 1;

	private static readonly FieldCodec<PICILIIFKBE> _repeated_oOGJAKIPFDJ_codec = FieldCodec.ForMessage(10u, PICILIIFKBE.Parser);

	private readonly RepeatedField<PICILIIFKBE> oOGJAKIPFDJ_ = new RepeatedField<PICILIIFKBE>();

	public const int UnlockStatusFieldNumber = 2;

	private HeartDialUnlockStatus unlockStatus_;

	public const int ScriptInfoListFieldNumber = 3;

	private static readonly FieldCodec<HeartDialScriptInfo> _repeated_scriptInfoList_codec = FieldCodec.ForMessage(26u, HeartDialScriptInfo.Parser);

	private readonly RepeatedField<HeartDialScriptInfo> scriptInfoList_ = new RepeatedField<HeartDialScriptInfo>();

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int DialogueInfoListFieldNumber = 8;

	private static readonly FieldCodec<HeartDialDialogueInfo> _repeated_dialogueInfoList_codec = FieldCodec.ForMessage(66u, HeartDialDialogueInfo.Parser);

	private readonly RepeatedField<HeartDialDialogueInfo> dialogueInfoList_ = new RepeatedField<HeartDialDialogueInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetHeartDialInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetHeartDialInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PICILIIFKBE> OOGJAKIPFDJ => oOGJAKIPFDJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeartDialUnlockStatus UnlockStatus
	{
		get
		{
			return unlockStatus_;
		}
		set
		{
			unlockStatus_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HeartDialScriptInfo> ScriptInfoList => scriptInfoList_;

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
	public RepeatedField<HeartDialDialogueInfo> DialogueInfoList => dialogueInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetHeartDialInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetHeartDialInfoScRsp(GetHeartDialInfoScRsp other)
		: this()
	{
		oOGJAKIPFDJ_ = other.oOGJAKIPFDJ_.Clone();
		unlockStatus_ = other.unlockStatus_;
		scriptInfoList_ = other.scriptInfoList_.Clone();
		retcode_ = other.retcode_;
		dialogueInfoList_ = other.dialogueInfoList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetHeartDialInfoScRsp Clone()
	{
		return new GetHeartDialInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetHeartDialInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetHeartDialInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!oOGJAKIPFDJ_.Equals(other.oOGJAKIPFDJ_))
		{
			return false;
		}
		if (UnlockStatus != other.UnlockStatus)
		{
			return false;
		}
		if (!scriptInfoList_.Equals(other.scriptInfoList_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!dialogueInfoList_.Equals(other.dialogueInfoList_))
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
		num ^= oOGJAKIPFDJ_.GetHashCode();
		if (UnlockStatus != HeartDialUnlockStatus.Lock)
		{
			num ^= UnlockStatus.GetHashCode();
		}
		num ^= scriptInfoList_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= dialogueInfoList_.GetHashCode();
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
		oOGJAKIPFDJ_.WriteTo(ref output, _repeated_oOGJAKIPFDJ_codec);
		if (UnlockStatus != HeartDialUnlockStatus.Lock)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)UnlockStatus);
		}
		scriptInfoList_.WriteTo(ref output, _repeated_scriptInfoList_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		dialogueInfoList_.WriteTo(ref output, _repeated_dialogueInfoList_codec);
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
		num += oOGJAKIPFDJ_.CalculateSize(_repeated_oOGJAKIPFDJ_codec);
		if (UnlockStatus != HeartDialUnlockStatus.Lock)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UnlockStatus);
		}
		num += scriptInfoList_.CalculateSize(_repeated_scriptInfoList_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += dialogueInfoList_.CalculateSize(_repeated_dialogueInfoList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetHeartDialInfoScRsp other)
	{
		if (other != null)
		{
			oOGJAKIPFDJ_.Add(other.oOGJAKIPFDJ_);
			if (other.UnlockStatus != HeartDialUnlockStatus.Lock)
			{
				UnlockStatus = other.UnlockStatus;
			}
			scriptInfoList_.Add(other.scriptInfoList_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			dialogueInfoList_.Add(other.dialogueInfoList_);
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
				oOGJAKIPFDJ_.AddEntriesFrom(ref input, _repeated_oOGJAKIPFDJ_codec);
				break;
			case 16u:
				UnlockStatus = (HeartDialUnlockStatus)input.ReadEnum();
				break;
			case 26u:
				scriptInfoList_.AddEntriesFrom(ref input, _repeated_scriptInfoList_codec);
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 66u:
				dialogueInfoList_.AddEntriesFrom(ref input, _repeated_dialogueInfoList_codec);
				break;
			}
		}
	}
}
