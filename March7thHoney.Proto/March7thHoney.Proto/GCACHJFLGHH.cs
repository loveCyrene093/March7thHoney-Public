using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GCACHJFLGHH : IMessage<GCACHJFLGHH>, IMessage, IEquatable<GCACHJFLGHH>, IDeepCloneable<GCACHJFLGHH>, IBufferMessage
{
	public enum AGFCPGHPEDDOneofCase
	{
		None = 0,
		CHFNLJPEENB = 1,
		KGAABCGGHNM = 11
	}

	private static readonly MessageParser<GCACHJFLGHH> _parser = new MessageParser<GCACHJFLGHH>(() => new GCACHJFLGHH());

	private UnknownFieldSet _unknownFields;

	public const int StatusFieldNumber = 2;

	private PlanetFesQuestState status_;

	public const int ProgressFieldNumber = 5;

	private uint progress_;

	public const int QuestIdFieldNumber = 10;

	private uint questId_;

	public const int OJBEACGLLOHFieldNumber = 14;

	private uint oJBEACGLLOH_;

	public const int CHFNLJPEENBFieldNumber = 1;

	public const int KGAABCGGHNMFieldNumber = 11;

	private object aGFCPGHPEDD_;

	private AGFCPGHPEDDOneofCase aGFCPGHPEDDCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GCACHJFLGHH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GCACHJFLGHHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesQuestState Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Progress
	{
		get
		{
			return progress_;
		}
		set
		{
			progress_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint QuestId
	{
		get
		{
			return questId_;
		}
		set
		{
			questId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OJBEACGLLOH
	{
		get
		{
			return oJBEACGLLOH_;
		}
		set
		{
			oJBEACGLLOH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN CHFNLJPEENB
	{
		get
		{
			if (aGFCPGHPEDDCase_ != AGFCPGHPEDDOneofCase.CHFNLJPEENB)
			{
				return null;
			}
			return (EFEGKDHEMFN)aGFCPGHPEDD_;
		}
		set
		{
			aGFCPGHPEDD_ = value;
			aGFCPGHPEDDCase_ = ((value != null) ? AGFCPGHPEDDOneofCase.CHFNLJPEENB : AGFCPGHPEDDOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KGAABCGGHNM
	{
		get
		{
			if (!HasKGAABCGGHNM)
			{
				return 0u;
			}
			return (uint)aGFCPGHPEDD_;
		}
		set
		{
			aGFCPGHPEDD_ = value;
			aGFCPGHPEDDCase_ = AGFCPGHPEDDOneofCase.KGAABCGGHNM;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasKGAABCGGHNM => aGFCPGHPEDDCase_ == AGFCPGHPEDDOneofCase.KGAABCGGHNM;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGFCPGHPEDDOneofCase AGFCPGHPEDDCase => aGFCPGHPEDDCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCACHJFLGHH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCACHJFLGHH(GCACHJFLGHH other)
		: this()
	{
		status_ = other.status_;
		progress_ = other.progress_;
		questId_ = other.questId_;
		oJBEACGLLOH_ = other.oJBEACGLLOH_;
		switch (other.AGFCPGHPEDDCase)
		{
		case AGFCPGHPEDDOneofCase.CHFNLJPEENB:
			CHFNLJPEENB = other.CHFNLJPEENB.Clone();
			break;
		case AGFCPGHPEDDOneofCase.KGAABCGGHNM:
			KGAABCGGHNM = other.KGAABCGGHNM;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GCACHJFLGHH Clone()
	{
		return new GCACHJFLGHH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearKGAABCGGHNM()
	{
		if (HasKGAABCGGHNM)
		{
			ClearAGFCPGHPEDD();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearAGFCPGHPEDD()
	{
		aGFCPGHPEDDCase_ = AGFCPGHPEDDOneofCase.None;
		aGFCPGHPEDD_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GCACHJFLGHH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GCACHJFLGHH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (Progress != other.Progress)
		{
			return false;
		}
		if (QuestId != other.QuestId)
		{
			return false;
		}
		if (OJBEACGLLOH != other.OJBEACGLLOH)
		{
			return false;
		}
		if (!object.Equals(CHFNLJPEENB, other.CHFNLJPEENB))
		{
			return false;
		}
		if (KGAABCGGHNM != other.KGAABCGGHNM)
		{
			return false;
		}
		if (AGFCPGHPEDDCase != other.AGFCPGHPEDDCase)
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
		if (Status != PlanetFesQuestState.GkbampagnbeAldgogpgnmo)
		{
			num ^= Status.GetHashCode();
		}
		if (Progress != 0)
		{
			num ^= Progress.GetHashCode();
		}
		if (QuestId != 0)
		{
			num ^= QuestId.GetHashCode();
		}
		if (OJBEACGLLOH != 0)
		{
			num ^= OJBEACGLLOH.GetHashCode();
		}
		if (aGFCPGHPEDDCase_ == AGFCPGHPEDDOneofCase.CHFNLJPEENB)
		{
			num ^= CHFNLJPEENB.GetHashCode();
		}
		if (HasKGAABCGGHNM)
		{
			num ^= KGAABCGGHNM.GetHashCode();
		}
		num ^= (int)aGFCPGHPEDDCase_;
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
		if (aGFCPGHPEDDCase_ == AGFCPGHPEDDOneofCase.CHFNLJPEENB)
		{
			output.WriteRawTag(10);
			output.WriteMessage(CHFNLJPEENB);
		}
		if (Status != PlanetFesQuestState.GkbampagnbeAldgogpgnmo)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)Status);
		}
		if (Progress != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Progress);
		}
		if (QuestId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(QuestId);
		}
		if (HasKGAABCGGHNM)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(KGAABCGGHNM);
		}
		if (OJBEACGLLOH != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(OJBEACGLLOH);
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
		if (Status != PlanetFesQuestState.GkbampagnbeAldgogpgnmo)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (Progress != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Progress);
		}
		if (QuestId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(QuestId);
		}
		if (OJBEACGLLOH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OJBEACGLLOH);
		}
		if (aGFCPGHPEDDCase_ == AGFCPGHPEDDOneofCase.CHFNLJPEENB)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CHFNLJPEENB);
		}
		if (HasKGAABCGGHNM)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KGAABCGGHNM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GCACHJFLGHH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Status != PlanetFesQuestState.GkbampagnbeAldgogpgnmo)
		{
			Status = other.Status;
		}
		if (other.Progress != 0)
		{
			Progress = other.Progress;
		}
		if (other.QuestId != 0)
		{
			QuestId = other.QuestId;
		}
		if (other.OJBEACGLLOH != 0)
		{
			OJBEACGLLOH = other.OJBEACGLLOH;
		}
		switch (other.AGFCPGHPEDDCase)
		{
		case AGFCPGHPEDDOneofCase.CHFNLJPEENB:
			if (CHFNLJPEENB == null)
			{
				CHFNLJPEENB = new EFEGKDHEMFN();
			}
			CHFNLJPEENB.MergeFrom(other.CHFNLJPEENB);
			break;
		case AGFCPGHPEDDOneofCase.KGAABCGGHNM:
			KGAABCGGHNM = other.KGAABCGGHNM;
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
			case 10u:
			{
				EFEGKDHEMFN eFEGKDHEMFN = new EFEGKDHEMFN();
				if (aGFCPGHPEDDCase_ == AGFCPGHPEDDOneofCase.CHFNLJPEENB)
				{
					eFEGKDHEMFN.MergeFrom(CHFNLJPEENB);
				}
				input.ReadMessage(eFEGKDHEMFN);
				CHFNLJPEENB = eFEGKDHEMFN;
				break;
			}
			case 16u:
				Status = (PlanetFesQuestState)input.ReadEnum();
				break;
			case 40u:
				Progress = input.ReadUInt32();
				break;
			case 80u:
				QuestId = input.ReadUInt32();
				break;
			case 88u:
				KGAABCGGHNM = input.ReadUInt32();
				break;
			case 112u:
				OJBEACGLLOH = input.ReadUInt32();
				break;
			}
		}
	}
}
