using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CDDGLOAEOHH : IMessage<CDDGLOAEOHH>, IMessage, IEquatable<CDDGLOAEOHH>, IDeepCloneable<CDDGLOAEOHH>, IBufferMessage
{
	private static readonly MessageParser<CDDGLOAEOHH> _parser = new MessageParser<CDDGLOAEOHH>(() => new CDDGLOAEOHH());

	private UnknownFieldSet _unknownFields;

	public const int NMBFMHLNPLMFieldNumber = 12;

	private uint nMBFMHLNPLM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CDDGLOAEOHH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CDDGLOAEOHHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NMBFMHLNPLM
	{
		get
		{
			return nMBFMHLNPLM_;
		}
		set
		{
			nMBFMHLNPLM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDDGLOAEOHH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDDGLOAEOHH(CDDGLOAEOHH other)
		: this()
	{
		nMBFMHLNPLM_ = other.nMBFMHLNPLM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CDDGLOAEOHH Clone()
	{
		return new CDDGLOAEOHH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CDDGLOAEOHH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CDDGLOAEOHH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NMBFMHLNPLM != other.NMBFMHLNPLM)
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
		if (NMBFMHLNPLM != 0)
		{
			num ^= NMBFMHLNPLM.GetHashCode();
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
		if (NMBFMHLNPLM != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(NMBFMHLNPLM);
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
		if (NMBFMHLNPLM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NMBFMHLNPLM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CDDGLOAEOHH other)
	{
		if (other != null)
		{
			if (other.NMBFMHLNPLM != 0)
			{
				NMBFMHLNPLM = other.NMBFMHLNPLM;
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
			if (num != 96)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				NMBFMHLNPLM = input.ReadUInt32();
			}
		}
	}
}
