using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JCEEENOLDIF : IMessage<JCEEENOLDIF>, IMessage, IEquatable<JCEEENOLDIF>, IDeepCloneable<JCEEENOLDIF>, IBufferMessage
{
	private static readonly MessageParser<JCEEENOLDIF> _parser = new MessageParser<JCEEENOLDIF>(() => new JCEEENOLDIF());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 3;

	private TreasureDungeonRecordType type_;

	public const int CMAPCGGABJIFieldNumber = 8;

	private uint cMAPCGGABJI_;

	public const int GHAIGLAHMHOFieldNumber = 10;

	private uint gHAIGLAHMHO_;

	public const int PNIDNOGHMBHFieldNumber = 12;

	private uint pNIDNOGHMBH_;

	public const int HAFFDDDPFGAFieldNumber = 14;

	private uint hAFFDDDPFGA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JCEEENOLDIF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JCEEENOLDIFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TreasureDungeonRecordType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CMAPCGGABJI
	{
		get
		{
			return cMAPCGGABJI_;
		}
		set
		{
			cMAPCGGABJI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GHAIGLAHMHO
	{
		get
		{
			return gHAIGLAHMHO_;
		}
		set
		{
			gHAIGLAHMHO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PNIDNOGHMBH
	{
		get
		{
			return pNIDNOGHMBH_;
		}
		set
		{
			pNIDNOGHMBH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HAFFDDDPFGA
	{
		get
		{
			return hAFFDDDPFGA_;
		}
		set
		{
			hAFFDDDPFGA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCEEENOLDIF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCEEENOLDIF(JCEEENOLDIF other)
		: this()
	{
		type_ = other.type_;
		cMAPCGGABJI_ = other.cMAPCGGABJI_;
		gHAIGLAHMHO_ = other.gHAIGLAHMHO_;
		pNIDNOGHMBH_ = other.pNIDNOGHMBH_;
		hAFFDDDPFGA_ = other.hAFFDDDPFGA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCEEENOLDIF Clone()
	{
		return new JCEEENOLDIF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JCEEENOLDIF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JCEEENOLDIF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (CMAPCGGABJI != other.CMAPCGGABJI)
		{
			return false;
		}
		if (GHAIGLAHMHO != other.GHAIGLAHMHO)
		{
			return false;
		}
		if (PNIDNOGHMBH != other.PNIDNOGHMBH)
		{
			return false;
		}
		if (HAFFDDDPFGA != other.HAFFDDDPFGA)
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
		if (Type != TreasureDungeonRecordType.CelmkjfkclkFobkgbghanc)
		{
			num ^= Type.GetHashCode();
		}
		if (CMAPCGGABJI != 0)
		{
			num ^= CMAPCGGABJI.GetHashCode();
		}
		if (GHAIGLAHMHO != 0)
		{
			num ^= GHAIGLAHMHO.GetHashCode();
		}
		if (PNIDNOGHMBH != 0)
		{
			num ^= PNIDNOGHMBH.GetHashCode();
		}
		if (HAFFDDDPFGA != 0)
		{
			num ^= HAFFDDDPFGA.GetHashCode();
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
		if (Type != TreasureDungeonRecordType.CelmkjfkclkFobkgbghanc)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)Type);
		}
		if (CMAPCGGABJI != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(CMAPCGGABJI);
		}
		if (GHAIGLAHMHO != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(GHAIGLAHMHO);
		}
		if (PNIDNOGHMBH != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(PNIDNOGHMBH);
		}
		if (HAFFDDDPFGA != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(HAFFDDDPFGA);
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
		if (Type != TreasureDungeonRecordType.CelmkjfkclkFobkgbghanc)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (CMAPCGGABJI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CMAPCGGABJI);
		}
		if (GHAIGLAHMHO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GHAIGLAHMHO);
		}
		if (PNIDNOGHMBH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PNIDNOGHMBH);
		}
		if (HAFFDDDPFGA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HAFFDDDPFGA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JCEEENOLDIF other)
	{
		if (other != null)
		{
			if (other.Type != TreasureDungeonRecordType.CelmkjfkclkFobkgbghanc)
			{
				Type = other.Type;
			}
			if (other.CMAPCGGABJI != 0)
			{
				CMAPCGGABJI = other.CMAPCGGABJI;
			}
			if (other.GHAIGLAHMHO != 0)
			{
				GHAIGLAHMHO = other.GHAIGLAHMHO;
			}
			if (other.PNIDNOGHMBH != 0)
			{
				PNIDNOGHMBH = other.PNIDNOGHMBH;
			}
			if (other.HAFFDDDPFGA != 0)
			{
				HAFFDDDPFGA = other.HAFFDDDPFGA;
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
				Type = (TreasureDungeonRecordType)input.ReadEnum();
				break;
			case 64u:
				CMAPCGGABJI = input.ReadUInt32();
				break;
			case 80u:
				GHAIGLAHMHO = input.ReadUInt32();
				break;
			case 96u:
				PNIDNOGHMBH = input.ReadUInt32();
				break;
			case 112u:
				HAFFDDDPFGA = input.ReadUInt32();
				break;
			}
		}
	}
}
