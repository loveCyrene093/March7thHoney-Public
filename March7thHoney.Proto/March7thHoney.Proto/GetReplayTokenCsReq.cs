using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetReplayTokenCsReq : IMessage<GetReplayTokenCsReq>, IMessage, IEquatable<GetReplayTokenCsReq>, IDeepCloneable<GetReplayTokenCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetReplayTokenCsReq> _parser = new MessageParser<GetReplayTokenCsReq>(() => new GetReplayTokenCsReq());

	private UnknownFieldSet _unknownFields;

	public const int EBNFHHGKDKEFieldNumber = 1;

	private string eBNFHHGKDKE_ = "";

	public const int ReplayTypeFieldNumber = 2;

	private OCLEJLEFBFO replayType_;

	public const int KALAGIBCNAOFieldNumber = 3;

	private uint kALAGIBCNAO_;

	public const int DFLMKCIKFOPFieldNumber = 4;

	private string dFLMKCIKFOP_ = "";

	public const int DAFEJIENABLFieldNumber = 12;

	private uint dAFEJIENABL_;

	public const int StageIdFieldNumber = 15;

	private uint stageId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetReplayTokenCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetReplayTokenCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string EBNFHHGKDKE
	{
		get
		{
			return eBNFHHGKDKE_;
		}
		set
		{
			eBNFHHGKDKE_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OCLEJLEFBFO ReplayType
	{
		get
		{
			return replayType_;
		}
		set
		{
			replayType_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KALAGIBCNAO
	{
		get
		{
			return kALAGIBCNAO_;
		}
		set
		{
			kALAGIBCNAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string DFLMKCIKFOP
	{
		get
		{
			return dFLMKCIKFOP_;
		}
		set
		{
			dFLMKCIKFOP_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DAFEJIENABL
	{
		get
		{
			return dAFEJIENABL_;
		}
		set
		{
			dAFEJIENABL_ = value;
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
	public GetReplayTokenCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetReplayTokenCsReq(GetReplayTokenCsReq other)
		: this()
	{
		eBNFHHGKDKE_ = other.eBNFHHGKDKE_;
		replayType_ = other.replayType_;
		kALAGIBCNAO_ = other.kALAGIBCNAO_;
		dFLMKCIKFOP_ = other.dFLMKCIKFOP_;
		dAFEJIENABL_ = other.dAFEJIENABL_;
		stageId_ = other.stageId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetReplayTokenCsReq Clone()
	{
		return new GetReplayTokenCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetReplayTokenCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetReplayTokenCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EBNFHHGKDKE != other.EBNFHHGKDKE)
		{
			return false;
		}
		if (ReplayType != other.ReplayType)
		{
			return false;
		}
		if (KALAGIBCNAO != other.KALAGIBCNAO)
		{
			return false;
		}
		if (DFLMKCIKFOP != other.DFLMKCIKFOP)
		{
			return false;
		}
		if (DAFEJIENABL != other.DAFEJIENABL)
		{
			return false;
		}
		if (StageId != other.StageId)
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
		if (EBNFHHGKDKE.Length != 0)
		{
			num ^= EBNFHHGKDKE.GetHashCode();
		}
		if (ReplayType != OCLEJLEFBFO.Pcpdhelpkem)
		{
			num ^= ReplayType.GetHashCode();
		}
		if (KALAGIBCNAO != 0)
		{
			num ^= KALAGIBCNAO.GetHashCode();
		}
		if (DFLMKCIKFOP.Length != 0)
		{
			num ^= DFLMKCIKFOP.GetHashCode();
		}
		if (DAFEJIENABL != 0)
		{
			num ^= DAFEJIENABL.GetHashCode();
		}
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
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
		if (EBNFHHGKDKE.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(EBNFHHGKDKE);
		}
		if (ReplayType != OCLEJLEFBFO.Pcpdhelpkem)
		{
			output.WriteRawTag(16);
			output.WriteEnum((int)ReplayType);
		}
		if (KALAGIBCNAO != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(KALAGIBCNAO);
		}
		if (DFLMKCIKFOP.Length != 0)
		{
			output.WriteRawTag(34);
			output.WriteString(DFLMKCIKFOP);
		}
		if (DAFEJIENABL != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(DAFEJIENABL);
		}
		if (StageId != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(StageId);
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
		if (EBNFHHGKDKE.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(EBNFHHGKDKE);
		}
		if (ReplayType != OCLEJLEFBFO.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ReplayType);
		}
		if (KALAGIBCNAO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KALAGIBCNAO);
		}
		if (DFLMKCIKFOP.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(DFLMKCIKFOP);
		}
		if (DAFEJIENABL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DAFEJIENABL);
		}
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetReplayTokenCsReq other)
	{
		if (other != null)
		{
			if (other.EBNFHHGKDKE.Length != 0)
			{
				EBNFHHGKDKE = other.EBNFHHGKDKE;
			}
			if (other.ReplayType != OCLEJLEFBFO.Pcpdhelpkem)
			{
				ReplayType = other.ReplayType;
			}
			if (other.KALAGIBCNAO != 0)
			{
				KALAGIBCNAO = other.KALAGIBCNAO;
			}
			if (other.DFLMKCIKFOP.Length != 0)
			{
				DFLMKCIKFOP = other.DFLMKCIKFOP;
			}
			if (other.DAFEJIENABL != 0)
			{
				DAFEJIENABL = other.DAFEJIENABL;
			}
			if (other.StageId != 0)
			{
				StageId = other.StageId;
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
			case 10u:
				EBNFHHGKDKE = input.ReadString();
				break;
			case 16u:
				ReplayType = (OCLEJLEFBFO)input.ReadEnum();
				break;
			case 24u:
				KALAGIBCNAO = input.ReadUInt32();
				break;
			case 34u:
				DFLMKCIKFOP = input.ReadString();
				break;
			case 96u:
				DAFEJIENABL = input.ReadUInt32();
				break;
			case 120u:
				StageId = input.ReadUInt32();
				break;
			}
		}
	}
}
