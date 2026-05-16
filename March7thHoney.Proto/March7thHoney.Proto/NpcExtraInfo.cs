using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NpcExtraInfo : IMessage<NpcExtraInfo>, IMessage, IEquatable<NpcExtraInfo>, IDeepCloneable<NpcExtraInfo>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		JACDADCHNFL = 3,
		FPCOMNAOABD = 11,
		RogueGameInfo = 15
	}

	private static readonly MessageParser<NpcExtraInfo> _parser = new MessageParser<NpcExtraInfo>(() => new NpcExtraInfo());

	private UnknownFieldSet _unknownFields;

	public const int JACDADCHNFLFieldNumber = 3;

	public const int FPCOMNAOABDFieldNumber = 11;

	public const int RogueGameInfoFieldNumber = 15;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NpcExtraInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NpcExtraInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EBFBPHIADMI JACDADCHNFL
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.JACDADCHNFL)
			{
				return null;
			}
			return (EBFBPHIADMI)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.JACDADCHNFL : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEAOBFJOMCF FPCOMNAOABD
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.FPCOMNAOABD)
			{
				return null;
			}
			return (NEAOBFJOMCF)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.FPCOMNAOABD : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcRogueGameInfo RogueGameInfo
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.RogueGameInfo)
			{
				return null;
			}
			return (NpcRogueGameInfo)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.RogueGameInfo : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcExtraInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcExtraInfo(NpcExtraInfo other)
		: this()
	{
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.JACDADCHNFL:
			JACDADCHNFL = other.JACDADCHNFL.Clone();
			break;
		case BPIHFAJCLOCOneofCase.FPCOMNAOABD:
			FPCOMNAOABD = other.FPCOMNAOABD.Clone();
			break;
		case BPIHFAJCLOCOneofCase.RogueGameInfo:
			RogueGameInfo = other.RogueGameInfo.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NpcExtraInfo Clone()
	{
		return new NpcExtraInfo(this);
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
		return Equals(other as NpcExtraInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NpcExtraInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JACDADCHNFL, other.JACDADCHNFL))
		{
			return false;
		}
		if (!object.Equals(FPCOMNAOABD, other.FPCOMNAOABD))
		{
			return false;
		}
		if (!object.Equals(RogueGameInfo, other.RogueGameInfo))
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JACDADCHNFL)
		{
			num ^= JACDADCHNFL.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FPCOMNAOABD)
		{
			num ^= FPCOMNAOABD.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.RogueGameInfo)
		{
			num ^= RogueGameInfo.GetHashCode();
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JACDADCHNFL)
		{
			output.WriteRawTag(26);
			output.WriteMessage(JACDADCHNFL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FPCOMNAOABD)
		{
			output.WriteRawTag(90);
			output.WriteMessage(FPCOMNAOABD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.RogueGameInfo)
		{
			output.WriteRawTag(122);
			output.WriteMessage(RogueGameInfo);
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JACDADCHNFL)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JACDADCHNFL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FPCOMNAOABD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FPCOMNAOABD);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.RogueGameInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RogueGameInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NpcExtraInfo other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.JACDADCHNFL:
			if (JACDADCHNFL == null)
			{
				JACDADCHNFL = new EBFBPHIADMI();
			}
			JACDADCHNFL.MergeFrom(other.JACDADCHNFL);
			break;
		case BPIHFAJCLOCOneofCase.FPCOMNAOABD:
			if (FPCOMNAOABD == null)
			{
				FPCOMNAOABD = new NEAOBFJOMCF();
			}
			FPCOMNAOABD.MergeFrom(other.FPCOMNAOABD);
			break;
		case BPIHFAJCLOCOneofCase.RogueGameInfo:
			if (RogueGameInfo == null)
			{
				RogueGameInfo = new NpcRogueGameInfo();
			}
			RogueGameInfo.MergeFrom(other.RogueGameInfo);
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
			case 26u:
			{
				EBFBPHIADMI eBFBPHIADMI = new EBFBPHIADMI();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.JACDADCHNFL)
				{
					eBFBPHIADMI.MergeFrom(JACDADCHNFL);
				}
				input.ReadMessage(eBFBPHIADMI);
				JACDADCHNFL = eBFBPHIADMI;
				break;
			}
			case 90u:
			{
				NEAOBFJOMCF nEAOBFJOMCF = new NEAOBFJOMCF();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.FPCOMNAOABD)
				{
					nEAOBFJOMCF.MergeFrom(FPCOMNAOABD);
				}
				input.ReadMessage(nEAOBFJOMCF);
				FPCOMNAOABD = nEAOBFJOMCF;
				break;
			}
			case 122u:
			{
				NpcRogueGameInfo npcRogueGameInfo = new NpcRogueGameInfo();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.RogueGameInfo)
				{
					npcRogueGameInfo.MergeFrom(RogueGameInfo);
				}
				input.ReadMessage(npcRogueGameInfo);
				RogueGameInfo = npcRogueGameInfo;
				break;
			}
			}
		}
	}
}
