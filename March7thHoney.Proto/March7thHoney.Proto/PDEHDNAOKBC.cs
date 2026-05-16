using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PDEHDNAOKBC : IMessage<PDEHDNAOKBC>, IMessage, IEquatable<PDEHDNAOKBC>, IDeepCloneable<PDEHDNAOKBC>, IBufferMessage
{
	private static readonly MessageParser<PDEHDNAOKBC> _parser = new MessageParser<PDEHDNAOKBC>(() => new PDEHDNAOKBC());

	private UnknownFieldSet _unknownFields;

	public const int KLAAFEIMAMIFieldNumber = 13;

	private uint kLAAFEIMAMI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PDEHDNAOKBC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PDEHDNAOKBCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KLAAFEIMAMI
	{
		get
		{
			return kLAAFEIMAMI_;
		}
		set
		{
			kLAAFEIMAMI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PDEHDNAOKBC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PDEHDNAOKBC(PDEHDNAOKBC other)
		: this()
	{
		kLAAFEIMAMI_ = other.kLAAFEIMAMI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PDEHDNAOKBC Clone()
	{
		return new PDEHDNAOKBC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PDEHDNAOKBC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PDEHDNAOKBC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KLAAFEIMAMI != other.KLAAFEIMAMI)
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
		if (KLAAFEIMAMI != 0)
		{
			num ^= KLAAFEIMAMI.GetHashCode();
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
		if (KLAAFEIMAMI != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(KLAAFEIMAMI);
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
		if (KLAAFEIMAMI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KLAAFEIMAMI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PDEHDNAOKBC other)
	{
		if (other != null)
		{
			if (other.KLAAFEIMAMI != 0)
			{
				KLAAFEIMAMI = other.KLAAFEIMAMI;
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
				KLAAFEIMAMI = input.ReadUInt32();
			}
		}
	}
}
