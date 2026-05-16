using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SwitchHandCoinUpdateCsReq : IMessage<SwitchHandCoinUpdateCsReq>, IMessage, IEquatable<SwitchHandCoinUpdateCsReq>, IDeepCloneable<SwitchHandCoinUpdateCsReq>, IBufferMessage
{
	private static readonly MessageParser<SwitchHandCoinUpdateCsReq> _parser = new MessageParser<SwitchHandCoinUpdateCsReq>(() => new SwitchHandCoinUpdateCsReq());

	private UnknownFieldSet _unknownFields;

	public const int JLMJFEDNBMFFieldNumber = 14;

	private uint jLMJFEDNBMF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SwitchHandCoinUpdateCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SwitchHandCoinUpdateCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JLMJFEDNBMF
	{
		get
		{
			return jLMJFEDNBMF_;
		}
		set
		{
			jLMJFEDNBMF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchHandCoinUpdateCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchHandCoinUpdateCsReq(SwitchHandCoinUpdateCsReq other)
		: this()
	{
		jLMJFEDNBMF_ = other.jLMJFEDNBMF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchHandCoinUpdateCsReq Clone()
	{
		return new SwitchHandCoinUpdateCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SwitchHandCoinUpdateCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SwitchHandCoinUpdateCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JLMJFEDNBMF != other.JLMJFEDNBMF)
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
		if (JLMJFEDNBMF != 0)
		{
			num ^= JLMJFEDNBMF.GetHashCode();
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
		if (JLMJFEDNBMF != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(JLMJFEDNBMF);
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
		if (JLMJFEDNBMF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JLMJFEDNBMF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SwitchHandCoinUpdateCsReq other)
	{
		if (other != null)
		{
			if (other.JLMJFEDNBMF != 0)
			{
				JLMJFEDNBMF = other.JLMJFEDNBMF;
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
			if (num != 112)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				JLMJFEDNBMF = input.ReadUInt32();
			}
		}
	}
}
