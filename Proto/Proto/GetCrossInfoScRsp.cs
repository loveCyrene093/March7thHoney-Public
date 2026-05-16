using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetCrossInfoScRsp : IMessage<GetCrossInfoScRsp>, IMessage, IEquatable<GetCrossInfoScRsp>, IDeepCloneable<GetCrossInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<GetCrossInfoScRsp> _parser = new MessageParser<GetCrossInfoScRsp>(() => new GetCrossInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int PLOBMBFPNFKFieldNumber = 3;

	private FightGameMode pLOBMBFPNFK_;

	public const int RoomIdFieldNumber = 4;

	private ulong roomId_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int EIFFDNNBGMCFieldNumber = 14;

	private ulong eIFFDNNBGMC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetCrossInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetCrossInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightGameMode PLOBMBFPNFK
	{
		get
		{
			return pLOBMBFPNFK_;
		}
		set
		{
			pLOBMBFPNFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong RoomId
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
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong EIFFDNNBGMC
	{
		get
		{
			return eIFFDNNBGMC_;
		}
		set
		{
			eIFFDNNBGMC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetCrossInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetCrossInfoScRsp(GetCrossInfoScRsp other)
		: this()
	{
		pLOBMBFPNFK_ = other.pLOBMBFPNFK_;
		roomId_ = other.roomId_;
		retcode_ = other.retcode_;
		eIFFDNNBGMC_ = other.eIFFDNNBGMC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetCrossInfoScRsp Clone()
	{
		return new GetCrossInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetCrossInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetCrossInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PLOBMBFPNFK != other.PLOBMBFPNFK)
		{
			return false;
		}
		if (RoomId != other.RoomId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (EIFFDNNBGMC != other.EIFFDNNBGMC)
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
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num ^= PLOBMBFPNFK.GetHashCode();
		}
		if (RoomId != 0L)
		{
			num ^= RoomId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (EIFFDNNBGMC != 0L)
		{
			num ^= EIFFDNNBGMC.GetHashCode();
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
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			output.WriteRawTag(24);
			output.WriteEnum((int)PLOBMBFPNFK);
		}
		if (RoomId != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(RoomId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (EIFFDNNBGMC != 0L)
		{
			output.WriteRawTag(112);
			output.WriteUInt64(EIFFDNNBGMC);
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
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PLOBMBFPNFK);
		}
		if (RoomId != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(RoomId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (EIFFDNNBGMC != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(EIFFDNNBGMC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetCrossInfoScRsp other)
	{
		if (other != null)
		{
			if (other.PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
			{
				PLOBMBFPNFK = other.PLOBMBFPNFK;
			}
			if (other.RoomId != 0L)
			{
				RoomId = other.RoomId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.EIFFDNNBGMC != 0L)
			{
				EIFFDNNBGMC = other.EIFFDNNBGMC;
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
				PLOBMBFPNFK = (FightGameMode)input.ReadEnum();
				break;
			case 32u:
				RoomId = input.ReadUInt64();
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 112u:
				EIFFDNNBGMC = input.ReadUInt64();
				break;
			}
		}
	}
}
