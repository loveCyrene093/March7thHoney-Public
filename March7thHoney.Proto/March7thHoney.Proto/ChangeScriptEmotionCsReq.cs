using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChangeScriptEmotionCsReq : IMessage<ChangeScriptEmotionCsReq>, IMessage, IEquatable<ChangeScriptEmotionCsReq>, IDeepCloneable<ChangeScriptEmotionCsReq>, IBufferMessage
{
	private static readonly MessageParser<ChangeScriptEmotionCsReq> _parser = new MessageParser<ChangeScriptEmotionCsReq>(() => new ChangeScriptEmotionCsReq());

	private UnknownFieldSet _unknownFields;

	public const int AILOMBIMICBFieldNumber = 2;

	private uint aILOMBIMICB_;

	public const int ScriptIdFieldNumber = 13;

	private uint scriptId_;

	public const int TargetEmotionTypeFieldNumber = 15;

	private HeartDialEmotionType targetEmotionType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChangeScriptEmotionCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChangeScriptEmotionCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AILOMBIMICB
	{
		get
		{
			return aILOMBIMICB_;
		}
		set
		{
			aILOMBIMICB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScriptId
	{
		get
		{
			return scriptId_;
		}
		set
		{
			scriptId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeartDialEmotionType TargetEmotionType
	{
		get
		{
			return targetEmotionType_;
		}
		set
		{
			targetEmotionType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChangeScriptEmotionCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChangeScriptEmotionCsReq(ChangeScriptEmotionCsReq other)
		: this()
	{
		aILOMBIMICB_ = other.aILOMBIMICB_;
		scriptId_ = other.scriptId_;
		targetEmotionType_ = other.targetEmotionType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChangeScriptEmotionCsReq Clone()
	{
		return new ChangeScriptEmotionCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChangeScriptEmotionCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChangeScriptEmotionCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AILOMBIMICB != other.AILOMBIMICB)
		{
			return false;
		}
		if (ScriptId != other.ScriptId)
		{
			return false;
		}
		if (TargetEmotionType != other.TargetEmotionType)
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
		if (AILOMBIMICB != 0)
		{
			num ^= AILOMBIMICB.GetHashCode();
		}
		if (ScriptId != 0)
		{
			num ^= ScriptId.GetHashCode();
		}
		if (TargetEmotionType != HeartDialEmotionType.Peace)
		{
			num ^= TargetEmotionType.GetHashCode();
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
		if (AILOMBIMICB != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(AILOMBIMICB);
		}
		if (ScriptId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ScriptId);
		}
		if (TargetEmotionType != HeartDialEmotionType.Peace)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)TargetEmotionType);
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
		if (AILOMBIMICB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AILOMBIMICB);
		}
		if (ScriptId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScriptId);
		}
		if (TargetEmotionType != HeartDialEmotionType.Peace)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)TargetEmotionType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChangeScriptEmotionCsReq other)
	{
		if (other != null)
		{
			if (other.AILOMBIMICB != 0)
			{
				AILOMBIMICB = other.AILOMBIMICB;
			}
			if (other.ScriptId != 0)
			{
				ScriptId = other.ScriptId;
			}
			if (other.TargetEmotionType != HeartDialEmotionType.Peace)
			{
				TargetEmotionType = other.TargetEmotionType;
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
				AILOMBIMICB = input.ReadUInt32();
				break;
			case 104u:
				ScriptId = input.ReadUInt32();
				break;
			case 120u:
				TargetEmotionType = (HeartDialEmotionType)input.ReadEnum();
				break;
			}
		}
	}
}
