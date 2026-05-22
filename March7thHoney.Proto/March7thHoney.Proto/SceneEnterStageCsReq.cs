using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SceneEnterStageCsReq : IMessage<SceneEnterStageCsReq>, IMessage, IEquatable<SceneEnterStageCsReq>, IDeepCloneable<SceneEnterStageCsReq>, IBufferMessage
{
	private static readonly MessageParser<SceneEnterStageCsReq> _parser = new MessageParser<SceneEnterStageCsReq>(() => new SceneEnterStageCsReq());

	private UnknownFieldSet _unknownFields;

	public const int EventIdFieldNumber = 4;

	private uint eventId_;

	public const int MGABMCBOHMKFieldNumber = 6;

	private RebattleType mGABMCBOHMK_;

	public const int FDBGOJCKLBHFieldNumber = 8;

	private bool fDBGOJCKLBH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SceneEnterStageCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SceneEnterStageCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EventId
	{
		get
		{
			return eventId_;
		}
		set
		{
			eventId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RebattleType MGABMCBOHMK
	{
		get
		{
			return mGABMCBOHMK_;
		}
		set
		{
			mGABMCBOHMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FDBGOJCKLBH
	{
		get
		{
			return fDBGOJCKLBH_;
		}
		set
		{
			fDBGOJCKLBH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEnterStageCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEnterStageCsReq(SceneEnterStageCsReq other)
		: this()
	{
		eventId_ = other.eventId_;
		mGABMCBOHMK_ = other.mGABMCBOHMK_;
		fDBGOJCKLBH_ = other.fDBGOJCKLBH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneEnterStageCsReq Clone()
	{
		return new SceneEnterStageCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SceneEnterStageCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SceneEnterStageCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EventId != other.EventId)
		{
			return false;
		}
		if (MGABMCBOHMK != other.MGABMCBOHMK)
		{
			return false;
		}
		if (FDBGOJCKLBH != other.FDBGOJCKLBH)
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
		if (EventId != 0)
		{
			num ^= EventId.GetHashCode();
		}
		if (MGABMCBOHMK != RebattleType.None)
		{
			num ^= MGABMCBOHMK.GetHashCode();
		}
		if (FDBGOJCKLBH)
		{
			num ^= FDBGOJCKLBH.GetHashCode();
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
		if (EventId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(EventId);
		}
		if (MGABMCBOHMK != RebattleType.None)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)MGABMCBOHMK);
		}
		if (FDBGOJCKLBH)
		{
			output.WriteRawTag(64);
			output.WriteBool(FDBGOJCKLBH);
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
		if (EventId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EventId);
		}
		if (MGABMCBOHMK != RebattleType.None)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MGABMCBOHMK);
		}
		if (FDBGOJCKLBH)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SceneEnterStageCsReq other)
	{
		if (other != null)
		{
			if (other.EventId != 0)
			{
				EventId = other.EventId;
			}
			if (other.MGABMCBOHMK != RebattleType.None)
			{
				MGABMCBOHMK = other.MGABMCBOHMK;
			}
			if (other.FDBGOJCKLBH)
			{
				FDBGOJCKLBH = other.FDBGOJCKLBH;
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
				EventId = input.ReadUInt32();
				break;
			case 48u:
				MGABMCBOHMK = (RebattleType)input.ReadEnum();
				break;
			case 64u:
				FDBGOJCKLBH = input.ReadBool();
				break;
			}
		}
	}
}
