using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MPEFJJJIGHM : IMessage<MPEFJJJIGHM>, IMessage, IEquatable<MPEFJJJIGHM>, IDeepCloneable<MPEFJJJIGHM>, IBufferMessage
{
	private static readonly MessageParser<MPEFJJJIGHM> _parser = new MessageParser<MPEFJJJIGHM>(() => new MPEFJJJIGHM());

	private UnknownFieldSet _unknownFields;

	public const int DOAOPBBIGPOFieldNumber = 1;

	private uint dOAOPBBIGPO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MPEFJJJIGHM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MPEFJJJIGHMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DOAOPBBIGPO
	{
		get
		{
			return dOAOPBBIGPO_;
		}
		set
		{
			dOAOPBBIGPO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPEFJJJIGHM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPEFJJJIGHM(MPEFJJJIGHM other)
		: this()
	{
		dOAOPBBIGPO_ = other.dOAOPBBIGPO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MPEFJJJIGHM Clone()
	{
		return new MPEFJJJIGHM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MPEFJJJIGHM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MPEFJJJIGHM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DOAOPBBIGPO != other.DOAOPBBIGPO)
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
		if (DOAOPBBIGPO != 0)
		{
			num ^= DOAOPBBIGPO.GetHashCode();
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
		if (DOAOPBBIGPO != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(DOAOPBBIGPO);
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
		if (DOAOPBBIGPO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DOAOPBBIGPO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MPEFJJJIGHM other)
	{
		if (other != null)
		{
			if (other.DOAOPBBIGPO != 0)
			{
				DOAOPBBIGPO = other.DOAOPBBIGPO;
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				DOAOPBBIGPO = input.ReadUInt32();
			}
		}
	}
}
