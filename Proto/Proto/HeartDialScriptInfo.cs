using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HeartDialScriptInfo : IMessage<HeartDialScriptInfo>, IMessage, IEquatable<HeartDialScriptInfo>, IDeepCloneable<HeartDialScriptInfo>, IBufferMessage
{
	private static readonly MessageParser<HeartDialScriptInfo> _parser = new MessageParser<HeartDialScriptInfo>(() => new HeartDialScriptInfo());

	private UnknownFieldSet _unknownFields;

	public const int GKOALBAPIHBFieldNumber = 4;

	private bool gKOALBAPIHB_;

	public const int StepFieldNumber = 10;

	private HeartDialStepType step_;

	public const int CurEmotionTypeFieldNumber = 12;

	private HeartDialEmotionType curEmotionType_;

	public const int HPNINIJEOBHFieldNumber = 13;

	private bool hPNINIJEOBH_;

	public const int ScriptIdFieldNumber = 15;

	private uint scriptId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HeartDialScriptInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HeartDialScriptInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool GKOALBAPIHB
	{
		get
		{
			return gKOALBAPIHB_;
		}
		set
		{
			gKOALBAPIHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeartDialStepType Step
	{
		get
		{
			return step_;
		}
		set
		{
			step_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeartDialEmotionType CurEmotionType
	{
		get
		{
			return curEmotionType_;
		}
		set
		{
			curEmotionType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HPNINIJEOBH
	{
		get
		{
			return hPNINIJEOBH_;
		}
		set
		{
			hPNINIJEOBH_ = value;
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
	public HeartDialScriptInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeartDialScriptInfo(HeartDialScriptInfo other)
		: this()
	{
		gKOALBAPIHB_ = other.gKOALBAPIHB_;
		step_ = other.step_;
		curEmotionType_ = other.curEmotionType_;
		hPNINIJEOBH_ = other.hPNINIJEOBH_;
		scriptId_ = other.scriptId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HeartDialScriptInfo Clone()
	{
		return new HeartDialScriptInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HeartDialScriptInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HeartDialScriptInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GKOALBAPIHB != other.GKOALBAPIHB)
		{
			return false;
		}
		if (Step != other.Step)
		{
			return false;
		}
		if (CurEmotionType != other.CurEmotionType)
		{
			return false;
		}
		if (HPNINIJEOBH != other.HPNINIJEOBH)
		{
			return false;
		}
		if (ScriptId != other.ScriptId)
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
		if (GKOALBAPIHB)
		{
			num ^= GKOALBAPIHB.GetHashCode();
		}
		if (Step != HeartDialStepType.Coeejalelpf)
		{
			num ^= Step.GetHashCode();
		}
		if (CurEmotionType != HeartDialEmotionType.Peace)
		{
			num ^= CurEmotionType.GetHashCode();
		}
		if (HPNINIJEOBH)
		{
			num ^= HPNINIJEOBH.GetHashCode();
		}
		if (ScriptId != 0)
		{
			num ^= ScriptId.GetHashCode();
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
		if (GKOALBAPIHB)
		{
			output.WriteRawTag(32);
			output.WriteBool(GKOALBAPIHB);
		}
		if (Step != HeartDialStepType.Coeejalelpf)
		{
			output.WriteRawTag(80);
			output.WriteEnum((int)Step);
		}
		if (CurEmotionType != HeartDialEmotionType.Peace)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)CurEmotionType);
		}
		if (HPNINIJEOBH)
		{
			output.WriteRawTag(104);
			output.WriteBool(HPNINIJEOBH);
		}
		if (ScriptId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(ScriptId);
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
		if (GKOALBAPIHB)
		{
			num += 2;
		}
		if (Step != HeartDialStepType.Coeejalelpf)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Step);
		}
		if (CurEmotionType != HeartDialEmotionType.Peace)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)CurEmotionType);
		}
		if (HPNINIJEOBH)
		{
			num += 2;
		}
		if (ScriptId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScriptId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HeartDialScriptInfo other)
	{
		if (other != null)
		{
			if (other.GKOALBAPIHB)
			{
				GKOALBAPIHB = other.GKOALBAPIHB;
			}
			if (other.Step != HeartDialStepType.Coeejalelpf)
			{
				Step = other.Step;
			}
			if (other.CurEmotionType != HeartDialEmotionType.Peace)
			{
				CurEmotionType = other.CurEmotionType;
			}
			if (other.HPNINIJEOBH)
			{
				HPNINIJEOBH = other.HPNINIJEOBH;
			}
			if (other.ScriptId != 0)
			{
				ScriptId = other.ScriptId;
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
				GKOALBAPIHB = input.ReadBool();
				break;
			case 80u:
				Step = (HeartDialStepType)input.ReadEnum();
				break;
			case 96u:
				CurEmotionType = (HeartDialEmotionType)input.ReadEnum();
				break;
			case 104u:
				HPNINIJEOBH = input.ReadBool();
				break;
			case 120u:
				ScriptId = input.ReadUInt32();
				break;
			}
		}
	}
}
