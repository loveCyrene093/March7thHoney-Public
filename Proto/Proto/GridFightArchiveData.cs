using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightArchiveData : IMessage<GridFightArchiveData>, IMessage, IEquatable<GridFightArchiveData>, IDeepCloneable<GridFightArchiveData>, IBufferMessage
{
	private static readonly MessageParser<GridFightArchiveData> _parser = new MessageParser<GridFightArchiveData>(() => new GridFightArchiveData());

	private UnknownFieldSet _unknownFields;

	public const int AJMBOLHDGHKFieldNumber = 2;

	private uint aJMBOLHDGHK_;

	public const int PDLBECHDJBLFieldNumber = 6;

	private bool pDLBECHDJBL_;

	public const int SeasonFieldNumber = 9;

	private uint season_;

	public const int BMPCCPCCJJOFieldNumber = 12;

	private uint bMPCCPCCJJO_;

	public const int EDKJMPACHNJFieldNumber = 13;

	private GridFightFinishInfo eDKJMPACHNJ_;

	public const int CALIMAKGGHJFieldNumber = 14;

	private uint cALIMAKGGHJ_;

	public const int DKCFJNDCBEPFieldNumber = 15;

	private long dKCFJNDCBEP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightArchiveData> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightArchiveDataReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AJMBOLHDGHK
	{
		get
		{
			return aJMBOLHDGHK_;
		}
		set
		{
			aJMBOLHDGHK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PDLBECHDJBL
	{
		get
		{
			return pDLBECHDJBL_;
		}
		set
		{
			pDLBECHDJBL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Season
	{
		get
		{
			return season_;
		}
		set
		{
			season_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BMPCCPCCJJO
	{
		get
		{
			return bMPCCPCCJJO_;
		}
		set
		{
			bMPCCPCCJJO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightFinishInfo EDKJMPACHNJ
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
	public uint CALIMAKGGHJ
	{
		get
		{
			return cALIMAKGGHJ_;
		}
		set
		{
			cALIMAKGGHJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long DKCFJNDCBEP
	{
		get
		{
			return dKCFJNDCBEP_;
		}
		set
		{
			dKCFJNDCBEP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightArchiveData()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightArchiveData(GridFightArchiveData other)
		: this()
	{
		aJMBOLHDGHK_ = other.aJMBOLHDGHK_;
		pDLBECHDJBL_ = other.pDLBECHDJBL_;
		season_ = other.season_;
		bMPCCPCCJJO_ = other.bMPCCPCCJJO_;
		eDKJMPACHNJ_ = ((other.eDKJMPACHNJ_ != null) ? other.eDKJMPACHNJ_.Clone() : null);
		cALIMAKGGHJ_ = other.cALIMAKGGHJ_;
		dKCFJNDCBEP_ = other.dKCFJNDCBEP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightArchiveData Clone()
	{
		return new GridFightArchiveData(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightArchiveData);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightArchiveData other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AJMBOLHDGHK != other.AJMBOLHDGHK)
		{
			return false;
		}
		if (PDLBECHDJBL != other.PDLBECHDJBL)
		{
			return false;
		}
		if (Season != other.Season)
		{
			return false;
		}
		if (BMPCCPCCJJO != other.BMPCCPCCJJO)
		{
			return false;
		}
		if (!object.Equals(EDKJMPACHNJ, other.EDKJMPACHNJ))
		{
			return false;
		}
		if (CALIMAKGGHJ != other.CALIMAKGGHJ)
		{
			return false;
		}
		if (DKCFJNDCBEP != other.DKCFJNDCBEP)
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
		if (AJMBOLHDGHK != 0)
		{
			num ^= AJMBOLHDGHK.GetHashCode();
		}
		if (PDLBECHDJBL)
		{
			num ^= PDLBECHDJBL.GetHashCode();
		}
		if (Season != 0)
		{
			num ^= Season.GetHashCode();
		}
		if (BMPCCPCCJJO != 0)
		{
			num ^= BMPCCPCCJJO.GetHashCode();
		}
		if (eDKJMPACHNJ_ != null)
		{
			num ^= EDKJMPACHNJ.GetHashCode();
		}
		if (CALIMAKGGHJ != 0)
		{
			num ^= CALIMAKGGHJ.GetHashCode();
		}
		if (DKCFJNDCBEP != 0L)
		{
			num ^= DKCFJNDCBEP.GetHashCode();
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
		if (AJMBOLHDGHK != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(AJMBOLHDGHK);
		}
		if (PDLBECHDJBL)
		{
			output.WriteRawTag(48);
			output.WriteBool(PDLBECHDJBL);
		}
		if (Season != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Season);
		}
		if (BMPCCPCCJJO != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(BMPCCPCCJJO);
		}
		if (eDKJMPACHNJ_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(EDKJMPACHNJ);
		}
		if (CALIMAKGGHJ != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(CALIMAKGGHJ);
		}
		if (DKCFJNDCBEP != 0L)
		{
			output.WriteRawTag(120);
			output.WriteInt64(DKCFJNDCBEP);
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
		if (AJMBOLHDGHK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AJMBOLHDGHK);
		}
		if (PDLBECHDJBL)
		{
			num += 2;
		}
		if (Season != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Season);
		}
		if (BMPCCPCCJJO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BMPCCPCCJJO);
		}
		if (eDKJMPACHNJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EDKJMPACHNJ);
		}
		if (CALIMAKGGHJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CALIMAKGGHJ);
		}
		if (DKCFJNDCBEP != 0L)
		{
			num += 1 + CodedOutputStream.ComputeInt64Size(DKCFJNDCBEP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightArchiveData other)
	{
		if (other == null)
		{
			return;
		}
		if (other.AJMBOLHDGHK != 0)
		{
			AJMBOLHDGHK = other.AJMBOLHDGHK;
		}
		if (other.PDLBECHDJBL)
		{
			PDLBECHDJBL = other.PDLBECHDJBL;
		}
		if (other.Season != 0)
		{
			Season = other.Season;
		}
		if (other.BMPCCPCCJJO != 0)
		{
			BMPCCPCCJJO = other.BMPCCPCCJJO;
		}
		if (other.eDKJMPACHNJ_ != null)
		{
			if (eDKJMPACHNJ_ == null)
			{
				EDKJMPACHNJ = new GridFightFinishInfo();
			}
			EDKJMPACHNJ.MergeFrom(other.EDKJMPACHNJ);
		}
		if (other.CALIMAKGGHJ != 0)
		{
			CALIMAKGGHJ = other.CALIMAKGGHJ;
		}
		if (other.DKCFJNDCBEP != 0L)
		{
			DKCFJNDCBEP = other.DKCFJNDCBEP;
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
			case 16u:
				AJMBOLHDGHK = input.ReadUInt32();
				break;
			case 48u:
				PDLBECHDJBL = input.ReadBool();
				break;
			case 72u:
				Season = input.ReadUInt32();
				break;
			case 96u:
				BMPCCPCCJJO = input.ReadUInt32();
				break;
			case 106u:
				if (eDKJMPACHNJ_ == null)
				{
					EDKJMPACHNJ = new GridFightFinishInfo();
				}
				input.ReadMessage(EDKJMPACHNJ);
				break;
			case 112u:
				CALIMAKGGHJ = input.ReadUInt32();
				break;
			case 120u:
				DKCFJNDCBEP = input.ReadInt64();
				break;
			}
		}
	}
}
