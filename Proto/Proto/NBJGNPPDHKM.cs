using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NBJGNPPDHKM : IMessage<NBJGNPPDHKM>, IMessage, IEquatable<NBJGNPPDHKM>, IDeepCloneable<NBJGNPPDHKM>, IBufferMessage
{
	private static readonly MessageParser<NBJGNPPDHKM> _parser = new MessageParser<NBJGNPPDHKM>(() => new NBJGNPPDHKM());

	private UnknownFieldSet _unknownFields;

	public const int StatusFieldNumber = 6;

	private FKANCDDCALO status_;

	public const int RoomIdFieldNumber = 7;

	private uint roomId_;

	public const int OBOJOIHDCGKFieldNumber = 10;

	private uint oBOJOIHDCGK_;

	public const int PMMDFFFNFIOFieldNumber = 13;

	private uint pMMDFFFNFIO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NBJGNPPDHKM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NBJGNPPDHKMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FKANCDDCALO Status
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
	public uint RoomId
	{
		get
		{
			return roomId_;
		}
		set
		{
			roomId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OBOJOIHDCGK
	{
		get
		{
			return oBOJOIHDCGK_;
		}
		set
		{
			oBOJOIHDCGK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PMMDFFFNFIO
	{
		get
		{
			return pMMDFFFNFIO_;
		}
		set
		{
			pMMDFFFNFIO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBJGNPPDHKM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBJGNPPDHKM(NBJGNPPDHKM other)
		: this()
	{
		status_ = other.status_;
		roomId_ = other.roomId_;
		oBOJOIHDCGK_ = other.oBOJOIHDCGK_;
		pMMDFFFNFIO_ = other.pMMDFFFNFIO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBJGNPPDHKM Clone()
	{
		return new NBJGNPPDHKM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NBJGNPPDHKM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NBJGNPPDHKM other)
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
		if (RoomId != other.RoomId)
		{
			return false;
		}
		if (OBOJOIHDCGK != other.OBOJOIHDCGK)
		{
			return false;
		}
		if (PMMDFFFNFIO != other.PMMDFFFNFIO)
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
		if (Status != FKANCDDCALO.Pcpdhelpkem)
		{
			num ^= Status.GetHashCode();
		}
		if (RoomId != 0)
		{
			num ^= RoomId.GetHashCode();
		}
		if (OBOJOIHDCGK != 0)
		{
			num ^= OBOJOIHDCGK.GetHashCode();
		}
		if (PMMDFFFNFIO != 0)
		{
			num ^= PMMDFFFNFIO.GetHashCode();
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
		if (Status != FKANCDDCALO.Pcpdhelpkem)
		{
			output.WriteRawTag(48);
			output.WriteEnum((int)Status);
		}
		if (RoomId != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(RoomId);
		}
		if (OBOJOIHDCGK != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(OBOJOIHDCGK);
		}
		if (PMMDFFFNFIO != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(PMMDFFFNFIO);
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
		if (Status != FKANCDDCALO.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (RoomId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoomId);
		}
		if (OBOJOIHDCGK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OBOJOIHDCGK);
		}
		if (PMMDFFFNFIO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PMMDFFFNFIO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NBJGNPPDHKM other)
	{
		if (other != null)
		{
			if (other.Status != FKANCDDCALO.Pcpdhelpkem)
			{
				Status = other.Status;
			}
			if (other.RoomId != 0)
			{
				RoomId = other.RoomId;
			}
			if (other.OBOJOIHDCGK != 0)
			{
				OBOJOIHDCGK = other.OBOJOIHDCGK;
			}
			if (other.PMMDFFFNFIO != 0)
			{
				PMMDFFFNFIO = other.PMMDFFFNFIO;
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
			case 48u:
				Status = (FKANCDDCALO)input.ReadEnum();
				break;
			case 56u:
				RoomId = input.ReadUInt32();
				break;
			case 80u:
				OBOJOIHDCGK = input.ReadUInt32();
				break;
			case 104u:
				PMMDFFFNFIO = input.ReadUInt32();
				break;
			}
		}
	}
}
