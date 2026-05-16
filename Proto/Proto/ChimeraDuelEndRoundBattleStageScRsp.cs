using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraDuelEndRoundBattleStageScRsp : IMessage<ChimeraDuelEndRoundBattleStageScRsp>, IMessage, IEquatable<ChimeraDuelEndRoundBattleStageScRsp>, IDeepCloneable<ChimeraDuelEndRoundBattleStageScRsp>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		OIAPHBBDPHL = 1088,
		CKIMOELPOAB = 2013
	}

	private static readonly MessageParser<ChimeraDuelEndRoundBattleStageScRsp> _parser = new MessageParser<ChimeraDuelEndRoundBattleStageScRsp>(() => new ChimeraDuelEndRoundBattleStageScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int KGEBJNHOLCNFieldNumber = 14;

	private DCIFPICPJMK kGEBJNHOLCN_;

	public const int OIAPHBBDPHLFieldNumber = 1088;

	public const int CKIMOELPOABFieldNumber = 2013;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraDuelEndRoundBattleStageScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraDuelEndRoundBattleStageScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public DCIFPICPJMK KGEBJNHOLCN
	{
		get
		{
			return kGEBJNHOLCN_;
		}
		set
		{
			kGEBJNHOLCN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDJOEIBOELH OIAPHBBDPHL
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.OIAPHBBDPHL)
			{
				return null;
			}
			return (DDJOEIBOELH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.OIAPHBBDPHL : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HOBCIOKKNKH CKIMOELPOAB
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.CKIMOELPOAB)
			{
				return null;
			}
			return (HOBCIOKKNKH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.CKIMOELPOAB : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelEndRoundBattleStageScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelEndRoundBattleStageScRsp(ChimeraDuelEndRoundBattleStageScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		kGEBJNHOLCN_ = other.kGEBJNHOLCN_;
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.OIAPHBBDPHL:
			OIAPHBBDPHL = other.OIAPHBBDPHL.Clone();
			break;
		case BPIHFAJCLOCOneofCase.CKIMOELPOAB:
			CKIMOELPOAB = other.CKIMOELPOAB.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelEndRoundBattleStageScRsp Clone()
	{
		return new ChimeraDuelEndRoundBattleStageScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBPIHFAJCLOC()
	{
		bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.None;
		bPIHFAJCLOC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraDuelEndRoundBattleStageScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraDuelEndRoundBattleStageScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (KGEBJNHOLCN != other.KGEBJNHOLCN)
		{
			return false;
		}
		if (!object.Equals(OIAPHBBDPHL, other.OIAPHBBDPHL))
		{
			return false;
		}
		if (!object.Equals(CKIMOELPOAB, other.CKIMOELPOAB))
		{
			return false;
		}
		if (BPIHFAJCLOCCase != other.BPIHFAJCLOCCase)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (KGEBJNHOLCN != DCIFPICPJMK.Pcpdhelpkem)
		{
			num ^= KGEBJNHOLCN.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OIAPHBBDPHL)
		{
			num ^= OIAPHBBDPHL.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CKIMOELPOAB)
		{
			num ^= CKIMOELPOAB.GetHashCode();
		}
		num ^= (int)bPIHFAJCLOCCase_;
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
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		if (KGEBJNHOLCN != DCIFPICPJMK.Pcpdhelpkem)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)KGEBJNHOLCN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OIAPHBBDPHL)
		{
			output.WriteRawTag(130, 68);
			output.WriteMessage(OIAPHBBDPHL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CKIMOELPOAB)
		{
			output.WriteRawTag(234, 125);
			output.WriteMessage(CKIMOELPOAB);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (KGEBJNHOLCN != DCIFPICPJMK.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)KGEBJNHOLCN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OIAPHBBDPHL)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(OIAPHBBDPHL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CKIMOELPOAB)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(CKIMOELPOAB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraDuelEndRoundBattleStageScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.KGEBJNHOLCN != DCIFPICPJMK.Pcpdhelpkem)
		{
			KGEBJNHOLCN = other.KGEBJNHOLCN;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.OIAPHBBDPHL:
			if (OIAPHBBDPHL == null)
			{
				OIAPHBBDPHL = new DDJOEIBOELH();
			}
			OIAPHBBDPHL.MergeFrom(other.OIAPHBBDPHL);
			break;
		case BPIHFAJCLOCOneofCase.CKIMOELPOAB:
			if (CKIMOELPOAB == null)
			{
				CKIMOELPOAB = new HOBCIOKKNKH();
			}
			CKIMOELPOAB.MergeFrom(other.CKIMOELPOAB);
			break;
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
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 112u:
				KGEBJNHOLCN = (DCIFPICPJMK)input.ReadEnum();
				break;
			case 8706u:
			{
				DDJOEIBOELH dDJOEIBOELH = new DDJOEIBOELH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.OIAPHBBDPHL)
				{
					dDJOEIBOELH.MergeFrom(OIAPHBBDPHL);
				}
				input.ReadMessage(dDJOEIBOELH);
				OIAPHBBDPHL = dDJOEIBOELH;
				break;
			}
			case 16106u:
			{
				HOBCIOKKNKH hOBCIOKKNKH = new HOBCIOKKNKH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.CKIMOELPOAB)
				{
					hOBCIOKKNKH.MergeFrom(CKIMOELPOAB);
				}
				input.ReadMessage(hOBCIOKKNKH);
				CKIMOELPOAB = hOBCIOKKNKH;
				break;
			}
			}
		}
	}
}
