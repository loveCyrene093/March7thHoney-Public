using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MGGLDHHPNBM : IMessage<MGGLDHHPNBM>, IMessage, IEquatable<MGGLDHHPNBM>, IDeepCloneable<MGGLDHHPNBM>, IBufferMessage
{
	private static readonly MessageParser<MGGLDHHPNBM> _parser = new MessageParser<MGGLDHHPNBM>(() => new MGGLDHHPNBM());

	private UnknownFieldSet _unknownFields;

	public const int LBAEHCIFNNEFieldNumber = 2;

	private uint lBAEHCIFNNE_;

	public const int AFEIBDDGGEFFieldNumber = 11;

	private uint aFEIBDDGGEF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MGGLDHHPNBM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MGGLDHHPNBMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LBAEHCIFNNE
	{
		get
		{
			return lBAEHCIFNNE_;
		}
		set
		{
			lBAEHCIFNNE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AFEIBDDGGEF
	{
		get
		{
			return aFEIBDDGGEF_;
		}
		set
		{
			aFEIBDDGGEF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGGLDHHPNBM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGGLDHHPNBM(MGGLDHHPNBM other)
		: this()
	{
		lBAEHCIFNNE_ = other.lBAEHCIFNNE_;
		aFEIBDDGGEF_ = other.aFEIBDDGGEF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGGLDHHPNBM Clone()
	{
		return new MGGLDHHPNBM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MGGLDHHPNBM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MGGLDHHPNBM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LBAEHCIFNNE != other.LBAEHCIFNNE)
		{
			return false;
		}
		if (AFEIBDDGGEF != other.AFEIBDDGGEF)
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
		if (LBAEHCIFNNE != 0)
		{
			num ^= LBAEHCIFNNE.GetHashCode();
		}
		if (AFEIBDDGGEF != 0)
		{
			num ^= AFEIBDDGGEF.GetHashCode();
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
		if (LBAEHCIFNNE != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(LBAEHCIFNNE);
		}
		if (AFEIBDDGGEF != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(AFEIBDDGGEF);
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
		if (LBAEHCIFNNE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LBAEHCIFNNE);
		}
		if (AFEIBDDGGEF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AFEIBDDGGEF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MGGLDHHPNBM other)
	{
		if (other != null)
		{
			if (other.LBAEHCIFNNE != 0)
			{
				LBAEHCIFNNE = other.LBAEHCIFNNE;
			}
			if (other.AFEIBDDGGEF != 0)
			{
				AFEIBDDGGEF = other.AFEIBDDGGEF;
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
			case 16u:
				LBAEHCIFNNE = input.ReadUInt32();
				break;
			case 88u:
				AFEIBDDGGEF = input.ReadUInt32();
				break;
			}
		}
	}
}
