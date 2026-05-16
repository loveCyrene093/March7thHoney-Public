using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AHDICMGKLMB : IMessage<AHDICMGKLMB>, IMessage, IEquatable<AHDICMGKLMB>, IDeepCloneable<AHDICMGKLMB>, IBufferMessage
{
	private static readonly MessageParser<AHDICMGKLMB> _parser = new MessageParser<AHDICMGKLMB>(() => new AHDICMGKLMB());

	private UnknownFieldSet _unknownFields;

	public const int DJIDCABJNLAFieldNumber = 2;

	private IFGDFHLNPGD dJIDCABJNLA_;

	public const int JGOEPADOKEMFieldNumber = 15;

	private uint jGOEPADOKEM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AHDICMGKLMB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AHDICMGKLMBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFGDFHLNPGD DJIDCABJNLA
	{
		get
		{
			return dJIDCABJNLA_;
		}
		set
		{
			dJIDCABJNLA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JGOEPADOKEM
	{
		get
		{
			return jGOEPADOKEM_;
		}
		set
		{
			jGOEPADOKEM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHDICMGKLMB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHDICMGKLMB(AHDICMGKLMB other)
		: this()
	{
		dJIDCABJNLA_ = ((other.dJIDCABJNLA_ != null) ? other.dJIDCABJNLA_.Clone() : null);
		jGOEPADOKEM_ = other.jGOEPADOKEM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHDICMGKLMB Clone()
	{
		return new AHDICMGKLMB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AHDICMGKLMB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AHDICMGKLMB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DJIDCABJNLA, other.DJIDCABJNLA))
		{
			return false;
		}
		if (JGOEPADOKEM != other.JGOEPADOKEM)
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
		if (dJIDCABJNLA_ != null)
		{
			num ^= DJIDCABJNLA.GetHashCode();
		}
		if (JGOEPADOKEM != 0)
		{
			num ^= JGOEPADOKEM.GetHashCode();
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
		if (dJIDCABJNLA_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(DJIDCABJNLA);
		}
		if (JGOEPADOKEM != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(JGOEPADOKEM);
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
		if (dJIDCABJNLA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DJIDCABJNLA);
		}
		if (JGOEPADOKEM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JGOEPADOKEM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AHDICMGKLMB other)
	{
		if (other == null)
		{
			return;
		}
		if (other.dJIDCABJNLA_ != null)
		{
			if (dJIDCABJNLA_ == null)
			{
				DJIDCABJNLA = new IFGDFHLNPGD();
			}
			DJIDCABJNLA.MergeFrom(other.DJIDCABJNLA);
		}
		if (other.JGOEPADOKEM != 0)
		{
			JGOEPADOKEM = other.JGOEPADOKEM;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 18u:
				if (dJIDCABJNLA_ == null)
				{
					DJIDCABJNLA = new IFGDFHLNPGD();
				}
				input.ReadMessage(DJIDCABJNLA);
				break;
			case 120u:
				JGOEPADOKEM = input.ReadUInt32();
				break;
			}
		}
	}
}
