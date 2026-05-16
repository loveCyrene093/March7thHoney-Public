using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CBDEPHGEPJJ : IMessage<CBDEPHGEPJJ>, IMessage, IEquatable<CBDEPHGEPJJ>, IDeepCloneable<CBDEPHGEPJJ>, IBufferMessage
{
	private static readonly MessageParser<CBDEPHGEPJJ> _parser = new MessageParser<CBDEPHGEPJJ>(() => new CBDEPHGEPJJ());

	private UnknownFieldSet _unknownFields;

	public const int LMIICENMOBIFieldNumber = 1;

	private uint lMIICENMOBI_;

	public const int HAIOHANDIKIFieldNumber = 4;

	private static readonly FieldCodec<LKFNDAOGMMO> _repeated_hAIOHANDIKI_codec = FieldCodec.ForMessage(34u, LKFNDAOGMMO.Parser);

	private readonly RepeatedField<LKFNDAOGMMO> hAIOHANDIKI_ = new RepeatedField<LKFNDAOGMMO>();

	public const int HFIHPFFADOCFieldNumber = 5;

	private bool hFIHPFFADOC_;

	public const int CurHpFieldNumber = 6;

	private uint curHp_;

	public const int IsWinFieldNumber = 10;

	private bool isWin_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	public const int EDKJMPACHNJFieldNumber = 14;

	private DCEBJIGAPEI eDKJMPACHNJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CBDEPHGEPJJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CBDEPHGEPJJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LMIICENMOBI
	{
		get
		{
			return lMIICENMOBI_;
		}
		set
		{
			lMIICENMOBI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LKFNDAOGMMO> HAIOHANDIKI => hAIOHANDIKI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HFIHPFFADOC
	{
		get
		{
			return hFIHPFFADOC_;
		}
		set
		{
			hFIHPFFADOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurHp
	{
		get
		{
			return curHp_;
		}
		set
		{
			curHp_ = value;
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
	public DCEBJIGAPEI EDKJMPACHNJ
	{
		get
		{
			return eDKJMPACHNJ_;
		}
		set
		{
			eDKJMPACHNJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CBDEPHGEPJJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CBDEPHGEPJJ(CBDEPHGEPJJ other)
		: this()
	{
		lMIICENMOBI_ = other.lMIICENMOBI_;
		hAIOHANDIKI_ = other.hAIOHANDIKI_.Clone();
		hFIHPFFADOC_ = other.hFIHPFFADOC_;
		curHp_ = other.curHp_;
		isWin_ = other.isWin_;
		retcode_ = other.retcode_;
		eDKJMPACHNJ_ = ((other.eDKJMPACHNJ_ != null) ? other.eDKJMPACHNJ_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CBDEPHGEPJJ Clone()
	{
		return new CBDEPHGEPJJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CBDEPHGEPJJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CBDEPHGEPJJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LMIICENMOBI != other.LMIICENMOBI)
		{
			return false;
		}
		if (!hAIOHANDIKI_.Equals(other.hAIOHANDIKI_))
		{
			return false;
		}
		if (HFIHPFFADOC != other.HFIHPFFADOC)
		{
			return false;
		}
		if (CurHp != other.CurHp)
		{
			return false;
		}
		if (IsWin != other.IsWin)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(EDKJMPACHNJ, other.EDKJMPACHNJ))
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
		if (LMIICENMOBI != 0)
		{
			num ^= LMIICENMOBI.GetHashCode();
		}
		num ^= hAIOHANDIKI_.GetHashCode();
		if (HFIHPFFADOC)
		{
			num ^= HFIHPFFADOC.GetHashCode();
		}
		if (CurHp != 0)
		{
			num ^= CurHp.GetHashCode();
		}
		if (IsWin)
		{
			num ^= IsWin.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (eDKJMPACHNJ_ != null)
		{
			num ^= EDKJMPACHNJ.GetHashCode();
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
		if (LMIICENMOBI != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(LMIICENMOBI);
		}
		hAIOHANDIKI_.WriteTo(ref output, _repeated_hAIOHANDIKI_codec);
		if (HFIHPFFADOC)
		{
			output.WriteRawTag(40);
			output.WriteBool(HFIHPFFADOC);
		}
		if (CurHp != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(CurHp);
		}
		if (IsWin)
		{
			output.WriteRawTag(80);
			output.WriteBool(IsWin);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
		}
		if (eDKJMPACHNJ_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(EDKJMPACHNJ);
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
		if (LMIICENMOBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LMIICENMOBI);
		}
		num += hAIOHANDIKI_.CalculateSize(_repeated_hAIOHANDIKI_codec);
		if (HFIHPFFADOC)
		{
			num += 2;
		}
		if (CurHp != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurHp);
		}
		if (IsWin)
		{
			num += 2;
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (eDKJMPACHNJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EDKJMPACHNJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CBDEPHGEPJJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.LMIICENMOBI != 0)
		{
			LMIICENMOBI = other.LMIICENMOBI;
		}
		hAIOHANDIKI_.Add(other.hAIOHANDIKI_);
		if (other.HFIHPFFADOC)
		{
			HFIHPFFADOC = other.HFIHPFFADOC;
		}
		if (other.CurHp != 0)
		{
			CurHp = other.CurHp;
		}
		if (other.IsWin)
		{
			IsWin = other.IsWin;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.eDKJMPACHNJ_ != null)
		{
			if (eDKJMPACHNJ_ == null)
			{
				EDKJMPACHNJ = new DCEBJIGAPEI();
			}
			EDKJMPACHNJ.MergeFrom(other.EDKJMPACHNJ);
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
				LMIICENMOBI = input.ReadUInt32();
				break;
			case 34u:
				hAIOHANDIKI_.AddEntriesFrom(ref input, _repeated_hAIOHANDIKI_codec);
				break;
			case 40u:
				HFIHPFFADOC = input.ReadBool();
				break;
			case 48u:
				CurHp = input.ReadUInt32();
				break;
			case 80u:
				IsWin = input.ReadBool();
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				if (eDKJMPACHNJ_ == null)
				{
					EDKJMPACHNJ = new DCEBJIGAPEI();
				}
				input.ReadMessage(EDKJMPACHNJ);
				break;
			}
		}
	}
}
