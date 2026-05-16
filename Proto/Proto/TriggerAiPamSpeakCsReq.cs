using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class TriggerAiPamSpeakCsReq : IMessage<TriggerAiPamSpeakCsReq>, IMessage, IEquatable<TriggerAiPamSpeakCsReq>, IDeepCloneable<TriggerAiPamSpeakCsReq>, IBufferMessage
{
	private static readonly MessageParser<TriggerAiPamSpeakCsReq> _parser = new MessageParser<TriggerAiPamSpeakCsReq>(() => new TriggerAiPamSpeakCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CEHJJGEIMCLFieldNumber = 11;

	private uint cEHJJGEIMCL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TriggerAiPamSpeakCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => TriggerAiPamSpeakCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CEHJJGEIMCL
	{
		get
		{
			return cEHJJGEIMCL_;
		}
		set
		{
			cEHJJGEIMCL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TriggerAiPamSpeakCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TriggerAiPamSpeakCsReq(TriggerAiPamSpeakCsReq other)
		: this()
	{
		cEHJJGEIMCL_ = other.cEHJJGEIMCL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TriggerAiPamSpeakCsReq Clone()
	{
		return new TriggerAiPamSpeakCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as TriggerAiPamSpeakCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TriggerAiPamSpeakCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CEHJJGEIMCL != other.CEHJJGEIMCL)
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
		if (CEHJJGEIMCL != 0)
		{
			num ^= CEHJJGEIMCL.GetHashCode();
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
		if (CEHJJGEIMCL != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(CEHJJGEIMCL);
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
		if (CEHJJGEIMCL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CEHJJGEIMCL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TriggerAiPamSpeakCsReq other)
	{
		if (other != null)
		{
			if (other.CEHJJGEIMCL != 0)
			{
				CEHJJGEIMCL = other.CEHJJGEIMCL;
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
			if (num != 88)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				CEHJJGEIMCL = input.ReadUInt32();
			}
		}
	}
}
