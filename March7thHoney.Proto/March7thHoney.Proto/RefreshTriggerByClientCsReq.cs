using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RefreshTriggerByClientCsReq : IMessage<RefreshTriggerByClientCsReq>, IMessage, IEquatable<RefreshTriggerByClientCsReq>, IDeepCloneable<RefreshTriggerByClientCsReq>, IBufferMessage
{
	private static readonly MessageParser<RefreshTriggerByClientCsReq> _parser = new MessageParser<RefreshTriggerByClientCsReq>(() => new RefreshTriggerByClientCsReq());

	private UnknownFieldSet _unknownFields;

	public const int InteractIdFieldNumber = 1;

	private ulong interactId_;

	public const int TriggerTargetIdListFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_triggerTargetIdList_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> triggerTargetIdList_ = new RepeatedField<uint>();

	public const int TriggerNameFieldNumber = 5;

	private string triggerName_ = "";

	public const int TriggerEntityIdFieldNumber = 7;

	private uint triggerEntityId_;

	public const int TriggerMotionFieldNumber = 13;

	private MotionInfo triggerMotion_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RefreshTriggerByClientCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RefreshTriggerByClientCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong InteractId
	{
		get
		{
			return interactId_;
		}
		set
		{
			interactId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> TriggerTargetIdList => triggerTargetIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TriggerName
	{
		get
		{
			return triggerName_;
		}
		set
		{
			triggerName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TriggerEntityId
	{
		get
		{
			return triggerEntityId_;
		}
		set
		{
			triggerEntityId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MotionInfo TriggerMotion
	{
		get
		{
			return triggerMotion_;
		}
		set
		{
			triggerMotion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RefreshTriggerByClientCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RefreshTriggerByClientCsReq(RefreshTriggerByClientCsReq other)
		: this()
	{
		interactId_ = other.interactId_;
		triggerTargetIdList_ = other.triggerTargetIdList_.Clone();
		triggerName_ = other.triggerName_;
		triggerEntityId_ = other.triggerEntityId_;
		triggerMotion_ = ((other.triggerMotion_ != null) ? other.triggerMotion_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RefreshTriggerByClientCsReq Clone()
	{
		return new RefreshTriggerByClientCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RefreshTriggerByClientCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RefreshTriggerByClientCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (InteractId != other.InteractId)
		{
			return false;
		}
		if (!triggerTargetIdList_.Equals(other.triggerTargetIdList_))
		{
			return false;
		}
		if (TriggerName != other.TriggerName)
		{
			return false;
		}
		if (TriggerEntityId != other.TriggerEntityId)
		{
			return false;
		}
		if (!object.Equals(TriggerMotion, other.TriggerMotion))
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
		if (InteractId != 0L)
		{
			num ^= InteractId.GetHashCode();
		}
		num ^= triggerTargetIdList_.GetHashCode();
		if (TriggerName.Length != 0)
		{
			num ^= TriggerName.GetHashCode();
		}
		if (TriggerEntityId != 0)
		{
			num ^= TriggerEntityId.GetHashCode();
		}
		if (triggerMotion_ != null)
		{
			num ^= TriggerMotion.GetHashCode();
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
		if (InteractId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(InteractId);
		}
		triggerTargetIdList_.WriteTo(ref output, _repeated_triggerTargetIdList_codec);
		if (TriggerName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(TriggerName);
		}
		if (TriggerEntityId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(TriggerEntityId);
		}
		if (triggerMotion_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(TriggerMotion);
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
		if (InteractId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(InteractId);
		}
		num += triggerTargetIdList_.CalculateSize(_repeated_triggerTargetIdList_codec);
		if (TriggerName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(TriggerName);
		}
		if (TriggerEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TriggerEntityId);
		}
		if (triggerMotion_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TriggerMotion);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RefreshTriggerByClientCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.InteractId != 0L)
		{
			InteractId = other.InteractId;
		}
		triggerTargetIdList_.Add(other.triggerTargetIdList_);
		if (other.TriggerName.Length != 0)
		{
			TriggerName = other.TriggerName;
		}
		if (other.TriggerEntityId != 0)
		{
			TriggerEntityId = other.TriggerEntityId;
		}
		if (other.triggerMotion_ != null)
		{
			if (triggerMotion_ == null)
			{
				TriggerMotion = new MotionInfo();
			}
			TriggerMotion.MergeFrom(other.TriggerMotion);
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 8u:
				InteractId = input.ReadUInt64();
				break;
			case 16u:
			case 18u:
				triggerTargetIdList_.AddEntriesFrom(ref input, _repeated_triggerTargetIdList_codec);
				break;
			case 42u:
				TriggerName = input.ReadString();
				break;
			case 56u:
				TriggerEntityId = input.ReadUInt32();
				break;
			case 106u:
				if (triggerMotion_ == null)
				{
					TriggerMotion = new MotionInfo();
				}
				input.ReadMessage(TriggerMotion);
				break;
			}
		}
	}
}
