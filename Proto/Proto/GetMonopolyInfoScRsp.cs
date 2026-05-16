using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetMonopolyInfoScRsp : IMessage<GetMonopolyInfoScRsp>, IMessage, IEquatable<GetMonopolyInfoScRsp>, IDeepCloneable<GetMonopolyInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetMonopolyInfoScRsp> _parser = new MessageParser<GetMonopolyInfoScRsp>(() => new GetMonopolyInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int OBOOODMPBBHFieldNumber = 1;

	private NOJCNLNIBBH oBOOODMPBBH_;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int MNHBJFMNNOFFieldNumber = 3;

	private FIOJPNPLKNP mNHBJFMNNOF_;

	public const int GMOKKMANOJDFieldNumber = 5;

	private static readonly FieldCodec<uint> _repeated_gMOKKMANOJD_codec = FieldCodec.ForUInt32(42u);

	private readonly RepeatedField<uint> gMOKKMANOJD_ = new RepeatedField<uint>();

	public const int GHLEJOGAICJFieldNumber = 6;

	private CIFMFBBMIDG gHLEJOGAICJ_;

	public const int FBACKLDDEBLFieldNumber = 7;

	private JLLHMAHMCBF fBACKLDDEBL_;

	public const int HKGKNEKKJHBFieldNumber = 8;

	private IMKOOMMHAML hKGKNEKKJHB_;

	public const int GGLDOGIHFLGFieldNumber = 9;

	private FFKCDBGNELO gGLDOGIHFLG_;

	public const int FFCDOBMOCDOFieldNumber = 10;

	private OHJFHJHFGBH fFCDOBMOCDO_;

	public const int SttFieldNumber = 12;

	private MDKPOAEEGJB stt_;

	public const int EOBENDPKFBOFieldNumber = 13;

	private ODONLHDAPKB eOBENDPKFBO_;

	public const int AMMJECHPGPEFieldNumber = 14;

	private IMDPAIOOHMF aMMJECHPGPE_;

	public const int EDHLMHHAHDDFieldNumber = 15;

	private GFNGJAJAJJH eDHLMHHAHDD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetMonopolyInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetMonopolyInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NOJCNLNIBBH OBOOODMPBBH
	{
		get
		{
			return oBOOODMPBBH_;
		}
		set
		{
			oBOOODMPBBH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIOJPNPLKNP MNHBJFMNNOF
	{
		get
		{
			return mNHBJFMNNOF_;
		}
		set
		{
			mNHBJFMNNOF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> GMOKKMANOJD => gMOKKMANOJD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIFMFBBMIDG GHLEJOGAICJ
	{
		get
		{
			return gHLEJOGAICJ_;
		}
		set
		{
			gHLEJOGAICJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLLHMAHMCBF FBACKLDDEBL
	{
		get
		{
			return fBACKLDDEBL_;
		}
		set
		{
			fBACKLDDEBL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IMKOOMMHAML HKGKNEKKJHB
	{
		get
		{
			return hKGKNEKKJHB_;
		}
		set
		{
			hKGKNEKKJHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFKCDBGNELO GGLDOGIHFLG
	{
		get
		{
			return gGLDOGIHFLG_;
		}
		set
		{
			gGLDOGIHFLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OHJFHJHFGBH FFCDOBMOCDO
	{
		get
		{
			return fFCDOBMOCDO_;
		}
		set
		{
			fFCDOBMOCDO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDKPOAEEGJB Stt
	{
		get
		{
			return stt_;
		}
		set
		{
			stt_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODONLHDAPKB EOBENDPKFBO
	{
		get
		{
			return eOBENDPKFBO_;
		}
		set
		{
			eOBENDPKFBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IMDPAIOOHMF AMMJECHPGPE
	{
		get
		{
			return aMMJECHPGPE_;
		}
		set
		{
			aMMJECHPGPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GFNGJAJAJJH EDHLMHHAHDD
	{
		get
		{
			return eDHLMHHAHDD_;
		}
		set
		{
			eDHLMHHAHDD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMonopolyInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMonopolyInfoScRsp(GetMonopolyInfoScRsp other)
		: this()
	{
		oBOOODMPBBH_ = ((other.oBOOODMPBBH_ != null) ? other.oBOOODMPBBH_.Clone() : null);
		retcode_ = other.retcode_;
		mNHBJFMNNOF_ = ((other.mNHBJFMNNOF_ != null) ? other.mNHBJFMNNOF_.Clone() : null);
		gMOKKMANOJD_ = other.gMOKKMANOJD_.Clone();
		gHLEJOGAICJ_ = ((other.gHLEJOGAICJ_ != null) ? other.gHLEJOGAICJ_.Clone() : null);
		fBACKLDDEBL_ = ((other.fBACKLDDEBL_ != null) ? other.fBACKLDDEBL_.Clone() : null);
		hKGKNEKKJHB_ = ((other.hKGKNEKKJHB_ != null) ? other.hKGKNEKKJHB_.Clone() : null);
		gGLDOGIHFLG_ = ((other.gGLDOGIHFLG_ != null) ? other.gGLDOGIHFLG_.Clone() : null);
		fFCDOBMOCDO_ = ((other.fFCDOBMOCDO_ != null) ? other.fFCDOBMOCDO_.Clone() : null);
		stt_ = ((other.stt_ != null) ? other.stt_.Clone() : null);
		eOBENDPKFBO_ = ((other.eOBENDPKFBO_ != null) ? other.eOBENDPKFBO_.Clone() : null);
		aMMJECHPGPE_ = ((other.aMMJECHPGPE_ != null) ? other.aMMJECHPGPE_.Clone() : null);
		eDHLMHHAHDD_ = ((other.eDHLMHHAHDD_ != null) ? other.eDHLMHHAHDD_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMonopolyInfoScRsp Clone()
	{
		return new GetMonopolyInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetMonopolyInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetMonopolyInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OBOOODMPBBH, other.OBOOODMPBBH))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(MNHBJFMNNOF, other.MNHBJFMNNOF))
		{
			return false;
		}
		if (!gMOKKMANOJD_.Equals(other.gMOKKMANOJD_))
		{
			return false;
		}
		if (!object.Equals(GHLEJOGAICJ, other.GHLEJOGAICJ))
		{
			return false;
		}
		if (!object.Equals(FBACKLDDEBL, other.FBACKLDDEBL))
		{
			return false;
		}
		if (!object.Equals(HKGKNEKKJHB, other.HKGKNEKKJHB))
		{
			return false;
		}
		if (!object.Equals(GGLDOGIHFLG, other.GGLDOGIHFLG))
		{
			return false;
		}
		if (!object.Equals(FFCDOBMOCDO, other.FFCDOBMOCDO))
		{
			return false;
		}
		if (!object.Equals(Stt, other.Stt))
		{
			return false;
		}
		if (!object.Equals(EOBENDPKFBO, other.EOBENDPKFBO))
		{
			return false;
		}
		if (!object.Equals(AMMJECHPGPE, other.AMMJECHPGPE))
		{
			return false;
		}
		if (!object.Equals(EDHLMHHAHDD, other.EDHLMHHAHDD))
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
		if (oBOOODMPBBH_ != null)
		{
			num ^= OBOOODMPBBH.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (mNHBJFMNNOF_ != null)
		{
			num ^= MNHBJFMNNOF.GetHashCode();
		}
		num ^= gMOKKMANOJD_.GetHashCode();
		if (gHLEJOGAICJ_ != null)
		{
			num ^= GHLEJOGAICJ.GetHashCode();
		}
		if (fBACKLDDEBL_ != null)
		{
			num ^= FBACKLDDEBL.GetHashCode();
		}
		if (hKGKNEKKJHB_ != null)
		{
			num ^= HKGKNEKKJHB.GetHashCode();
		}
		if (gGLDOGIHFLG_ != null)
		{
			num ^= GGLDOGIHFLG.GetHashCode();
		}
		if (fFCDOBMOCDO_ != null)
		{
			num ^= FFCDOBMOCDO.GetHashCode();
		}
		if (stt_ != null)
		{
			num ^= Stt.GetHashCode();
		}
		if (eOBENDPKFBO_ != null)
		{
			num ^= EOBENDPKFBO.GetHashCode();
		}
		if (aMMJECHPGPE_ != null)
		{
			num ^= AMMJECHPGPE.GetHashCode();
		}
		if (eDHLMHHAHDD_ != null)
		{
			num ^= EDHLMHHAHDD.GetHashCode();
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
		if (oBOOODMPBBH_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(OBOOODMPBBH);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (mNHBJFMNNOF_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(MNHBJFMNNOF);
		}
		gMOKKMANOJD_.WriteTo(ref output, _repeated_gMOKKMANOJD_codec);
		if (gHLEJOGAICJ_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(GHLEJOGAICJ);
		}
		if (fBACKLDDEBL_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(FBACKLDDEBL);
		}
		if (hKGKNEKKJHB_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(HKGKNEKKJHB);
		}
		if (gGLDOGIHFLG_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(GGLDOGIHFLG);
		}
		if (fFCDOBMOCDO_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(FFCDOBMOCDO);
		}
		if (stt_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(Stt);
		}
		if (eOBENDPKFBO_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(EOBENDPKFBO);
		}
		if (aMMJECHPGPE_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(AMMJECHPGPE);
		}
		if (eDHLMHHAHDD_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(EDHLMHHAHDD);
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
		if (oBOOODMPBBH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OBOOODMPBBH);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (mNHBJFMNNOF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MNHBJFMNNOF);
		}
		num += gMOKKMANOJD_.CalculateSize(_repeated_gMOKKMANOJD_codec);
		if (gHLEJOGAICJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GHLEJOGAICJ);
		}
		if (fBACKLDDEBL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FBACKLDDEBL);
		}
		if (hKGKNEKKJHB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HKGKNEKKJHB);
		}
		if (gGLDOGIHFLG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GGLDOGIHFLG);
		}
		if (fFCDOBMOCDO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FFCDOBMOCDO);
		}
		if (stt_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Stt);
		}
		if (eOBENDPKFBO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EOBENDPKFBO);
		}
		if (aMMJECHPGPE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AMMJECHPGPE);
		}
		if (eDHLMHHAHDD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EDHLMHHAHDD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetMonopolyInfoScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oBOOODMPBBH_ != null)
		{
			if (oBOOODMPBBH_ == null)
			{
				OBOOODMPBBH = new NOJCNLNIBBH();
			}
			OBOOODMPBBH.MergeFrom(other.OBOOODMPBBH);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.mNHBJFMNNOF_ != null)
		{
			if (mNHBJFMNNOF_ == null)
			{
				MNHBJFMNNOF = new FIOJPNPLKNP();
			}
			MNHBJFMNNOF.MergeFrom(other.MNHBJFMNNOF);
		}
		gMOKKMANOJD_.Add(other.gMOKKMANOJD_);
		if (other.gHLEJOGAICJ_ != null)
		{
			if (gHLEJOGAICJ_ == null)
			{
				GHLEJOGAICJ = new CIFMFBBMIDG();
			}
			GHLEJOGAICJ.MergeFrom(other.GHLEJOGAICJ);
		}
		if (other.fBACKLDDEBL_ != null)
		{
			if (fBACKLDDEBL_ == null)
			{
				FBACKLDDEBL = new JLLHMAHMCBF();
			}
			FBACKLDDEBL.MergeFrom(other.FBACKLDDEBL);
		}
		if (other.hKGKNEKKJHB_ != null)
		{
			if (hKGKNEKKJHB_ == null)
			{
				HKGKNEKKJHB = new IMKOOMMHAML();
			}
			HKGKNEKKJHB.MergeFrom(other.HKGKNEKKJHB);
		}
		if (other.gGLDOGIHFLG_ != null)
		{
			if (gGLDOGIHFLG_ == null)
			{
				GGLDOGIHFLG = new FFKCDBGNELO();
			}
			GGLDOGIHFLG.MergeFrom(other.GGLDOGIHFLG);
		}
		if (other.fFCDOBMOCDO_ != null)
		{
			if (fFCDOBMOCDO_ == null)
			{
				FFCDOBMOCDO = new OHJFHJHFGBH();
			}
			FFCDOBMOCDO.MergeFrom(other.FFCDOBMOCDO);
		}
		if (other.stt_ != null)
		{
			if (stt_ == null)
			{
				Stt = new MDKPOAEEGJB();
			}
			Stt.MergeFrom(other.Stt);
		}
		if (other.eOBENDPKFBO_ != null)
		{
			if (eOBENDPKFBO_ == null)
			{
				EOBENDPKFBO = new ODONLHDAPKB();
			}
			EOBENDPKFBO.MergeFrom(other.EOBENDPKFBO);
		}
		if (other.aMMJECHPGPE_ != null)
		{
			if (aMMJECHPGPE_ == null)
			{
				AMMJECHPGPE = new IMDPAIOOHMF();
			}
			AMMJECHPGPE.MergeFrom(other.AMMJECHPGPE);
		}
		if (other.eDHLMHHAHDD_ != null)
		{
			if (eDHLMHHAHDD_ == null)
			{
				EDHLMHHAHDD = new GFNGJAJAJJH();
			}
			EDHLMHHAHDD.MergeFrom(other.EDHLMHHAHDD);
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
			case 10u:
				if (oBOOODMPBBH_ == null)
				{
					OBOOODMPBBH = new NOJCNLNIBBH();
				}
				input.ReadMessage(OBOOODMPBBH);
				break;
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 26u:
				if (mNHBJFMNNOF_ == null)
				{
					MNHBJFMNNOF = new FIOJPNPLKNP();
				}
				input.ReadMessage(MNHBJFMNNOF);
				break;
			case 40u:
			case 42u:
				gMOKKMANOJD_.AddEntriesFrom(ref input, _repeated_gMOKKMANOJD_codec);
				break;
			case 50u:
				if (gHLEJOGAICJ_ == null)
				{
					GHLEJOGAICJ = new CIFMFBBMIDG();
				}
				input.ReadMessage(GHLEJOGAICJ);
				break;
			case 58u:
				if (fBACKLDDEBL_ == null)
				{
					FBACKLDDEBL = new JLLHMAHMCBF();
				}
				input.ReadMessage(FBACKLDDEBL);
				break;
			case 66u:
				if (hKGKNEKKJHB_ == null)
				{
					HKGKNEKKJHB = new IMKOOMMHAML();
				}
				input.ReadMessage(HKGKNEKKJHB);
				break;
			case 74u:
				if (gGLDOGIHFLG_ == null)
				{
					GGLDOGIHFLG = new FFKCDBGNELO();
				}
				input.ReadMessage(GGLDOGIHFLG);
				break;
			case 82u:
				if (fFCDOBMOCDO_ == null)
				{
					FFCDOBMOCDO = new OHJFHJHFGBH();
				}
				input.ReadMessage(FFCDOBMOCDO);
				break;
			case 98u:
				if (stt_ == null)
				{
					Stt = new MDKPOAEEGJB();
				}
				input.ReadMessage(Stt);
				break;
			case 106u:
				if (eOBENDPKFBO_ == null)
				{
					EOBENDPKFBO = new ODONLHDAPKB();
				}
				input.ReadMessage(EOBENDPKFBO);
				break;
			case 114u:
				if (aMMJECHPGPE_ == null)
				{
					AMMJECHPGPE = new IMDPAIOOHMF();
				}
				input.ReadMessage(AMMJECHPGPE);
				break;
			case 122u:
				if (eDHLMHHAHDD_ == null)
				{
					EDHLMHHAHDD = new GFNGJAJAJJH();
				}
				input.ReadMessage(EDHLMHHAHDD);
				break;
			}
		}
	}
}
