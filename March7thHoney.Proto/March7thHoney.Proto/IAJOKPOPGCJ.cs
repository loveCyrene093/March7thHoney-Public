using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IAJOKPOPGCJ : IMessage<IAJOKPOPGCJ>, IMessage, IEquatable<IAJOKPOPGCJ>, IDeepCloneable<IAJOKPOPGCJ>, IBufferMessage
{
	private static readonly MessageParser<IAJOKPOPGCJ> _parser = new MessageParser<IAJOKPOPGCJ>(() => new IAJOKPOPGCJ());

	private UnknownFieldSet _unknownFields;

	public const int IAPFJINFNLOFieldNumber = 5;

	private uint iAPFJINFNLO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IAJOKPOPGCJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IAJOKPOPGCJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IAPFJINFNLO
	{
		get
		{
			return iAPFJINFNLO_;
		}
		set
		{
			iAPFJINFNLO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IAJOKPOPGCJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IAJOKPOPGCJ(IAJOKPOPGCJ other)
		: this()
	{
		iAPFJINFNLO_ = other.iAPFJINFNLO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IAJOKPOPGCJ Clone()
	{
		return new IAJOKPOPGCJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IAJOKPOPGCJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IAJOKPOPGCJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IAPFJINFNLO != other.IAPFJINFNLO)
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
		if (IAPFJINFNLO != 0)
		{
			num ^= IAPFJINFNLO.GetHashCode();
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
		if (IAPFJINFNLO != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(IAPFJINFNLO);
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
		if (IAPFJINFNLO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IAPFJINFNLO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IAJOKPOPGCJ other)
	{
		if (other != null)
		{
			if (other.IAPFJINFNLO != 0)
			{
				IAPFJINFNLO = other.IAPFJINFNLO;
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
			if (num != 40)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				IAPFJINFNLO = input.ReadUInt32();
			}
		}
	}
}
