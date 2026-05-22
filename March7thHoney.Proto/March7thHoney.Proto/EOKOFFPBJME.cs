using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EOKOFFPBJME : IMessage<EOKOFFPBJME>, IMessage, IEquatable<EOKOFFPBJME>, IDeepCloneable<EOKOFFPBJME>, IBufferMessage
{
	private static readonly MessageParser<EOKOFFPBJME> _parser = new MessageParser<EOKOFFPBJME>(() => new EOKOFFPBJME());

	private UnknownFieldSet _unknownFields;

	public const int FGFBJLADLJBFieldNumber = 3;

	private int fGFBJLADLJB_;

	public const int IGFIHLBNDNMFieldNumber = 6;

	private uint iGFIHLBNDNM_;

	public const int EHJBMNMOFLFFieldNumber = 7;

	private uint eHJBMNMOFLF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EOKOFFPBJME> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EOKOFFPBJMEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public EOKOFFPBJME()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EOKOFFPBJME(EOKOFFPBJME other)
		: this()
	{
		fGFBJLADLJB_ = other.fGFBJLADLJB_;
		iGFIHLBNDNM_ = other.iGFIHLBNDNM_;
		eHJBMNMOFLF_ = other.eHJBMNMOFLF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EOKOFFPBJME Clone()
	{
		return new EOKOFFPBJME(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EOKOFFPBJME);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EOKOFFPBJME other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FGFBJLADLJB != other.FGFBJLADLJB)
		{
			return false;
		}
		if (IGFIHLBNDNM != other.IGFIHLBNDNM)
		{
			return false;
		}
		if (EHJBMNMOFLF != other.EHJBMNMOFLF)
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
		if (FGFBJLADLJB != 0)
		{
			num ^= FGFBJLADLJB.GetHashCode();
		}
		if (IGFIHLBNDNM != 0)
		{
			num ^= IGFIHLBNDNM.GetHashCode();
		}
		if (EHJBMNMOFLF != 0)
		{
			num ^= EHJBMNMOFLF.GetHashCode();
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
		if (FGFBJLADLJB != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(FGFBJLADLJB);
		}
		if (IGFIHLBNDNM != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(IGFIHLBNDNM);
		}
		if (EHJBMNMOFLF != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(EHJBMNMOFLF);
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
		if (FGFBJLADLJB != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(FGFBJLADLJB);
		}
		if (IGFIHLBNDNM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IGFIHLBNDNM);
		}
		if (EHJBMNMOFLF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EHJBMNMOFLF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EOKOFFPBJME other)
	{
		if (other != null)
		{
			if (other.FGFBJLADLJB != 0)
			{
				FGFBJLADLJB = other.FGFBJLADLJB;
			}
			if (other.IGFIHLBNDNM != 0)
			{
				IGFIHLBNDNM = other.IGFIHLBNDNM;
			}
			if (other.EHJBMNMOFLF != 0)
			{
				EHJBMNMOFLF = other.EHJBMNMOFLF;
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
			case 24u:
				FGFBJLADLJB = input.ReadInt32();
				break;
			case 48u:
				IGFIHLBNDNM = input.ReadUInt32();
				break;
			case 56u:
				EHJBMNMOFLF = input.ReadUInt32();
				break;
			}
		}
	}
}
