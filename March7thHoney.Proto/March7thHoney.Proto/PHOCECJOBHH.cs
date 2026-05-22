using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PHOCECJOBHH : IMessage<PHOCECJOBHH>, IMessage, IEquatable<PHOCECJOBHH>, IDeepCloneable<PHOCECJOBHH>, IBufferMessage
{
	private static readonly MessageParser<PHOCECJOBHH> _parser = new MessageParser<PHOCECJOBHH>(() => new PHOCECJOBHH());

	private UnknownFieldSet _unknownFields;

	public const int UidFieldNumber = 1;

	private uint uid_;

	public const int DAECKFGAKLFFieldNumber = 2;

	private uint dAECKFGAKLF_;

	public const int OAOJAEPJFFOFieldNumber = 3;

	private bool oAOJAEPJFFO_;

	public const int GCMNADAKONJFieldNumber = 4;

	private uint gCMNADAKONJ_;

	public const int ReplayNameFieldNumber = 5;

	private string replayName_ = "";

	public const int AvatarListFieldNumber = 6;

	private static readonly FieldCodec<GLMBJJOFPAC> _repeated_avatarList_codec = FieldCodec.ForMessage(50u, GLMBJJOFPAC.Parser);

	private readonly RepeatedField<GLMBJJOFPAC> avatarList_ = new RepeatedField<GLMBJJOFPAC>();

	public const int GGHCFMOLDNIFieldNumber = 7;

	private uint gGHCFMOLDNI_;

	public const int PDBNGNABDJIFieldNumber = 8;

	private uint pDBNGNABDJI_;

	public const int MHDJJDNHILKFieldNumber = 9;

	private uint mHDJJDNHILK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PHOCECJOBHH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PHOCECJOBHHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DAECKFGAKLF
	{
		get
		{
			return dAECKFGAKLF_;
		}
		set
		{
			dAECKFGAKLF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OAOJAEPJFFO
	{
		get
		{
			return oAOJAEPJFFO_;
		}
		set
		{
			oAOJAEPJFFO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GCMNADAKONJ
	{
		get
		{
			return gCMNADAKONJ_;
		}
		set
		{
			gCMNADAKONJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ReplayName
	{
		get
		{
			return replayName_;
		}
		set
		{
			replayName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GLMBJJOFPAC> AvatarList => avatarList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GGHCFMOLDNI
	{
		get
		{
			return gGHCFMOLDNI_;
		}
		set
		{
			gGHCFMOLDNI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PDBNGNABDJI
	{
		get
		{
			return pDBNGNABDJI_;
		}
		set
		{
			pDBNGNABDJI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MHDJJDNHILK
	{
		get
		{
			return mHDJJDNHILK_;
		}
		set
		{
			mHDJJDNHILK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHOCECJOBHH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHOCECJOBHH(PHOCECJOBHH other)
		: this()
	{
		uid_ = other.uid_;
		dAECKFGAKLF_ = other.dAECKFGAKLF_;
		oAOJAEPJFFO_ = other.oAOJAEPJFFO_;
		gCMNADAKONJ_ = other.gCMNADAKONJ_;
		replayName_ = other.replayName_;
		avatarList_ = other.avatarList_.Clone();
		gGHCFMOLDNI_ = other.gGHCFMOLDNI_;
		pDBNGNABDJI_ = other.pDBNGNABDJI_;
		mHDJJDNHILK_ = other.mHDJJDNHILK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHOCECJOBHH Clone()
	{
		return new PHOCECJOBHH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PHOCECJOBHH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PHOCECJOBHH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (DAECKFGAKLF != other.DAECKFGAKLF)
		{
			return false;
		}
		if (OAOJAEPJFFO != other.OAOJAEPJFFO)
		{
			return false;
		}
		if (GCMNADAKONJ != other.GCMNADAKONJ)
		{
			return false;
		}
		if (ReplayName != other.ReplayName)
		{
			return false;
		}
		if (!avatarList_.Equals(other.avatarList_))
		{
			return false;
		}
		if (GGHCFMOLDNI != other.GGHCFMOLDNI)
		{
			return false;
		}
		if (PDBNGNABDJI != other.PDBNGNABDJI)
		{
			return false;
		}
		if (MHDJJDNHILK != other.MHDJJDNHILK)
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
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (DAECKFGAKLF != 0)
		{
			num ^= DAECKFGAKLF.GetHashCode();
		}
		if (OAOJAEPJFFO)
		{
			num ^= OAOJAEPJFFO.GetHashCode();
		}
		if (GCMNADAKONJ != 0)
		{
			num ^= GCMNADAKONJ.GetHashCode();
		}
		if (ReplayName.Length != 0)
		{
			num ^= ReplayName.GetHashCode();
		}
		num ^= avatarList_.GetHashCode();
		if (GGHCFMOLDNI != 0)
		{
			num ^= GGHCFMOLDNI.GetHashCode();
		}
		if (PDBNGNABDJI != 0)
		{
			num ^= PDBNGNABDJI.GetHashCode();
		}
		if (MHDJJDNHILK != 0)
		{
			num ^= MHDJJDNHILK.GetHashCode();
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
		if (Uid != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Uid);
		}
		if (DAECKFGAKLF != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(DAECKFGAKLF);
		}
		if (OAOJAEPJFFO)
		{
			output.WriteRawTag(24);
			output.WriteBool(OAOJAEPJFFO);
		}
		if (GCMNADAKONJ != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GCMNADAKONJ);
		}
		if (ReplayName.Length != 0)
		{
			output.WriteRawTag(42);
			output.WriteString(ReplayName);
		}
		avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
		if (GGHCFMOLDNI != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(GGHCFMOLDNI);
		}
		if (PDBNGNABDJI != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PDBNGNABDJI);
		}
		if (MHDJJDNHILK != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(MHDJJDNHILK);
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
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (DAECKFGAKLF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DAECKFGAKLF);
		}
		if (OAOJAEPJFFO)
		{
			num += 2;
		}
		if (GCMNADAKONJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GCMNADAKONJ);
		}
		if (ReplayName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ReplayName);
		}
		num += avatarList_.CalculateSize(_repeated_avatarList_codec);
		if (GGHCFMOLDNI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GGHCFMOLDNI);
		}
		if (PDBNGNABDJI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PDBNGNABDJI);
		}
		if (MHDJJDNHILK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MHDJJDNHILK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PHOCECJOBHH other)
	{
		if (other != null)
		{
			if (other.Uid != 0)
			{
				Uid = other.Uid;
			}
			if (other.DAECKFGAKLF != 0)
			{
				DAECKFGAKLF = other.DAECKFGAKLF;
			}
			if (other.OAOJAEPJFFO)
			{
				OAOJAEPJFFO = other.OAOJAEPJFFO;
			}
			if (other.GCMNADAKONJ != 0)
			{
				GCMNADAKONJ = other.GCMNADAKONJ;
			}
			if (other.ReplayName.Length != 0)
			{
				ReplayName = other.ReplayName;
			}
			avatarList_.Add(other.avatarList_);
			if (other.GGHCFMOLDNI != 0)
			{
				GGHCFMOLDNI = other.GGHCFMOLDNI;
			}
			if (other.PDBNGNABDJI != 0)
			{
				PDBNGNABDJI = other.PDBNGNABDJI;
			}
			if (other.MHDJJDNHILK != 0)
			{
				MHDJJDNHILK = other.MHDJJDNHILK;
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
				Uid = input.ReadUInt32();
				break;
			case 16u:
				DAECKFGAKLF = input.ReadUInt32();
				break;
			case 24u:
				OAOJAEPJFFO = input.ReadBool();
				break;
			case 32u:
				GCMNADAKONJ = input.ReadUInt32();
				break;
			case 42u:
				ReplayName = input.ReadString();
				break;
			case 50u:
				avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
				break;
			case 56u:
				GGHCFMOLDNI = input.ReadUInt32();
				break;
			case 64u:
				PDBNGNABDJI = input.ReadUInt32();
				break;
			case 72u:
				MHDJJDNHILK = input.ReadUInt32();
				break;
			}
		}
	}
}
