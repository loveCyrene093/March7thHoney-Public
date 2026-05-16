using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ClockParkQuitScriptCsReq : IMessage<ClockParkQuitScriptCsReq>, IMessage, IEquatable<ClockParkQuitScriptCsReq>, IDeepCloneable<ClockParkQuitScriptCsReq>, IBufferMessage
{
	private static readonly MessageParser<ClockParkQuitScriptCsReq> _parser = new MessageParser<ClockParkQuitScriptCsReq>(() => new ClockParkQuitScriptCsReq());

	private UnknownFieldSet _unknownFields;

	public const int ScriptIdFieldNumber = 6;

	private uint scriptId_;

	public const int NMAKFODLJHPFieldNumber = 9;

	private bool nMAKFODLJHP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ClockParkQuitScriptCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ClockParkQuitScriptCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public bool NMAKFODLJHP
	{
		get
		{
			return nMAKFODLJHP_;
		}
		set
		{
			nMAKFODLJHP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkQuitScriptCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkQuitScriptCsReq(ClockParkQuitScriptCsReq other)
		: this()
	{
		scriptId_ = other.scriptId_;
		nMAKFODLJHP_ = other.nMAKFODLJHP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkQuitScriptCsReq Clone()
	{
		return new ClockParkQuitScriptCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ClockParkQuitScriptCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ClockParkQuitScriptCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ScriptId != other.ScriptId)
		{
			return false;
		}
		if (NMAKFODLJHP != other.NMAKFODLJHP)
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
		if (ScriptId != 0)
		{
			num ^= ScriptId.GetHashCode();
		}
		if (NMAKFODLJHP)
		{
			num ^= NMAKFODLJHP.GetHashCode();
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
		if (ScriptId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ScriptId);
		}
		if (NMAKFODLJHP)
		{
			output.WriteRawTag(72);
			output.WriteBool(NMAKFODLJHP);
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
		if (ScriptId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScriptId);
		}
		if (NMAKFODLJHP)
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
	public void MergeFrom(ClockParkQuitScriptCsReq other)
	{
		if (other != null)
		{
			if (other.ScriptId != 0)
			{
				ScriptId = other.ScriptId;
			}
			if (other.NMAKFODLJHP)
			{
				NMAKFODLJHP = other.NMAKFODLJHP;
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
			case 48u:
				ScriptId = input.ReadUInt32();
				break;
			case 72u:
				NMAKFODLJHP = input.ReadBool();
				break;
			}
		}
	}
}
