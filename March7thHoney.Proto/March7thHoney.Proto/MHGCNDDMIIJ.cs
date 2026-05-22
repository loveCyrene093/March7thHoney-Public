using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MHGCNDDMIIJ : IMessage<MHGCNDDMIIJ>, IMessage, IEquatable<MHGCNDDMIIJ>, IDeepCloneable<MHGCNDDMIIJ>, IBufferMessage
{
	private static readonly MessageParser<MHGCNDDMIIJ> _parser = new MessageParser<MHGCNDDMIIJ>(() => new MHGCNDDMIIJ());

	private UnknownFieldSet _unknownFields;

	public const int MaxScoreFieldNumber = 3;

	private uint maxScore_;

	public const int StageIdFieldNumber = 8;

	private uint stageId_;

	public const int PanelIdFieldNumber = 11;

	private uint panelId_;

	public const int PPCKOFILGNBFieldNumber = 14;

	private uint pPCKOFILGNB_;

	public const int CEFADHIFNINFieldNumber = 15;

	private JANNOEMCKOI cEFADHIFNIN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MHGCNDDMIIJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MHGCNDDMIIJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MaxScore
	{
		get
		{
			return maxScore_;
		}
		set
		{
			maxScore_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PanelId
	{
		get
		{
			return panelId_;
		}
		set
		{
			panelId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PPCKOFILGNB
	{
		get
		{
			return pPCKOFILGNB_;
		}
		set
		{
			pPCKOFILGNB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JANNOEMCKOI CEFADHIFNIN
	{
		get
		{
			return cEFADHIFNIN_;
		}
		set
		{
			cEFADHIFNIN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MHGCNDDMIIJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MHGCNDDMIIJ(MHGCNDDMIIJ other)
		: this()
	{
		maxScore_ = other.maxScore_;
		stageId_ = other.stageId_;
		panelId_ = other.panelId_;
		pPCKOFILGNB_ = other.pPCKOFILGNB_;
		cEFADHIFNIN_ = ((other.cEFADHIFNIN_ != null) ? other.cEFADHIFNIN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MHGCNDDMIIJ Clone()
	{
		return new MHGCNDDMIIJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MHGCNDDMIIJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MHGCNDDMIIJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MaxScore != other.MaxScore)
		{
			return false;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (PanelId != other.PanelId)
		{
			return false;
		}
		if (PPCKOFILGNB != other.PPCKOFILGNB)
		{
			return false;
		}
		if (!object.Equals(CEFADHIFNIN, other.CEFADHIFNIN))
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
		if (MaxScore != 0)
		{
			num ^= MaxScore.GetHashCode();
		}
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (PanelId != 0)
		{
			num ^= PanelId.GetHashCode();
		}
		if (PPCKOFILGNB != 0)
		{
			num ^= PPCKOFILGNB.GetHashCode();
		}
		if (cEFADHIFNIN_ != null)
		{
			num ^= CEFADHIFNIN.GetHashCode();
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
		if (MaxScore != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MaxScore);
		}
		if (StageId != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(StageId);
		}
		if (PanelId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(PanelId);
		}
		if (PPCKOFILGNB != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(PPCKOFILGNB);
		}
		if (cEFADHIFNIN_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(CEFADHIFNIN);
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
		if (MaxScore != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MaxScore);
		}
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (PanelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PanelId);
		}
		if (PPCKOFILGNB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PPCKOFILGNB);
		}
		if (cEFADHIFNIN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CEFADHIFNIN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MHGCNDDMIIJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MaxScore != 0)
		{
			MaxScore = other.MaxScore;
		}
		if (other.StageId != 0)
		{
			StageId = other.StageId;
		}
		if (other.PanelId != 0)
		{
			PanelId = other.PanelId;
		}
		if (other.PPCKOFILGNB != 0)
		{
			PPCKOFILGNB = other.PPCKOFILGNB;
		}
		if (other.cEFADHIFNIN_ != null)
		{
			if (cEFADHIFNIN_ == null)
			{
				CEFADHIFNIN = new JANNOEMCKOI();
			}
			CEFADHIFNIN.MergeFrom(other.CEFADHIFNIN);
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
			case 24u:
				MaxScore = input.ReadUInt32();
				break;
			case 64u:
				StageId = input.ReadUInt32();
				break;
			case 88u:
				PanelId = input.ReadUInt32();
				break;
			case 112u:
				PPCKOFILGNB = input.ReadUInt32();
				break;
			case 122u:
				if (cEFADHIFNIN_ == null)
				{
					CEFADHIFNIN = new JANNOEMCKOI();
				}
				input.ReadMessage(CEFADHIFNIN);
				break;
			}
		}
	}
}
