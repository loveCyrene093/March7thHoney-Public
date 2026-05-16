using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ParkourEndLevelScRsp : IMessage<ParkourEndLevelScRsp>, IMessage, IEquatable<ParkourEndLevelScRsp>, IDeepCloneable<ParkourEndLevelScRsp>, IBufferMessage
{
	private static readonly MessageParser<ParkourEndLevelScRsp> _parser = new MessageParser<ParkourEndLevelScRsp>(() => new ParkourEndLevelScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BCBOHFGDEMFFieldNumber = 4;

	private bool bCBOHFGDEMF_;

	public const int TimeFieldNumber = 5;

	private uint time_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int IDOPNCKAADOFieldNumber = 9;

	private bool iDOPNCKAADO_;

	public const int EFAADCIGMDKFieldNumber = 10;

	private LNGJCJNKPKE eFAADCIGMDK_;

	public const int LevelIdFieldNumber = 11;

	private uint levelId_;

	public const int EndReasonFieldNumber = 15;

	private NOMNEHCNGLH endReason_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ParkourEndLevelScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ParkourEndLevelScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BCBOHFGDEMF
	{
		get
		{
			return bCBOHFGDEMF_;
		}
		set
		{
			bCBOHFGDEMF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Time
	{
		get
		{
			return time_;
		}
		set
		{
			time_ = value;
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
	public bool IDOPNCKAADO
	{
		get
		{
			return iDOPNCKAADO_;
		}
		set
		{
			iDOPNCKAADO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LNGJCJNKPKE EFAADCIGMDK
	{
		get
		{
			return eFAADCIGMDK_;
		}
		set
		{
			eFAADCIGMDK_ = value;
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
	public NOMNEHCNGLH EndReason
	{
		get
		{
			return endReason_;
		}
		set
		{
			endReason_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ParkourEndLevelScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ParkourEndLevelScRsp(ParkourEndLevelScRsp other)
		: this()
	{
		bCBOHFGDEMF_ = other.bCBOHFGDEMF_;
		time_ = other.time_;
		retcode_ = other.retcode_;
		iDOPNCKAADO_ = other.iDOPNCKAADO_;
		eFAADCIGMDK_ = ((other.eFAADCIGMDK_ != null) ? other.eFAADCIGMDK_.Clone() : null);
		levelId_ = other.levelId_;
		endReason_ = other.endReason_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ParkourEndLevelScRsp Clone()
	{
		return new ParkourEndLevelScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ParkourEndLevelScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ParkourEndLevelScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BCBOHFGDEMF != other.BCBOHFGDEMF)
		{
			return false;
		}
		if (Time != other.Time)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (IDOPNCKAADO != other.IDOPNCKAADO)
		{
			return false;
		}
		if (!object.Equals(EFAADCIGMDK, other.EFAADCIGMDK))
		{
			return false;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (EndReason != other.EndReason)
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
		if (BCBOHFGDEMF)
		{
			num ^= BCBOHFGDEMF.GetHashCode();
		}
		if (Time != 0)
		{
			num ^= Time.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (IDOPNCKAADO)
		{
			num ^= IDOPNCKAADO.GetHashCode();
		}
		if (eFAADCIGMDK_ != null)
		{
			num ^= EFAADCIGMDK.GetHashCode();
		}
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (EndReason != NOMNEHCNGLH.Pcpdhelpkem)
		{
			num ^= EndReason.GetHashCode();
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
		if (BCBOHFGDEMF)
		{
			output.WriteRawTag(32);
			output.WriteBool(BCBOHFGDEMF);
		}
		if (Time != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Time);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (IDOPNCKAADO)
		{
			output.WriteRawTag(72);
			output.WriteBool(IDOPNCKAADO);
		}
		if (eFAADCIGMDK_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(EFAADCIGMDK);
		}
		if (LevelId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(LevelId);
		}
		if (EndReason != NOMNEHCNGLH.Pcpdhelpkem)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)EndReason);
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
		if (BCBOHFGDEMF)
		{
			num += 2;
		}
		if (Time != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Time);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (IDOPNCKAADO)
		{
			num += 2;
		}
		if (eFAADCIGMDK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EFAADCIGMDK);
		}
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		if (EndReason != NOMNEHCNGLH.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)EndReason);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ParkourEndLevelScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BCBOHFGDEMF)
		{
			BCBOHFGDEMF = other.BCBOHFGDEMF;
		}
		if (other.Time != 0)
		{
			Time = other.Time;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.IDOPNCKAADO)
		{
			IDOPNCKAADO = other.IDOPNCKAADO;
		}
		if (other.eFAADCIGMDK_ != null)
		{
			if (eFAADCIGMDK_ == null)
			{
				EFAADCIGMDK = new LNGJCJNKPKE();
			}
			EFAADCIGMDK.MergeFrom(other.EFAADCIGMDK);
		}
		if (other.LevelId != 0)
		{
			LevelId = other.LevelId;
		}
		if (other.EndReason != NOMNEHCNGLH.Pcpdhelpkem)
		{
			EndReason = other.EndReason;
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
			case 32u:
				BCBOHFGDEMF = input.ReadBool();
				break;
			case 40u:
				Time = input.ReadUInt32();
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 72u:
				IDOPNCKAADO = input.ReadBool();
				break;
			case 82u:
				if (eFAADCIGMDK_ == null)
				{
					EFAADCIGMDK = new LNGJCJNKPKE();
				}
				input.ReadMessage(EFAADCIGMDK);
				break;
			case 88u:
				LevelId = input.ReadUInt32();
				break;
			case 120u:
				EndReason = (NOMNEHCNGLH)input.ReadEnum();
				break;
			}
		}
	}
}
