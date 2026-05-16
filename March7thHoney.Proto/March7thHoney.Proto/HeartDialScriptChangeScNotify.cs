using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeartDialScriptChangeScNotify : IMessage<HeartDialScriptChangeScNotify>, IMessage, IEquatable<HeartDialScriptChangeScNotify>, IDeepCloneable<HeartDialScriptChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<HeartDialScriptChangeScNotify> _parser = new MessageParser<HeartDialScriptChangeScNotify>(() => new HeartDialScriptChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int ChangedDialogueInfoListFieldNumber = 2;

	private static readonly FieldCodec<HeartDialDialogueInfo> _repeated_changedDialogueInfoList_codec = FieldCodec.ForMessage(18u, HeartDialDialogueInfo.Parser);

	private readonly RepeatedField<HeartDialDialogueInfo> changedDialogueInfoList_ = new RepeatedField<HeartDialDialogueInfo>();

	public const int ChangedScriptInfoListFieldNumber = 5;

	private static readonly FieldCodec<HeartDialScriptInfo> _repeated_changedScriptInfoList_codec = FieldCodec.ForMessage(42u, HeartDialScriptInfo.Parser);

	private readonly RepeatedField<HeartDialScriptInfo> changedScriptInfoList_ = new RepeatedField<HeartDialScriptInfo>();

	public const int UnlockStatusFieldNumber = 10;

	private HeartDialUnlockStatus unlockStatus_;

	public const int OOGJAKIPFDJFieldNumber = 11;

	private static readonly FieldCodec<PICILIIFKBE> _repeated_oOGJAKIPFDJ_codec = FieldCodec.ForMessage(90u, PICILIIFKBE.Parser);

	private readonly RepeatedField<PICILIIFKBE> oOGJAKIPFDJ_ = new RepeatedField<PICILIIFKBE>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeartDialScriptChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeartDialScriptChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HeartDialDialogueInfo> ChangedDialogueInfoList => changedDialogueInfoList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<HeartDialScriptInfo> ChangedScriptInfoList => changedScriptInfoList_;

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
	public RepeatedField<PICILIIFKBE> OOGJAKIPFDJ => oOGJAKIPFDJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeartDialScriptChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeartDialScriptChangeScNotify(HeartDialScriptChangeScNotify other)
		: this()
	{
		changedDialogueInfoList_ = other.changedDialogueInfoList_.Clone();
		changedScriptInfoList_ = other.changedScriptInfoList_.Clone();
		unlockStatus_ = other.unlockStatus_;
		oOGJAKIPFDJ_ = other.oOGJAKIPFDJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeartDialScriptChangeScNotify Clone()
	{
		return new HeartDialScriptChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeartDialScriptChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeartDialScriptChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!changedDialogueInfoList_.Equals(other.changedDialogueInfoList_))
		{
			return false;
		}
		if (!changedScriptInfoList_.Equals(other.changedScriptInfoList_))
		{
			return false;
		}
		if (UnlockStatus != other.UnlockStatus)
		{
			return false;
		}
		if (!oOGJAKIPFDJ_.Equals(other.oOGJAKIPFDJ_))
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
		num ^= changedDialogueInfoList_.GetHashCode();
		num ^= changedScriptInfoList_.GetHashCode();
		if (UnlockStatus != HeartDialUnlockStatus.Lock)
		{
			num ^= UnlockStatus.GetHashCode();
		}
		num ^= oOGJAKIPFDJ_.GetHashCode();
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
		changedDialogueInfoList_.WriteTo(ref output, _repeated_changedDialogueInfoList_codec);
		changedScriptInfoList_.WriteTo(ref output, _repeated_changedScriptInfoList_codec);
		if (UnlockStatus != HeartDialUnlockStatus.Lock)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)UnlockStatus);
		}
		oOGJAKIPFDJ_.WriteTo(ref output, _repeated_oOGJAKIPFDJ_codec);
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
		num += changedDialogueInfoList_.CalculateSize(_repeated_changedDialogueInfoList_codec);
		num += changedScriptInfoList_.CalculateSize(_repeated_changedScriptInfoList_codec);
		if (UnlockStatus != HeartDialUnlockStatus.Lock)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)UnlockStatus);
		}
		num += oOGJAKIPFDJ_.CalculateSize(_repeated_oOGJAKIPFDJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HeartDialScriptChangeScNotify other)
	{
		if (other != null)
		{
			changedDialogueInfoList_.Add(other.changedDialogueInfoList_);
			changedScriptInfoList_.Add(other.changedScriptInfoList_);
			if (other.UnlockStatus != HeartDialUnlockStatus.Lock)
			{
				UnlockStatus = other.UnlockStatus;
			}
			oOGJAKIPFDJ_.Add(other.oOGJAKIPFDJ_);
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
			case 18u:
				changedDialogueInfoList_.AddEntriesFrom(ref input, _repeated_changedDialogueInfoList_codec);
				break;
			case 42u:
				changedScriptInfoList_.AddEntriesFrom(ref input, _repeated_changedScriptInfoList_codec);
				break;
			case 80u:
				UnlockStatus = (HeartDialUnlockStatus)input.ReadEnum();
				break;
			case 90u:
				oOGJAKIPFDJ_.AddEntriesFrom(ref input, _repeated_oOGJAKIPFDJ_codec);
				break;
			}
		}
	}
}
