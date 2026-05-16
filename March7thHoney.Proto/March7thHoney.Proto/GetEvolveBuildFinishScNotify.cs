using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetEvolveBuildFinishScNotify : IMessage<GetEvolveBuildFinishScNotify>, IMessage, IEquatable<GetEvolveBuildFinishScNotify>, IDeepCloneable<GetEvolveBuildFinishScNotify>, IBufferMessage
{
	private static readonly MessageParser<GetEvolveBuildFinishScNotify> _parser = new MessageParser<GetEvolveBuildFinishScNotify>(() => new GetEvolveBuildFinishScNotify());

	private UnknownFieldSet _unknownFields;

	public const int MODDIBHCPPDFieldNumber = 1;

	private CJLJDKLCNDA mODDIBHCPPD_;

	public const int ScoreIdFieldNumber = 3;

	private uint scoreId_;

	public const int ExpFieldNumber = 4;

	private uint exp_;

	public const int GHIMJDPPJOGFieldNumber = 5;

	private CPCMNIKFLCH gHIMJDPPJOG_;

	public const int COLPBCECFOMFieldNumber = 6;

	private uint cOLPBCECFOM_;

	public const int LevelIdFieldNumber = 10;

	private uint levelId_;

	public const int WaveFieldNumber = 12;

	private uint wave_;

	public const int ItemValueFieldNumber = 13;

	private uint itemValue_;

	public const int JADBKBABANGFieldNumber = 14;

	private bool jADBKBABANG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetEvolveBuildFinishScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetEvolveBuildFinishScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CJLJDKLCNDA MODDIBHCPPD
	{
		get
		{
			return mODDIBHCPPD_;
		}
		set
		{
			mODDIBHCPPD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Exp
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
	public CPCMNIKFLCH GHIMJDPPJOG
	{
		get
		{
			return gHIMJDPPJOG_;
		}
		set
		{
			gHIMJDPPJOG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint COLPBCECFOM
	{
		get
		{
			return cOLPBCECFOM_;
		}
		set
		{
			cOLPBCECFOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Wave
	{
		get
		{
			return wave_;
		}
		set
		{
			wave_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemValue
	{
		get
		{
			return itemValue_;
		}
		set
		{
			itemValue_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JADBKBABANG
	{
		get
		{
			return jADBKBABANG_;
		}
		set
		{
			jADBKBABANG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetEvolveBuildFinishScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetEvolveBuildFinishScNotify(GetEvolveBuildFinishScNotify other)
		: this()
	{
		mODDIBHCPPD_ = ((other.mODDIBHCPPD_ != null) ? other.mODDIBHCPPD_.Clone() : null);
		scoreId_ = other.scoreId_;
		exp_ = other.exp_;
		gHIMJDPPJOG_ = other.gHIMJDPPJOG_;
		cOLPBCECFOM_ = other.cOLPBCECFOM_;
		levelId_ = other.levelId_;
		wave_ = other.wave_;
		itemValue_ = other.itemValue_;
		jADBKBABANG_ = other.jADBKBABANG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetEvolveBuildFinishScNotify Clone()
	{
		return new GetEvolveBuildFinishScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetEvolveBuildFinishScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetEvolveBuildFinishScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MODDIBHCPPD, other.MODDIBHCPPD))
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (Exp != other.Exp)
		{
			return false;
		}
		if (GHIMJDPPJOG != other.GHIMJDPPJOG)
		{
			return false;
		}
		if (COLPBCECFOM != other.COLPBCECFOM)
		{
			return false;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (Wave != other.Wave)
		{
			return false;
		}
		if (ItemValue != other.ItemValue)
		{
			return false;
		}
		if (JADBKBABANG != other.JADBKBABANG)
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
		if (mODDIBHCPPD_ != null)
		{
			num ^= MODDIBHCPPD.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (Exp != 0)
		{
			num ^= Exp.GetHashCode();
		}
		if (GHIMJDPPJOG != CPCMNIKFLCH.Kbjaikjefbb)
		{
			num ^= GHIMJDPPJOG.GetHashCode();
		}
		if (COLPBCECFOM != 0)
		{
			num ^= COLPBCECFOM.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (Wave != 0)
		{
			num ^= Wave.GetHashCode();
		}
		if (ItemValue != 0)
		{
			num ^= ItemValue.GetHashCode();
		}
		if (JADBKBABANG)
		{
			num ^= JADBKBABANG.GetHashCode();
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
		if (mODDIBHCPPD_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MODDIBHCPPD);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(ScoreId);
		}
		if (Exp != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Exp);
		}
		if (GHIMJDPPJOG != CPCMNIKFLCH.Kbjaikjefbb)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)GHIMJDPPJOG);
		}
		if (COLPBCECFOM != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(COLPBCECFOM);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(LevelId);
		}
		if (Wave != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Wave);
		}
		if (ItemValue != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ItemValue);
		}
		if (JADBKBABANG)
		{
			output.WriteRawTag(112);
			output.WriteBool(JADBKBABANG);
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
		if (mODDIBHCPPD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MODDIBHCPPD);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (Exp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Exp);
		}
		if (GHIMJDPPJOG != CPCMNIKFLCH.Kbjaikjefbb)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)GHIMJDPPJOG);
		}
		if (COLPBCECFOM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(COLPBCECFOM);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		if (Wave != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Wave);
		}
		if (ItemValue != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemValue);
		}
		if (JADBKBABANG)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetEvolveBuildFinishScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mODDIBHCPPD_ != null)
		{
			if (mODDIBHCPPD_ == null)
			{
				MODDIBHCPPD = new CJLJDKLCNDA();
			}
			MODDIBHCPPD.MergeFrom(other.MODDIBHCPPD);
		}
		if (other.ScoreId != 0)
		{
			ScoreId = other.ScoreId;
		}
		if (other.Exp != 0)
		{
			Exp = other.Exp;
		}
		if (other.GHIMJDPPJOG != CPCMNIKFLCH.Kbjaikjefbb)
		{
			GHIMJDPPJOG = other.GHIMJDPPJOG;
		}
		if (other.COLPBCECFOM != 0)
		{
			COLPBCECFOM = other.COLPBCECFOM;
		}
		if (other.LevelId != 0)
		{
			LevelId = other.LevelId;
		}
		if (other.Wave != 0)
		{
			Wave = other.Wave;
		}
		if (other.ItemValue != 0)
		{
			ItemValue = other.ItemValue;
		}
		if (other.JADBKBABANG)
		{
			JADBKBABANG = other.JADBKBABANG;
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
				if (mODDIBHCPPD_ == null)
				{
					MODDIBHCPPD = new CJLJDKLCNDA();
				}
				input.ReadMessage(MODDIBHCPPD);
				break;
			case 24u:
				ScoreId = input.ReadUInt32();
				break;
			case 32u:
				Exp = input.ReadUInt32();
				break;
			case 40u:
				GHIMJDPPJOG = (CPCMNIKFLCH)input.ReadEnum();
				break;
			case 48u:
				COLPBCECFOM = input.ReadUInt32();
				break;
			case 80u:
				LevelId = input.ReadUInt32();
				break;
			case 96u:
				Wave = input.ReadUInt32();
				break;
			case 104u:
				ItemValue = input.ReadUInt32();
				break;
			case 112u:
				JADBKBABANG = input.ReadBool();
				break;
			}
		}
	}
}
