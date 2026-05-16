using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PropExtraInfo : IMessage<PropExtraInfo>, IMessage, IEquatable<PropExtraInfo>, IDeepCloneable<PropExtraInfo>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		PBDJILOJFMH = 1,
		EILNNHINJHN = 2,
		RogueGameInfo = 4,
		GAJKEDLKGML = 5,
		AHEAFMNNBJH = 6,
		IMPBELJGDJH = 7,
		LKGJCKMJFGL = 10,
		IAFMCFJPJOA = 14
	}

	private static readonly MessageParser<PropExtraInfo> _parser = new MessageParser<PropExtraInfo>(() => new PropExtraInfo());

	private UnknownFieldSet _unknownFields;

	public const int TimelineInfoFieldNumber = 12;

	private PropTimelineInfo timelineInfo_;

	public const int PBDJILOJFMHFieldNumber = 1;

	public const int EILNNHINJHNFieldNumber = 2;

	public const int RogueGameInfoFieldNumber = 4;

	public const int GAJKEDLKGMLFieldNumber = 5;

	public const int AHEAFMNNBJHFieldNumber = 6;

	public const int IMPBELJGDJHFieldNumber = 7;

	public const int LKGJCKMJFGLFieldNumber = 10;

	public const int IAFMCFJPJOAFieldNumber = 14;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PropExtraInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PropExtraInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PropTimelineInfo TimelineInfo
	{
		get
		{
			return timelineInfo_;
		}
		set
		{
			timelineInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LACLGMFHPFG PBDJILOJFMH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.PBDJILOJFMH)
			{
				return null;
			}
			return (LACLGMFHPFG)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.PBDJILOJFMH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PHIEHJMGGMH EILNNHINJHN
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.EILNNHINJHN)
			{
				return null;
			}
			return (PHIEHJMGGMH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.EILNNHINJHN : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PropRogueInfo RogueGameInfo
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.RogueGameInfo)
			{
				return null;
			}
			return (PropRogueInfo)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.RogueGameInfo : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MGBHHILKGGD GAJKEDLKGML
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.GAJKEDLKGML)
			{
				return null;
			}
			return (MGBHHILKGGD)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.GAJKEDLKGML : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LKLHKLMEPCM AHEAFMNNBJH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.AHEAFMNNBJH)
			{
				return null;
			}
			return (LKLHKLMEPCM)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.AHEAFMNNBJH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HDKIAHMLICD IMPBELJGDJH
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.IMPBELJGDJH)
			{
				return null;
			}
			return (HDKIAHMLICD)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.IMPBELJGDJH : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIONEBIHOIP LKGJCKMJFGL
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.LKGJCKMJFGL)
			{
				return null;
			}
			return (JIONEBIHOIP)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.LKGJCKMJFGL : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AGLBGFLKIME IAFMCFJPJOA
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.IAFMCFJPJOA)
			{
				return null;
			}
			return (AGLBGFLKIME)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.IAFMCFJPJOA : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PropExtraInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PropExtraInfo(PropExtraInfo other)
		: this()
	{
		timelineInfo_ = ((other.timelineInfo_ != null) ? other.timelineInfo_.Clone() : null);
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.PBDJILOJFMH:
			PBDJILOJFMH = other.PBDJILOJFMH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.EILNNHINJHN:
			EILNNHINJHN = other.EILNNHINJHN.Clone();
			break;
		case BPIHFAJCLOCOneofCase.RogueGameInfo:
			RogueGameInfo = other.RogueGameInfo.Clone();
			break;
		case BPIHFAJCLOCOneofCase.GAJKEDLKGML:
			GAJKEDLKGML = other.GAJKEDLKGML.Clone();
			break;
		case BPIHFAJCLOCOneofCase.AHEAFMNNBJH:
			AHEAFMNNBJH = other.AHEAFMNNBJH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.IMPBELJGDJH:
			IMPBELJGDJH = other.IMPBELJGDJH.Clone();
			break;
		case BPIHFAJCLOCOneofCase.LKGJCKMJFGL:
			LKGJCKMJFGL = other.LKGJCKMJFGL.Clone();
			break;
		case BPIHFAJCLOCOneofCase.IAFMCFJPJOA:
			IAFMCFJPJOA = other.IAFMCFJPJOA.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PropExtraInfo Clone()
	{
		return new PropExtraInfo(this);
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
		return Equals(other as PropExtraInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PropExtraInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(TimelineInfo, other.TimelineInfo))
		{
			return false;
		}
		if (!object.Equals(PBDJILOJFMH, other.PBDJILOJFMH))
		{
			return false;
		}
		if (!object.Equals(EILNNHINJHN, other.EILNNHINJHN))
		{
			return false;
		}
		if (!object.Equals(RogueGameInfo, other.RogueGameInfo))
		{
			return false;
		}
		if (!object.Equals(GAJKEDLKGML, other.GAJKEDLKGML))
		{
			return false;
		}
		if (!object.Equals(AHEAFMNNBJH, other.AHEAFMNNBJH))
		{
			return false;
		}
		if (!object.Equals(IMPBELJGDJH, other.IMPBELJGDJH))
		{
			return false;
		}
		if (!object.Equals(LKGJCKMJFGL, other.LKGJCKMJFGL))
		{
			return false;
		}
		if (!object.Equals(IAFMCFJPJOA, other.IAFMCFJPJOA))
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
		if (timelineInfo_ != null)
		{
			num ^= TimelineInfo.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PBDJILOJFMH)
		{
			num ^= PBDJILOJFMH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EILNNHINJHN)
		{
			num ^= EILNNHINJHN.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.RogueGameInfo)
		{
			num ^= RogueGameInfo.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GAJKEDLKGML)
		{
			num ^= GAJKEDLKGML.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AHEAFMNNBJH)
		{
			num ^= AHEAFMNNBJH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IMPBELJGDJH)
		{
			num ^= IMPBELJGDJH.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LKGJCKMJFGL)
		{
			num ^= LKGJCKMJFGL.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IAFMCFJPJOA)
		{
			num ^= IAFMCFJPJOA.GetHashCode();
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
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PBDJILOJFMH)
		{
			output.WriteRawTag(10);
			output.WriteMessage(PBDJILOJFMH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EILNNHINJHN)
		{
			output.WriteRawTag(18);
			output.WriteMessage(EILNNHINJHN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.RogueGameInfo)
		{
			output.WriteRawTag(34);
			output.WriteMessage(RogueGameInfo);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GAJKEDLKGML)
		{
			output.WriteRawTag(42);
			output.WriteMessage(GAJKEDLKGML);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AHEAFMNNBJH)
		{
			output.WriteRawTag(50);
			output.WriteMessage(AHEAFMNNBJH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IMPBELJGDJH)
		{
			output.WriteRawTag(58);
			output.WriteMessage(IMPBELJGDJH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LKGJCKMJFGL)
		{
			output.WriteRawTag(82);
			output.WriteMessage(LKGJCKMJFGL);
		}
		if (timelineInfo_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(TimelineInfo);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IAFMCFJPJOA)
		{
			output.WriteRawTag(114);
			output.WriteMessage(IAFMCFJPJOA);
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
		if (timelineInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(TimelineInfo);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PBDJILOJFMH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PBDJILOJFMH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EILNNHINJHN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EILNNHINJHN);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.RogueGameInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RogueGameInfo);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GAJKEDLKGML)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GAJKEDLKGML);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AHEAFMNNBJH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AHEAFMNNBJH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IMPBELJGDJH)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMPBELJGDJH);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LKGJCKMJFGL)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LKGJCKMJFGL);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IAFMCFJPJOA)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IAFMCFJPJOA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PropExtraInfo other)
	{
		if (other == null)
		{
			return;
		}
		if (other.timelineInfo_ != null)
		{
			if (timelineInfo_ == null)
			{
				TimelineInfo = new PropTimelineInfo();
			}
			TimelineInfo.MergeFrom(other.TimelineInfo);
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.PBDJILOJFMH:
			if (PBDJILOJFMH == null)
			{
				PBDJILOJFMH = new LACLGMFHPFG();
			}
			PBDJILOJFMH.MergeFrom(other.PBDJILOJFMH);
			break;
		case BPIHFAJCLOCOneofCase.EILNNHINJHN:
			if (EILNNHINJHN == null)
			{
				EILNNHINJHN = new PHIEHJMGGMH();
			}
			EILNNHINJHN.MergeFrom(other.EILNNHINJHN);
			break;
		case BPIHFAJCLOCOneofCase.RogueGameInfo:
			if (RogueGameInfo == null)
			{
				RogueGameInfo = new PropRogueInfo();
			}
			RogueGameInfo.MergeFrom(other.RogueGameInfo);
			break;
		case BPIHFAJCLOCOneofCase.GAJKEDLKGML:
			if (GAJKEDLKGML == null)
			{
				GAJKEDLKGML = new MGBHHILKGGD();
			}
			GAJKEDLKGML.MergeFrom(other.GAJKEDLKGML);
			break;
		case BPIHFAJCLOCOneofCase.AHEAFMNNBJH:
			if (AHEAFMNNBJH == null)
			{
				AHEAFMNNBJH = new LKLHKLMEPCM();
			}
			AHEAFMNNBJH.MergeFrom(other.AHEAFMNNBJH);
			break;
		case BPIHFAJCLOCOneofCase.IMPBELJGDJH:
			if (IMPBELJGDJH == null)
			{
				IMPBELJGDJH = new HDKIAHMLICD();
			}
			IMPBELJGDJH.MergeFrom(other.IMPBELJGDJH);
			break;
		case BPIHFAJCLOCOneofCase.LKGJCKMJFGL:
			if (LKGJCKMJFGL == null)
			{
				LKGJCKMJFGL = new JIONEBIHOIP();
			}
			LKGJCKMJFGL.MergeFrom(other.LKGJCKMJFGL);
			break;
		case BPIHFAJCLOCOneofCase.IAFMCFJPJOA:
			if (IAFMCFJPJOA == null)
			{
				IAFMCFJPJOA = new AGLBGFLKIME();
			}
			IAFMCFJPJOA.MergeFrom(other.IAFMCFJPJOA);
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
				LACLGMFHPFG lACLGMFHPFG = new LACLGMFHPFG();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.PBDJILOJFMH)
				{
					lACLGMFHPFG.MergeFrom(PBDJILOJFMH);
				}
				input.ReadMessage(lACLGMFHPFG);
				PBDJILOJFMH = lACLGMFHPFG;
				break;
			}
			case 18u:
			{
				PHIEHJMGGMH pHIEHJMGGMH = new PHIEHJMGGMH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.EILNNHINJHN)
				{
					pHIEHJMGGMH.MergeFrom(EILNNHINJHN);
				}
				input.ReadMessage(pHIEHJMGGMH);
				EILNNHINJHN = pHIEHJMGGMH;
				break;
			}
			case 34u:
			{
				PropRogueInfo propRogueInfo = new PropRogueInfo();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.RogueGameInfo)
				{
					propRogueInfo.MergeFrom(RogueGameInfo);
				}
				input.ReadMessage(propRogueInfo);
				RogueGameInfo = propRogueInfo;
				break;
			}
			case 42u:
			{
				MGBHHILKGGD mGBHHILKGGD = new MGBHHILKGGD();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.GAJKEDLKGML)
				{
					mGBHHILKGGD.MergeFrom(GAJKEDLKGML);
				}
				input.ReadMessage(mGBHHILKGGD);
				GAJKEDLKGML = mGBHHILKGGD;
				break;
			}
			case 50u:
			{
				LKLHKLMEPCM lKLHKLMEPCM = new LKLHKLMEPCM();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.AHEAFMNNBJH)
				{
					lKLHKLMEPCM.MergeFrom(AHEAFMNNBJH);
				}
				input.ReadMessage(lKLHKLMEPCM);
				AHEAFMNNBJH = lKLHKLMEPCM;
				break;
			}
			case 58u:
			{
				HDKIAHMLICD hDKIAHMLICD = new HDKIAHMLICD();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IMPBELJGDJH)
				{
					hDKIAHMLICD.MergeFrom(IMPBELJGDJH);
				}
				input.ReadMessage(hDKIAHMLICD);
				IMPBELJGDJH = hDKIAHMLICD;
				break;
			}
			case 82u:
			{
				JIONEBIHOIP jIONEBIHOIP = new JIONEBIHOIP();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.LKGJCKMJFGL)
				{
					jIONEBIHOIP.MergeFrom(LKGJCKMJFGL);
				}
				input.ReadMessage(jIONEBIHOIP);
				LKGJCKMJFGL = jIONEBIHOIP;
				break;
			}
			case 98u:
				if (timelineInfo_ == null)
				{
					TimelineInfo = new PropTimelineInfo();
				}
				input.ReadMessage(TimelineInfo);
				break;
			case 114u:
			{
				AGLBGFLKIME aGLBGFLKIME = new AGLBGFLKIME();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.IAFMCFJPJOA)
				{
					aGLBGFLKIME.MergeFrom(IAFMCFJPJOA);
				}
				input.ReadMessage(aGLBGFLKIME);
				IAFMCFJPJOA = aGLBGFLKIME;
				break;
			}
			}
		}
	}
}
