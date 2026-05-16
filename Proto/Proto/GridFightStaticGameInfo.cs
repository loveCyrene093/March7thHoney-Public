using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightStaticGameInfo : IMessage<GridFightStaticGameInfo>, IMessage, IEquatable<GridFightStaticGameInfo>, IDeepCloneable<GridFightStaticGameInfo>, IBufferMessage
{
	private static readonly MessageParser<GridFightStaticGameInfo> _parser = new MessageParser<GridFightStaticGameInfo>(() => new GridFightStaticGameInfo());

	private UnknownFieldSet _unknownFields;

	public const int ExpFieldNumber = 2;

	private JIBAKJGOPJM exp_;

	public const int EDIGFNFPBKAFieldNumber = 3;

	private uint eDIGFNFPBKA_;

	public const int GridFightComboWinNumFieldNumber = 6;

	private uint gridFightComboWinNum_;

	public const int EJCFDAABLOCFieldNumber = 8;

	private GridFightHandBookInfo eJCFDAABLOC_;

	public const int CKFIACKHNAEFieldNumber = 9;

	private uint cKFIACKHNAE_;

	public const int DivisionIdFieldNumber = 11;

	private uint divisionId_;

	public const int OJLAODIALLEFieldNumber = 13;

	private GridFightTalentInfo oJLAODIALLE_;

	public const int CALIMAKGGHJFieldNumber = 15;

	private uint cALIMAKGGHJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightStaticGameInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightStaticGameInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIBAKJGOPJM Exp
	{
		get
		{
			return exp_;
		}
		set
		{
			exp_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EDIGFNFPBKA
	{
		get
		{
			return eDIGFNFPBKA_;
		}
		set
		{
			eDIGFNFPBKA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GridFightComboWinNum
	{
		get
		{
			return gridFightComboWinNum_;
		}
		set
		{
			gridFightComboWinNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightHandBookInfo EJCFDAABLOC
	{
		get
		{
			return eJCFDAABLOC_;
		}
		set
		{
			eJCFDAABLOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CKFIACKHNAE
	{
		get
		{
			return cKFIACKHNAE_;
		}
		set
		{
			cKFIACKHNAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DivisionId
	{
		get
		{
			return divisionId_;
		}
		set
		{
			divisionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightTalentInfo OJLAODIALLE
	{
		get
		{
			return oJLAODIALLE_;
		}
		set
		{
			oJLAODIALLE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CALIMAKGGHJ
	{
		get
		{
			return cALIMAKGGHJ_;
		}
		set
		{
			cALIMAKGGHJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightStaticGameInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightStaticGameInfo(GridFightStaticGameInfo other)
		: this()
	{
		exp_ = ((other.exp_ != null) ? other.exp_.Clone() : null);
		eDIGFNFPBKA_ = other.eDIGFNFPBKA_;
		gridFightComboWinNum_ = other.gridFightComboWinNum_;
		eJCFDAABLOC_ = ((other.eJCFDAABLOC_ != null) ? other.eJCFDAABLOC_.Clone() : null);
		cKFIACKHNAE_ = other.cKFIACKHNAE_;
		divisionId_ = other.divisionId_;
		oJLAODIALLE_ = ((other.oJLAODIALLE_ != null) ? other.oJLAODIALLE_.Clone() : null);
		cALIMAKGGHJ_ = other.cALIMAKGGHJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightStaticGameInfo Clone()
	{
		return new GridFightStaticGameInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightStaticGameInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightStaticGameInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Exp, other.Exp))
		{
			return false;
		}
		if (EDIGFNFPBKA != other.EDIGFNFPBKA)
		{
			return false;
		}
		if (GridFightComboWinNum != other.GridFightComboWinNum)
		{
			return false;
		}
		if (!object.Equals(EJCFDAABLOC, other.EJCFDAABLOC))
		{
			return false;
		}
		if (CKFIACKHNAE != other.CKFIACKHNAE)
		{
			return false;
		}
		if (DivisionId != other.DivisionId)
		{
			return false;
		}
		if (!object.Equals(OJLAODIALLE, other.OJLAODIALLE))
		{
			return false;
		}
		if (CALIMAKGGHJ != other.CALIMAKGGHJ)
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
		if (exp_ != null)
		{
			num ^= Exp.GetHashCode();
		}
		if (EDIGFNFPBKA != 0)
		{
			num ^= EDIGFNFPBKA.GetHashCode();
		}
		if (GridFightComboWinNum != 0)
		{
			num ^= GridFightComboWinNum.GetHashCode();
		}
		if (eJCFDAABLOC_ != null)
		{
			num ^= EJCFDAABLOC.GetHashCode();
		}
		if (CKFIACKHNAE != 0)
		{
			num ^= CKFIACKHNAE.GetHashCode();
		}
		if (DivisionId != 0)
		{
			num ^= DivisionId.GetHashCode();
		}
		if (oJLAODIALLE_ != null)
		{
			num ^= OJLAODIALLE.GetHashCode();
		}
		if (CALIMAKGGHJ != 0)
		{
			num ^= CALIMAKGGHJ.GetHashCode();
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
		if (exp_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(Exp);
		}
		if (EDIGFNFPBKA != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(EDIGFNFPBKA);
		}
		if (GridFightComboWinNum != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(GridFightComboWinNum);
		}
		if (eJCFDAABLOC_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(EJCFDAABLOC);
		}
		if (CKFIACKHNAE != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(CKFIACKHNAE);
		}
		if (DivisionId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(DivisionId);
		}
		if (oJLAODIALLE_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(OJLAODIALLE);
		}
		if (CALIMAKGGHJ != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(CALIMAKGGHJ);
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
		if (exp_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Exp);
		}
		if (EDIGFNFPBKA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EDIGFNFPBKA);
		}
		if (GridFightComboWinNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GridFightComboWinNum);
		}
		if (eJCFDAABLOC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EJCFDAABLOC);
		}
		if (CKFIACKHNAE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CKFIACKHNAE);
		}
		if (DivisionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DivisionId);
		}
		if (oJLAODIALLE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OJLAODIALLE);
		}
		if (CALIMAKGGHJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CALIMAKGGHJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightStaticGameInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.exp_ != null)
		{
			if (exp_ == null)
			{
				Exp = new JIBAKJGOPJM();
			}
			Exp.MergeFrom(other.Exp);
		}
		if (other.EDIGFNFPBKA != 0)
		{
			EDIGFNFPBKA = other.EDIGFNFPBKA;
		}
		if (other.GridFightComboWinNum != 0)
		{
			GridFightComboWinNum = other.GridFightComboWinNum;
		}
		if (other.eJCFDAABLOC_ != null)
		{
			if (eJCFDAABLOC_ == null)
			{
				EJCFDAABLOC = new GridFightHandBookInfo();
			}
			EJCFDAABLOC.MergeFrom(other.EJCFDAABLOC);
		}
		if (other.CKFIACKHNAE != 0)
		{
			CKFIACKHNAE = other.CKFIACKHNAE;
		}
		if (other.DivisionId != 0)
		{
			DivisionId = other.DivisionId;
		}
		if (other.oJLAODIALLE_ != null)
		{
			if (oJLAODIALLE_ == null)
			{
				OJLAODIALLE = new GridFightTalentInfo();
			}
			OJLAODIALLE.MergeFrom(other.OJLAODIALLE);
		}
		if (other.CALIMAKGGHJ != 0)
		{
			CALIMAKGGHJ = other.CALIMAKGGHJ;
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
				if (exp_ == null)
				{
					Exp = new JIBAKJGOPJM();
				}
				input.ReadMessage(Exp);
				break;
			case 24u:
				EDIGFNFPBKA = input.ReadUInt32();
				break;
			case 48u:
				GridFightComboWinNum = input.ReadUInt32();
				break;
			case 66u:
				if (eJCFDAABLOC_ == null)
				{
					EJCFDAABLOC = new GridFightHandBookInfo();
				}
				input.ReadMessage(EJCFDAABLOC);
				break;
			case 72u:
				CKFIACKHNAE = input.ReadUInt32();
				break;
			case 88u:
				DivisionId = input.ReadUInt32();
				break;
			case 106u:
				if (oJLAODIALLE_ == null)
				{
					OJLAODIALLE = new GridFightTalentInfo();
				}
				input.ReadMessage(OJLAODIALLE);
				break;
			case 120u:
				CALIMAKGGHJ = input.ReadUInt32();
				break;
			}
		}
	}
}
