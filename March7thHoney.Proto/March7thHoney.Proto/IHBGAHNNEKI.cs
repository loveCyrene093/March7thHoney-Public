using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IHBGAHNNEKI : IMessage<IHBGAHNNEKI>, IMessage, IEquatable<IHBGAHNNEKI>, IDeepCloneable<IHBGAHNNEKI>, IBufferMessage
{
	private static readonly MessageParser<IHBGAHNNEKI> _parser = new MessageParser<IHBGAHNNEKI>(() => new IHBGAHNNEKI());

	private UnknownFieldSet _unknownFields;

	public const int RoomIdFieldNumber = 1;

	private ulong roomId_;

	public const int MMLKFJIAKKHFieldNumber = 2;

	private uint mMLKFJIAKKH_;

	public const int NDKAIAFPNBJFieldNumber = 3;

	private uint nDKAIAFPNBJ_;

	public const int GLNMEPNKHLNFieldNumber = 4;

	private uint gLNMEPNKHLN_;

	public const int EEJCIOGHFCKFieldNumber = 5;

	private uint eEJCIOGHFCK_;

	public const int FKEHOGMGLJFFieldNumber = 6;

	private CIMCDCBNNKJ fKEHOGMGLJF_;

	public const int HMDBAGELEIEFieldNumber = 7;

	private CIMCDCBNNKJ hMDBAGELEIE_;

	public const int MonsterBattleTypeFieldNumber = 8;

	private uint monsterBattleType_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IHBGAHNNEKI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IHBGAHNNEKIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong RoomId
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
	public uint MMLKFJIAKKH
	{
		get
		{
			return mMLKFJIAKKH_;
		}
		set
		{
			mMLKFJIAKKH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NDKAIAFPNBJ
	{
		get
		{
			return nDKAIAFPNBJ_;
		}
		set
		{
			nDKAIAFPNBJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GLNMEPNKHLN
	{
		get
		{
			return gLNMEPNKHLN_;
		}
		set
		{
			gLNMEPNKHLN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EEJCIOGHFCK
	{
		get
		{
			return eEJCIOGHFCK_;
		}
		set
		{
			eEJCIOGHFCK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIMCDCBNNKJ FKEHOGMGLJF
	{
		get
		{
			return fKEHOGMGLJF_;
		}
		set
		{
			fKEHOGMGLJF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIMCDCBNNKJ HMDBAGELEIE
	{
		get
		{
			return hMDBAGELEIE_;
		}
		set
		{
			hMDBAGELEIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MonsterBattleType
	{
		get
		{
			return monsterBattleType_;
		}
		set
		{
			monsterBattleType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHBGAHNNEKI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHBGAHNNEKI(IHBGAHNNEKI other)
		: this()
	{
		roomId_ = other.roomId_;
		mMLKFJIAKKH_ = other.mMLKFJIAKKH_;
		nDKAIAFPNBJ_ = other.nDKAIAFPNBJ_;
		gLNMEPNKHLN_ = other.gLNMEPNKHLN_;
		eEJCIOGHFCK_ = other.eEJCIOGHFCK_;
		fKEHOGMGLJF_ = ((other.fKEHOGMGLJF_ != null) ? other.fKEHOGMGLJF_.Clone() : null);
		hMDBAGELEIE_ = ((other.hMDBAGELEIE_ != null) ? other.hMDBAGELEIE_.Clone() : null);
		monsterBattleType_ = other.monsterBattleType_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IHBGAHNNEKI Clone()
	{
		return new IHBGAHNNEKI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IHBGAHNNEKI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IHBGAHNNEKI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoomId != other.RoomId)
		{
			return false;
		}
		if (MMLKFJIAKKH != other.MMLKFJIAKKH)
		{
			return false;
		}
		if (NDKAIAFPNBJ != other.NDKAIAFPNBJ)
		{
			return false;
		}
		if (GLNMEPNKHLN != other.GLNMEPNKHLN)
		{
			return false;
		}
		if (EEJCIOGHFCK != other.EEJCIOGHFCK)
		{
			return false;
		}
		if (!object.Equals(FKEHOGMGLJF, other.FKEHOGMGLJF))
		{
			return false;
		}
		if (!object.Equals(HMDBAGELEIE, other.HMDBAGELEIE))
		{
			return false;
		}
		if (MonsterBattleType != other.MonsterBattleType)
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
		if (RoomId != 0L)
		{
			num ^= RoomId.GetHashCode();
		}
		if (MMLKFJIAKKH != 0)
		{
			num ^= MMLKFJIAKKH.GetHashCode();
		}
		if (NDKAIAFPNBJ != 0)
		{
			num ^= NDKAIAFPNBJ.GetHashCode();
		}
		if (GLNMEPNKHLN != 0)
		{
			num ^= GLNMEPNKHLN.GetHashCode();
		}
		if (EEJCIOGHFCK != 0)
		{
			num ^= EEJCIOGHFCK.GetHashCode();
		}
		if (fKEHOGMGLJF_ != null)
		{
			num ^= FKEHOGMGLJF.GetHashCode();
		}
		if (hMDBAGELEIE_ != null)
		{
			num ^= HMDBAGELEIE.GetHashCode();
		}
		if (MonsterBattleType != 0)
		{
			num ^= MonsterBattleType.GetHashCode();
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
		if (RoomId != 0L)
		{
			output.WriteRawTag(8);
			output.WriteUInt64(RoomId);
		}
		if (MMLKFJIAKKH != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MMLKFJIAKKH);
		}
		if (NDKAIAFPNBJ != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(NDKAIAFPNBJ);
		}
		if (GLNMEPNKHLN != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GLNMEPNKHLN);
		}
		if (EEJCIOGHFCK != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(EEJCIOGHFCK);
		}
		if (fKEHOGMGLJF_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(FKEHOGMGLJF);
		}
		if (hMDBAGELEIE_ != null)
		{
			output.WriteRawTag(58);
			output.WriteMessage(HMDBAGELEIE);
		}
		if (MonsterBattleType != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(MonsterBattleType);
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
		if (RoomId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoomId);
		}
		if (MMLKFJIAKKH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMLKFJIAKKH);
		}
		if (NDKAIAFPNBJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NDKAIAFPNBJ);
		}
		if (GLNMEPNKHLN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GLNMEPNKHLN);
		}
		if (EEJCIOGHFCK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EEJCIOGHFCK);
		}
		if (fKEHOGMGLJF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FKEHOGMGLJF);
		}
		if (hMDBAGELEIE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(HMDBAGELEIE);
		}
		if (MonsterBattleType != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MonsterBattleType);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IHBGAHNNEKI other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RoomId != 0L)
		{
			RoomId = other.RoomId;
		}
		if (other.MMLKFJIAKKH != 0)
		{
			MMLKFJIAKKH = other.MMLKFJIAKKH;
		}
		if (other.NDKAIAFPNBJ != 0)
		{
			NDKAIAFPNBJ = other.NDKAIAFPNBJ;
		}
		if (other.GLNMEPNKHLN != 0)
		{
			GLNMEPNKHLN = other.GLNMEPNKHLN;
		}
		if (other.EEJCIOGHFCK != 0)
		{
			EEJCIOGHFCK = other.EEJCIOGHFCK;
		}
		if (other.fKEHOGMGLJF_ != null)
		{
			if (fKEHOGMGLJF_ == null)
			{
				FKEHOGMGLJF = new CIMCDCBNNKJ();
			}
			FKEHOGMGLJF.MergeFrom(other.FKEHOGMGLJF);
		}
		if (other.hMDBAGELEIE_ != null)
		{
			if (hMDBAGELEIE_ == null)
			{
				HMDBAGELEIE = new CIMCDCBNNKJ();
			}
			HMDBAGELEIE.MergeFrom(other.HMDBAGELEIE);
		}
		if (other.MonsterBattleType != 0)
		{
			MonsterBattleType = other.MonsterBattleType;
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
				RoomId = input.ReadUInt64();
				break;
			case 16u:
				MMLKFJIAKKH = input.ReadUInt32();
				break;
			case 24u:
				NDKAIAFPNBJ = input.ReadUInt32();
				break;
			case 32u:
				GLNMEPNKHLN = input.ReadUInt32();
				break;
			case 40u:
				EEJCIOGHFCK = input.ReadUInt32();
				break;
			case 50u:
				if (fKEHOGMGLJF_ == null)
				{
					FKEHOGMGLJF = new CIMCDCBNNKJ();
				}
				input.ReadMessage(FKEHOGMGLJF);
				break;
			case 58u:
				if (hMDBAGELEIE_ == null)
				{
					HMDBAGELEIE = new CIMCDCBNNKJ();
				}
				input.ReadMessage(HMDBAGELEIE);
				break;
			case 64u:
				MonsterBattleType = input.ReadUInt32();
				break;
			}
		}
	}
}
