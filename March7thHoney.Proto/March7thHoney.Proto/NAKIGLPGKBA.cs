using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NAKIGLPGKBA : IMessage<NAKIGLPGKBA>, IMessage, IEquatable<NAKIGLPGKBA>, IDeepCloneable<NAKIGLPGKBA>, IBufferMessage
{
	private static readonly MessageParser<NAKIGLPGKBA> _parser = new MessageParser<NAKIGLPGKBA>(() => new NAKIGLPGKBA());

	private UnknownFieldSet _unknownFields;

	public const int IdFieldNumber = 1;

	private uint id_;

	public const int EHNCLFLKMFAFieldNumber = 2;

	private ChessRogueBoardCellStatus eHNCLFLKMFA_;

	public const int EOOIGCCKGFBFieldNumber = 3;

	private uint eOOIGCCKGFB_;

	public const int GELDILBFGBMFieldNumber = 4;

	private ChessRogueCellSpecialType gELDILBFGBM_;

	public const int StageInfoFieldNumber = 6;

	private COFDJFIBPDM stageInfo_;

	public const int GKBENCDFCEJFieldNumber = 8;

	private uint gKBENCDFCEJ_;

	public const int CKIHBDKDOEJFieldNumber = 9;

	private bool cKIHBDKDOEJ_;

	public const int PPEPAPCEPCMFieldNumber = 10;

	private uint pPEPAPCEPCM_;

	public const int RoomIdFieldNumber = 11;

	private uint roomId_;

	public const int CEBPAJAAJPPFieldNumber = 14;

	private bool cEBPAJAAJPP_;

	public const int MFNIOBKFBKFFieldNumber = 15;

	private uint mFNIOBKFBKF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NAKIGLPGKBA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NAKIGLPGKBAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Id
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
	public ChessRogueBoardCellStatus EHNCLFLKMFA
	{
		get
		{
			return eHNCLFLKMFA_;
		}
		set
		{
			eHNCLFLKMFA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EOOIGCCKGFB
	{
		get
		{
			return eOOIGCCKGFB_;
		}
		set
		{
			eOOIGCCKGFB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChessRogueCellSpecialType GELDILBFGBM
	{
		get
		{
			return gELDILBFGBM_;
		}
		set
		{
			gELDILBFGBM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public COFDJFIBPDM StageInfo
	{
		get
		{
			return stageInfo_;
		}
		set
		{
			stageInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GKBENCDFCEJ
	{
		get
		{
			return gKBENCDFCEJ_;
		}
		set
		{
			gKBENCDFCEJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CKIHBDKDOEJ
	{
		get
		{
			return cKIHBDKDOEJ_;
		}
		set
		{
			cKIHBDKDOEJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PPEPAPCEPCM
	{
		get
		{
			return pPEPAPCEPCM_;
		}
		set
		{
			pPEPAPCEPCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint RoomId
	{
		get
		{
			return roomId_;
		}
		set
		{
			roomId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CEBPAJAAJPP
	{
		get
		{
			return cEBPAJAAJPP_;
		}
		set
		{
			cEBPAJAAJPP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MFNIOBKFBKF
	{
		get
		{
			return mFNIOBKFBKF_;
		}
		set
		{
			mFNIOBKFBKF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAKIGLPGKBA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAKIGLPGKBA(NAKIGLPGKBA other)
		: this()
	{
		id_ = other.id_;
		eHNCLFLKMFA_ = other.eHNCLFLKMFA_;
		eOOIGCCKGFB_ = other.eOOIGCCKGFB_;
		gELDILBFGBM_ = other.gELDILBFGBM_;
		stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
		gKBENCDFCEJ_ = other.gKBENCDFCEJ_;
		cKIHBDKDOEJ_ = other.cKIHBDKDOEJ_;
		pPEPAPCEPCM_ = other.pPEPAPCEPCM_;
		roomId_ = other.roomId_;
		cEBPAJAAJPP_ = other.cEBPAJAAJPP_;
		mFNIOBKFBKF_ = other.mFNIOBKFBKF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NAKIGLPGKBA Clone()
	{
		return new NAKIGLPGKBA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NAKIGLPGKBA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NAKIGLPGKBA other)
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
		if (EHNCLFLKMFA != other.EHNCLFLKMFA)
		{
			return false;
		}
		if (EOOIGCCKGFB != other.EOOIGCCKGFB)
		{
			return false;
		}
		if (GELDILBFGBM != other.GELDILBFGBM)
		{
			return false;
		}
		if (!object.Equals(StageInfo, other.StageInfo))
		{
			return false;
		}
		if (GKBENCDFCEJ != other.GKBENCDFCEJ)
		{
			return false;
		}
		if (CKIHBDKDOEJ != other.CKIHBDKDOEJ)
		{
			return false;
		}
		if (PPEPAPCEPCM != other.PPEPAPCEPCM)
		{
			return false;
		}
		if (RoomId != other.RoomId)
		{
			return false;
		}
		if (CEBPAJAAJPP != other.CEBPAJAAJPP)
		{
			return false;
		}
		if (MFNIOBKFBKF != other.MFNIOBKFBKF)
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
		if (Id != 0)
		{
			num ^= Id.GetHashCode();
		}
		if (EHNCLFLKMFA != ChessRogueBoardCellStatus.GbikcjpglbkGhgapoakgab)
		{
			num ^= EHNCLFLKMFA.GetHashCode();
		}
		if (EOOIGCCKGFB != 0)
		{
			num ^= EOOIGCCKGFB.GetHashCode();
		}
		if (GELDILBFGBM != ChessRogueCellSpecialType.PkfegchgceePcpdhelpkem)
		{
			num ^= GELDILBFGBM.GetHashCode();
		}
		if (stageInfo_ != null)
		{
			num ^= StageInfo.GetHashCode();
		}
		if (GKBENCDFCEJ != 0)
		{
			num ^= GKBENCDFCEJ.GetHashCode();
		}
		if (CKIHBDKDOEJ)
		{
			num ^= CKIHBDKDOEJ.GetHashCode();
		}
		if (PPEPAPCEPCM != 0)
		{
			num ^= PPEPAPCEPCM.GetHashCode();
		}
		if (RoomId != 0)
		{
			num ^= RoomId.GetHashCode();
		}
		if (CEBPAJAAJPP)
		{
			num ^= CEBPAJAAJPP.GetHashCode();
		}
		if (MFNIOBKFBKF != 0)
		{
			num ^= MFNIOBKFBKF.GetHashCode();
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
		if (Id != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Id);
		}
		if (EHNCLFLKMFA != ChessRogueBoardCellStatus.GbikcjpglbkGhgapoakgab)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)EHNCLFLKMFA);
		}
		if (EOOIGCCKGFB != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(EOOIGCCKGFB);
		}
		if (GELDILBFGBM != ChessRogueCellSpecialType.PkfegchgceePcpdhelpkem)
		{
			output.WriteRawTag(32);
			output.WriteEnum((int)GELDILBFGBM);
		}
		if (stageInfo_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(StageInfo);
		}
		if (GKBENCDFCEJ != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(GKBENCDFCEJ);
		}
		if (CKIHBDKDOEJ)
		{
			output.WriteRawTag(72);
			output.WriteBool(CKIHBDKDOEJ);
		}
		if (PPEPAPCEPCM != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(PPEPAPCEPCM);
		}
		if (RoomId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(RoomId);
		}
		if (CEBPAJAAJPP)
		{
			output.WriteRawTag(112);
			output.WriteBool(CEBPAJAAJPP);
		}
		if (MFNIOBKFBKF != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(MFNIOBKFBKF);
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
		if (Id != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Id);
		}
		if (EHNCLFLKMFA != ChessRogueBoardCellStatus.GbikcjpglbkGhgapoakgab)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EHNCLFLKMFA);
		}
		if (EOOIGCCKGFB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EOOIGCCKGFB);
		}
		if (GELDILBFGBM != ChessRogueCellSpecialType.PkfegchgceePcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GELDILBFGBM);
		}
		if (stageInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(StageInfo);
		}
		if (GKBENCDFCEJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GKBENCDFCEJ);
		}
		if (CKIHBDKDOEJ)
		{
			num += 2;
		}
		if (PPEPAPCEPCM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PPEPAPCEPCM);
		}
		if (RoomId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoomId);
		}
		if (CEBPAJAAJPP)
		{
			num += 2;
		}
		if (MFNIOBKFBKF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MFNIOBKFBKF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NAKIGLPGKBA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Id != 0)
		{
			Id = other.Id;
		}
		if (other.EHNCLFLKMFA != ChessRogueBoardCellStatus.GbikcjpglbkGhgapoakgab)
		{
			EHNCLFLKMFA = other.EHNCLFLKMFA;
		}
		if (other.EOOIGCCKGFB != 0)
		{
			EOOIGCCKGFB = other.EOOIGCCKGFB;
		}
		if (other.GELDILBFGBM != ChessRogueCellSpecialType.PkfegchgceePcpdhelpkem)
		{
			GELDILBFGBM = other.GELDILBFGBM;
		}
		if (other.stageInfo_ != null)
		{
			if (stageInfo_ == null)
			{
				StageInfo = new COFDJFIBPDM();
			}
			StageInfo.MergeFrom(other.StageInfo);
		}
		if (other.GKBENCDFCEJ != 0)
		{
			GKBENCDFCEJ = other.GKBENCDFCEJ;
		}
		if (other.CKIHBDKDOEJ)
		{
			CKIHBDKDOEJ = other.CKIHBDKDOEJ;
		}
		if (other.PPEPAPCEPCM != 0)
		{
			PPEPAPCEPCM = other.PPEPAPCEPCM;
		}
		if (other.RoomId != 0)
		{
			RoomId = other.RoomId;
		}
		if (other.CEBPAJAAJPP)
		{
			CEBPAJAAJPP = other.CEBPAJAAJPP;
		}
		if (other.MFNIOBKFBKF != 0)
		{
			MFNIOBKFBKF = other.MFNIOBKFBKF;
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
				Id = input.ReadUInt32();
				break;
			case 16u:
				EHNCLFLKMFA = (ChessRogueBoardCellStatus)input.ReadEnum();
				break;
			case 24u:
				EOOIGCCKGFB = input.ReadUInt32();
				break;
			case 32u:
				GELDILBFGBM = (ChessRogueCellSpecialType)input.ReadEnum();
				break;
			case 50u:
				if (stageInfo_ == null)
				{
					StageInfo = new COFDJFIBPDM();
				}
				input.ReadMessage(StageInfo);
				break;
			case 64u:
				GKBENCDFCEJ = input.ReadUInt32();
				break;
			case 72u:
				CKIHBDKDOEJ = input.ReadBool();
				break;
			case 80u:
				PPEPAPCEPCM = input.ReadUInt32();
				break;
			case 88u:
				RoomId = input.ReadUInt32();
				break;
			case 112u:
				CEBPAJAAJPP = input.ReadBool();
				break;
			case 120u:
				MFNIOBKFBKF = input.ReadUInt32();
				break;
			}
		}
	}
}
