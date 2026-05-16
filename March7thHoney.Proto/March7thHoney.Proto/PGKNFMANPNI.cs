using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PGKNFMANPNI : IMessage<PGKNFMANPNI>, IMessage, IEquatable<PGKNFMANPNI>, IDeepCloneable<PGKNFMANPNI>, IBufferMessage
{
	private static readonly MessageParser<PGKNFMANPNI> _parser = new MessageParser<PGKNFMANPNI>(() => new PGKNFMANPNI());

	private UnknownFieldSet _unknownFields;

	public const int OBOJOIHDCGKFieldNumber = 1;

	private uint oBOJOIHDCGK_;

	public const int PMMDFFFNFIOFieldNumber = 2;

	private uint pMMDFFFNFIO_;

	public const int RoomIdFieldNumber = 3;

	private uint roomId_;

	public const int ELIGJDHJEACFieldNumber = 4;

	private LGMIBLCAEFA eLIGJDHJEAC_;

	public const int LHENDOOGBCKFieldNumber = 7;

	private uint lHENDOOGBCK_;

	public const int StatusFieldNumber = 11;

	private FLCPAPOJBGP status_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PGKNFMANPNI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PGKNFMANPNIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public LGMIBLCAEFA ELIGJDHJEAC
	{
		get
		{
			return eLIGJDHJEAC_;
		}
		set
		{
			eLIGJDHJEAC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LHENDOOGBCK
	{
		get
		{
			return lHENDOOGBCK_;
		}
		set
		{
			lHENDOOGBCK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FLCPAPOJBGP Status
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
	public PGKNFMANPNI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGKNFMANPNI(PGKNFMANPNI other)
		: this()
	{
		oBOJOIHDCGK_ = other.oBOJOIHDCGK_;
		pMMDFFFNFIO_ = other.pMMDFFFNFIO_;
		roomId_ = other.roomId_;
		eLIGJDHJEAC_ = ((other.eLIGJDHJEAC_ != null) ? other.eLIGJDHJEAC_.Clone() : null);
		lHENDOOGBCK_ = other.lHENDOOGBCK_;
		status_ = other.status_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PGKNFMANPNI Clone()
	{
		return new PGKNFMANPNI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PGKNFMANPNI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PGKNFMANPNI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OBOJOIHDCGK != other.OBOJOIHDCGK)
		{
			return false;
		}
		if (PMMDFFFNFIO != other.PMMDFFFNFIO)
		{
			return false;
		}
		if (RoomId != other.RoomId)
		{
			return false;
		}
		if (!object.Equals(ELIGJDHJEAC, other.ELIGJDHJEAC))
		{
			return false;
		}
		if (LHENDOOGBCK != other.LHENDOOGBCK)
		{
			return false;
		}
		if (Status != other.Status)
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
		if (OBOJOIHDCGK != 0)
		{
			num ^= OBOJOIHDCGK.GetHashCode();
		}
		if (PMMDFFFNFIO != 0)
		{
			num ^= PMMDFFFNFIO.GetHashCode();
		}
		if (RoomId != 0)
		{
			num ^= RoomId.GetHashCode();
		}
		if (eLIGJDHJEAC_ != null)
		{
			num ^= ELIGJDHJEAC.GetHashCode();
		}
		if (LHENDOOGBCK != 0)
		{
			num ^= LHENDOOGBCK.GetHashCode();
		}
		if (Status != FLCPAPOJBGP.Pcpdhelpkem)
		{
			num ^= Status.GetHashCode();
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
		if (OBOJOIHDCGK != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(OBOJOIHDCGK);
		}
		if (PMMDFFFNFIO != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(PMMDFFFNFIO);
		}
		if (RoomId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(RoomId);
		}
		if (eLIGJDHJEAC_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(ELIGJDHJEAC);
		}
		if (LHENDOOGBCK != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(LHENDOOGBCK);
		}
		if (Status != FLCPAPOJBGP.Pcpdhelpkem)
		{
			output.WriteRawTag(88);
			output.WriteEnum((int)Status);
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
		if (OBOJOIHDCGK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OBOJOIHDCGK);
		}
		if (PMMDFFFNFIO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PMMDFFFNFIO);
		}
		if (RoomId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(RoomId);
		}
		if (eLIGJDHJEAC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ELIGJDHJEAC);
		}
		if (LHENDOOGBCK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LHENDOOGBCK);
		}
		if (Status != FLCPAPOJBGP.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Status);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PGKNFMANPNI other)
	{
		if (other == null)
		{
			return;
		}
		if (other.OBOJOIHDCGK != 0)
		{
			OBOJOIHDCGK = other.OBOJOIHDCGK;
		}
		if (other.PMMDFFFNFIO != 0)
		{
			PMMDFFFNFIO = other.PMMDFFFNFIO;
		}
		if (other.RoomId != 0)
		{
			RoomId = other.RoomId;
		}
		if (other.eLIGJDHJEAC_ != null)
		{
			if (eLIGJDHJEAC_ == null)
			{
				ELIGJDHJEAC = new LGMIBLCAEFA();
			}
			ELIGJDHJEAC.MergeFrom(other.ELIGJDHJEAC);
		}
		if (other.LHENDOOGBCK != 0)
		{
			LHENDOOGBCK = other.LHENDOOGBCK;
		}
		if (other.Status != FLCPAPOJBGP.Pcpdhelpkem)
		{
			Status = other.Status;
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
			case 8u:
				OBOJOIHDCGK = input.ReadUInt32();
				break;
			case 16u:
				PMMDFFFNFIO = input.ReadUInt32();
				break;
			case 24u:
				RoomId = input.ReadUInt32();
				break;
			case 34u:
				if (eLIGJDHJEAC_ == null)
				{
					ELIGJDHJEAC = new LGMIBLCAEFA();
				}
				input.ReadMessage(ELIGJDHJEAC);
				break;
			case 56u:
				LHENDOOGBCK = input.ReadUInt32();
				break;
			case 88u:
				Status = (FLCPAPOJBGP)input.ReadEnum();
				break;
			}
		}
	}
}
