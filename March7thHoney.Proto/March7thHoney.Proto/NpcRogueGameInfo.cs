using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NpcRogueGameInfo : IMessage<NpcRogueGameInfo>, IMessage, IEquatable<NpcRogueGameInfo>, IDeepCloneable<NpcRogueGameInfo>, IBufferMessage
{
	private static readonly MessageParser<NpcRogueGameInfo> _parser = new MessageParser<NpcRogueGameInfo>(() => new NpcRogueGameInfo());

	private UnknownFieldSet _unknownFields;

	public const int IINHPJNHGAHFieldNumber = 1;

	private bool iINHPJNHGAH_;

	public const int DHILGBCKPCLFieldNumber = 2;

	private bool dHILGBCKPCL_;

	public const int JBEILMFIIGMFieldNumber = 3;

	private uint jBEILMFIIGM_;

	public const int HOHANPJNANAFieldNumber = 6;

	private uint hOHANPJNANA_;

	public const int KIGLLJKDDNEFieldNumber = 10;

	private bool kIGLLJKDDNE_;

	public const int FOEJFEMLPPCFieldNumber = 13;

	private static readonly MapField<uint, uint>.Codec _map_fOEJFEMLPPC_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8u, 0u), FieldCodec.ForUInt32(16u, 0u), 106u);

	private readonly MapField<uint, uint> fOEJFEMLPPC_ = new MapField<uint, uint>();

	public const int AHKFFCIEPDGFieldNumber = 14;

	private uint aHKFFCIEPDG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NpcRogueGameInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NpcRogueGameInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IINHPJNHGAH
	{
		get
		{
			return iINHPJNHGAH_;
		}
		set
		{
			iINHPJNHGAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DHILGBCKPCL
	{
		get
		{
			return dHILGBCKPCL_;
		}
		set
		{
			dHILGBCKPCL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JBEILMFIIGM
	{
		get
		{
			return jBEILMFIIGM_;
		}
		set
		{
			jBEILMFIIGM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HOHANPJNANA
	{
		get
		{
			return hOHANPJNANA_;
		}
		set
		{
			hOHANPJNANA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KIGLLJKDDNE
	{
		get
		{
			return kIGLLJKDDNE_;
		}
		set
		{
			kIGLLJKDDNE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<uint, uint> FOEJFEMLPPC => fOEJFEMLPPC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AHKFFCIEPDG
	{
		get
		{
			return aHKFFCIEPDG_;
		}
		set
		{
			aHKFFCIEPDG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcRogueGameInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcRogueGameInfo(NpcRogueGameInfo other)
		: this()
	{
		iINHPJNHGAH_ = other.iINHPJNHGAH_;
		dHILGBCKPCL_ = other.dHILGBCKPCL_;
		jBEILMFIIGM_ = other.jBEILMFIIGM_;
		hOHANPJNANA_ = other.hOHANPJNANA_;
		kIGLLJKDDNE_ = other.kIGLLJKDDNE_;
		fOEJFEMLPPC_ = other.fOEJFEMLPPC_.Clone();
		aHKFFCIEPDG_ = other.aHKFFCIEPDG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcRogueGameInfo Clone()
	{
		return new NpcRogueGameInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NpcRogueGameInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NpcRogueGameInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IINHPJNHGAH != other.IINHPJNHGAH)
		{
			return false;
		}
		if (DHILGBCKPCL != other.DHILGBCKPCL)
		{
			return false;
		}
		if (JBEILMFIIGM != other.JBEILMFIIGM)
		{
			return false;
		}
		if (HOHANPJNANA != other.HOHANPJNANA)
		{
			return false;
		}
		if (KIGLLJKDDNE != other.KIGLLJKDDNE)
		{
			return false;
		}
		if (!FOEJFEMLPPC.Equals(other.FOEJFEMLPPC))
		{
			return false;
		}
		if (AHKFFCIEPDG != other.AHKFFCIEPDG)
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
		if (IINHPJNHGAH)
		{
			num ^= IINHPJNHGAH.GetHashCode();
		}
		if (DHILGBCKPCL)
		{
			num ^= DHILGBCKPCL.GetHashCode();
		}
		if (JBEILMFIIGM != 0)
		{
			num ^= JBEILMFIIGM.GetHashCode();
		}
		if (HOHANPJNANA != 0)
		{
			num ^= HOHANPJNANA.GetHashCode();
		}
		if (KIGLLJKDDNE)
		{
			num ^= KIGLLJKDDNE.GetHashCode();
		}
		num ^= FOEJFEMLPPC.GetHashCode();
		if (AHKFFCIEPDG != 0)
		{
			num ^= AHKFFCIEPDG.GetHashCode();
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
		if (IINHPJNHGAH)
		{
			output.WriteRawTag(8);
			output.WriteBool(IINHPJNHGAH);
		}
		if (DHILGBCKPCL)
		{
			output.WriteRawTag(16);
			output.WriteBool(DHILGBCKPCL);
		}
		if (JBEILMFIIGM != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(JBEILMFIIGM);
		}
		if (HOHANPJNANA != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(HOHANPJNANA);
		}
		if (KIGLLJKDDNE)
		{
			output.WriteRawTag(80);
			output.WriteBool(KIGLLJKDDNE);
		}
		fOEJFEMLPPC_.WriteTo(ref output, _map_fOEJFEMLPPC_codec);
		if (AHKFFCIEPDG != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(AHKFFCIEPDG);
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
		if (IINHPJNHGAH)
		{
			num += 2;
		}
		if (DHILGBCKPCL)
		{
			num += 2;
		}
		if (JBEILMFIIGM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JBEILMFIIGM);
		}
		if (HOHANPJNANA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HOHANPJNANA);
		}
		if (KIGLLJKDDNE)
		{
			num += 2;
		}
		num += fOEJFEMLPPC_.CalculateSize(_map_fOEJFEMLPPC_codec);
		if (AHKFFCIEPDG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AHKFFCIEPDG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NpcRogueGameInfo other)
	{
		if (other != null)
		{
			if (other.IINHPJNHGAH)
			{
				IINHPJNHGAH = other.IINHPJNHGAH;
			}
			if (other.DHILGBCKPCL)
			{
				DHILGBCKPCL = other.DHILGBCKPCL;
			}
			if (other.JBEILMFIIGM != 0)
			{
				JBEILMFIIGM = other.JBEILMFIIGM;
			}
			if (other.HOHANPJNANA != 0)
			{
				HOHANPJNANA = other.HOHANPJNANA;
			}
			if (other.KIGLLJKDDNE)
			{
				KIGLLJKDDNE = other.KIGLLJKDDNE;
			}
			fOEJFEMLPPC_.MergeFrom(other.fOEJFEMLPPC_);
			if (other.AHKFFCIEPDG != 0)
			{
				AHKFFCIEPDG = other.AHKFFCIEPDG;
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
				IINHPJNHGAH = input.ReadBool();
				break;
			case 16u:
				DHILGBCKPCL = input.ReadBool();
				break;
			case 24u:
				JBEILMFIIGM = input.ReadUInt32();
				break;
			case 48u:
				HOHANPJNANA = input.ReadUInt32();
				break;
			case 80u:
				KIGLLJKDDNE = input.ReadBool();
				break;
			case 106u:
				fOEJFEMLPPC_.AddEntriesFrom(ref input, _map_fOEJFEMLPPC_codec);
				break;
			case 112u:
				AHKFFCIEPDG = input.ReadUInt32();
				break;
			}
		}
	}
}
