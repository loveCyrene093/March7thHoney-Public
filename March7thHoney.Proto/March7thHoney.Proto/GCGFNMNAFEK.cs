using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GCGFNMNAFEK : IMessage<GCGFNMNAFEK>, IMessage, IEquatable<GCGFNMNAFEK>, IDeepCloneable<GCGFNMNAFEK>, IBufferMessage
{
	private static readonly MessageParser<GCGFNMNAFEK> _parser = new MessageParser<GCGFNMNAFEK>(() => new GCGFNMNAFEK());

	private UnknownFieldSet _unknownFields;

	public const int PLFJBHOGCAFFieldNumber = 10;

	private ulong pLFJBHOGCAF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GCGFNMNAFEK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GCGFNMNAFEKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong PLFJBHOGCAF
	{
		get
		{
			return pLFJBHOGCAF_;
		}
		set
		{
			pLFJBHOGCAF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCGFNMNAFEK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCGFNMNAFEK(GCGFNMNAFEK other)
		: this()
	{
		pLFJBHOGCAF_ = other.pLFJBHOGCAF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCGFNMNAFEK Clone()
	{
		return new GCGFNMNAFEK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GCGFNMNAFEK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GCGFNMNAFEK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PLFJBHOGCAF != other.PLFJBHOGCAF)
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
		if (PLFJBHOGCAF != 0L)
		{
			num ^= PLFJBHOGCAF.GetHashCode();
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
		if (PLFJBHOGCAF != 0L)
		{
			output.WriteRawTag(80);
			output.WriteUInt64(PLFJBHOGCAF);
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
		if (PLFJBHOGCAF != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(PLFJBHOGCAF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GCGFNMNAFEK other)
	{
		if (other != null)
		{
			if (other.PLFJBHOGCAF != 0L)
			{
				PLFJBHOGCAF = other.PLFJBHOGCAF;
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
			if (num != 80)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				PLFJBHOGCAF = input.ReadUInt64();
			}
		}
	}
}
