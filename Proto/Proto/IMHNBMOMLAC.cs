using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IMHNBMOMLAC : IMessage<IMHNBMOMLAC>, IMessage, IEquatable<IMHNBMOMLAC>, IDeepCloneable<IMHNBMOMLAC>, IBufferMessage
{
	private static readonly MessageParser<IMHNBMOMLAC> _parser = new MessageParser<IMHNBMOMLAC>(() => new IMHNBMOMLAC());

	private UnknownFieldSet _unknownFields;

	public const int IIMKIFDKJHOFieldNumber = 7;

	private uint iIMKIFDKJHO_;

	public const int JDPHBPHAPKHFieldNumber = 12;

	private uint jDPHBPHAPKH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IMHNBMOMLAC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IMHNBMOMLACReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IIMKIFDKJHO
	{
		get
		{
			return iIMKIFDKJHO_;
		}
		set
		{
			iIMKIFDKJHO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JDPHBPHAPKH
	{
		get
		{
			return jDPHBPHAPKH_;
		}
		set
		{
			jDPHBPHAPKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IMHNBMOMLAC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IMHNBMOMLAC(IMHNBMOMLAC other)
		: this()
	{
		iIMKIFDKJHO_ = other.iIMKIFDKJHO_;
		jDPHBPHAPKH_ = other.jDPHBPHAPKH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IMHNBMOMLAC Clone()
	{
		return new IMHNBMOMLAC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IMHNBMOMLAC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IMHNBMOMLAC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IIMKIFDKJHO != other.IIMKIFDKJHO)
		{
			return false;
		}
		if (JDPHBPHAPKH != other.JDPHBPHAPKH)
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
		if (IIMKIFDKJHO != 0)
		{
			num ^= IIMKIFDKJHO.GetHashCode();
		}
		if (JDPHBPHAPKH != 0)
		{
			num ^= JDPHBPHAPKH.GetHashCode();
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
		if (IIMKIFDKJHO != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(IIMKIFDKJHO);
		}
		if (JDPHBPHAPKH != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(JDPHBPHAPKH);
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
		if (IIMKIFDKJHO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IIMKIFDKJHO);
		}
		if (JDPHBPHAPKH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JDPHBPHAPKH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IMHNBMOMLAC other)
	{
		if (other != null)
		{
			if (other.IIMKIFDKJHO != 0)
			{
				IIMKIFDKJHO = other.IIMKIFDKJHO;
			}
			if (other.JDPHBPHAPKH != 0)
			{
				JDPHBPHAPKH = other.JDPHBPHAPKH;
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
			case 56u:
				IIMKIFDKJHO = input.ReadUInt32();
				break;
			case 96u:
				JDPHBPHAPKH = input.ReadUInt32();
				break;
			}
		}
	}
}
