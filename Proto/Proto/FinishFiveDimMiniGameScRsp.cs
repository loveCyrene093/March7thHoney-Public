using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishFiveDimMiniGameScRsp : IMessage<FinishFiveDimMiniGameScRsp>, IMessage, IEquatable<FinishFiveDimMiniGameScRsp>, IDeepCloneable<FinishFiveDimMiniGameScRsp>, IBufferMessage
{
	private static readonly MessageParser<FinishFiveDimMiniGameScRsp> _parser = new MessageParser<FinishFiveDimMiniGameScRsp>(() => new FinishFiveDimMiniGameScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MENAAPNNKGEFieldNumber = 2;

	private ItemList mENAAPNNKGE_;

	public const int NCODIMPANCCFieldNumber = 3;

	private uint nCODIMPANCC_;

	public const int ScoreIdFieldNumber = 5;

	private uint scoreId_;

	public const int ENMFKJIOEOCFieldNumber = 6;

	private ItemList eNMFKJIOEOC_;

	public const int GoldFieldNumber = 7;

	private uint gold_;

	public const int KEABPBONOKMFieldNumber = 8;

	private uint kEABPBONOKM_;

	public const int GCPNCEDAMABFieldNumber = 10;

	private uint gCPNCEDAMAB_;

	public const int CHPAMPNMCOEFieldNumber = 11;

	private bool cHPAMPNMCOE_;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int PBDBJOHCJFOFieldNumber = 13;

	private float pBDBJOHCJFO_;

	public const int OJIAAGJBJAFFieldNumber = 15;

	private uint oJIAAGJBJAF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FinishFiveDimMiniGameScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FinishFiveDimMiniGameScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList MENAAPNNKGE
	{
		get
		{
			return mENAAPNNKGE_;
		}
		set
		{
			mENAAPNNKGE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NCODIMPANCC
	{
		get
		{
			return nCODIMPANCC_;
		}
		set
		{
			nCODIMPANCC_ = value;
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
	public ItemList ENMFKJIOEOC
	{
		get
		{
			return eNMFKJIOEOC_;
		}
		set
		{
			eNMFKJIOEOC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Gold
	{
		get
		{
			return gold_;
		}
		set
		{
			gold_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KEABPBONOKM
	{
		get
		{
			return kEABPBONOKM_;
		}
		set
		{
			kEABPBONOKM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GCPNCEDAMAB
	{
		get
		{
			return gCPNCEDAMAB_;
		}
		set
		{
			gCPNCEDAMAB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CHPAMPNMCOE
	{
		get
		{
			return cHPAMPNMCOE_;
		}
		set
		{
			cHPAMPNMCOE_ = value;
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
	public float PBDBJOHCJFO
	{
		get
		{
			return pBDBJOHCJFO_;
		}
		set
		{
			pBDBJOHCJFO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OJIAAGJBJAF
	{
		get
		{
			return oJIAAGJBJAF_;
		}
		set
		{
			oJIAAGJBJAF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishFiveDimMiniGameScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishFiveDimMiniGameScRsp(FinishFiveDimMiniGameScRsp other)
		: this()
	{
		mENAAPNNKGE_ = ((other.mENAAPNNKGE_ != null) ? other.mENAAPNNKGE_.Clone() : null);
		nCODIMPANCC_ = other.nCODIMPANCC_;
		scoreId_ = other.scoreId_;
		eNMFKJIOEOC_ = ((other.eNMFKJIOEOC_ != null) ? other.eNMFKJIOEOC_.Clone() : null);
		gold_ = other.gold_;
		kEABPBONOKM_ = other.kEABPBONOKM_;
		gCPNCEDAMAB_ = other.gCPNCEDAMAB_;
		cHPAMPNMCOE_ = other.cHPAMPNMCOE_;
		retcode_ = other.retcode_;
		pBDBJOHCJFO_ = other.pBDBJOHCJFO_;
		oJIAAGJBJAF_ = other.oJIAAGJBJAF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishFiveDimMiniGameScRsp Clone()
	{
		return new FinishFiveDimMiniGameScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FinishFiveDimMiniGameScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FinishFiveDimMiniGameScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MENAAPNNKGE, other.MENAAPNNKGE))
		{
			return false;
		}
		if (NCODIMPANCC != other.NCODIMPANCC)
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
		{
			return false;
		}
		if (!object.Equals(ENMFKJIOEOC, other.ENMFKJIOEOC))
		{
			return false;
		}
		if (Gold != other.Gold)
		{
			return false;
		}
		if (KEABPBONOKM != other.KEABPBONOKM)
		{
			return false;
		}
		if (GCPNCEDAMAB != other.GCPNCEDAMAB)
		{
			return false;
		}
		if (CHPAMPNMCOE != other.CHPAMPNMCOE)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(PBDBJOHCJFO, other.PBDBJOHCJFO))
		{
			return false;
		}
		if (OJIAAGJBJAF != other.OJIAAGJBJAF)
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
		if (mENAAPNNKGE_ != null)
		{
			num ^= MENAAPNNKGE.GetHashCode();
		}
		if (NCODIMPANCC != 0)
		{
			num ^= NCODIMPANCC.GetHashCode();
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
		}
		if (eNMFKJIOEOC_ != null)
		{
			num ^= ENMFKJIOEOC.GetHashCode();
		}
		if (Gold != 0)
		{
			num ^= Gold.GetHashCode();
		}
		if (KEABPBONOKM != 0)
		{
			num ^= KEABPBONOKM.GetHashCode();
		}
		if (GCPNCEDAMAB != 0)
		{
			num ^= GCPNCEDAMAB.GetHashCode();
		}
		if (CHPAMPNMCOE)
		{
			num ^= CHPAMPNMCOE.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (PBDBJOHCJFO != 0f)
		{
			num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(PBDBJOHCJFO);
		}
		if (OJIAAGJBJAF != 0)
		{
			num ^= OJIAAGJBJAF.GetHashCode();
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
		if (mENAAPNNKGE_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(MENAAPNNKGE);
		}
		if (NCODIMPANCC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(NCODIMPANCC);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(ScoreId);
		}
		if (eNMFKJIOEOC_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(ENMFKJIOEOC);
		}
		if (Gold != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Gold);
		}
		if (KEABPBONOKM != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(KEABPBONOKM);
		}
		if (GCPNCEDAMAB != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(GCPNCEDAMAB);
		}
		if (CHPAMPNMCOE)
		{
			output.WriteRawTag(88);
			output.WriteBool(CHPAMPNMCOE);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		if (PBDBJOHCJFO != 0f)
		{
			output.WriteRawTag(109);
			output.WriteFloat(PBDBJOHCJFO);
		}
		if (OJIAAGJBJAF != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(OJIAAGJBJAF);
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
		if (mENAAPNNKGE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MENAAPNNKGE);
		}
		if (NCODIMPANCC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NCODIMPANCC);
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (eNMFKJIOEOC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ENMFKJIOEOC);
		}
		if (Gold != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Gold);
		}
		if (KEABPBONOKM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KEABPBONOKM);
		}
		if (GCPNCEDAMAB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GCPNCEDAMAB);
		}
		if (CHPAMPNMCOE)
		{
			num += 2;
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (PBDBJOHCJFO != 0f)
		{
			num += 5;
		}
		if (OJIAAGJBJAF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OJIAAGJBJAF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FinishFiveDimMiniGameScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mENAAPNNKGE_ != null)
		{
			if (mENAAPNNKGE_ == null)
			{
				MENAAPNNKGE = new ItemList();
			}
			MENAAPNNKGE.MergeFrom(other.MENAAPNNKGE);
		}
		if (other.NCODIMPANCC != 0)
		{
			NCODIMPANCC = other.NCODIMPANCC;
		}
		if (other.ScoreId != 0)
		{
			ScoreId = other.ScoreId;
		}
		if (other.eNMFKJIOEOC_ != null)
		{
			if (eNMFKJIOEOC_ == null)
			{
				ENMFKJIOEOC = new ItemList();
			}
			ENMFKJIOEOC.MergeFrom(other.ENMFKJIOEOC);
		}
		if (other.Gold != 0)
		{
			Gold = other.Gold;
		}
		if (other.KEABPBONOKM != 0)
		{
			KEABPBONOKM = other.KEABPBONOKM;
		}
		if (other.GCPNCEDAMAB != 0)
		{
			GCPNCEDAMAB = other.GCPNCEDAMAB;
		}
		if (other.CHPAMPNMCOE)
		{
			CHPAMPNMCOE = other.CHPAMPNMCOE;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.PBDBJOHCJFO != 0f)
		{
			PBDBJOHCJFO = other.PBDBJOHCJFO;
		}
		if (other.OJIAAGJBJAF != 0)
		{
			OJIAAGJBJAF = other.OJIAAGJBJAF;
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
				if (mENAAPNNKGE_ == null)
				{
					MENAAPNNKGE = new ItemList();
				}
				input.ReadMessage(MENAAPNNKGE);
				break;
			case 24u:
				NCODIMPANCC = input.ReadUInt32();
				break;
			case 40u:
				ScoreId = input.ReadUInt32();
				break;
			case 50u:
				if (eNMFKJIOEOC_ == null)
				{
					ENMFKJIOEOC = new ItemList();
				}
				input.ReadMessage(ENMFKJIOEOC);
				break;
			case 56u:
				Gold = input.ReadUInt32();
				break;
			case 64u:
				KEABPBONOKM = input.ReadUInt32();
				break;
			case 80u:
				GCPNCEDAMAB = input.ReadUInt32();
				break;
			case 88u:
				CHPAMPNMCOE = input.ReadBool();
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 109u:
				PBDBJOHCJFO = input.ReadFloat();
				break;
			case 120u:
				OJIAAGJBJAF = input.ReadUInt32();
				break;
			}
		}
	}
}
