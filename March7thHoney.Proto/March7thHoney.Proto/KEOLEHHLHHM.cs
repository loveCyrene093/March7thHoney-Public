using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KEOLEHHLHHM : IMessage<KEOLEHHLHHM>, IMessage, IEquatable<KEOLEHHLHHM>, IDeepCloneable<KEOLEHHLHHM>, IBufferMessage
{
	private static readonly MessageParser<KEOLEHHLHHM> _parser = new MessageParser<KEOLEHHLHHM>(() => new KEOLEHHLHHM());

	private UnknownFieldSet _unknownFields;

	public const int EDIGJGGPPONFieldNumber = 4;

	private uint eDIGJGGPPON_;

	public const int AuthkeyVerFieldNumber = 8;

	private BDHENEOKMFE authkeyVer_;

	public const int HMPPEEMEPMCFieldNumber = 15;

	private uint hMPPEEMEPMC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KEOLEHHLHHM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KEOLEHHLHHMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EDIGJGGPPON
	{
		get
		{
			return eDIGJGGPPON_;
		}
		set
		{
			eDIGJGGPPON_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BDHENEOKMFE AuthkeyVer
	{
		get
		{
			return authkeyVer_;
		}
		set
		{
			authkeyVer_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HMPPEEMEPMC
	{
		get
		{
			return hMPPEEMEPMC_;
		}
		set
		{
			hMPPEEMEPMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEOLEHHLHHM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEOLEHHLHHM(KEOLEHHLHHM other)
		: this()
	{
		eDIGJGGPPON_ = other.eDIGJGGPPON_;
		authkeyVer_ = other.authkeyVer_;
		hMPPEEMEPMC_ = other.hMPPEEMEPMC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KEOLEHHLHHM Clone()
	{
		return new KEOLEHHLHHM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KEOLEHHLHHM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KEOLEHHLHHM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EDIGJGGPPON != other.EDIGJGGPPON)
		{
			return false;
		}
		if (AuthkeyVer != other.AuthkeyVer)
		{
			return false;
		}
		if (HMPPEEMEPMC != other.HMPPEEMEPMC)
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
		if (EDIGJGGPPON != 0)
		{
			num ^= EDIGJGGPPON.GetHashCode();
		}
		if (AuthkeyVer != BDHENEOKMFE.Pcpdhelpkem)
		{
			num ^= AuthkeyVer.GetHashCode();
		}
		if (HMPPEEMEPMC != 0)
		{
			num ^= HMPPEEMEPMC.GetHashCode();
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
		if (EDIGJGGPPON != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(EDIGJGGPPON);
		}
		if (AuthkeyVer != BDHENEOKMFE.Pcpdhelpkem)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)AuthkeyVer);
		}
		if (HMPPEEMEPMC != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(HMPPEEMEPMC);
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
		if (EDIGJGGPPON != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EDIGJGGPPON);
		}
		if (AuthkeyVer != BDHENEOKMFE.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)AuthkeyVer);
		}
		if (HMPPEEMEPMC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HMPPEEMEPMC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KEOLEHHLHHM other)
	{
		if (other != null)
		{
			if (other.EDIGJGGPPON != 0)
			{
				EDIGJGGPPON = other.EDIGJGGPPON;
			}
			if (other.AuthkeyVer != BDHENEOKMFE.Pcpdhelpkem)
			{
				AuthkeyVer = other.AuthkeyVer;
			}
			if (other.HMPPEEMEPMC != 0)
			{
				HMPPEEMEPMC = other.HMPPEEMEPMC;
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
			case 32u:
				EDIGJGGPPON = input.ReadUInt32();
				break;
			case 64u:
				AuthkeyVer = (BDHENEOKMFE)input.ReadEnum();
				break;
			case 120u:
				HMPPEEMEPMC = input.ReadUInt32();
				break;
			}
		}
	}
}
