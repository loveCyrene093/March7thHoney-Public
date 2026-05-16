using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OPPNAHLPAFG : IMessage<OPPNAHLPAFG>, IMessage, IEquatable<OPPNAHLPAFG>, IDeepCloneable<OPPNAHLPAFG>, IBufferMessage
{
	private static readonly MessageParser<OPPNAHLPAFG> _parser = new MessageParser<OPPNAHLPAFG>(() => new OPPNAHLPAFG());

	private UnknownFieldSet _unknownFields;

	public const int DINMKEIINLMFieldNumber = 13;

	private uint dINMKEIINLM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OPPNAHLPAFG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OPPNAHLPAFGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DINMKEIINLM
	{
		get
		{
			return dINMKEIINLM_;
		}
		set
		{
			dINMKEIINLM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPPNAHLPAFG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPPNAHLPAFG(OPPNAHLPAFG other)
		: this()
	{
		dINMKEIINLM_ = other.dINMKEIINLM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OPPNAHLPAFG Clone()
	{
		return new OPPNAHLPAFG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OPPNAHLPAFG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OPPNAHLPAFG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DINMKEIINLM != other.DINMKEIINLM)
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
		if (DINMKEIINLM != 0)
		{
			num ^= DINMKEIINLM.GetHashCode();
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
		if (DINMKEIINLM != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(DINMKEIINLM);
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
		if (DINMKEIINLM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DINMKEIINLM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OPPNAHLPAFG other)
	{
		if (other != null)
		{
			if (other.DINMKEIINLM != 0)
			{
				DINMKEIINLM = other.DINMKEIINLM;
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
			if (num != 104)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				DINMKEIINLM = input.ReadUInt32();
			}
		}
	}
}
