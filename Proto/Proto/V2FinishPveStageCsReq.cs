using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class V2FinishPveStageCsReq : IMessage<V2FinishPveStageCsReq>, IMessage, IEquatable<V2FinishPveStageCsReq>, IDeepCloneable<V2FinishPveStageCsReq>, IBufferMessage
{
	private static readonly MessageParser<V2FinishPveStageCsReq> _parser = new MessageParser<V2FinishPveStageCsReq>(() => new V2FinishPveStageCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IHONDJOAPBMFieldNumber = 7;

	private uint iHONDJOAPBM_;

	public const int LNOPKMMELCCFieldNumber = 8;

	private uint lNOPKMMELCC_;

	public const int BIODAJLLINOFieldNumber = 9;

	private bool bIODAJLLINO_;

	public const int IIAJPADOLMCFieldNumber = 10;

	private uint iIAJPADOLMC_;

	public const int MMLKFJIAKKHFieldNumber = 11;

	private uint mMLKFJIAKKH_;

	public const int BEEMJECDMGBFieldNumber = 12;

	private uint bEEMJECDMGB_;

	public const int IsWinFieldNumber = 13;

	private bool isWin_;

	public const int DamageFieldNumber = 14;

	private uint damage_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<V2FinishPveStageCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => V2FinishPveStageCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IHONDJOAPBM
	{
		get
		{
			return iHONDJOAPBM_;
		}
		set
		{
			iHONDJOAPBM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LNOPKMMELCC
	{
		get
		{
			return lNOPKMMELCC_;
		}
		set
		{
			lNOPKMMELCC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BIODAJLLINO
	{
		get
		{
			return bIODAJLLINO_;
		}
		set
		{
			bIODAJLLINO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IIAJPADOLMC
	{
		get
		{
			return iIAJPADOLMC_;
		}
		set
		{
			iIAJPADOLMC_ = value;
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
	public uint BEEMJECDMGB
	{
		get
		{
			return bEEMJECDMGB_;
		}
		set
		{
			bEEMJECDMGB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsWin
	{
		get
		{
			return isWin_;
		}
		set
		{
			isWin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Damage
	{
		get
		{
			return damage_;
		}
		set
		{
			damage_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public V2FinishPveStageCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public V2FinishPveStageCsReq(V2FinishPveStageCsReq other)
		: this()
	{
		iHONDJOAPBM_ = other.iHONDJOAPBM_;
		lNOPKMMELCC_ = other.lNOPKMMELCC_;
		bIODAJLLINO_ = other.bIODAJLLINO_;
		iIAJPADOLMC_ = other.iIAJPADOLMC_;
		mMLKFJIAKKH_ = other.mMLKFJIAKKH_;
		bEEMJECDMGB_ = other.bEEMJECDMGB_;
		isWin_ = other.isWin_;
		damage_ = other.damage_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public V2FinishPveStageCsReq Clone()
	{
		return new V2FinishPveStageCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as V2FinishPveStageCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(V2FinishPveStageCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IHONDJOAPBM != other.IHONDJOAPBM)
		{
			return false;
		}
		if (LNOPKMMELCC != other.LNOPKMMELCC)
		{
			return false;
		}
		if (BIODAJLLINO != other.BIODAJLLINO)
		{
			return false;
		}
		if (IIAJPADOLMC != other.IIAJPADOLMC)
		{
			return false;
		}
		if (MMLKFJIAKKH != other.MMLKFJIAKKH)
		{
			return false;
		}
		if (BEEMJECDMGB != other.BEEMJECDMGB)
		{
			return false;
		}
		if (IsWin != other.IsWin)
		{
			return false;
		}
		if (Damage != other.Damage)
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
		if (IHONDJOAPBM != 0)
		{
			num ^= IHONDJOAPBM.GetHashCode();
		}
		if (LNOPKMMELCC != 0)
		{
			num ^= LNOPKMMELCC.GetHashCode();
		}
		if (BIODAJLLINO)
		{
			num ^= BIODAJLLINO.GetHashCode();
		}
		if (IIAJPADOLMC != 0)
		{
			num ^= IIAJPADOLMC.GetHashCode();
		}
		if (MMLKFJIAKKH != 0)
		{
			num ^= MMLKFJIAKKH.GetHashCode();
		}
		if (BEEMJECDMGB != 0)
		{
			num ^= BEEMJECDMGB.GetHashCode();
		}
		if (IsWin)
		{
			num ^= IsWin.GetHashCode();
		}
		if (Damage != 0)
		{
			num ^= Damage.GetHashCode();
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
		if (IHONDJOAPBM != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(IHONDJOAPBM);
		}
		if (LNOPKMMELCC != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(LNOPKMMELCC);
		}
		if (BIODAJLLINO)
		{
			output.WriteRawTag(72);
			output.WriteBool(BIODAJLLINO);
		}
		if (IIAJPADOLMC != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(IIAJPADOLMC);
		}
		if (MMLKFJIAKKH != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(MMLKFJIAKKH);
		}
		if (BEEMJECDMGB != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(BEEMJECDMGB);
		}
		if (IsWin)
		{
			output.WriteRawTag(104);
			output.WriteBool(IsWin);
		}
		if (Damage != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Damage);
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
		if (IHONDJOAPBM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IHONDJOAPBM);
		}
		if (LNOPKMMELCC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LNOPKMMELCC);
		}
		if (BIODAJLLINO)
		{
			num += 2;
		}
		if (IIAJPADOLMC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IIAJPADOLMC);
		}
		if (MMLKFJIAKKH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMLKFJIAKKH);
		}
		if (BEEMJECDMGB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BEEMJECDMGB);
		}
		if (IsWin)
		{
			num += 2;
		}
		if (Damage != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Damage);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(V2FinishPveStageCsReq other)
	{
		if (other != null)
		{
			if (other.IHONDJOAPBM != 0)
			{
				IHONDJOAPBM = other.IHONDJOAPBM;
			}
			if (other.LNOPKMMELCC != 0)
			{
				LNOPKMMELCC = other.LNOPKMMELCC;
			}
			if (other.BIODAJLLINO)
			{
				BIODAJLLINO = other.BIODAJLLINO;
			}
			if (other.IIAJPADOLMC != 0)
			{
				IIAJPADOLMC = other.IIAJPADOLMC;
			}
			if (other.MMLKFJIAKKH != 0)
			{
				MMLKFJIAKKH = other.MMLKFJIAKKH;
			}
			if (other.BEEMJECDMGB != 0)
			{
				BEEMJECDMGB = other.BEEMJECDMGB;
			}
			if (other.IsWin)
			{
				IsWin = other.IsWin;
			}
			if (other.Damage != 0)
			{
				Damage = other.Damage;
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
			case 56u:
				IHONDJOAPBM = input.ReadUInt32();
				break;
			case 64u:
				LNOPKMMELCC = input.ReadUInt32();
				break;
			case 72u:
				BIODAJLLINO = input.ReadBool();
				break;
			case 80u:
				IIAJPADOLMC = input.ReadUInt32();
				break;
			case 88u:
				MMLKFJIAKKH = input.ReadUInt32();
				break;
			case 96u:
				BEEMJECDMGB = input.ReadUInt32();
				break;
			case 104u:
				IsWin = input.ReadBool();
				break;
			case 112u:
				Damage = input.ReadUInt32();
				break;
			}
		}
	}
}
