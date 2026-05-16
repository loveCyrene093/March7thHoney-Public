using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OFBNFNFGDFJ : IMessage<OFBNFNFGDFJ>, IMessage, IEquatable<OFBNFNFGDFJ>, IDeepCloneable<OFBNFNFGDFJ>, IBufferMessage
{
	private static readonly MessageParser<OFBNFNFGDFJ> _parser = new MessageParser<OFBNFNFGDFJ>(() => new OFBNFNFGDFJ());

	private UnknownFieldSet _unknownFields;

	public const int IDFELNMBDBJFieldNumber = 1;

	private uint iDFELNMBDBJ_;

	public const int DGPFGADEBMDFieldNumber = 6;

	private uint dGPFGADEBMD_;

	public const int PGINLOFKCMDFieldNumber = 8;

	private uint pGINLOFKCMD_;

	public const int OFOODOBJKBJFieldNumber = 9;

	private CADKBOKEJMD oFOODOBJKBJ_;

	public const int MapIdFieldNumber = 10;

	private uint mapId_;

	public const int UnfinishedStoryLineIdListFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_unfinishedStoryLineIdList_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> unfinishedStoryLineIdList_ = new RepeatedField<uint>();

	public const int DPCBMJGBMGPFieldNumber = 13;

	private DECAOHONNJG dPCBMJGBMGP_;

	public const int StatusFieldNumber = 14;

	private RogueStatus status_;

	public const int BaseAvatarIdListFieldNumber = 15;

	private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(122u);

	private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OFBNFNFGDFJ> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OFBNFNFGDFJReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IDFELNMBDBJ
	{
		get
		{
			return iDFELNMBDBJ_;
		}
		set
		{
			iDFELNMBDBJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DGPFGADEBMD
	{
		get
		{
			return dGPFGADEBMD_;
		}
		set
		{
			dGPFGADEBMD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PGINLOFKCMD
	{
		get
		{
			return pGINLOFKCMD_;
		}
		set
		{
			pGINLOFKCMD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CADKBOKEJMD OFOODOBJKBJ
	{
		get
		{
			return oFOODOBJKBJ_;
		}
		set
		{
			oFOODOBJKBJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MapId
	{
		get
		{
			return mapId_;
		}
		set
		{
			mapId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> UnfinishedStoryLineIdList => unfinishedStoryLineIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DECAOHONNJG DPCBMJGBMGP
	{
		get
		{
			return dPCBMJGBMGP_;
		}
		set
		{
			dPCBMJGBMGP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueStatus Status
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
	public RepeatedField<uint> BaseAvatarIdList => baseAvatarIdList_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFBNFNFGDFJ()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFBNFNFGDFJ(OFBNFNFGDFJ other)
		: this()
	{
		iDFELNMBDBJ_ = other.iDFELNMBDBJ_;
		dGPFGADEBMD_ = other.dGPFGADEBMD_;
		pGINLOFKCMD_ = other.pGINLOFKCMD_;
		oFOODOBJKBJ_ = ((other.oFOODOBJKBJ_ != null) ? other.oFOODOBJKBJ_.Clone() : null);
		mapId_ = other.mapId_;
		unfinishedStoryLineIdList_ = other.unfinishedStoryLineIdList_.Clone();
		dPCBMJGBMGP_ = ((other.dPCBMJGBMGP_ != null) ? other.dPCBMJGBMGP_.Clone() : null);
		status_ = other.status_;
		baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OFBNFNFGDFJ Clone()
	{
		return new OFBNFNFGDFJ(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OFBNFNFGDFJ);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OFBNFNFGDFJ other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IDFELNMBDBJ != other.IDFELNMBDBJ)
		{
			return false;
		}
		if (DGPFGADEBMD != other.DGPFGADEBMD)
		{
			return false;
		}
		if (PGINLOFKCMD != other.PGINLOFKCMD)
		{
			return false;
		}
		if (!object.Equals(OFOODOBJKBJ, other.OFOODOBJKBJ))
		{
			return false;
		}
		if (MapId != other.MapId)
		{
			return false;
		}
		if (!unfinishedStoryLineIdList_.Equals(other.unfinishedStoryLineIdList_))
		{
			return false;
		}
		if (!object.Equals(DPCBMJGBMGP, other.DPCBMJGBMGP))
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (!baseAvatarIdList_.Equals(other.baseAvatarIdList_))
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
		if (IDFELNMBDBJ != 0)
		{
			num ^= IDFELNMBDBJ.GetHashCode();
		}
		if (DGPFGADEBMD != 0)
		{
			num ^= DGPFGADEBMD.GetHashCode();
		}
		if (PGINLOFKCMD != 0)
		{
			num ^= PGINLOFKCMD.GetHashCode();
		}
		if (oFOODOBJKBJ_ != null)
		{
			num ^= OFOODOBJKBJ.GetHashCode();
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		num ^= unfinishedStoryLineIdList_.GetHashCode();
		if (dPCBMJGBMGP_ != null)
		{
			num ^= DPCBMJGBMGP.GetHashCode();
		}
		if (Status != RogueStatus.JbfmhgkneglPcpdhelpkem)
		{
			num ^= Status.GetHashCode();
		}
		num ^= baseAvatarIdList_.GetHashCode();
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
		if (IDFELNMBDBJ != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(IDFELNMBDBJ);
		}
		if (DGPFGADEBMD != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(DGPFGADEBMD);
		}
		if (PGINLOFKCMD != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(PGINLOFKCMD);
		}
		if (oFOODOBJKBJ_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(OFOODOBJKBJ);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(MapId);
		}
		unfinishedStoryLineIdList_.WriteTo(ref output, _repeated_unfinishedStoryLineIdList_codec);
		if (dPCBMJGBMGP_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(DPCBMJGBMGP);
		}
		if (Status != RogueStatus.JbfmhgkneglPcpdhelpkem)
		{
			output.WriteRawTag(112);
			output.WriteEnum((int)Status);
		}
		baseAvatarIdList_.WriteTo(ref output, _repeated_baseAvatarIdList_codec);
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
		if (IDFELNMBDBJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IDFELNMBDBJ);
		}
		if (DGPFGADEBMD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DGPFGADEBMD);
		}
		if (PGINLOFKCMD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PGINLOFKCMD);
		}
		if (oFOODOBJKBJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OFOODOBJKBJ);
		}
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MapId);
		}
		num += unfinishedStoryLineIdList_.CalculateSize(_repeated_unfinishedStoryLineIdList_codec);
		if (dPCBMJGBMGP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DPCBMJGBMGP);
		}
		if (Status != RogueStatus.JbfmhgkneglPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		num += baseAvatarIdList_.CalculateSize(_repeated_baseAvatarIdList_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OFBNFNFGDFJ other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IDFELNMBDBJ != 0)
		{
			IDFELNMBDBJ = other.IDFELNMBDBJ;
		}
		if (other.DGPFGADEBMD != 0)
		{
			DGPFGADEBMD = other.DGPFGADEBMD;
		}
		if (other.PGINLOFKCMD != 0)
		{
			PGINLOFKCMD = other.PGINLOFKCMD;
		}
		if (other.oFOODOBJKBJ_ != null)
		{
			if (oFOODOBJKBJ_ == null)
			{
				OFOODOBJKBJ = new CADKBOKEJMD();
			}
			OFOODOBJKBJ.MergeFrom(other.OFOODOBJKBJ);
		}
		if (other.MapId != 0)
		{
			MapId = other.MapId;
		}
		unfinishedStoryLineIdList_.Add(other.unfinishedStoryLineIdList_);
		if (other.dPCBMJGBMGP_ != null)
		{
			if (dPCBMJGBMGP_ == null)
			{
				DPCBMJGBMGP = new DECAOHONNJG();
			}
			DPCBMJGBMGP.MergeFrom(other.DPCBMJGBMGP);
		}
		if (other.Status != RogueStatus.JbfmhgkneglPcpdhelpkem)
		{
			Status = other.Status;
		}
		baseAvatarIdList_.Add(other.baseAvatarIdList_);
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
				IDFELNMBDBJ = input.ReadUInt32();
				break;
			case 48u:
				DGPFGADEBMD = input.ReadUInt32();
				break;
			case 64u:
				PGINLOFKCMD = input.ReadUInt32();
				break;
			case 74u:
				if (oFOODOBJKBJ_ == null)
				{
					OFOODOBJKBJ = new CADKBOKEJMD();
				}
				input.ReadMessage(OFOODOBJKBJ);
				break;
			case 80u:
				MapId = input.ReadUInt32();
				break;
			case 96u:
			case 98u:
				unfinishedStoryLineIdList_.AddEntriesFrom(ref input, _repeated_unfinishedStoryLineIdList_codec);
				break;
			case 106u:
				if (dPCBMJGBMGP_ == null)
				{
					DPCBMJGBMGP = new DECAOHONNJG();
				}
				input.ReadMessage(DPCBMJGBMGP);
				break;
			case 112u:
				Status = (RogueStatus)input.ReadEnum();
				break;
			case 120u:
			case 122u:
				baseAvatarIdList_.AddEntriesFrom(ref input, _repeated_baseAvatarIdList_codec);
				break;
			}
		}
	}
}
