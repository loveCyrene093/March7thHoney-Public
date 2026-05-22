using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ClockParkStartScriptCsReq : IMessage<ClockParkStartScriptCsReq>, IMessage, IEquatable<ClockParkStartScriptCsReq>, IDeepCloneable<ClockParkStartScriptCsReq>, IBufferMessage
{
	private static readonly MessageParser<ClockParkStartScriptCsReq> _parser = new MessageParser<ClockParkStartScriptCsReq>(() => new ClockParkStartScriptCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DANAGDAPKJEFieldNumber = 6;

	private static readonly FieldCodec<uint> _repeated_dANAGDAPKJE_codec = FieldCodec.ForUInt32(50u);

	private readonly RepeatedField<uint> dANAGDAPKJE_ = new RepeatedField<uint>();

	public const int ScriptIdFieldNumber = 10;

	private uint scriptId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ClockParkStartScriptCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ClockParkStartScriptCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DANAGDAPKJE => dANAGDAPKJE_;

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
	public ClockParkStartScriptCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkStartScriptCsReq(ClockParkStartScriptCsReq other)
		: this()
	{
		dANAGDAPKJE_ = other.dANAGDAPKJE_.Clone();
		scriptId_ = other.scriptId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkStartScriptCsReq Clone()
	{
		return new ClockParkStartScriptCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ClockParkStartScriptCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ClockParkStartScriptCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!dANAGDAPKJE_.Equals(other.dANAGDAPKJE_))
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
		num ^= dANAGDAPKJE_.GetHashCode();
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
		dANAGDAPKJE_.WriteTo(ref output, _repeated_dANAGDAPKJE_codec);
		if (ScriptId != 0)
		{
			output.WriteRawTag(80);
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
		num += dANAGDAPKJE_.CalculateSize(_repeated_dANAGDAPKJE_codec);
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
	public void MergeFrom(ClockParkStartScriptCsReq other)
	{
		if (other != null)
		{
			dANAGDAPKJE_.Add(other.dANAGDAPKJE_);
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
			case 48u:
			case 50u:
				dANAGDAPKJE_.AddEntriesFrom(ref input, _repeated_dANAGDAPKJE_codec);
				break;
			case 80u:
				ScriptId = input.ReadUInt32();
				break;
			}
		}
	}
}
