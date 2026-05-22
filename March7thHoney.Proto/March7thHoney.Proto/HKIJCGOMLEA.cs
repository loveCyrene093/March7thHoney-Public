using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class HKIJCGOMLEA : IMessage<HKIJCGOMLEA>, IMessage, IEquatable<HKIJCGOMLEA>, IDeepCloneable<HKIJCGOMLEA>, IBufferMessage
{
	private static readonly MessageParser<HKIJCGOMLEA> _parser = new MessageParser<HKIJCGOMLEA>(() => new HKIJCGOMLEA());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private ulong id_;

	public const int IBPLHNAAEIBFieldNumber = 2;

	private FightGameMode iBPLHNAAEIB_;

	public const int LMNKCJEHEMNFieldNumber = 3;

	private static readonly FieldCodec<ADHNJADIJAC> _repeated_lMNKCJEHEMN_codec = FieldCodec.ForMessage(26u, ADHNJADIJAC.Parser);

	private readonly RepeatedField<ADHNJADIJAC> lMNKCJEHEMN_ = new RepeatedField<ADHNJADIJAC>();

	public const int TypeFieldNumber = 4;

	private PFNAOGJDEMN type_;

	public const int MGDNOACBFOEFieldNumber = 5;

	private ulong mGDNOACBFOE_;

	public const int BGHICIBOLLIFieldNumber = 6;

	private ulong bGHICIBOLLI_;

	public const int OFCKCNDOBOMFieldNumber = 8;

	private NJBNHHAPKHB oFCKCNDOBOM_;

	public const int POFOCMIHJIAFieldNumber = 9;

	private PBICJCPDLGD pOFOCMIHJIA_;

	public const int MGFMLBDEHNLFieldNumber = 11;

	private FIKNLFBIPHK mGFMLBDEHNL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HKIJCGOMLEA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => HKIJCGOMLEAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong Id
	{
		get
		{
			return id_;
		}
		set
		{
			id_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightGameMode IBPLHNAAEIB
	{
		get
		{
			return iBPLHNAAEIB_;
		}
		set
		{
			iBPLHNAAEIB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ADHNJADIJAC> LMNKCJEHEMN => lMNKCJEHEMN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PFNAOGJDEMN Type
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
	public ulong MGDNOACBFOE
	{
		get
		{
			return mGDNOACBFOE_;
		}
		set
		{
			mGDNOACBFOE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong BGHICIBOLLI
	{
		get
		{
			return bGHICIBOLLI_;
		}
		set
		{
			bGHICIBOLLI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NJBNHHAPKHB OFCKCNDOBOM
	{
		get
		{
			return oFCKCNDOBOM_;
		}
		set
		{
			oFCKCNDOBOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBICJCPDLGD POFOCMIHJIA
	{
		get
		{
			return pOFOCMIHJIA_;
		}
		set
		{
			pOFOCMIHJIA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIKNLFBIPHK MGFMLBDEHNL
	{
		get
		{
			return mGFMLBDEHNL_;
		}
		set
		{
			mGFMLBDEHNL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKIJCGOMLEA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKIJCGOMLEA(HKIJCGOMLEA other)
		: this()
	{
		id_ = other.id_;
		iBPLHNAAEIB_ = other.iBPLHNAAEIB_;
		lMNKCJEHEMN_ = other.lMNKCJEHEMN_.Clone();
		type_ = other.type_;
		mGDNOACBFOE_ = other.mGDNOACBFOE_;
		bGHICIBOLLI_ = other.bGHICIBOLLI_;
		oFCKCNDOBOM_ = other.oFCKCNDOBOM_;
		pOFOCMIHJIA_ = ((other.pOFOCMIHJIA_ != null) ? other.pOFOCMIHJIA_.Clone() : null);
		mGFMLBDEHNL_ = ((other.mGFMLBDEHNL_ != null) ? other.mGFMLBDEHNL_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HKIJCGOMLEA Clone()
	{
		return new HKIJCGOMLEA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as HKIJCGOMLEA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HKIJCGOMLEA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Id != other.Id)
		{
			return false;
		}
		if (IBPLHNAAEIB != other.IBPLHNAAEIB)
		{
			return false;
		}
		if (!lMNKCJEHEMN_.Equals(other.lMNKCJEHEMN_))
		{
			return false;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (MGDNOACBFOE != other.MGDNOACBFOE)
		{
			return false;
		}
		if (BGHICIBOLLI != other.BGHICIBOLLI)
		{
			return false;
		}
		if (OFCKCNDOBOM != other.OFCKCNDOBOM)
		{
			return false;
		}
		if (!object.Equals(POFOCMIHJIA, other.POFOCMIHJIA))
		{
			return false;
		}
		if (!object.Equals(MGFMLBDEHNL, other.MGFMLBDEHNL))
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
		if (Id != 0L)
		{
			num ^= Id.GetHashCode();
		}
		if (IBPLHNAAEIB != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num ^= IBPLHNAAEIB.GetHashCode();
		}
		num ^= lMNKCJEHEMN_.GetHashCode();
		if (Type != PFNAOGJDEMN.Pcpdhelpkem)
		{
			num ^= Type.GetHashCode();
		}
		if (MGDNOACBFOE != 0L)
		{
			num ^= MGDNOACBFOE.GetHashCode();
		}
		if (BGHICIBOLLI != 0L)
		{
			num ^= BGHICIBOLLI.GetHashCode();
		}
		if (OFCKCNDOBOM != NJBNHHAPKHB.Pcpdhelpkem)
		{
			num ^= OFCKCNDOBOM.GetHashCode();
		}
		if (pOFOCMIHJIA_ != null)
		{
			num ^= POFOCMIHJIA.GetHashCode();
		}
		if (mGFMLBDEHNL_ != null)
		{
			num ^= MGFMLBDEHNL.GetHashCode();
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
		if (Id != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(Id);
		}
		if (IBPLHNAAEIB != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)IBPLHNAAEIB);
		}
		lMNKCJEHEMN_.WriteTo(ref output, _repeated_lMNKCJEHEMN_codec);
		if (Type != PFNAOGJDEMN.Pcpdhelpkem)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)Type);
		}
		if (MGDNOACBFOE != 0L)
		{
			output.WriteRawTag(40);
			output.WriteUInt64(MGDNOACBFOE);
		}
		if (BGHICIBOLLI != 0L)
		{
			output.WriteRawTag(48);
			output.WriteUInt64(BGHICIBOLLI);
		}
		if (OFCKCNDOBOM != NJBNHHAPKHB.Pcpdhelpkem)
		{
			output.WriteRawTag(64);
			output.WriteEnum((int)OFCKCNDOBOM);
		}
		if (pOFOCMIHJIA_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(POFOCMIHJIA);
		}
		if (mGFMLBDEHNL_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(MGFMLBDEHNL);
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
		if (Id != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(Id);
		}
		if (IBPLHNAAEIB != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)IBPLHNAAEIB);
		}
		num += lMNKCJEHEMN_.CalculateSize(_repeated_lMNKCJEHEMN_codec);
		if (Type != PFNAOGJDEMN.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		if (MGDNOACBFOE != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(MGDNOACBFOE);
		}
		if (BGHICIBOLLI != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(BGHICIBOLLI);
		}
		if (OFCKCNDOBOM != NJBNHHAPKHB.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)OFCKCNDOBOM);
		}
		if (pOFOCMIHJIA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(POFOCMIHJIA);
		}
		if (mGFMLBDEHNL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MGFMLBDEHNL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HKIJCGOMLEA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Id != 0L)
		{
			Id = other.Id;
		}
		if (other.IBPLHNAAEIB != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			IBPLHNAAEIB = other.IBPLHNAAEIB;
		}
		lMNKCJEHEMN_.Add(other.lMNKCJEHEMN_);
		if (other.Type != PFNAOGJDEMN.Pcpdhelpkem)
		{
			Type = other.Type;
		}
		if (other.MGDNOACBFOE != 0L)
		{
			MGDNOACBFOE = other.MGDNOACBFOE;
		}
		if (other.BGHICIBOLLI != 0L)
		{
			BGHICIBOLLI = other.BGHICIBOLLI;
		}
		if (other.OFCKCNDOBOM != NJBNHHAPKHB.Pcpdhelpkem)
		{
			OFCKCNDOBOM = other.OFCKCNDOBOM;
		}
		if (other.pOFOCMIHJIA_ != null)
		{
			if (pOFOCMIHJIA_ == null)
			{
				POFOCMIHJIA = new PBICJCPDLGD();
			}
			POFOCMIHJIA.MergeFrom(other.POFOCMIHJIA);
		}
		if (other.mGFMLBDEHNL_ != null)
		{
			if (mGFMLBDEHNL_ == null)
			{
				MGFMLBDEHNL = new FIKNLFBIPHK();
			}
			MGFMLBDEHNL.MergeFrom(other.MGFMLBDEHNL);
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
			case 8u:
				Id = input.ReadUInt64();
				break;
			case 16u:
				IBPLHNAAEIB = (FightGameMode)input.ReadEnum();
				break;
			case 26u:
				lMNKCJEHEMN_.AddEntriesFrom(ref input, _repeated_lMNKCJEHEMN_codec);
				break;
			case 32u:
				Type = (PFNAOGJDEMN)input.ReadEnum();
				break;
			case 40u:
				MGDNOACBFOE = input.ReadUInt64();
				break;
			case 48u:
				BGHICIBOLLI = input.ReadUInt64();
				break;
			case 64u:
				OFCKCNDOBOM = (NJBNHHAPKHB)input.ReadEnum();
				break;
			case 74u:
				if (pOFOCMIHJIA_ == null)
				{
					POFOCMIHJIA = new PBICJCPDLGD();
				}
				input.ReadMessage(POFOCMIHJIA);
				break;
			case 90u:
				if (mGFMLBDEHNL_ == null)
				{
					MGFMLBDEHNL = new FIKNLFBIPHK();
				}
				input.ReadMessage(MGFMLBDEHNL);
				break;
			}
		}
	}
}
