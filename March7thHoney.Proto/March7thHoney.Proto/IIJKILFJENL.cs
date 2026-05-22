using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IIJKILFJENL : IMessage<IIJKILFJENL>, IMessage, IEquatable<IIJKILFJENL>, IDeepCloneable<IIJKILFJENL>, IBufferMessage
{
	private static readonly MessageParser<IIJKILFJENL> _parser = new MessageParser<IIJKILFJENL>(() => new IIJKILFJENL());

	private UnknownFieldSet _unknownFields;

	public const int COOOFFKIDMCFieldNumber = 2;

	private uint cOOOFFKIDMC_;

	public const int FDDHIBCEOKEFieldNumber = 7;

	private bool fDDHIBCEOKE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IIJKILFJENL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IIJKILFJENLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint COOOFFKIDMC
	{
		get
		{
			return cOOOFFKIDMC_;
		}
		set
		{
			cOOOFFKIDMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool FDDHIBCEOKE
	{
		get
		{
			return fDDHIBCEOKE_;
		}
		set
		{
			fDDHIBCEOKE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IIJKILFJENL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IIJKILFJENL(IIJKILFJENL other)
		: this()
	{
		cOOOFFKIDMC_ = other.cOOOFFKIDMC_;
		fDDHIBCEOKE_ = other.fDDHIBCEOKE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IIJKILFJENL Clone()
	{
		return new IIJKILFJENL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IIJKILFJENL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IIJKILFJENL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (COOOFFKIDMC != other.COOOFFKIDMC)
		{
			return false;
		}
		if (FDDHIBCEOKE != other.FDDHIBCEOKE)
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
		if (COOOFFKIDMC != 0)
		{
			num ^= COOOFFKIDMC.GetHashCode();
		}
		if (FDDHIBCEOKE)
		{
			num ^= FDDHIBCEOKE.GetHashCode();
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
		if (COOOFFKIDMC != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(COOOFFKIDMC);
		}
		if (FDDHIBCEOKE)
		{
			output.WriteRawTag(56);
			output.WriteBool(FDDHIBCEOKE);
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
		if (COOOFFKIDMC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(COOOFFKIDMC);
		}
		if (FDDHIBCEOKE)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IIJKILFJENL other)
	{
		if (other != null)
		{
			if (other.COOOFFKIDMC != 0)
			{
				COOOFFKIDMC = other.COOOFFKIDMC;
			}
			if (other.FDDHIBCEOKE)
			{
				FDDHIBCEOKE = other.FDDHIBCEOKE;
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
				COOOFFKIDMC = input.ReadUInt32();
				break;
			case 56u:
				FDDHIBCEOKE = input.ReadBool();
				break;
			}
		}
	}
}
