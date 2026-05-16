using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OECPLDABABL : IMessage<OECPLDABABL>, IMessage, IEquatable<OECPLDABABL>, IDeepCloneable<OECPLDABABL>, IBufferMessage
{
	private static readonly MessageParser<OECPLDABABL> _parser = new MessageParser<OECPLDABABL>(() => new OECPLDABABL());

	private UnknownFieldSet _unknownFields;

	public const int DMPGNLIBNDEFieldNumber = 5;

	private uint dMPGNLIBNDE_;

	public const int EHJBMNMOFLFFieldNumber = 7;

	private uint eHJBMNMOFLF_;

	public const int FGFBJLADLJBFieldNumber = 8;

	private int fGFBJLADLJB_;

	public const int IGFIHLBNDNMFieldNumber = 9;

	private uint iGFIHLBNDNM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OECPLDABABL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OECPLDABABLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DMPGNLIBNDE
	{
		get
		{
			return dMPGNLIBNDE_;
		}
		set
		{
			dMPGNLIBNDE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EHJBMNMOFLF
	{
		get
		{
			return eHJBMNMOFLF_;
		}
		set
		{
			eHJBMNMOFLF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FGFBJLADLJB
	{
		get
		{
			return fGFBJLADLJB_;
		}
		set
		{
			fGFBJLADLJB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IGFIHLBNDNM
	{
		get
		{
			return iGFIHLBNDNM_;
		}
		set
		{
			iGFIHLBNDNM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OECPLDABABL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OECPLDABABL(OECPLDABABL other)
		: this()
	{
		dMPGNLIBNDE_ = other.dMPGNLIBNDE_;
		eHJBMNMOFLF_ = other.eHJBMNMOFLF_;
		fGFBJLADLJB_ = other.fGFBJLADLJB_;
		iGFIHLBNDNM_ = other.iGFIHLBNDNM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OECPLDABABL Clone()
	{
		return new OECPLDABABL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OECPLDABABL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OECPLDABABL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DMPGNLIBNDE != other.DMPGNLIBNDE)
		{
			return false;
		}
		if (EHJBMNMOFLF != other.EHJBMNMOFLF)
		{
			return false;
		}
		if (FGFBJLADLJB != other.FGFBJLADLJB)
		{
			return false;
		}
		if (IGFIHLBNDNM != other.IGFIHLBNDNM)
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
		if (DMPGNLIBNDE != 0)
		{
			num ^= DMPGNLIBNDE.GetHashCode();
		}
		if (EHJBMNMOFLF != 0)
		{
			num ^= EHJBMNMOFLF.GetHashCode();
		}
		if (FGFBJLADLJB != 0)
		{
			num ^= FGFBJLADLJB.GetHashCode();
		}
		if (IGFIHLBNDNM != 0)
		{
			num ^= IGFIHLBNDNM.GetHashCode();
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
		if (DMPGNLIBNDE != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(DMPGNLIBNDE);
		}
		if (EHJBMNMOFLF != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(EHJBMNMOFLF);
		}
		if (FGFBJLADLJB != 0)
		{
			output.WriteRawTag(64);
			output.WriteInt32(FGFBJLADLJB);
		}
		if (IGFIHLBNDNM != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(IGFIHLBNDNM);
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
		if (DMPGNLIBNDE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DMPGNLIBNDE);
		}
		if (EHJBMNMOFLF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EHJBMNMOFLF);
		}
		if (FGFBJLADLJB != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FGFBJLADLJB);
		}
		if (IGFIHLBNDNM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IGFIHLBNDNM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OECPLDABABL other)
	{
		if (other != null)
		{
			if (other.DMPGNLIBNDE != 0)
			{
				DMPGNLIBNDE = other.DMPGNLIBNDE;
			}
			if (other.EHJBMNMOFLF != 0)
			{
				EHJBMNMOFLF = other.EHJBMNMOFLF;
			}
			if (other.FGFBJLADLJB != 0)
			{
				FGFBJLADLJB = other.FGFBJLADLJB;
			}
			if (other.IGFIHLBNDNM != 0)
			{
				IGFIHLBNDNM = other.IGFIHLBNDNM;
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
			case 40u:
				DMPGNLIBNDE = input.ReadUInt32();
				break;
			case 56u:
				EHJBMNMOFLF = input.ReadUInt32();
				break;
			case 64u:
				FGFBJLADLJB = input.ReadInt32();
				break;
			case 72u:
				IGFIHLBNDNM = input.ReadUInt32();
				break;
			}
		}
	}
}
