using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CAOCJIENIEP : IMessage<CAOCJIENIEP>, IMessage, IEquatable<CAOCJIENIEP>, IDeepCloneable<CAOCJIENIEP>, IBufferMessage
{
	private static readonly MessageParser<CAOCJIENIEP> _parser = new MessageParser<CAOCJIENIEP>(() => new CAOCJIENIEP());

	private UnknownFieldSet _unknownFields;

	public const int BCGCGHEPDEAFieldNumber = 1;

	private uint bCGCGHEPDEA_;

	public const int FANOLNOMHFIFieldNumber = 14;

	private uint fANOLNOMHFI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CAOCJIENIEP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CAOCJIENIEPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BCGCGHEPDEA
	{
		get
		{
			return bCGCGHEPDEA_;
		}
		set
		{
			bCGCGHEPDEA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FANOLNOMHFI
	{
		get
		{
			return fANOLNOMHFI_;
		}
		set
		{
			fANOLNOMHFI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAOCJIENIEP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAOCJIENIEP(CAOCJIENIEP other)
		: this()
	{
		bCGCGHEPDEA_ = other.bCGCGHEPDEA_;
		fANOLNOMHFI_ = other.fANOLNOMHFI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CAOCJIENIEP Clone()
	{
		return new CAOCJIENIEP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CAOCJIENIEP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CAOCJIENIEP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BCGCGHEPDEA != other.BCGCGHEPDEA)
		{
			return false;
		}
		if (FANOLNOMHFI != other.FANOLNOMHFI)
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
		if (BCGCGHEPDEA != 0)
		{
			num ^= BCGCGHEPDEA.GetHashCode();
		}
		if (FANOLNOMHFI != 0)
		{
			num ^= FANOLNOMHFI.GetHashCode();
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
		if (BCGCGHEPDEA != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(BCGCGHEPDEA);
		}
		if (FANOLNOMHFI != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(FANOLNOMHFI);
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
		if (BCGCGHEPDEA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BCGCGHEPDEA);
		}
		if (FANOLNOMHFI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FANOLNOMHFI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CAOCJIENIEP other)
	{
		if (other != null)
		{
			if (other.BCGCGHEPDEA != 0)
			{
				BCGCGHEPDEA = other.BCGCGHEPDEA;
			}
			if (other.FANOLNOMHFI != 0)
			{
				FANOLNOMHFI = other.FANOLNOMHFI;
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
			case 8u:
				BCGCGHEPDEA = input.ReadUInt32();
				break;
			case 112u:
				FANOLNOMHFI = input.ReadUInt32();
				break;
			}
		}
	}
}
