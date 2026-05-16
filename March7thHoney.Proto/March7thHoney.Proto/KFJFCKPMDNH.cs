using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KFJFCKPMDNH : IMessage<KFJFCKPMDNH>, IMessage, IEquatable<KFJFCKPMDNH>, IDeepCloneable<KFJFCKPMDNH>, IBufferMessage
{
	private static readonly MessageParser<KFJFCKPMDNH> _parser = new MessageParser<KFJFCKPMDNH>(() => new KFJFCKPMDNH());

	private UnknownFieldSet _unknownFields;

	public const int PJLADGOOFKEFieldNumber = 13;

	private uint pJLADGOOFKE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KFJFCKPMDNH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KFJFCKPMDNHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PJLADGOOFKE
	{
		get
		{
			return pJLADGOOFKE_;
		}
		set
		{
			pJLADGOOFKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFJFCKPMDNH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFJFCKPMDNH(KFJFCKPMDNH other)
		: this()
	{
		pJLADGOOFKE_ = other.pJLADGOOFKE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFJFCKPMDNH Clone()
	{
		return new KFJFCKPMDNH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KFJFCKPMDNH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KFJFCKPMDNH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PJLADGOOFKE != other.PJLADGOOFKE)
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
		if (PJLADGOOFKE != 0)
		{
			num ^= PJLADGOOFKE.GetHashCode();
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
		if (PJLADGOOFKE != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(PJLADGOOFKE);
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
		if (PJLADGOOFKE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PJLADGOOFKE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KFJFCKPMDNH other)
	{
		if (other != null)
		{
			if (other.PJLADGOOFKE != 0)
			{
				PJLADGOOFKE = other.PJLADGOOFKE;
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
				PJLADGOOFKE = input.ReadUInt32();
			}
		}
	}
}
