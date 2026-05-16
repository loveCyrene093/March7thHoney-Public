using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NEILIAPHAMN : IMessage<NEILIAPHAMN>, IMessage, IEquatable<NEILIAPHAMN>, IDeepCloneable<NEILIAPHAMN>, IBufferMessage
{
	private static readonly MessageParser<NEILIAPHAMN> _parser = new MessageParser<NEILIAPHAMN>(() => new NEILIAPHAMN());

	private UnknownFieldSet _unknownFields;

	public const int ECJPEBDJKKEFieldNumber = 3;

	private RogueAreaStatus eCJPEBDJKKE_;

	public const int MapIdFieldNumber = 4;

	private uint mapId_;

	public const int FIMAMEDNNILFieldNumber = 5;

	private RogueStatus fIMAMEDNNIL_;

	public const int AreaIdFieldNumber = 7;

	private uint areaId_;

	public const int PGINLOFKCMDFieldNumber = 12;

	private uint pGINLOFKCMD_;

	public const int CNDKAPOIEOJFieldNumber = 13;

	private bool cNDKAPOIEOJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NEILIAPHAMN> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NEILIAPHAMNReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueAreaStatus ECJPEBDJKKE
	{
		get
		{
			return eCJPEBDJKKE_;
		}
		set
		{
			eCJPEBDJKKE_ = value;
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
	public RogueStatus FIMAMEDNNIL
	{
		get
		{
			return fIMAMEDNNIL_;
		}
		set
		{
			fIMAMEDNNIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
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
	public bool CNDKAPOIEOJ
	{
		get
		{
			return cNDKAPOIEOJ_;
		}
		set
		{
			cNDKAPOIEOJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEILIAPHAMN()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEILIAPHAMN(NEILIAPHAMN other)
		: this()
	{
		eCJPEBDJKKE_ = other.eCJPEBDJKKE_;
		mapId_ = other.mapId_;
		fIMAMEDNNIL_ = other.fIMAMEDNNIL_;
		areaId_ = other.areaId_;
		pGINLOFKCMD_ = other.pGINLOFKCMD_;
		cNDKAPOIEOJ_ = other.cNDKAPOIEOJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NEILIAPHAMN Clone()
	{
		return new NEILIAPHAMN(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NEILIAPHAMN);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NEILIAPHAMN other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ECJPEBDJKKE != other.ECJPEBDJKKE)
		{
			return false;
		}
		if (MapId != other.MapId)
		{
			return false;
		}
		if (FIMAMEDNNIL != other.FIMAMEDNNIL)
		{
			return false;
		}
		if (AreaId != other.AreaId)
		{
			return false;
		}
		if (PGINLOFKCMD != other.PGINLOFKCMD)
		{
			return false;
		}
		if (CNDKAPOIEOJ != other.CNDKAPOIEOJ)
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
		if (ECJPEBDJKKE != RogueAreaStatus.FdpoaplbfkcDklpaafflee)
		{
			num ^= ECJPEBDJKKE.GetHashCode();
		}
		if (MapId != 0)
		{
			num ^= MapId.GetHashCode();
		}
		if (FIMAMEDNNIL != RogueStatus.JbfmhgkneglPcpdhelpkem)
		{
			num ^= FIMAMEDNNIL.GetHashCode();
		}
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
		}
		if (PGINLOFKCMD != 0)
		{
			num ^= PGINLOFKCMD.GetHashCode();
		}
		if (CNDKAPOIEOJ)
		{
			num ^= CNDKAPOIEOJ.GetHashCode();
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
		if (ECJPEBDJKKE != RogueAreaStatus.FdpoaplbfkcDklpaafflee)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)ECJPEBDJKKE);
		}
		if (MapId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MapId);
		}
		if (FIMAMEDNNIL != RogueStatus.JbfmhgkneglPcpdhelpkem)
		{
			output.WriteRawTag(40);
			output.WriteEnum((int)FIMAMEDNNIL);
		}
		if (AreaId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(AreaId);
		}
		if (PGINLOFKCMD != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(PGINLOFKCMD);
		}
		if (CNDKAPOIEOJ)
		{
			output.WriteRawTag(104);
			output.WriteBool(CNDKAPOIEOJ);
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
		if (ECJPEBDJKKE != RogueAreaStatus.FdpoaplbfkcDklpaafflee)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)ECJPEBDJKKE);
		}
		if (MapId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MapId);
		}
		if (FIMAMEDNNIL != RogueStatus.JbfmhgkneglPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)FIMAMEDNNIL);
		}
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (PGINLOFKCMD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PGINLOFKCMD);
		}
		if (CNDKAPOIEOJ)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NEILIAPHAMN other)
	{
		if (other != null)
		{
			if (other.ECJPEBDJKKE != RogueAreaStatus.FdpoaplbfkcDklpaafflee)
			{
				ECJPEBDJKKE = other.ECJPEBDJKKE;
			}
			if (other.MapId != 0)
			{
				MapId = other.MapId;
			}
			if (other.FIMAMEDNNIL != RogueStatus.JbfmhgkneglPcpdhelpkem)
			{
				FIMAMEDNNIL = other.FIMAMEDNNIL;
			}
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
			}
			if (other.PGINLOFKCMD != 0)
			{
				PGINLOFKCMD = other.PGINLOFKCMD;
			}
			if (other.CNDKAPOIEOJ)
			{
				CNDKAPOIEOJ = other.CNDKAPOIEOJ;
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
			case 24u:
				ECJPEBDJKKE = (RogueAreaStatus)input.ReadEnum();
				break;
			case 32u:
				MapId = input.ReadUInt32();
				break;
			case 40u:
				FIMAMEDNNIL = (RogueStatus)input.ReadEnum();
				break;
			case 56u:
				AreaId = input.ReadUInt32();
				break;
			case 96u:
				PGINLOFKCMD = input.ReadUInt32();
				break;
			case 104u:
				CNDKAPOIEOJ = input.ReadBool();
				break;
			}
		}
	}
}
